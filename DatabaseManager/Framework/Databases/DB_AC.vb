
''' <summary>
''' CLASS WITH METHODS / ROUTINES FOR ACCESS TO DATABASE ACCESS
''' </summary>
''' <remarks></remarks>
Public Class DB_AC

#Region "Conexoes Banco de dados"

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

#Region "Acesso BD"

    Public Shared Sub execute(ByVal my_command As String)
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

            If FrmConsulta.IsHandleCreated Then
                FrmConsulta.Focus()
            Else
                FrmConsulta.Show()
            End If

            FrmConsulta.Grid.AutoGenerateColumns = True
            FrmConsulta.Grid.DataSource = dt
            FrmConsulta.Grid.Refresh()

        Else
            myCmd.ExecuteNonQuery()
        End If
        cn.Close()
    End Sub

    Public Shared Sub execute2(ByVal my_command As String)
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

    Public Shared Function ListTable() As List(Of String)
        Dim list As New List(Of String)

        Try
            Using conn As New System.Data.OleDb.OleDbConnection(DB_AC.string_conection())
                conn.Open()
                Dim dt As DataTable = conn.GetSchema("TABLES", {Nothing, Nothing, Nothing, "TABLE"})

                For Each row In dt.Rows
                    list.Add(row("TABLE_NAME"))
                Next

                dt.Dispose()
            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return list
    End Function


    Public Shared Function ListFields(ByVal table As String) As DataSet
        Dim ds As New DataSet
        Try
            Using conn As New System.Data.OleDb.OleDbConnection(DB_AC.string_conection())
                conn.Open()

                Dim dt As DataTable = conn.GetSchema("Columns", {Nothing, Nothing, table})
                ds.Tables.Add(dt)

                dt.Dispose()

                Return ds

            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

#End Region

End Class
