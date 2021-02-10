Imports System.ComponentModel

Public Class FrmTableEditor

    Public table As String
    Dim ds As New DataSet
    Dim where_clause, grid_selection As String

#Region "Form Control"


    Private Sub FrmTableEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Table [" & table & "]"
        'Dim new_row As String()
        'Dim last_row As DataGridViewRow

        where_clause = ""
        PanelDataFilters.Height = 24

        DB_Mediator.LoadSchemaTable(table, EstructureGrid)
        DB_Mediator.LoadSchemaIndexs(table, TreeViewIndex)

        FilterDataGrid.Rows.Clear()

        'For Each row As DataGridViewRow In EstructureGrid.Rows
        '    If Not row.IsNewRow Then
        '        new_row = New String() {False, True, row.Cells().Item(FindIndexColumn("Column Name", EstructureGrid)).Value, Nothing, Nothing, "AND"}
        '        FilterDataGrid.Rows.Add(new_row)
        '        last_row = FilterDataGrid.Rows.OfType(Of DataGridViewRow).Last()

        '        last_row.DefaultCellStyle.Font = New Font(FilterDataGrid.Font, FontStyle.Bold)
        '    End If
        'Next

        Call LoadRegisters()
        Call FrmTableEditor_Resize(sender, e)
    End Sub

    Private Sub FrmTableEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        PictureLoad.Top = (TableDataGrid.Height - PictureLoad.Height) / 2
        PictureLoad.Left = (TableDataGrid.Width - PictureLoad.Width) / 2
    End Sub

    Private Sub tsbRefresh_Click(sender As Object, e As EventArgs) Handles tsbRefresh.Click
        Me.Text = "Table [" & table & "]"

        DB_Mediator.LoadSchemaTable(table, EstructureGrid)
        DB_Mediator.LoadSchemaIndexs(table, TreeViewIndex)

        Call LoadRegisters()
    End Sub

#End Region

#Region "Functions Thread"

    Private Sub LoadRegisters()

        If Not BackgroundWorkerSearch.IsBusy Then
            If IsNothing(table) Then Exit Sub

            TableDataGrid.Visible = False
            Application.DoEvents()
            Call BackgroundWorkerSearch.RunWorkerAsync()

        Else
            MsgBox("The last query is still in progress", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub BackgroundWorkerSearch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSearch.DoWork
        Try
            If IsNothing(table) Then Exit Sub
            ds = DB_Mediator.LoadGrid(table, where_clause)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorkerSearch_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSearch.RunWorkerCompleted
        Try

            If IsNothing(ds) Then
                TableDataGrid.DataSource = Nothing
            Else
                TableDataGrid.DataSource = ds.Tables(0)
                TableDataGrid.ClearSelection()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        TableDataGrid.Visible = True
    End Sub

#End Region

    Private Function FindIndexColumn(ByVal header As String, ByVal grid As DataGridView) As Integer
        Dim index As Integer = -1

        For Each col In grid.Columns
            If col.HeaderText.ToString.ToUpper = header.ToUpper Then
                index = col.Index
            End If
        Next

        Return index
    End Function

#Region "Grid Estructure - Actions"

    Private Sub EstructureGrid_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles EstructureGrid.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub EstructureGrid_MouseClick(sender As Object, e As MouseEventArgs) Handles EstructureGrid.MouseClick
        If Not IsNothing(EstructureGrid.CurrentCell) Then
            tsbRemoveField.Enabled = True
            tsbEditField.Enabled = True
        Else
            tsbRemoveField.Enabled = False
            tsbEditField.Enabled = False
        End If
    End Sub

    Private Sub EstructureGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EstructureGrid.CellDoubleClick

        Call Open_field_editor()

    End Sub

    Private Sub tsbAddField_Click(sender As Object, e As EventArgs) Handles tsbAddField.Click
        Dim result As Windows.Forms.DialogResult
        Dim new_window As New FrmFieldEditor
        new_window.table = table
        new_window.field = ""
        result = new_window.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Call tsbRefresh_Click(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub tsbRemoveField_Click(sender As Object, e As EventArgs) Handles tsbRemoveField.Click
        If IsNothing(EstructureGrid.CurrentCell) Then
            tsbRemoveField.Enabled = False
            tsbEditField.Enabled = False
            Exit Sub
        End If

        Dim query, column As String
        column = EstructureGrid.CurrentRow.Cells("Column_Name").Value

        If MsgBox("Are you sure that you want to drop [" & column & "] field  ?", vbQuestion + vbYesNo, "Warning") = MsgBoxResult.Yes Then

            query = DB_Mediator.ScriptDropField(table, column)
            If DB_Mediator.Script_execute(query) Then
                Call tsbRefresh_Click(sender, e)
            End If

        End If

    End Sub

    Private Sub tsbEditField_Click(sender As Object, e As EventArgs) Handles tsbEditField.Click
        Call Open_field_editor()
    End Sub

    Private Sub Open_field_editor()
        Dim result As Windows.Forms.DialogResult

        If Not IsNothing(EstructureGrid.CurrentCell) Then

            Dim new_window As New FrmFieldEditor
            new_window.table = table
            new_window.field = EstructureGrid.CurrentRow.Cells("Column_Name").Value
            result = new_window.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                Call tsbRefresh_Click(Nothing, EventArgs.Empty)
            End If

        End If
    End Sub

#End Region

#Region "Grid - Data and filter - Actions"

    Private Sub makeWhereClause()
        Dim clause, query As String
        Dim old_field, field, value, criteria As String

        clause = ""
        query = ""
        For Each row As DataGridViewRow In FilterDataGrid.Rows

            If row.Cells().Item(FindIndexColumn("A", FilterDataGrid)).Value = True Then

                query += clause

                field = row.Cells().Item(FindIndexColumn("Column", FilterDataGrid)).Value
                criteria = row.Cells().Item(FindIndexColumn("Criteria", FilterDataGrid)).Value
                value = row.Cells().Item(FindIndexColumn("Value", FilterDataGrid)).Value

                query += DB_Mediator.Translate_criteria(field, criteria, value)
                clause = " " + row.Cells().Item(FindIndexColumn("AND/OR", FilterDataGrid)).Value + " "

                old_field = field

            End If

        Next

        TxtWhereClause.Text = query
        where_clause = query
    End Sub

    Private Sub TsbAddFilter_Click(sender As Object, e As EventArgs) Handles TsbAddFilter.Click
        Dim column_name, row_value As String
        Dim row_position As Long

        row_value = ""

        If grid_selection = TableDataGrid.Name Then

            column_name = TableDataGrid.Columns(TableDataGrid.CurrentCell.ColumnIndex).HeaderText()
            row_value = TableDataGrid.CurrentCell.Value

            Dim new_row = New String() {True, True, column_name, "=", row_value, "AND"}
            FilterDataGrid.Rows.Add(new_row)

        ElseIf grid_selection = FilterDataGrid.Name Then

            If IsNothing(FilterDataGrid.CurrentRow) Then Exit Sub

            row_position = FilterDataGrid.CurrentRow.Index
            If FilterDataGrid.Rows(row_position).Cells().Item(FindIndexColumn("Editable", FilterDataGrid)).Value = False Then

                Dim new_row = New String() {True, True, "", "=", Nothing, "AND"}
                FilterDataGrid.Rows.Add(new_row)

            Else

                Dim new_row = New String() {True, True, FilterDataGrid.Rows(row_position).Cells().Item(FindIndexColumn("Column", FilterDataGrid)).Value, "=", Nothing, "AND"}
                FilterDataGrid.Rows.Add(new_row)

            End If

        End If

        If PanelDataFilters.Height < 25 Then PanelDataFilters.Height = 100

        FilterDataGrid.Sort(FilterDataGrid.Columns(FindIndexColumn("Column", FilterDataGrid)), ListSortDirection.Ascending)

        Call makeWhereClause()
    End Sub

    Private Sub TsbRemoveFilter_Click(sender As Object, e As EventArgs) Handles TsbRemoveFilter.Click
        Dim row_position As Long

        If grid_selection = FilterDataGrid.Name And Not IsNothing(FilterDataGrid.CurrentRow) Then
            row_position = FilterDataGrid.CurrentRow.Index
            If FilterDataGrid.Rows(row_position).Cells().Item(FindIndexColumn("Editable", FilterDataGrid)).Value = True Then
                FilterDataGrid.Rows.RemoveAt(row_position)
            End If
        End If

        Call makeWhereClause()
    End Sub

    Private Sub TsbSearch_Click(sender As Object, e As EventArgs) Handles TsbSearch.Click
        Call LoadRegisters()
    End Sub

    Private Sub TableDataGrid_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles TableDataGrid.DataError
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TableDataGrid_GotFocus(sender As Object, e As EventArgs) Handles TableDataGrid.GotFocus

        grid_selection = TableDataGrid.Name

    End Sub

    Private Sub TableDataGrid_LostFocus(sender As Object, e As EventArgs) Handles TableDataGrid.LostFocus

        TsbAddFilter.Enabled = False
        TsbRemoveFilter.Enabled = False

    End Sub

    Private Sub TableDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableDataGrid.CellClick

        If Not IsNothing(TableDataGrid.CurrentCell) Then
            TsbAddFilter.Enabled = True
        Else
            TsbAddFilter.Enabled = False
        End If

    End Sub

    Private Sub FilterDataGrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles FilterDataGrid.CellValueChanged
        If e.RowIndex < 0 Then Exit Sub
        Call makeWhereClause()
        Call LoadRegisters()
    End Sub

    Private Sub FilterDataGrid_GotFocus(sender As Object, e As EventArgs) Handles FilterDataGrid.GotFocus
        grid_selection = FilterDataGrid.Name
    End Sub

    Private Sub FilterDataGrid_LostFocus(sender As Object, e As EventArgs) Handles FilterDataGrid.LostFocus
        TsbAddFilter.Enabled = False
        TsbRemoveFilter.Enabled = False
    End Sub

    Private Sub FilterDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FilterDataGrid.CellClick
        If Not IsNothing(FilterDataGrid.CurrentCell) Then
            TsbAddFilter.Enabled = True
            TsbRemoveFilter.Enabled = True
        Else
            TsbAddFilter.Enabled = False
            TsbRemoveFilter.Enabled = False
        End If
    End Sub

#End Region

End Class