Public Class FrmTableEditor
    Public table As String

    Private Sub FrmTableEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Table [" & table & "]"

        Grid.DataSource = DB_AC.ListFields(table).Tables(0)
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.Text = "Table [" & table & "]"
        Grid.DataSource = DB_AC.ListFields(table).Tables(0)
    End Sub
End Class