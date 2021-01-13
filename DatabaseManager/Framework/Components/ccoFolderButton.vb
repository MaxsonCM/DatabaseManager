Imports System.IO

Public Class ccoFolderButton
    Inherits System.Windows.Forms.Button
    Private _aux_control As TextBox
    Private _type_folder As TYPE_FOLDER
    Private _type_filter As TYPE_FILTER_FILE

    Public Sub New()
        Me.Image = Global.DatabaseManager.My.Resources.Folder_Explorer_16
        Me.FlatStyle = Windows.Forms.FlatStyle.Popup
        Me.Text = ""
        Me.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        _type_folder = TYPE_FOLDER.FOLDER
        _type_filter = TYPE_FILTER_FILE.ALL
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        Dim _last_local As String
        Try
            If (IsNothing(_aux_control) = False) Then
                _last_local = REGEDIT.GetRegistry("btnFolder", _aux_control.Name)

                If Not IO.Directory.Exists(_last_local) And Not IO.File.Exists(_last_local) Then _last_local = IO.Directory.GetCurrentDirectory & "\"
                '_aux_control.Text = ""
                If TYPE_FOLDER.FOLDER = _type_folder Then
                    Dim browser As New FolderBrowserDialog()
                    browser.ShowNewFolderButton = True
                    browser.Description = "Select a folder"
                    browser.SelectedPath = Path.GetDirectoryName(_last_local)
                    If (browser.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        _aux_control.Text = browser.SelectedPath
                        REGEDIT.SetRegistry("btnFolder", _aux_control.Name, browser.SelectedPath)
                    End If
                ElseIf TYPE_FOLDER.FOLDER_FILE = _type_folder Then
                    Dim browser As New OpenFileDialog()
                    browser.Filter = GetFilter()
                    'browser.CheckPathExists = Path.GetDirectoryName(_last_local)
                    If Directory.Exists(Path.GetDirectoryName(_last_local)) Then
                        browser.FileName = Path.GetDirectoryName(_last_local)
                    End If
                    If (browser.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        _aux_control.Text = browser.FileName
                        REGEDIT.SetRegistry("btnFolder", _aux_control.Name, browser.FileName)
                    End If
                ElseIf TYPE_FOLDER.FILE = _type_folder Then
                    Dim browser As New OpenFileDialog()
                    browser.Filter = GetFilter()
                    browser.CheckPathExists = Path.GetDirectoryName(_last_local)
                    If (browser.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                        _aux_control.Text = Path.GetFileName(browser.FileName)
                        REGEDIT.SetRegistry("btnFolder", _aux_control.Name, browser.FileName)
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        Me.Text = ""
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        Me.Size = New System.Drawing.Size(26, 21)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStyle = Windows.Forms.FlatStyle.Popup
        Me.Text = ""
        Me.Size = New System.Drawing.Size(26, 21)
    End Sub

    Public Property PUAuxControl As TextBox
        Get
            Return _aux_control
        End Get
        Set(value As TextBox)
            _aux_control = value
        End Set
    End Property

    Public Property PUDataType() As TYPE_FOLDER
        Get
            Return _type_folder
        End Get
        Set(value As TYPE_FOLDER)
            _type_folder = value
        End Set
    End Property

    Public Property PUFilterType() As TYPE_FILTER_FILE
        Get
            Return _type_filter
        End Get
        Set(value As TYPE_FILTER_FILE)
            _type_filter = value
        End Set
    End Property

    Private Function GetFilter() As String
        Dim resultado As String = "All Files|*.*"

        Select Case _type_filter
            Case TYPE_FILTER_FILE.ACCESS : resultado = "Access Files|*.MDB;*.ACCDB|All Files|*.*"
            Case TYPE_FILTER_FILE.TEXT : resultado = "Text Files|*.txt|All Files|*.*"
            Case TYPE_FILTER_FILE.EXCEL : resultado = "Excel Fiels|*.xls;*.xlsx|All Files|*.*"
            Case TYPE_FILTER_FILE.JPEG : resultado = "Image Files (*.jpeg)|*.jpeg|All Files|*.*"
            Case TYPE_FILTER_FILE.FIREBIRD : resultado = "Firebird (*.fdb)|*.fdb;*.gdb|All Files|*.*"
            Case TYPE_FILTER_FILE.ALL_DATABASE : resultado = "Compatible databases |*.MDB;*.ACCDB;*.FDB;*.GDB|Access Files|*.MDB;*.ACCDB|Firebird and Int. |*.FDB;*.GDB|All Files|*.*"
        End Select

        Return resultado
    End Function

End Class
