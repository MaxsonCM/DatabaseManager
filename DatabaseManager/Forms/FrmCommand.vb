
Public Class FrmCommand

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Try

            If InStr(UCase(txtCommand.Text), "UPDATE ", CompareMethod.Text) > 0 Then
                If InStr(UCase(txtCommand.Text), " WHERE ", CompareMethod.Text) = 0 Then
                    MsgBox("UPDATE without WHERE !", MsgBoxStyle.Exclamation, "Atenção")
                    txtStatus.Text = ""
                    Exit Sub
                End If
            End If
            If InStr(UCase(txtCommand.Text), "DELETE ", CompareMethod.Text) > 0 Then
                If InStr(UCase(txtCommand.Text), " WHERE ", CompareMethod.Text) = 0 Then
                    MsgBox("DELETE without WHERE !", MsgBoxStyle.Exclamation, "Atenção")
                    txtStatus.Text = ""
                    Exit Sub
                End If
            End If

            If Trim(txtCommand.Text) = "" Then Exit Sub

            If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
                txtStatus.Text = DB_AC.Execute2(txtCommand.Text)
            Else
                MsgBox("Execution has not been implemented for the current database", vbInformation, "Attention")
            End If
        Catch ex As Exception
            txtStatus.Text = ex.Message
        End Try
    End Sub

End Class
