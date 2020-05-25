Imports System.Data.OleDb

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

    Public Shared Function Execute(ByVal my_command As String) As DataTable
        Dim cn As New OleDb.OleDbConnection
        Dim myCmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim dt = New DataTable()

        cn.ConnectionString = string_conection()
        cn.Open()

        myCmd.Connection = cn
        myCmd.CommandText = my_command

        If InStr(UCase(my_command), "SELECT ", CompareMethod.Text) > 0 Then
            dr = myCmd.ExecuteReader()
            dr.Read()
            dt.Load(dr)

            dr.Close()
            cn.Close()

            Return dt
        Else
            myCmd.ExecuteNonQuery()
        End If

        cn.Close()

        Return Nothing
    End Function

    Public Shared Sub Execute2(ByVal my_command As String)
        Dim dataSet As New DataSet()
        Dim dataAdapter As System.Data.OleDb.OleDbDataAdapter
        Dim comando As System.Data.OleDb.OleDbCommand
        Dim conexao As System.Data.OleDb.OleDbConnection

        Try
            conexao = New System.Data.OleDb.OleDbConnection
            conexao.ConnectionString = string_conection()
            conexao.Open()

            comando = New System.Data.OleDb.OleDbCommand
            comando.Connection = conexao
            comando.CommandText = my_command

            dataAdapter = New System.Data.OleDb.OleDbDataAdapter(comando)
            dataAdapter.Fill(dataSet)
            dataAdapter.Dispose()

            If FrmConsulta.IsHandleCreated Then
                FrmConsulta.Focus()
            Else
                FrmConsulta.Show()
            End If

            FrmConsulta.Grid.DataSource = dataSet
            FrmConsulta.Grid.DataMember = dataSet.Tables(0).TableName
            dataSet.Dispose()

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
        Dim objAccess As Object
        Dim intFormat As Integer
        objAccess = CreateObject("Access.Application")

        objAccess.OpenCurrentDatabase(clsGlobal.localDataBase)

        intFormat = objAccess.CurrentProject.FileFormat

        Select Case intFormat
            Case 2 : Return "Microsoft Access 2"
            Case 7 : Return "Microsoft Access 95"
            Case 8 : Return "Microsoft Access 97"
            Case 9 : Return "Microsoft Access 2000"
            Case 10 : Return "Microsoft Access 2002/2003"
            Case 12 : Return "Microsoft Access 2007/2010"
            Case Else : Return intFormat & " Unknown"
        End Select

        objAccess.Close()

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

    Public Shared Function ListIndex(ByVal table As String) As DataSet
        Dim ds As New DataSet


        Try

            Using conn As New System.Data.OleDb.OleDbConnection(string_conection())

                conn.Open()
                Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, {Nothing, Nothing, table})
                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.DbInfoKeywords, {})
                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.DbInfoLiterals, {})
                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Indexes, {})



                'Dim dt As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, {Nothing, Nothing, Nothing, "TABLE"})

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



#End Region

End Class
