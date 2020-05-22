Imports System.IO
Imports System.Runtime.InteropServices

Public Class FrmComando

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click

        Try

            If Not File.Exists(txtLocal_dados.Text) Then
                MsgBox("Informe o local do banco de dados !", MsgBoxStyle.Information, "Atenção")
                txtLocal_dados.Focus()
                lblStatus.Text = ""
                Exit Sub
            End If
            If InStr(UCase(txtComando.Text), "UPDATE ", CompareMethod.Text) > 0 Then
                If InStr(UCase(txtComando.Text), " WHERE ", CompareMethod.Text) = 0 Then
                    MsgBox("UPDATE sem WHERE não permitido !", MsgBoxStyle.Exclamation, "Atenção")
                    lblStatus.Text = ""
                    Exit Sub
                End If
            End If
            If InStr(UCase(txtComando.Text), "DELETE ", CompareMethod.Text) > 0 Then
                If InStr(UCase(txtComando.Text), " WHERE ", CompareMethod.Text) = 0 Then
                    MsgBox("DELETE sem WHERE não permitido !", MsgBoxStyle.Exclamation, "Atenção")
                    lblStatus.Text = ""
                    Exit Sub
                End If
            End If

            If Trim(txtComando.Text) = "" Then Exit Sub

            Call executar2()

            'lblStatus.Text = ""
        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try
    End Sub

    Private Function string_conection() As String
        Dim strConexao As String

        If UCase(Mid(txtLocal_dados.Text, Len(txtLocal_dados.Text) - 3)) = ".MDB" Then
            strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;"
        ElseIf UCase(Mid(txtLocal_dados.Text, Len(txtLocal_dados.Text) - 5)) = ".ACCDB" Then
            strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;"
        Else
            strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;"
        End If

        If Len(txtSenha.Text) > 0 Then
            strConexao += " Persist Security Info=True; Jet OLEDB:Database Password=" + txtSenha.Text + ";"
        Else
            strConexao += " Persist Security Info=False;"
        End If
        strConexao += " data source=" + txtLocal_dados.Text + ";"

        Return strConexao
    End Function

    Private Sub executar()
        Dim cn As New OleDb.OleDbConnection
        Dim myCmd As New OleDb.OleDbCommand
        Dim dr As OleDb.OleDbDataReader
        Dim dt = New DataTable()

        cn.ConnectionString = string_conection()
        cn.Open()

        myCmd.Connection = cn
        myCmd.CommandText = txtComando.Text

        If InStr(UCase(txtComando.Text), "SELECT ", CompareMethod.Text) > 0 Then
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

    Private Sub executar2()
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
            comando.CommandText = txtComando.Text

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

            lblStatus.Text = ""
        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnEstrutura_Click(sender As Object, e As EventArgs) Handles btnEstrutura.Click
        Try

            If Not File.Exists(txtLocal_dados.Text) Then
                MsgBox("Informe o local do banco de dados !", MsgBoxStyle.Information, "Atenção")
                txtLocal_dados.Focus()
                lblStatus.Text = ""
                Exit Sub
            End If

            Using conn As New System.Data.OleDb.OleDbConnection(string_conection)
                conn.Open()
                Dim dt As DataTable = conn.GetSchema("TABLES", {Nothing, Nothing, Nothing, "TABLE"})

                If FrmEstrutura.IsHandleCreated Then
                    FrmEstrutura.Focus()
                Else
                    FrmEstrutura.Show()
                End If

                FrmEstrutura.Grid.DataSource = dt
                dt.Dispose()
            End Using

            lblStatus.Text = ""
        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        End
    End Sub

    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblStatus_MouseDown(sender As Object, e As EventArgs) Handles lblStatus.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub lblTitulo_MouseDown(sender As Object, e As EventArgs) Handles lblTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

End Class
