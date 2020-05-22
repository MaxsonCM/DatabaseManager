Public Class FrmTableEditor
    Public table As String

    Private Sub FrmTableEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Table [" & table & "]"

        Grid.DataSource = DB_AC.ListFields(table)
    End Sub
End Class