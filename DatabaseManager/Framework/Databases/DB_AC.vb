Imports System.Data.OleDb
Imports System.IO

''' <summary>
''' CLASS WITH METHODS / ROUTINES FOR ACCESS TO DATABASE ACCESS
''' </summary>
''' <remarks></remarks>
Public Class DB_AC

#Region "Configuration"

    Public Shared ReadOnly Property string_conection() As String
        Get
            Dim strConnection As String

            If UCase(Mid(clsGlobal.localDataBase, Len(clsGlobal.localDataBase) - 3)) = ".MDB" Then
                strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;"
            ElseIf UCase(Mid(clsGlobal.localDataBase, Len(clsGlobal.localDataBase) - 5)) = ".ACCDB" Then
                strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;"
            Else
                strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;"
            End If

            If Len(clsGlobal.passDataBase) > 0 Then
                strConnection += " Persist Security Info=True; Jet OLEDB:Database Password=" + clsGlobal.passDataBase + ";"
            Else
                strConnection += " Persist Security Info=False;"
            End If
            strConnection += " data source=" + clsGlobal.localDataBase + ";"

            Return strConnection
        End Get
    End Property

#End Region

#Region "Functions"

    Public Shared Sub CloseConnection(ByRef connection As OleDbConnection)
        Try
            connection.Close()
        Catch ex As Exception

        End Try
    End Sub


    Public Shared Function SearchTable(ByVal table As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim myCmd As New OleDb.OleDbCommand
        Dim dataAdapter As OleDb.OleDbDataAdapter
        Dim ds As New DataSet()

        Try

            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd.CommandType = CommandType.Text
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT * FROM [" & table & "]"

            dataAdapter = New System.Data.OleDb.OleDbDataAdapter(myCmd)
            dataAdapter.Fill(ds)

            dataAdapter.Dispose()
            conn.Close()

            Return ds

        Catch ex As Exception

            Call CloseConnection(conn)
            Return Nothing
        End Try
    End Function

    Public Shared Function Execute(ByVal my_command As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim myCmd As New OleDb.OleDbCommand
        Dim dataAdapter As OleDb.OleDbDataAdapter
        Dim dataSet As New DataSet()

        Try

            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd.CommandType = CommandType.Text
            myCmd.Connection = conn
            myCmd.CommandText = my_command

            If InStr(UCase(my_command), "SELECT ", CompareMethod.Text) > 0 Then

                dataAdapter = New System.Data.OleDb.OleDbDataAdapter(myCmd)
                dataAdapter.Fill(dataSet)

                dataAdapter.Dispose()
                conn.Close()

                Return dataSet
            Else
                myCmd.ExecuteNonQuery()
            End If

            conn.Close()

        Catch ex As Exception
            Call CloseConnection(conn)
        End Try

        Return Nothing
    End Function

    Public Shared Function Execute2(ByVal my_command As String) As String
        Dim dataSet As New DataSet()
        Dim dataAdapter As System.Data.OleDb.OleDbDataAdapter
        Dim myCmd As System.Data.OleDb.OleDbCommand
        Dim conn As System.Data.OleDb.OleDbConnection
        Dim my_status As String = ""

        Try
            conn = New System.Data.OleDb.OleDbConnection
            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd = New System.Data.OleDb.OleDbCommand
            myCmd.Connection = conn
            myCmd.CommandText = my_command

            If InStr(UCase(my_command), "SELECT ", CompareMethod.Text) > 0 Then

                dataAdapter = New System.Data.OleDb.OleDbDataAdapter(myCmd)
                dataAdapter.Fill(dataSet)

                dataAdapter.Dispose()

                If dataSet.Tables.Count > 0 Then
                    FrmResult.MdiParent = FrmMenu
                    If FrmResult.IsHandleCreated Then
                        FrmResult.Focus()
                    Else
                        FrmResult.Show()
                    End If

                    FrmResult.Grid.DataSource = dataSet
                    FrmResult.Grid.DataMember = dataSet.Tables(0).TableName
                End If

            Else
                my_status = "Affected rows: " & myCmd.ExecuteNonQuery()
            End If

            conn.Close()

            Return my_status
        Catch ex As Exception
            Return ex.Message
        End Try

    End Function

    Public Shared Sub RepairDatabase()
        Try
            Dim File_Path, compact_file As String
            File_Path = clsGlobal.localDataBase
            compact_file = Path.GetFullPath(clsGlobal.localDataBase) & Replace(Path.GetFileName(clsGlobal.localDataBase), Path.GetExtension(clsGlobal.localDataBase), "") & "_NEW" & Path.GetExtension(clsGlobal.localDataBase)
            If File.Exists(File_Path) Then
                'Dim db As New DAO.DBEngine()
                'db.CompactDatabase(File_Path, compact_file)
            End If
            If File.Exists(compact_file) Then
                File.Delete(File_Path)
                File.Move(compact_file, File_Path)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Get the structure of the database"

    ''' <summary>
    ''' Function test
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Version() As String
        ' need access installaed
        Dim objAccess As New Object
        Dim intFormat As Integer

        Try
            objAccess = CreateObject("Access.Application")

            objAccess.OpenCurrentDatabase(clsGlobal.localDataBase, , clsGlobal.passDataBase)

            intFormat = objAccess.CurrentProject.FileFormat

            Select Case intFormat
                Case 1 : Return intFormat & " - Microsoft Access 1"
                Case 2 : Return intFormat & " - Microsoft Access 2"
                Case 7 : Return intFormat & " - Microsoft Access 95"
                Case 8 : Return intFormat & " - Microsoft Access 97"
                Case 9 : Return intFormat & " - Microsoft Access 2000 (XP)"
                Case 10 : Return intFormat & " - Microsoft Access 2002/2003"
                Case 11 : Return intFormat & " - Microsoft Access 2003"
                Case 12 : Return intFormat & " - Microsoft Access 2007/2016"
                Case Else : Return intFormat & " - Unknown"
            End Select

            objAccess.Close()

        Catch ex As Exception

            Try
                objAccess.Close()
            Catch ex2 As Exception
            End Try

            Return "error"
        End Try

        'Dim wks As Workspace
        'Dim db As Database
        'DBEngine.SystemDB = "c:\secureddb path.mdw"
        'wks = DBEngine.CreateWorkspace("", "Username", "password")
        'db = wks.OpenDatabase("c:\secureddb.mdb")

    End Function

    Public Shared Function ListTable() As List(Of String)
        Dim list As New List(Of String)

        Try
            Using conn As New System.Data.OleDb.OleDbConnection(string_conection())
                conn.Open()
                Dim dt As DataTable = conn.GetSchema("TABLES", {Nothing, Nothing, Nothing, "TABLE"})

                For Each row In dt.Rows
                    list.Add(row("TABLE_NAME"))
                Next

                dt.Dispose()
                conn.Close()
            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return list
    End Function

    Public Shared Function ListFieldsByDS(ByVal table As String) As DataSet
        Dim ds As New DataSet

        Try
            Using conn As New System.Data.OleDb.OleDbConnection(string_conection())
                conn.Open()

                Dim dt As DataTable = conn.GetSchema("Columns", {Nothing, Nothing, table})

                ds.Tables.Add(dt)

                dt.Dispose()
                conn.Close()

                Return ds
            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListFields(ByVal table As String) As List(Of clsSchemaTable)
        Dim dr, dr_pk As DataRow

        Dim list_fields As New List(Of clsSchemaTable)
        Dim field As clsSchemaTable

        Try
            Using conn As New System.Data.OleDb.OleDbConnection(string_conection())
                conn.Open()

                Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, {Nothing, Nothing, table})
                Dim dt_pk As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, {Nothing, Nothing, table})

                For Each dr In dt.Rows
                    field = New clsSchemaTable
                    field.POSITION = dr("ORDINAL_POSITION")
                    field.COLUMN_NAME = dr("COLUMN_NAME")
                    field.DATA_TYPE_CODE = dr("DATA_TYPE")
                    Select Case dr("DATA_TYPE")
                        Case 2 : field.DATA_TYPE = "Integer"
                        Case 3 : field.DATA_TYPE = "Long"
                        Case 4 : field.DATA_TYPE = "Simple"
                        Case 5 : field.DATA_TYPE = "Double"
                        Case 6 : field.DATA_TYPE = "Currency"
                        Case 7 : field.DATA_TYPE = "Date Time"
                        Case 11 : field.DATA_TYPE = "Boolean"
                        Case 17 : field.DATA_TYPE = "Byte"
                        Case 72 : field.DATA_TYPE = "Replication code"
                        Case 128 : field.DATA_TYPE = "Object OLE"
                        Case 130
                            field.DATA_TYPE = "Memo"
                            If dr("CHARACTER_MAXIMUM_LENGTH") > 0 Then
                                field.DATA_TYPE = "Text"
                            End If
                        Case 131 : field.DATA_TYPE = "Decimal"
                        Case Else : field.DATA_TYPE = "Unknown"
                    End Select

                    If Not IsDBNull(dr("CHARACTER_MAXIMUM_LENGTH")) Then field.CHARACTER_LENGHT = dr("CHARACTER_MAXIMUM_LENGTH")

                    field.DEFAULT_VALUE = ""
                    If Not IsDBNull(dr("COLUMN_DEFAULT")) Then field.DEFAULT_VALUE = dr("COLUMN_DEFAULT")
                    field.DESCRIPTION = ""
                    If Not IsDBNull(dr("DESCRIPTION")) Then field.DESCRIPTION = dr("DESCRIPTION")
                    field.IS_NULLABLE = dr("IS_NULLABLE")

                    field.IS_PRIMARY_KEY = False
                    For Each dr_pk In dt_pk.Select("COLUMN_NAME='" & dr("COLUMN_NAME") & "' AND PK_NAME='PrimaryKey'")
                        If dr_pk("COLUMN_NAME") = dr("COLUMN_NAME") Then
                            field.IS_PRIMARY_KEY = True
                            Exit For
                        End If
                    Next

                    If Not IsDBNull(dr("NUMERIC_PRECISION")) Then field.NUMERIC_PRECISION = dr("NUMERIC_PRECISION")
                    If Not IsDBNull(dr("NUMERIC_SCALE")) Then field.NUMERIC_SCALE = dr("NUMERIC_SCALE")

                    list_fields.Add(field)
                Next

                dt.Dispose()
                dt_pk.Dispose()
                conn.Close()

                'sort the result
                list_fields.Sort(Function(x, y) x.POSITION.CompareTo(y.POSITION))
                'or
                'list_fields = list_fields.OrderBy(Function(x) x.POSITION).ToList()

                Return list_fields
            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListPrimaryKey(ByVal table As String) As DataSet
        Dim ds As New DataSet


        Try

            Using conn As New System.Data.OleDb.OleDbConnection(string_conection())

                conn.Open()
                Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, {Nothing, Nothing, table})
                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Procedures, {})
                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.DbInfoKeywords, {})
                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.DbInfoLiterals, {})
                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Indexes, {})

                ds.Tables.Add(dt)

                dt.Dispose()

                conn.Close()

                Return ds
            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListAllIndex(ByVal table As String) As List(Of clsSchemaIndex)
        Dim dt As DataTable
        Dim dr As DataRow
        Dim id As New clsSchemaIndex
        Dim my_indexs As New List(Of clsSchemaIndex)
        Try
            Using conn As New System.Data.OleDb.OleDbConnection(string_conection())
                conn.Open()

                dt = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Indexes, {Nothing, Nothing, Nothing, Nothing, table})

                For Each dr In dt.Rows
                    If id.INDEX_NAME <> dr("INDEX_NAME") Then
                        my_indexs.Add(id)
                        id = New clsSchemaIndex
                    End If

                    id.INDEX_NAME = dr("INDEX_NAME")
                    id.IS_PRIMARY_KEY = dr("PRIMARY_KEY")
                    id.IS_UNIQUE = dr("UNIQUE")
                    id.NOT_NULL = dr("NULLS")
                    id.COLUMNS_NAME.Add(dr("COLUMN_NAME"))
                Next
                my_indexs.Add(id)

                dt.Dispose()

                conn.Close()

                Return my_indexs
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

#End Region

End Class
