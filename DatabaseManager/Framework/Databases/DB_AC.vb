Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO

''' <summary>
''' CLASSE COM MÉTODOS/ROTINAS PARA ACESSO AO BANCO DE DADOS ACCESS
''' </summary>
''' <remarks></remarks>
Public Class DB_AC

#Region "private"

    Private Shared strConexao As String = ""

#End Region

#Region "Conexoes Banco de dados"
    Public Shared ReadOnly Property string_conection() As String
        Get
            Dim strConexao As String

            If UCase(Mid(clsGlobal.LocalDataBase, Len(clsGlobal.LocalDataBase) - 3)) = ".MDB" Then
                strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;"
            ElseIf UCase(Mid(clsGlobal.LocalDataBase, Len(clsGlobal.LocalDataBase) - 5)) = ".ACCDB" Then
                strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;"
            Else
                strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;"
            End If

            If Len(clsGlobal.PassDataBase) > 0 Then
                strConexao += " Persist Security Info=True; Jet OLEDB:Database Password=" + clsGlobal.PassDataBase + ";"
            Else
                strConexao += " Persist Security Info=False;"
            End If
            strConexao += " data source=" + clsGlobal.LocalDataBase + ";"

            Return strConexao
        End Get
    End Property

    ''' <summary>
    ''' Verifica se a conexão com o banco de dados esta ok.
    ''' Ao iniciar o aplicativo, é feito a verificação na tabela de operadoras. Se não tiver nenhum registro, 
    ''' entende que é o primeiro acesso ao sistema,e será solicitado a chave.
    ''' Porém se o banco não estiver acessível, não sera retornado nenhum registro, mesmo que não
    ''' seja o primeiro acesso. Neste caso o aplicativo sera encerrado.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function VerificarConexao() As Boolean
        Dim conexao As IDbConnection = CONECTAR
        If (IsNothing(conexao)) Then
            Return False
        Else
            If (conexao.State = ConnectionState.Open) Then
                FecharConexao(conexao)
                Return True
            Else
                Return False
            End If
        End If
    End Function

    ''' <summary>
    ''' Abre uma conexão com o banco de dados ACCESS
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property CONECTAR() As System.Data.OleDb.OleDbConnection
        Get
            Try
                Dim conexao As System.Data.OleDb.OleDbConnection
                conexao = New System.Data.OleDb.OleDbConnection
                conexao.ConnectionString = StringConexao("")
                conexao.Open()
                Return conexao
            Catch e As Exception
                MsgBox("Houve um problema conectar ao banco de dados!" & vbCrLf & e.Message, MsgBoxStyle.Exclamation)
                Return Nothing
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Fecha a conexão do banco de dados amarrada ao comando SQL e libera o comando
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <remarks></remarks>
    Public Shared Sub FecharConexao(ByRef comando As System.Data.OleDb.OleDbCommand)
        Try
            If comando.Connection IsNot Nothing Then
                If comando.Connection.State = System.Data.ConnectionState.Open Then
                    comando.Connection.Close()
                End If
                comando.Connection.Dispose()
                comando.Dispose()
            End If
        Catch e As Exception
            MsgBox("Houve um problema fechar a conecaõ com banco de dados!" & vbCrLf & e.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    ''' <summary>
    ''' Fecha a conexao passada como parametro.
    ''' </summary>
    ''' <param name="conexao"></param>
    ''' <remarks></remarks>
    Private Shared Sub FecharConexao(ByRef conexao As IDbConnection)
        Try
            If conexao IsNot Nothing Then
                If conexao.State = System.Data.ConnectionState.Open Then
                    conexao.Close()
                End If
                conexao.Dispose()
            End If
        Catch e As Exception
            MsgBox("Houve um problema fechar a conecaõ com banco de dados!" & vbCrLf & e.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' Lê os parametros no registro e gera a string de conexao ACCESS.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared ReadOnly Property StringConexao(ByVal base As String, Optional ByVal senha As String = "") As String
        Get
            If strConexao.Length = 0 Then
                strConexao = base
                If Len(strConexao) > 4 Then
                    If UCase(Mid(strConexao, Len(strConexao) - 3)) = ".MDB" Then
                        strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;"
                    ElseIf UCase(Mid(strConexao, Len(strConexao) - 5)) = ".ACCDB" Then
                        strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;"
                    End If
                Else
                    strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;"
                End If

                If Len(senha) > 0 Then
                    strConexao += " Persist Security Info=False;Jet OLEDB:Database Password=" + senha + ";"
                End If
                strConexao += " data source=" + base + ";"

            End If
            Return strConexao
        End Get

    End Property


#End Region

#Region "Acesso BD"

    ''' <summary>
    ''' Executa o comando sql passado como parametro
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecutaComando(ByRef comando As System.Data.OleDb.OleDbCommand) As Boolean
        Dim result As Boolean
        Try
            comando.Connection = CONECTAR
            If comando.Connection.State = ConnectionState.Open Then
                comando.ExecuteNonQuery()
                result = True
            Else
                result = False
            End If

        Catch ex As Exception
            MsgBox("Houve um problema ao executar o comando", MsgBoxStyle.Exclamation)
            result = False
        End Try

        FecharConexao(comando)
        Return result
    End Function

    Public Function ExecutaComando(ByVal strComando As String) As Boolean
        Dim result As Boolean
        Dim comando As New System.Data.OleDb.OleDbCommand
        comando.CommandText = strComando
        Try
            comando.Connection = CONECTAR
            If comando.Connection.State = ConnectionState.Open Then
                comando.ExecuteNonQuery()
                result = True
            Else
                result = False
            End If

        Catch ex As Exception
            MsgBox("Houve um problema ao Executar o comando!" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            result = False
        End Try

        FecharConexao(comando)
        Return result
    End Function


    ''' <summary>
    ''' Executa o comando e retorna o primeiro resultado
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecutaComandoEscalar(ByRef comando As System.Data.OleDb.OleDbCommand) As String
        Dim result As String = ""
        Try
            comando.Connection = CONECTAR
            If comando.Connection.State = ConnectionState.Open Then
                result = comando.ExecuteScalar
            Else
                result = ""
            End If

        Catch ex As Exception
            MsgBox("Houve um problema " & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            result = ex.Message
        End Try

        FecharConexao(comando)
        Return result
    End Function

    Public Shared Function ExecutaComandoEscalar(ByVal strComando As String) As String
        Dim result As String = ""
        Dim comando As New System.Data.OleDb.OleDbCommand
        comando.CommandText = strComando
        Try
            comando.Connection = CONECTAR
            If comando.Connection.State = ConnectionState.Open Then
                result = comando.ExecuteScalar
            Else
                result = ""
            End If

        Catch ex As Exception
            MsgBox("Houve um problema ao executar o Comando!" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            result = ex.Message
        End Try

        FecharConexao(comando)
        Return result
    End Function

    ''' <summary>
    ''' Carrega um dataset a partir do comando passado como parametro
    ''' </summary>
    ''' <param name="comando">IDbCommand</param>
    ''' <param name="mostarMsgErro">Em caso de erro, define se será ou não mostrado a mensagem de erro para o usuário</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CarregaDS(ByRef comando As System.Data.OleDb.OleDbCommand, ByRef mostarMsgErro As Boolean) As DataSet
        Dim dataSet As New DataSet()
        Dim dataAdapter As System.Data.OleDb.OleDbDataAdapter

        Try
            comando.Connection = CONECTAR
            If comando.Connection IsNot Nothing AndAlso comando.Connection.State = ConnectionState.Open Then
                dataAdapter = New System.Data.OleDb.OleDbDataAdapter(comando)
                dataAdapter.Fill(dataSet)
                'dataAdapter.Dispose()
            End If

        Catch ex As Exception
            MsgBox("Houve um problema ao carregar o dataset !" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try

        FecharConexao(comando)

        If dataSet.Tables.Count = 0 Then
            Return Nothing
        End If
        If dataSet.Tables(0).Rows.Count = 0 Then
            Return Nothing
        End If

        Return dataSet
    End Function

    Public Shared Function CarregaDS(ByVal strComando As String, Optional ByRef mostarMsgErro As Boolean = False) As DataSet
        Dim dataSet As New DataSet()
        Dim dataAdapter As System.Data.OleDb.OleDbDataAdapter
        Dim comando As New System.Data.OleDb.OleDbCommand
        comando.CommandText = strComando
        Try
            comando.Connection = CONECTAR
            If comando.Connection IsNot Nothing AndAlso comando.Connection.State = ConnectionState.Open Then
                dataAdapter = New System.Data.OleDb.OleDbDataAdapter(comando)
                dataAdapter.Fill(dataSet)
                'dataAdapter.Dispose()
            End If

        Catch ex As Exception
            MsgBox("Houve um problema ao carregar o dataset" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try

        FecharConexao(comando)

        If dataSet.Tables.Count = 0 Then
            Return Nothing
        End If
        If dataSet.Tables(0).Rows.Count = 0 Then
            Return Nothing
        End If

        Return dataSet
    End Function

    ''' <summary>
    ''' Carrega um dataset a partir do comando passado como parametro
    ''' Em caso de erro sera mostrado a mensagem ao usuário
    ''' </summary>
    ''' <param name="comando"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CarregaDS(ByRef comando As System.Data.OleDb.OleDbCommand)
        Return CarregaDS(comando, True)
    End Function

    ''' <summary>
    ''' Carrega um grid a partir de um comando sql.
    ''' </summary>
    ''' <param name="comando">Comando ACCESS</param>
    ''' <param name="grid">Grid para ser preenchido</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CarregaGrid(ByRef comando As System.Data.OleDb.OleDbCommand, ByRef grid As DataGridView) As Boolean
        Dim dataSet As New DataSet()
        Dim dataAdapter As System.Data.OleDb.OleDbDataAdapter
        Dim result As Boolean

        Try
            grid.ReadOnly = False
            comando.Connection = CONECTAR
            dataAdapter = New System.Data.OleDb.OleDbDataAdapter(comando)
            dataAdapter.Fill(dataSet)
            dataAdapter.Dispose()

            grid.DataSource = dataSet
            grid.DataMember = dataSet.Tables(0).TableName
            dataSet.Dispose()

            result = True
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Houve um problema ao carregar o grid" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            result = False
        Catch ex As Exception
            MsgBox("Houve um problema ao carregar o grid" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            result = False
        End Try

        FecharConexao(comando)
        grid.ReadOnly = True

        Return result
    End Function


    Public Shared Function CarregaGrid(ByVal strComando As String, ByRef grid As DataGridView) As Boolean
        Dim comando As New System.Data.OleDb.OleDbCommand
        comando.CommandText = strComando
        Dim dataSet As New DataSet()
        Dim dataAdapter As System.Data.OleDb.OleDbDataAdapter
        Dim result As Boolean

        Try
            grid.ReadOnly = False
            comando.Connection = CONECTAR
            dataAdapter = New System.Data.OleDb.OleDbDataAdapter(comando)
            dataAdapter.Fill(dataSet)
            dataAdapter.Dispose()

            grid.DataSource = dataSet
            grid.DataMember = dataSet.Tables(0).TableName
            dataSet.Dispose()

            result = True
        Catch ex As System.Data.OleDb.OleDbException
            MsgBox("Houve um problema ao carregar o grid" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            result = False
        Catch ex As Exception
            MsgBox("Houve um problema ao carregar o grid" & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            result = False
        End Try

        FecharConexao(comando)
        grid.ReadOnly = True

        Return result
    End Function


    Function criaDataReader(ByVal conexao As System.Data.IDbConnection, ByVal sql As String) As System.Data.IDataReader 'cria um objeto commandbehavior e atribui a enumeracao padrao 

        Dim cmdBehavior As CommandBehavior = CommandBehavior.Default 'abre a conexao se necessário

        If conexao.State <> ConnectionState.Open Then 'abre a conexão se estiver fechada
            conexao.Open() 'define o comportamento para quando o datareader foi utilizado
            cmdBehavior = CommandBehavior.CloseConnection
        End If 'prepara a string sql para selecionar dados 

        Dim comando As System.Data.IDbCommand = conexao.CreateCommand()
        comando.CommandText = sql 'cria um datareader e força o comportamento desejado
        Dim dr As System.Data.IDataReader = comando.ExecuteReader(cmdBehavior) 'fecha o objeto commando e retorna o resultado
        comando.Dispose()
        Return dr
    End Function


#End Region


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
                Dim dt As DataTable = conn.GetSchema("Columns", {Nothing, Nothing, Nothing, "TABLE"})
                'Dim dt As DataTable = conn.GetSchema("Columns", {Nothing, Nothing, table})
                'var dtCols = con.GetSchema("Columns", new[] { "DBName", null, "TableName" });


                ds.Tables.Add(dt)

                'dt.Dispose()

                Return ds

            End Using


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return Nothing
    End Function

    Public Shared Function getEstruturaAC(ByVal tabela As String, ByRef grid As DataGridView) As Boolean

        'Try
        '    Dim con As New ADODB.Connection
        '    Dim cat As New ADOX.Catalog
        '    Dim tbl As New ADOX.Table
        '    Dim Col As New ADOX.Column
        '    Dim conexao, tipo As String

        '    Dim ds As New DataSet
        '    Dim dt As DataTable
        '    Dim dr As DataRow
        '    Dim tabelaCoulumn As DataColumn

        '    'estabelecendo a conexao
        '    tipo = ""
        '    con = New ADODB.Connection
        '    conexao = DB_AC.string_conection
        '    con.Open(conexao)
        '    cat.ActiveConnection = con

        '    dt = New DataTable()
        '    tabelaCoulumn = New DataColumn("NOME_CAMPO", Type.GetType("System.String"))
        '    dt.Columns.Add(tabelaCoulumn)
        '    tabelaCoulumn = New DataColumn("TIPO_CAMPO", Type.GetType("System.String"))
        '    dt.Columns.Add(tabelaCoulumn)
        '    tabelaCoulumn = New DataColumn("TIPO_CAMPO2", Type.GetType("System.String"))
        '    dt.Columns.Add(tabelaCoulumn)
        '    tabelaCoulumn = New DataColumn("TAMANHO", Type.GetType("System.String"))
        '    dt.Columns.Add(tabelaCoulumn)
        '    tabelaCoulumn = New DataColumn("ESCALA", Type.GetType("System.String"))
        '    dt.Columns.Add(tabelaCoulumn)

        '    'exibindo o nome e os tipos das tabelas
        '    For Each tbl In cat.Tables
        '        If tabela = tbl.Name Then
        '            For Each Col In tbl.Columns

        '                If Col.Type.ToString = "adDate" Or Col.Type.ToString = "adDBTimeStamp" Then
        '                    tipo = "DateTime"
        '                ElseIf Col.Type.ToString = "adVarWChar" Or Col.Type.ToString = "adVarChar" Or Col.Type.ToString = "adWChar" Or Col.Type.ToString = "adChar" Or Col.Type.ToString = "adLongVarChar" Or Col.Type.ToString = "adLongVarWChar" Then
        '                    tipo = "Text"
        '                ElseIf Col.Type.ToString = "adInteger" Or Col.Type.ToString = "adSmallInt" Or Col.Type.ToString = "adBigInt" Then
        '                    tipo = "Integer"
        '                ElseIf Col.Type.ToString = "adSingle" Or Col.Type.ToString = "adNumeric" Or Col.Type.ToString = "adDecimal" Or Col.Type.ToString = "adCurrency" Or Col.Type.ToString = "adDouble" Then
        '                    tipo = "Double"
        '                Else
        '                    tipo = "Indefinido"
        '                End If
        '                'Double = MALLINT
        '                'Integer = INTEGER
        '                'QUAD = QUAD
        '                'Double = FLOAT
        '                'Double = D_FLOAT
        '                'DateTime = DATE
        '                'DateTime = TIME
        '                'String = CHAR
        '                'Integer = INT64
        '                'Double = DOUBLE
        '                'DateTime = TIMESTAMP
        '                'String = VARCHAR
        '                'String = CSTRING
        '                'String = BLOB
        '                'grid.Rows.Add(Col.Name, tipo, Col.Type, Col.Precision, Col.NumericScale)

        '                dr = dt.NewRow()
        '                dr("NOME_CAMPO") = UCase(Col.Name)
        '                dr("TIPO_CAMPO") = tipo
        '                dr("TIPO_CAMPO2") = Col.Type
        '                dr("TAMANHO") = Col.Precision
        '                dr("ESCALA") = Col.NumericScale
        '                dt.Rows.Add(dr)

        '            Next
        '        End If
        '    Next

        '    ds.Tables.Add(dt)

        '    grid.DataSource = dt
        '    grid.DataMember = dt.TableName
        '    Return True
        'Catch ex As Exception
        '    Return False
        'End Try
    End Function

End Class
