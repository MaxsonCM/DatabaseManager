Imports System.IO

Public Class clsUTIL

    Public Shared Function ExtensionFileName(ByVal file As String) As String
        Dim fi As New IO.FileInfo(file)

        Dim extn As String = Replace(UCase(fi.Extension), ".", "")

        Return extn
    End Function

    Public Shared Function Search_folder(ByVal type_folder As TYPE_FOLDER, ByVal filter As TYPE_FILTER_FILE) As String
        Dim my_local As String = ""

        Try
            my_local = REGEDIT.GetRegistry("search_folder", "last_local")

            If Not IO.Directory.Exists(my_local) And Not IO.File.Exists(my_local) Then my_local = IO.Directory.GetCurrentDirectory & "\"

            If type_folder.FOLDER = type_folder Then
                Dim browser As New FolderBrowserDialog()
                browser.ShowNewFolderButton = True
                browser.Description = "Select a folder"
                browser.SelectedPath = Path.GetDirectoryName(my_local)
                If (browser.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    my_local = browser.SelectedPath
                    REGEDIT.SetRegistry("search_folder", "last_local", browser.SelectedPath)
                End If
            ElseIf type_folder.FOLDER_FILE = type_folder Then
                Dim browser As New OpenFileDialog()
                browser.Filter = GetFilter(filter)
                'browser.CheckPathExists = Path.GetDirectoryName(my_local)
                If Directory.Exists(Path.GetDirectoryName(my_local)) Then
                    browser.FileName = Path.GetDirectoryName(my_local)
                End If
                If (browser.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    my_local = browser.FileName
                    REGEDIT.SetRegistry("search_folder", "last_local", Path.GetDirectoryName(browser.FileName))
                End If
            ElseIf type_folder.FILE = type_folder Then
                Dim browser As New OpenFileDialog()
                browser.Filter = GetFilter(filter)
                browser.CheckPathExists = Path.GetDirectoryName(my_local)
                If (browser.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                    my_local = Path.GetFileName(browser.FileName)
                    REGEDIT.SetRegistry("search_folder", "last_local", Path.GetDirectoryName(browser.FileName))
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return my_local
    End Function

    Private Shared Function GetFilter(ByVal filter As TYPE_FILTER_FILE) As String
        Dim resultado As String = "All Files (*.*)|*.*"""

        Select Case filter
            Case TYPE_FILTER_FILE.ACCESS : resultado = "Access Files|*.MDB;*.ACCDB|All Files|*.*"
            Case TYPE_FILTER_FILE.TEXT : resultado = "Text Files (*.txt)|*.txt|All Files|*.*"
            Case TYPE_FILTER_FILE.EXCEL : resultado = "Excel Files (*.xls*)|*.xls;*.xlsx|All Files|*.*"
            Case TYPE_FILTER_FILE.FIREBIRD : resultado = "Firebird (*.fdb)|*.fdb;*.gdb|All Files|*.*"
        End Select

        Return resultado
    End Function
End Class
