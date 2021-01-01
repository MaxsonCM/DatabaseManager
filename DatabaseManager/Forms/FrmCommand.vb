
Public Class FrmCommand

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
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

            If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then

                If DB_AC.Script_execute(txtCommand.Text, txtStatus.Text) Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                    If Me.Modal = True Then
                        Me.Close()
                        Me.Dispose()
                        Exit Sub
                    End If
                End If
            ElseIf clsGlobal.type_database = DATABASE_TYPE.FIREBIRD Then

                If DB_FB.Script_execute(txtCommand.Text, txtStatus.Text) Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK

                    If Me.Modal = True Then
                        Me.Close()
                        Me.Dispose()
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("Execution has not been implemented for the current database!", vbInformation, "Attention")
            End If

        Catch ex As Exception
            txtStatus.Text = ex.Message
        End Try

        Me.DialogResult = Windows.Forms.DialogResult.None

    End Sub

End Class
