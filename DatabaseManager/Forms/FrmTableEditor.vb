Public Class FrmTableEditor
    Public table As String

    Private Sub FrmTableEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Table [" & table & "]"

        'Grid.DataSource = DB_AC.ListFieldsByDS(table).Tables(0)
        clsComponentsLoad.LoadSchemaTable(table, EstructureGrid)
        Call BackgroundWorker1.RunWorkerAsync()
        'DataGridView1.DataSource = DB_AC.ListIndex(table).Tables(0)
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.Text = "Table [" & table & "]"

        clsComponentsLoad.LoadSchemaTable(table, EstructureGrid)

        If Not BackgroundWorker1.IsBusy Then
            Call BackgroundWorker1.RunWorkerAsync()
        Else
            MsgBox("The last query is still in progress", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim dt As New DataTable

        Try
            dt = clsComponentsLoad.LoadGrid(table)

            TableDataGrid.DataSource = dt
        Catch ex As Exception

        End Try

    End Sub
End Class