
Public Class FrmCommand

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim data As New DataSet

        Try

            If InStr(UCase(txtCommand.Text), "UPDATE ", CompareMethod.Text) > 0 Then
                If InStr(UCase(txtCommand.Text), " WHERE ", CompareMethod.Text) = 0 Then
                    If MsgBox("UPDATE without WHERE !" & vbCrLf & "The execution of the command cannot be undone!" & vbCrLf & "Continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                        txtStatus.Text = ""
                        Exit Sub
                    End If
                End If
            End If
            If InStr(UCase(txtCommand.Text), "DELETE ", CompareMethod.Text) > 0 Then
                If InStr(UCase(txtCommand.Text), " WHERE ", CompareMethod.Text) = 0 Then
                    If MsgBox("DELETE without WHERE !" & vbCrLf & "The execution of the command cannot be undone!" & vbCrLf & "Continue anyway?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                        txtStatus.Text = ""
                        Exit Sub
                    End If
                End If
            End If

            If Trim(txtCommand.Text) = "" Then Exit Sub

            DB_Mediator.Script_execute(txtCommand.Text, txtStatus.Text, data)

            GridResult.DataSource = data
            If Not IsNothing(data) Then
                GridResult.DataMember = data.Tables(0).TableName
                If data.Tables(0).Rows.Count > 0 Then TabControlCommand.SelectedIndex = 1
            End If

        Catch ex As Exception
            txtStatus.Text = ex.Message
        End Try

        Me.DialogResult = Windows.Forms.DialogResult.None

    End Sub

    Private Sub FrmCommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlCommand.SelectedIndex = 0

    End Sub
End Class
