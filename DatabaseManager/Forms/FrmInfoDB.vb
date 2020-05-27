Public Class FrmInfoDB

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Len(txtSource.Text) = 0 Then
            MsgBox("Select a valid database file !", MsgBoxStyle.Information, "Select a database file")
            Exit Sub
        End If

        clsGlobal.localDataBase = txtSource.Text
        clsGlobal.passDataBase = txtPassword.Text

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class