Public Class FrmInfoDB

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Len(txtDatabase.Text) = 0 Then
            MsgBox("Select a valid database file !", MsgBoxStyle.Information, "Select a database file")
            Exit Sub
        End If

        clsGlobal.sourceDataBase = TxtDataSource.Text
        clsGlobal.localDataBase = txtDatabase.Text
        clsGlobal.passDataBase = txtPassword.Text
        clsGlobal.userDataBase = TxtUser.Text
        clsGlobal.portDataBase = TxtPort.Text

        If clsGlobal.type_database = DATABASE_TYPE.ACCESS Then
            clsGlobal.sourceDataBase = ""
            clsGlobal.portDataBase = ""
        ElseIf clsGlobal.type_database = DATABASE_TYPE.NONE Then

        End If

        If Not DB_Mediator.test_connection() Then
            MsgBox("Could not connect to the database!", vbInformation)
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtDatabase_LostFocus(sender As Object, e As EventArgs) Handles txtDatabase.LostFocus
        If InStr(txtDatabase.Text.ToUpper, ".FDB", CompareMethod.Text) > 0 Or InStr(txtDatabase.Text.ToUpper, ".GDB", CompareMethod.Text) > 0 Then
            TxtPort.Text = 3050
            TxtUser.Text = "SYSDBA"
            txtPassword.Text = "masterkey"
            TxtDataSource.Text = "localhost"
            clsGlobal.type_database = DATABASE_TYPE.FIREBIRD
        ElseIf InStr(txtDatabase.Text.ToUpper, ".MDB", CompareMethod.Text) > 0 Or InStr(txtDatabase.Text.ToUpper, ".ACCDB", CompareMethod.Text) > 0 Then
            TxtPort.Text = ""
            TxtDataSource.Text = ""
            clsGlobal.type_database = DATABASE_TYPE.ACCESS
        Else
            clsGlobal.type_database = DATABASE_TYPE.NONE
        End If

        CmbDatabaseType.SelectedIndex = clsGlobal.type_database
    End Sub

    Private Sub CcoBotaoPasta1_Click(sender As Object, e As EventArgs) Handles CcoBotaoPasta1.Click
        Call txtDatabase_LostFocus(sender, e)
    End Sub

    Private Sub FrmInfoDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbDatabaseType.DataSource = System.Enum.GetValues(GetType(DATABASE_TYPE))
        CmbDatabaseType.TabIndex = 0
    End Sub
End Class