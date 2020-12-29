﻿Imports FirebirdSql.Data.FirebirdClient
Imports System.IO

Public Class DB_FB

#Region "Configuration"

    Public Shared ReadOnly Property string_conection() As String
        Get
            Dim strConnection As String

            strConnection = "data source=" + clsGlobal.sourceDataBase + ";"
            strConnection += "database=" + clsGlobal.localDataBase + ";"
            strConnection += "user=" + clsGlobal.userDataBase + ";"
            strConnection += "password=" + clsGlobal.passDataBase + ";"
            strConnection += "port=" + clsGlobal.portDataBase

            Return strConnection
        End Get
    End Property

#End Region

#Region "Functions"

    Public Shared Sub CloseConnection(ByRef connection As FbConnection)
        Try
            connection.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Function SearchTable(ByVal table As String) As DataSet
        Dim conn As New FbConnection
        Dim myCmd As New FbCommand
        Dim dataAdapter As FbDataAdapter
        Dim ds As New DataSet()

        Try

            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd.CommandType = CommandType.Text
            myCmd.Connection = conn
            myCmd.CommandText = "SELECT * FROM " & table & ""

            dataAdapter = New FbDataAdapter(myCmd)
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
        Dim conn As New FbConnection
        Dim myCmd As New FbCommand
        Dim dataAdapter As FbDataAdapter
        Dim dataSet As New DataSet

        Try

            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd.CommandType = CommandType.Text
            myCmd.Connection = conn
            myCmd.CommandText = my_command

            If InStr(UCase(my_command), "SELECT ", CompareMethod.Text) > 0 Then

                dataAdapter = New FbDataAdapter(myCmd)
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

    Public Shared Function Script_execute(ByVal my_command As String, Optional ByRef my_status As String = "") As Boolean
        Dim dataSet As New DataSet()
        Dim dataAdapter As FbDataAdapter
        Dim myCmd As FbCommand
        Dim conn As FbConnection

        my_status = ""

        Try
            conn = New FbConnection
            conn.ConnectionString = string_conection()
            conn.Open()

            myCmd = New FbCommand
            myCmd.Connection = conn
            myCmd.CommandText = my_command

            If InStr(UCase(my_command), "SELECT ", CompareMethod.Text) > 0 Then

                dataAdapter = New FbDataAdapter(myCmd)
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

            Return True
        Catch ex As Exception
            Return ex.Message
            Return False
        End Try

    End Function

#End Region

#Region "Get the structure of the database"

    ''' <summary>
    ''' Function test
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Version() As String
        Return ""
    End Function

    Public Shared Function GetDialectVersion() As String
        Dim myData As New DataSet
        Dim query As String

        query = "select  case 1/2 "
        query += " when 0 then 'Dialect 3'"
        query += " when 0.5000 then 'Dialect 1'"
        query += " else 'Unknown'"
        query += " end as Dialect"
        query += " from rdb$database"

        Try
            myData = Execute(query)

            If Not IsNothing(myData) Then
                Return myData.Tables(0).Rows(0).Item(0).ToString
            End If

        Catch ex As Exception

        End Try

        Return ""
    End Function

    Public Shared Function GetServerVersion() As String
        Dim myData As New DataSet

        Try
            myData = Execute("select rdb$get_context('SYSTEM','ENGINE_VERSION') as version from RDB$DATABASE")

            If Not IsNothing(myData) Then
                Return myData.Tables(0).Rows(0).ToString
            End If

        Catch ex As Exception

        End Try

        Return ""
    End Function

    Public Shared Function ListTable() As List(Of String)
        Dim list As New List(Of String)
        Dim myData As New DataSet

        Try

            myData = Execute("SELECT r.RDB$RELATION_NAME AS TABLE_NAME FROM RDB$RELATIONS r WHERE COALESCE(RDB$SYSTEM_FLAG, 0) = 0 AND RDB$RELATION_TYPE = 0")

            If Not IsNothing(myData) Then

                For Each row In myData.Tables(0).Rows
                    list.Add(row("TABLE_NAME").ToString.Trim)
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return list
    End Function

    Public Shared Function ListFieldsByDS(ByVal table As String) As DataSet
        Dim query As String

        query = "SELECT "
        query += " R.RDB$RELATION_NAME AS TABLE_NAME"
        query += ", R.RDB$FIELD_POSITION AS ORDINAL_POSITION"
        query += ", R.RDB$FIELD_NAME AS COLUMN_NAME"
        query += ", R.RDB$NULL_FLAG AS IS_NULLABLE"
        query += ", R.RDB$DESCRIPTION AS DESCRIPTION"
        query += ", F.RDB$DEFAULT_VALUE AS COLUMN_DEFAULT"
        query += ", F.RDB$FIELD_LENGTH AS CHARACTER_MAXIMUM_LENGTH"
        query += ", F.RDB$FIELD_TYPE AS DATA_TYPE"
        query += ", F.RDB$FIELD_SCALE AS NUMERIC_SCALE"
        query += ", F.RDB$FIELD_PRECISION AS NUMERIC_PRECISION"
        query += ", F.RDB$FIELD_SUB_TYPE AS SUB_TYPE"

        query += " FROM "
        query += " RDB$RELATION_FIELDS R"
        query += " JOIN RDB$FIELDS F"
        query += " ON F.RDB$FIELD_NAME = R.RDB$FIELD_SOURCE"
        query += " JOIN RDB$RELATIONS RL"
        query += " ON RL.RDB$RELATION_NAME = R.RDB$RELATION_NAME"
        query += " WHERE "
        query += " COALESCE(R.RDB$SYSTEM_FLAG, 0) = 0"
        query += " AND COALESCE(RL.RDB$SYSTEM_FLAG, 0) = 0"
        query += " AND RL.RDB$VIEW_BLR Is NULL"
        query += " AND R.RDB$RELATION_NAME ='" & table & "'"
        query += " ORDER BY"
        query += " R.RDB$FIELD_POSITION,"
        query += " R.RDB$RELATION_NAME"

        Try
            
            Return Execute(query)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListFields(ByVal table As String) As List(Of clsSchemaTable)
        Dim dsColumns, dsKeys As New DataSet
        Dim list_fields As New List(Of clsSchemaTable)
        Dim field As clsSchemaTable

        Try

            dsColumns = ListFieldsByDS(table)
            dsKeys = ListPrimaryKey(table)

            For Each item In dsColumns.Tables(0).Rows
                field = New clsSchemaTable

                If Not IsDBNull(item("ORDINAL_POSITION")) Then field.POSITION = item("ORDINAL_POSITION")
                If Not IsDBNull(item("COLUMN_NAME")) Then field.COLUMN_NAME = item("COLUMN_NAME")
                If Not IsDBNull(item("DATA_TYPE")) Then field.DATA_TYPE_CODE = item("DATA_TYPE")
                Select Case item("DATA_TYPE")
                    Case 7 : field.DATA_TYPE = "SMALLINT"
                    Case 8 : field.DATA_TYPE = "INTEGER"
                    Case 10 : field.DATA_TYPE = "FLOAT"
                    Case 12 : field.DATA_TYPE = "DATE"
                    Case 13 : field.DATA_TYPE = "TIME"
                    Case 14 : field.DATA_TYPE = "CHAR"
                    Case 16
                        If item("SUB_TYPE") = 0 Then
                            field.DATA_TYPE = "BIGINT"
                        ElseIf item("SUB_TYPE") = 1 Then
                            field.DATA_TYPE = "NUMERIC"
                        ElseIf item("SUB_TYPE") = 2 Then
                            field.DATA_TYPE = "DECIMAL"
                        End If
                    Case 27 : field.DATA_TYPE = "DOUBLE PRECISION"
                    Case 35 : field.DATA_TYPE = "TIMESTAMP"
                    Case 37 : field.DATA_TYPE = "VARCHAR"
                    Case 261
                        If item("SUB_TYPE") = 0 Then
                            field.DATA_TYPE = "BLOB (Binary)"
                        ElseIf item("SUB_TYPE") = 1 Then
                            field.DATA_TYPE = "BLOB (Text)"
                        End If
                    Case Else : field.DATA_TYPE = "Unknown"
                End Select

                If Not IsDBNull(item("CHARACTER_MAXIMUM_LENGTH")) Then field.CHARACTER_LENGHT = item("CHARACTER_MAXIMUM_LENGTH")

                field.DEFAULT_VALUE = ""
                If Not IsDBNull(item("COLUMN_DEFAULT")) Then field.DEFAULT_VALUE = item("COLUMN_DEFAULT")
                field.DESCRIPTION = ""
                If Not IsDBNull(item("DESCRIPTION")) Then field.DESCRIPTION = item("DESCRIPTION")
                If Not IsDBNull(item("IS_NULLABLE")) Then field.IS_NULLABLE = item("IS_NULLABLE")

                field.IS_PRIMARY_KEY = False
                For Each dr_pk In dsKeys.Tables(0).Select("COLUMN_NAME='" & item("COLUMN_NAME") & "' AND CONSTRAINT_TYPE='PRIMARY KEY'")
                    If dr_pk("COLUMN_NAME") = item("COLUMN_NAME") Then
                        field.IS_PRIMARY_KEY = True
                        Exit For
                    End If
                Next

                If Not IsDBNull(item("NUMERIC_PRECISION")) Then field.NUMERIC_PRECISION = item("NUMERIC_PRECISION")
                If Not IsDBNull(item("NUMERIC_SCALE")) Then field.NUMERIC_SCALE = item("NUMERIC_SCALE")

                list_fields.Add(field)
            Next

            'sort the result
            list_fields.Sort(Function(x, y) x.POSITION.CompareTo(y.POSITION))
            'or
            'list_fields = list_fields.OrderBy(Function(x) x.POSITION).ToList()

            Return list_fields

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListPrimaryKey(ByVal table As String) As DataSet
        Dim ds As New DataSet
        Dim query As String

        query = "SELECT REL_CONS.RDB$CONSTRAINT_NAME CONSTRAINT_NAME"
        query += ", REL_CONS.RDB$CONSTRAINT_TYPE CONSTRAINT_TYPE"
        query += ", REL_CONS.RDB$RELATION_NAME TABLE_NAME"
        query += ", ISEG.RDB$FIELD_NAME COLUMN_NAME"
        query += ", R.RDB$NULL_FLAG NULLS"
        query += " FROM RDB$RELATION_CONSTRAINTS REL_CONS"
        query += " INNER JOIN RDB$INDEX_SEGMENTS ISEG"
        query += " ON ISEG.RDB$INDEX_NAME = REL_CONS.RDB$INDEX_NAME"
        query += " INNER JOIN RDB$RELATION_FIELDS R"
        query += " ON R.RDB$FIELD_NAME = ISEG.RDB$FIELD_NAME"
        query += " WHERE REL_CONS.RDB$RELATION_NAME='" & table & "'"
        query += " AND REL_CONS.RDB$CONSTRAINT_TYPE='PRIMARY KEY'"

        Try

            Return Execute(query)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function ListProcedures() As List(Of String)
        Dim list As New List(Of String)
        Dim myData As New DataSet

        Try

            myData = Execute("SELECT rdb$Procedure_name as Procedure_Name FROM rdb$procedures WHERE rdb$system_flag IS NULL OR rdb$system_flag = 0;")

            If Not IsNothing(myData) Then

                For Each row In myData.Tables(0).Rows
                    list.Add(row("Procedure_Name").ToString.Trim)
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return list
    End Function

    Public Shared Function ListViews() As List(Of String)
        Dim my_views As New List(Of String)
        Dim myData As New DataSet

        Try

            myData = Execute("select rdb$relation_name as View_name from rdb$relations where rdb$view_blr is not null and (rdb$system_flag is null or rdb$system_flag = 0);")

            If Not IsNothing(myData) Then

                For Each row In myData.Tables(0).Rows
                    my_views.Add(row("View_name").ToString.Trim)
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return my_views
    End Function

    Public Shared Function ListModules() As List(Of String)
        Dim my_list As New List(Of String)

        my_list.Clear()

        Return my_list
    End Function

    Public Shared Function ListAllIndex(ByVal table As String) As List(Of clsSchemaIndex)
        Dim query As String
        Dim ds As New DataSet
        Dim id As New clsSchemaIndex
        Dim my_indexs As New List(Of clsSchemaIndex)

        query = "SELECT REL_CONS.RDB$CONSTRAINT_NAME CONSTRAINT_NAME"
        query += ", REL_CONS.RDB$CONSTRAINT_TYPE CONSTRAINT_TYPE"
        query += ", REL_CONS.RDB$RELATION_NAME TABLE_NAME"
        query += ", ISEG.RDB$FIELD_NAME COLUMN_NAME"
        query += ", R.RDB$NULL_FLAG NULLS"
        query += " FROM RDB$RELATION_CONSTRAINTS REL_CONS"
        query += " INNER JOIN RDB$INDEX_SEGMENTS ISEG"
        query += " ON ISEG.RDB$INDEX_NAME = REL_CONS.RDB$INDEX_NAME"
        query += " INNER JOIN RDB$RELATION_FIELDS R"
        query += " ON R.RDB$FIELD_NAME = ISEG.RDB$FIELD_NAME"
        query += " WHERE REL_CONS.RDB$RELATION_NAME='" & table & "'"

        Try
            ds = Execute(query)


            For Each dr In ds.Tables(0).Rows
                id = New clsSchemaIndex
                id.INDEX_NAME = dr("CONSTRAINT_NAME")

                If dr("CONSTRAINT_TYPE").ToString.Trim.ToUpper = "PRIMARY KEY" Then
                    id.IS_PRIMARY_KEY = True
                ElseIf dr("CONSTRAINT_TYPE").ToString.Trim.ToUpper = "FOREIGN KEY" Then
                    id.IS_FOREIGN_KEY = True
                ElseIf dr("CONSTRAINT_TYPE").ToString.Trim.ToUpper = "UNIQUE" Then
                    id.IS_UNIQUE = True
                End If

                If Not IsDBNull(dr("NULLS")) Then id.NOT_NULL = dr("NULLS")

                id.COLUMNS_NAME = (dr("COLUMN_NAME"))
                my_indexs.Add(id)
            Next

            Return my_indexs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Sub GetSchema()

        Try
            Using conn As New FbConnection(string_conection())
                conn.Open()

                Dim dt As DataTable = conn.GetSchema("Procedures", {})

                conn.Close()

                FrmResult.MdiParent = FrmMenu
                If FrmResult.IsHandleCreated Then
                    FrmResult.Focus()
                Else
                    FrmResult.Show()
                End If

                FrmResult.Grid.DataSource = dt
            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Scripts"

    Public Shared Function GetScriptDropTable(ByVal table As String) As String
        Return "DROP TABLE [" & table & "]"
    End Function

#End Region

End Class
