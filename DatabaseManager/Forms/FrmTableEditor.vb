Public Class FrmTableEditor
    Public table As String

    Private Sub FrmTableEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Table [" & table & "]"

        'Grid.DataSource = DB_AC.ListFieldsByDS(table).Tables(0)
        clsComponentsLoad.LoadSchemaTable(table, Grid)

        DataGridView1.DataSource = DB_AC.ListIndex(table).Tables(0)
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.Text = "Table [" & table & "]"

        clsComponentsLoad.LoadSchemaTable(table, Grid)
    End Sub
End Class