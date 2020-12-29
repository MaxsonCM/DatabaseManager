Public Class FrmTableEditor
    Public table As String
    Dim ds As New DataSet

    Private Sub FrmTableEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Table [" & table & "]"

        clsComponentsLoad.LoadSchemaTable(table, EstructureGrid)
        clsComponentsLoad.LoadSchemaIndexs(table, TreeViewIndex)
        Call LoadRegisters()
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.Text = "Table [" & table & "]"

        clsComponentsLoad.LoadSchemaTable(table, EstructureGrid)
        clsComponentsLoad.LoadSchemaIndexs(table, TreeViewIndex)

        Call LoadRegisters()
    End Sub

    Private Sub LoadRegisters()

        If Not BackgroundWorker1.IsBusy Then

            TableDataGrid.Visible = False
            Application.DoEvents()
            Call BackgroundWorker1.RunWorkerAsync()

        Else
            MsgBox("The last query is still in progress", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            ds = clsComponentsLoad.LoadGrid(table)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try

            TableDataGrid.DataSource = ds.Tables(0)
            TableDataGrid.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDataGrid.Visible = True
    End Sub

    Private Sub FrmTableEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureLoad.Top = (TableDataGrid.Height - PictureLoad.Height) / 2
        PictureLoad.Left = (TableDataGrid.Width - PictureLoad.Width) / 2
    End Sub

End Class