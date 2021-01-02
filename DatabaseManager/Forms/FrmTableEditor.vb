Public Class FrmTableEditor
    Public table As String
    Dim ds As New DataSet

#Region "Form Control"

    Private Sub FrmTableEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Table [" & table & "]"
        TstTableName.Text = table

        PanelDataFilters.Height = 24

        clsComponentsLoad.LoadSchemaTable(table, EstructureGrid)
        clsComponentsLoad.LoadSchemaIndexs(table, TreeViewIndex)

        Call LoadRegisters()
    End Sub

    Private Sub FrmTableEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureLoad.Top = (TableDataGrid.Height - PictureLoad.Height) / 2
        PictureLoad.Left = (TableDataGrid.Width - PictureLoad.Width) / 2
    End Sub

#End Region

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.Text = "Table [" & table & "]"
        TstTableName.Text = table

        clsComponentsLoad.LoadSchemaTable(table, EstructureGrid)
        clsComponentsLoad.LoadSchemaIndexs(table, TreeViewIndex)

        Call LoadRegisters()
    End Sub

#Region "Functions Thread"

    Private Sub LoadRegisters()

        If Not BackgroundWorkerSearch.IsBusy Then

            TableDataGrid.Visible = False
            Application.DoEvents()
            Call BackgroundWorkerSearch.RunWorkerAsync()

        Else
            MsgBox("The last query is still in progress", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BackgroundWorkerSearch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSearch.DoWork
        Try

            ds = clsComponentsLoad.LoadGrid(table)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorkerSearch_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSearch.RunWorkerCompleted
        Try

            TableDataGrid.DataSource = ds.Tables(0)
            TableDataGrid.ClearSelection()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDataGrid.Visible = True
    End Sub

#End Region

    Private Shared Function ConfigureDataTableWhere() As DataTable
        Dim dt As DataTable
        Dim dc As DataColumn

        dt = New DataTable()

        dc = New DataColumn("A", Type.GetType("System.Boolean"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Column / Criteria", Type.GetType("System.String"))
        dt.Columns.Add(dc)
        dc = New DataColumn("Value", Type.GetType("System.String"))
        dt.Columns.Add(dc)
        'dc = New DataColumn("AND / OR", DataGridView.ComboBox)
        'dt.Columns.Add(dc)

        Return dt
    End Function

    Private Sub TableDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableDataGrid.CellClick
        'TsbAddFilter.Enabled = True
    End Sub
    
    Private Sub TsbAddFilter_Click(sender As Object, e As EventArgs) Handles TsbAddFilter.Click

    End Sub
End Class