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

    Public Shared Function SearchTable(ByVal table As String, Optional ByVal where_clause As String = "") As DataSet
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
            If where_clause.Trim.Length > 0 Then myCmd.CommandText += " WHERE " + where_clause

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

    Public Shared Function SearchTable(ByVal table As String, Optional ByVal where_clause As String = "", Optional ByVal params As List(Of clsParameter) = Nothing) As DataSet
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

            If where_clause.Trim.Length > 0 Then myCmd.CommandText += " WHERE " + where_clause

            For Each column In params
                myCmd.Parameters.Add(New OleDbParameter(column.COLUMN_NAME, column.VALUE))
            Next

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

    Public Shared Function Script_execute(ByVal my_command As String, Optional ByRef my_status As String = "", Optional ByRef data As DataSet = Nothing) As Boolean
        Dim dataAdapter As System.Data.OleDb.OleDbDataAdapter
        Dim myCmd As System.Data.OleDb.OleDbCommand
        Dim conn As System.Data.OleDb.OleDbConnection

        my_status = ""

        Try
            conn = New System.Data.OleDb.OleDbConnection
            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd = New System.Data.OleDb.OleDbCommand
            myCmd.Connection = conn
            myCmd.CommandText = my_command

            If InStr(UCase(my_command), "SELECT ", CompareMethod.Text) > 0 Then

                dataAdapter = New System.Data.OleDb.OleDbDataAdapter(myCmd)

                data = New DataSet

                dataAdapter.Fill(data)

                dataAdapter.Dispose()

                'If dataSet.Tables.Count > 0 Then
                '    FrmResult.MdiParent = FrmMenu
                '    If FrmResult.IsHandleCreated Then
                '        FrmResult.Focus()
                '    Else
                '        FrmResult.Show()
                '    End If

                '    FrmResult.Grid.DataSource = dataSet
                '    FrmResult.Grid.DataMember = dataSet.Tables(0).TableName
                'End If

            Else
                my_status = "Affected rows: " & myCmd.ExecuteNonQuery()
            End If

            conn.Close()

            Return True
        Catch ex As Exception
            Return ex.Message
            Return False
        End Try

    End Function

    Public Shared Function Test_connection() As Boolean
        Dim conn As New OleDb.OleDbConnection
        Dim myCmd As New OleDb.OleDbCommand
        Dim dataAdapter As OleDb.OleDbDataAdapter
        Dim dataSet As New DataSet()

        Try
            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd.CommandType = CommandType.Text
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT NOW"

            dataAdapter = New System.Data.OleDb.OleDbDataAdapter(myCmd)
            dataAdapter.Fill(dataSet)

            dataAdapter.Dispose()
            conn.Close()

            If IsDate(dataSet.Tables(0).Rows(0).Item(0)) Then
                Return True
            End If

        Catch ex As Exception
            Call CloseConnection(conn)
        End Try

        Return False
    End Function

    Public Shared Sub RepairDatabase()
        ''need DAO360.DLL
        'Try
        '    Dim File_Path, compact_file As String
        '    Dim db As New dao.DBEngine()

        '    File_Path = clsGlobal.localDataBase
        '    compact_file = Path.GetFullPath(clsGlobal.localDataBase) & Replace(Path.GetFileName(clsGlobal.localDataBase), Path.GetExtension(clsGlobal.localDataBase), "") & "_NEW" & Path.GetExtension(clsGlobal.localDataBase)

        '    If File.Exists(File_Path) Then
        '        db.CompactDatabase(File_Path, compact_file)
        '    End If

        '    If File.Exists(compact_file) Then
        '        File.Delete(File_Path)
        '        File.Move(compact_file, File_Path)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Public Shared Function AlterTableName(ByVal old_name As String, ByVal new_name As String) As Boolean
        ''need DAO360.DLL
        'Dim dbe As New dao.DBEngine
        'Dim db As dao.Database
        'Dim tbd As New dao.TableDef
        'Dim result As Boolean = False

        'Try

        '    db = dbe.OpenDatabase(clsGlobal.localDataBase, False, True, "MS Access;PWD=" & clsGlobal.passDataBase)
        '    tbd = db.TableDefs(old_name)
        '    tbd.Name = new_name
        '    db.Close()

        '    result = True
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    result = False
        'End Try

        'Try
        '    dbe = Nothing
        '    db = Nothing
        '    tbd = Nothing
        'Catch ex As Exception
        'End Try

        'Return result
        Return False
    End Function

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
                Case 9 : Return intFormat & " - Microsoft Access XP/2000"
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
        Dim conn As New System.Data.OleDb.OleDbConnection

        Try

            conn.ConnectionString = string_conection
            conn.Open()
            Dim dt As DataTable = conn.GetSchema("TABLES", {Nothing, Nothing, Nothing, "TABLE"})

            For Each row In dt.Rows
                list.Add(row("TABLE_NAME"))
            Next

            dt.Dispose()
            conn.Close()

            conn = Nothing

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
        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim list_fields As New List(Of clsSchemaTable)
        Dim field As clsSchemaTable

        Try

            conn.ConnectionString = string_conection
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

            conn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListPrimaryKey(ByVal table As String) As DataSet
        Dim conn As New System.Data.OleDb.OleDbConnection()
        Dim ds As New DataSet

        Try

            conn.ConnectionString = string_conection
            conn.Open()
            Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, {Nothing, Nothing, table})

            ds.Tables.Add(dt)

            dt.Dispose()

            conn.Close()
            conn = Nothing

            Return ds

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListProcedures() As List(Of String)
        Dim conn As New System.Data.OleDb.OleDbConnection()
        Dim list As New List(Of String)
        Dim ds As New DataSet

        Try

            conn.ConnectionString = string_conection()
            conn.Open()

            Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Procedures, Nothing)

            ds.Tables.Add(dt)

            For Each row In dt.Rows
                list.Add(row("PROCEDURE_NAME"))
            Next

            dt.Dispose()
            conn.Close()
            conn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return list
    End Function

    Public Shared Function ListViews() As List(Of String)
        Dim conn As New System.Data.OleDb.OleDbConnection()
        Dim my_views As New List(Of String)

        Try
            conn.ConnectionString = string_conection
            conn.Open()

            Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Views, {})

            conn.Close()

            For Each row In dt.Rows
                my_views.Add(row("TABLE_NAME"))
            Next

            dt.Dispose()

            conn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return my_views
    End Function

    Public Shared Function ListModules() As List(Of String)
        Dim my_list As New List(Of String)
        'TODO

        'SELECT ModuleName FROM MSysNavPaneObjectIDs WHERE Type = 32775

        Return my_list
    End Function

    Public Shared Function ListAllIndex(ByVal table As String) As List(Of clsSchemaIndex)
        Dim conn As New System.Data.OleDb.OleDbConnection
        Dim dt As DataTable
        Dim dr As DataRow
        Dim id As New clsSchemaIndex
        Dim my_indexs As New List(Of clsSchemaIndex)
        Try
            conn.ConnectionString = string_conection
            conn.Open()

            dt = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Indexes, {Nothing, Nothing, Nothing, Nothing, table})

            For Each dr In dt.Rows
                id = New clsSchemaIndex
                id.INDEX_NAME = dr("INDEX_NAME")
                id.IS_PRIMARY_KEY = dr("PRIMARY_KEY")
                id.IS_UNIQUE = dr("UNIQUE")
                id.IS_FOREIGN_KEY = False
                id.NOT_NULL = dr("NULLS")

                id.COLUMNS_NAME = (dr("COLUMN_NAME"))
                my_indexs.Add(id)
            Next

            dt.Dispose()

            conn.Close()

            conn = Nothing

            Return my_indexs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Sub GetSchema()
        Dim conn As New System.Data.OleDb.OleDbConnection
        Try
            conn.ConnectionString = string_conection
            conn.Open()

            Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Procedures, {})

            conn.Close()

            FrmResult.MdiParent = FrmMenu
            If FrmResult.IsHandleCreated Then
                FrmResult.Focus()
            Else
                FrmResult.Show()
            End If

            FrmResult.Grid.DataSource = dt

            conn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Scripts"

    Public Shared Function GetScriptDropTable(ByVal table As String) As String
        Return "DROP TABLE [" & table & "];"
    End Function

    Public Shared Function GetScriptDropProcedure(ByVal procedure As String) As String
        Return "DROP PROCEDURE [" & procedure & "];"
    End Function

    Public Shared Function GetScriptDropField(ByVal table As String, ByVal column As String) As String
        Return "ALTER TABLE [" & table & "] DROP [" & column & "]"
    End Function

    Shared Function Translate_criteria(ByVal column As String, ByVal criteria As String, ByVal value As String) As String
        Dim trans As String = ""
        'access requires that single quotes are not used in numeric fields

        Select Case criteria.ToLower.Trim
            Case "is null" : trans = column & " IS NULL"
            Case "not is null" : trans = "NOT " & column & " IS NULL"
            Case "starting with"
                trans = column & " LIKE "
                If IsNumeric(value) Then
                    trans += "'" & value & "'"
                Else
                    trans += value
                End If
            Case "not starting with"
                trans = "NOT " & column & " LIKE "
                If IsNumeric(value) Then
                    trans += "'" & value & "'"
                Else
                    trans += value
                End If
            Case "contains"
                trans = "InStr(" & column & ","
                If IsNumeric(value) Then
                    trans += "'" & value & "'"
                Else
                    trans += value
                End If
                trans += ") > 0"
            Case "not contains"
                trans = "InStr(" & column & ","
                If IsNumeric(value) Then
                    trans += "'" & value & "'"
                Else
                    trans += value
                End If
                trans += ") = 0"
            Case Else
                trans = column & criteria
                If Not IsNumeric(value) Then
                    trans += "'" & value & "'"
                Else
                    trans += value
                End If
        End Select
        Return trans
    End Function

    Shared Function Translate_criteria(ByRef param As clsParameter, ByVal column As String, ByVal criteria As String, ByVal value As String) As String
        Dim trans As String
        'access requires that single quotes are not used in numeric fields

        Select Case criteria.ToLower.Trim
            Case "is null" : trans = column & " IS NULL"
            Case "not is null" : trans = "NOT " & column & " IS NULL"
            Case "starting with"
                trans = column & " LIKE "
                trans += "@" & column
            Case "not starting with"
                trans = "NOT " & column & " LIKE "
                trans += "@" & column
            Case "contains"
                trans = "InStr(" & column & ","
                trans += "@" & column
                trans += ") > 0"
            Case "not contains"
                trans = "InStr(" & column & ","
                trans += "@" & column
                trans += ") = 0"
            Case Else
                trans = column & criteria
                trans += "@" & column
        End Select

        param.COLUMN_NAME = "@" & column
        param.VALUE = value

        Return trans
    End Function

#End Region

    Public Shared Sub LoadTypes(ByRef combo As ComboBox)

        combo.Items.Clear()

        combo.Items.Add("Integer") '2
        combo.Items.Add("Long") '3
        combo.Items.Add("Simple") '4
        combo.Items.Add("Double") '5
        combo.Items.Add("Currency") '6
        combo.Items.Add("Date Time") '7
        combo.Items.Add("Boolean") '11
        combo.Items.Add("Byte") '17
        combo.Items.Add("Replication Code") '72
        combo.Items.Add("Object OLE") '128
        combo.Items.Add("Memo") '130
        combo.Items.Add("Decimal") '131

    End Sub


End Class
