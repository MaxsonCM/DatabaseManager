﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTableEditor
    Inherits System.Windows.Forms.Form
	
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTableEditor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("id", 6, 6)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PrimaryKey", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("id_name", 6, 6)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ForenigKey", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Name", 6, 6)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Birthday", 6, 6)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UniqueKey", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Name", 6, 6)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Index", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Indexes", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode7, TreeNode9})
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPageEstructure = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanelEstructure = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStripEstructure = New System.Windows.Forms.ToolStrip()
        Me.tsbSalve = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelSeparator = New System.Windows.Forms.ToolStripLabel()
        Me.tsbAddField = New System.Windows.Forms.ToolStripButton()
        Me.tsbRemoveField = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditField = New System.Windows.Forms.ToolStripButton()
        Me.PanelEstructureView = New System.Windows.Forms.Panel()
        Me.SplitterEstructure = New System.Windows.Forms.Splitter()
        Me.EstructureGrid = New System.Windows.Forms.DataGridView()
        Me.key = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Character_Lenght = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numeric_Scale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEGMENT_LENGTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelIndexes = New System.Windows.Forms.Panel()
        Me.TreeViewIndex = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageData = New System.Windows.Forms.TabPage()
        Me.TableDataGrid = New System.Windows.Forms.DataGridView()
        Me.SplitterData = New System.Windows.Forms.Splitter()
        Me.PanelDataFilters = New System.Windows.Forms.Panel()
        Me.PanelWhereClause = New System.Windows.Forms.Panel()
        Me.TxtWhereClause = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitterFilter = New System.Windows.Forms.Splitter()
        Me.FilterDataGrid = New System.Windows.Forms.DataGridView()
        Me.Editable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clause = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AND_OR = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ToolStripFilters = New System.Windows.Forms.ToolStrip()
        Me.TsbAddFilter = New System.Windows.Forms.ToolStripButton()
        Me.TsbRemoveFilter = New System.Windows.Forms.ToolStripButton()
        Me.TsbSearch = New System.Windows.Forms.ToolStripButton()
        Me.PictureLoad = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorkerSearch = New System.ComponentModel.BackgroundWorker()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPageEstructure.SuspendLayout()
        Me.TableLayoutPanelEstructure.SuspendLayout()
        Me.ToolStripEstructure.SuspendLayout()
        Me.PanelEstructureView.SuspendLayout()
        CType(Me.EstructureGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIndexes.SuspendLayout()
        Me.TabPageData.SuspendLayout()
        CType(Me.TableDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDataFilters.SuspendLayout()
        Me.PanelWhereClause.SuspendLayout()
        CType(Me.FilterDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripFilters.SuspendLayout()
        CType(Me.PictureLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPageEstructure)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageData)
        Me.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(778, 432)
        Me.TabControlPrincipal.TabIndex = 0
        '
        'TabPageEstructure
        '
        Me.TabPageEstructure.BackColor = System.Drawing.Color.Transparent
        Me.TabPageEstructure.Controls.Add(Me.TableLayoutPanelEstructure)
        Me.TabPageEstructure.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEstructure.Name = "TabPageEstructure"
        Me.TabPageEstructure.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEstructure.Size = New System.Drawing.Size(770, 406)
        Me.TabPageEstructure.TabIndex = 0
        Me.TabPageEstructure.Text = "Estructure"
        '
        'TableLayoutPanelEstructure
        '
        Me.TableLayoutPanelEstructure.ColumnCount = 1
        Me.TableLayoutPanelEstructure.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelEstructure.Controls.Add(Me.ToolStripEstructure, 0, 0)
        Me.TableLayoutPanelEstructure.Controls.Add(Me.PanelEstructureView, 0, 1)
        Me.TableLayoutPanelEstructure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelEstructure.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanelEstructure.Name = "TableLayoutPanelEstructure"
        Me.TableLayoutPanelEstructure.RowCount = 2
        Me.TableLayoutPanelEstructure.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanelEstructure.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelEstructure.Size = New System.Drawing.Size(764, 400)
        Me.TableLayoutPanelEstructure.TabIndex = 3
        '
        'ToolStripEstructure
        '
        Me.ToolStripEstructure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripEstructure.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalve, Me.ToolStripLabel3, Me.tsbRefresh, Me.ToolStripLabelSeparator, Me.tsbAddField, Me.tsbRemoveField, Me.tsbEditField})
        Me.ToolStripEstructure.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripEstructure.Name = "ToolStripEstructure"
        Me.ToolStripEstructure.Size = New System.Drawing.Size(764, 25)
        Me.ToolStripEstructure.TabIndex = 8
        Me.ToolStripEstructure.Text = "ToolStrip1"
        '
        'tsbSalve
        '
        Me.tsbSalve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalve.Image = CType(resources.GetObject("tsbSalve.Image"), System.Drawing.Image)
        Me.tsbSalve.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsbSalve.Name = "tsbSalve"
        Me.tsbSalve.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalve.Text = "Save"
        Me.tsbSalve.Visible = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.AutoSize = False
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripLabel3.Visible = False
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefresh.Image = Global.DatabaseManager.My.Resources.Resources.Refresh_16
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(23, 22)
        Me.tsbRefresh.Text = "Refresh data"
        '
        'ToolStripLabelSeparator
        '
        Me.ToolStripLabelSeparator.AutoSize = False
        Me.ToolStripLabelSeparator.Name = "ToolStripLabelSeparator"
        Me.ToolStripLabelSeparator.Size = New System.Drawing.Size(23, 22)
        '
        'tsbAddField
        '
        Me.tsbAddField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAddField.Image = Global.DatabaseManager.My.Resources.Resources.plus_16
        Me.tsbAddField.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAddField.Name = "tsbAddField"
        Me.tsbAddField.Size = New System.Drawing.Size(23, 22)
        Me.tsbAddField.Text = "Add field"
        '
        'tsbRemoveField
        '
        Me.tsbRemoveField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRemoveField.Enabled = False
        Me.tsbRemoveField.Image = Global.DatabaseManager.My.Resources.Resources.minus_16
        Me.tsbRemoveField.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRemoveField.Name = "tsbRemoveField"
        Me.tsbRemoveField.Size = New System.Drawing.Size(23, 22)
        Me.tsbRemoveField.Text = "Remove field"
        '
        'tsbEditField
        '
        Me.tsbEditField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEditField.Enabled = False
        Me.tsbEditField.Image = Global.DatabaseManager.My.Resources.Resources.edit_16
        Me.tsbEditField.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditField.Name = "tsbEditField"
        Me.tsbEditField.Size = New System.Drawing.Size(23, 22)
        Me.tsbEditField.Text = "Edit field"
        '
        'PanelEstructureView
        '
        Me.PanelEstructureView.Controls.Add(Me.SplitterEstructure)
        Me.PanelEstructureView.Controls.Add(Me.EstructureGrid)
        Me.PanelEstructureView.Controls.Add(Me.PanelIndexes)
        Me.PanelEstructureView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEstructureView.Location = New System.Drawing.Point(0, 25)
        Me.PanelEstructureView.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelEstructureView.Name = "PanelEstructureView"
        Me.PanelEstructureView.Padding = New System.Windows.Forms.Padding(3)
        Me.PanelEstructureView.Size = New System.Drawing.Size(764, 375)
        Me.PanelEstructureView.TabIndex = 0
        '
        'SplitterEstructure
        '
        Me.SplitterEstructure.Location = New System.Drawing.Point(135, 3)
        Me.SplitterEstructure.Name = "SplitterEstructure"
        Me.SplitterEstructure.Size = New System.Drawing.Size(4, 369)
        Me.SplitterEstructure.TabIndex = 3
        Me.SplitterEstructure.TabStop = False
        '
        'EstructureGrid
        '
        Me.EstructureGrid.AllowUserToAddRows = False
        Me.EstructureGrid.AllowUserToDeleteRows = False
        Me.EstructureGrid.AllowUserToResizeRows = False
        Me.EstructureGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EstructureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstructureGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.key, Me.Position, Me.Column_Name, Me.Data_Type, Me.Character_Lenght, Me.Precision, Me.Numeric_Scale, Me.Description, Me.SEGMENT_LENGTH})
        Me.EstructureGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EstructureGrid.Location = New System.Drawing.Point(135, 3)
        Me.EstructureGrid.Name = "EstructureGrid"
        Me.EstructureGrid.ReadOnly = True
        Me.EstructureGrid.RowHeadersVisible = False
        Me.EstructureGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EstructureGrid.ShowCellErrors = False
        Me.EstructureGrid.ShowEditingIcon = False
        Me.EstructureGrid.ShowRowErrors = False
        Me.EstructureGrid.Size = New System.Drawing.Size(626, 369)
        Me.EstructureGrid.TabIndex = 0
        '
        'key
        '
        Me.key.DataPropertyName = "key"
        Me.key.HeaderText = "key"
        Me.key.Name = "key"
        Me.key.ReadOnly = True
        Me.key.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.key.Width = 30
        '
        'Position
        '
        Me.Position.DataPropertyName = "Position"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Position.DefaultCellStyle = DataGridViewCellStyle1
        Me.Position.HeaderText = "Position"
        Me.Position.MaxInputLength = 6
        Me.Position.Name = "Position"
        Me.Position.ReadOnly = True
        Me.Position.Width = 60
        '
        'Column_Name
        '
        Me.Column_Name.DataPropertyName = "Column Name"
        Me.Column_Name.HeaderText = "Column Name"
        Me.Column_Name.Name = "Column_Name"
        Me.Column_Name.ReadOnly = True
        '
        'Data_Type
        '
        Me.Data_Type.DataPropertyName = "Data Type"
        Me.Data_Type.HeaderText = "Data Type"
        Me.Data_Type.Name = "Data_Type"
        Me.Data_Type.ReadOnly = True
        '
        'Character_Lenght
        '
        Me.Character_Lenght.DataPropertyName = "Character Lenght"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Character_Lenght.DefaultCellStyle = DataGridViewCellStyle2
        Me.Character_Lenght.HeaderText = "Character Lenght"
        Me.Character_Lenght.MaxInputLength = 4
        Me.Character_Lenght.Name = "Character_Lenght"
        Me.Character_Lenght.ReadOnly = True
        Me.Character_Lenght.Width = 115
        '
        'Precision
        '
        Me.Precision.DataPropertyName = "Precision"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Precision.DefaultCellStyle = DataGridViewCellStyle3
        Me.Precision.HeaderText = "Precision"
        Me.Precision.MaxInputLength = 3
        Me.Precision.Name = "Precision"
        Me.Precision.ReadOnly = True
        Me.Precision.Width = 60
        '
        'Numeric_Scale
        '
        Me.Numeric_Scale.DataPropertyName = "Scale"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Numeric_Scale.DefaultCellStyle = DataGridViewCellStyle4
        Me.Numeric_Scale.HeaderText = "Scale"
        Me.Numeric_Scale.MaxInputLength = 3
        Me.Numeric_Scale.Name = "Numeric_Scale"
        Me.Numeric_Scale.ReadOnly = True
        Me.Numeric_Scale.Width = 40
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Description.DefaultCellStyle = DataGridViewCellStyle5
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'SEGMENT_LENGTH
        '
        Me.SEGMENT_LENGTH.DataPropertyName = "SEGMENT_LENGTH"
        Me.SEGMENT_LENGTH.HeaderText = "Segment Length"
        Me.SEGMENT_LENGTH.Name = "SEGMENT_LENGTH"
        Me.SEGMENT_LENGTH.ReadOnly = True
        Me.SEGMENT_LENGTH.Width = 110
        '
        'PanelIndexes
        '
        Me.PanelIndexes.Controls.Add(Me.TreeViewIndex)
        Me.PanelIndexes.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIndexes.Location = New System.Drawing.Point(3, 3)
        Me.PanelIndexes.Name = "PanelIndexes"
        Me.PanelIndexes.Size = New System.Drawing.Size(132, 369)
        Me.PanelIndexes.TabIndex = 1
        '
        'TreeViewIndex
        '
        Me.TreeViewIndex.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewIndex.FullRowSelect = True
        Me.TreeViewIndex.ImageIndex = 0
        Me.TreeViewIndex.ImageList = Me.ImageList1
        Me.TreeViewIndex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TreeViewIndex.Location = New System.Drawing.Point(0, 0)
        Me.TreeViewIndex.Name = "TreeViewIndex"
        TreeNode1.ImageIndex = 6
        TreeNode1.Name = "id"
        TreeNode1.SelectedImageIndex = 6
        TreeNode1.Text = "id"
        TreeNode2.ImageIndex = 5
        TreeNode2.Name = "PrimaryKey"
        TreeNode2.SelectedImageIndex = 5
        TreeNode2.Text = "PrimaryKey"
        TreeNode3.ImageIndex = 6
        TreeNode3.Name = "id_name"
        TreeNode3.SelectedImageIndex = 6
        TreeNode3.Text = "id_name"
        TreeNode4.ImageIndex = 4
        TreeNode4.Name = "ForenigKey"
        TreeNode4.SelectedImageIndex = 4
        TreeNode4.Text = "ForenigKey"
        TreeNode5.ImageIndex = 6
        TreeNode5.Name = "Name"
        TreeNode5.SelectedImageIndex = 6
        TreeNode5.Text = "Name"
        TreeNode6.ImageIndex = 6
        TreeNode6.Name = "Birthday"
        TreeNode6.SelectedImageIndex = 6
        TreeNode6.Text = "Birthday"
        TreeNode7.ImageIndex = 2
        TreeNode7.Name = "UniqueKey"
        TreeNode7.SelectedImageIndex = 2
        TreeNode7.Text = "UniqueKey"
        TreeNode8.ImageIndex = 6
        TreeNode8.Name = "Name"
        TreeNode8.SelectedImageIndex = 6
        TreeNode8.Text = "Name"
        TreeNode9.ImageIndex = 3
        TreeNode9.Name = "Index"
        TreeNode9.SelectedImageIndex = 3
        TreeNode9.Text = "Index"
        TreeNode10.ImageIndex = 1
        TreeNode10.Name = "Indexes"
        TreeNode10.SelectedImageIndex = 1
        TreeNode10.Text = "Indexes"
        Me.TreeViewIndex.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode10})
        Me.TreeViewIndex.SelectedImageIndex = 0
        Me.TreeViewIndex.Size = New System.Drawing.Size(132, 369)
        Me.TreeViewIndex.StateImageList = Me.ImageList1
        Me.TreeViewIndex.TabIndex = 3
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "blank_16.png")
        Me.ImageList1.Images.SetKeyName(1, "Key_16.png")
        Me.ImageList1.Images.SetKeyName(2, "U_16.png")
        Me.ImageList1.Images.SetKeyName(3, "I_16.png")
        Me.ImageList1.Images.SetKeyName(4, "F_16.png")
        Me.ImageList1.Images.SetKeyName(5, "P_16.png")
        Me.ImageList1.Images.SetKeyName(6, "_16.png")
        '
        'TabPageData
        '
        Me.TabPageData.BackColor = System.Drawing.Color.Transparent
        Me.TabPageData.Controls.Add(Me.TableDataGrid)
        Me.TabPageData.Controls.Add(Me.SplitterData)
        Me.TabPageData.Controls.Add(Me.PanelDataFilters)
        Me.TabPageData.Controls.Add(Me.PictureLoad)
        Me.TabPageData.Location = New System.Drawing.Point(4, 22)
        Me.TabPageData.Name = "TabPageData"
        Me.TabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageData.Size = New System.Drawing.Size(770, 406)
        Me.TabPageData.TabIndex = 1
        Me.TabPageData.Text = "Registres"
        '
        'TableDataGrid
        '
        Me.TableDataGrid.AllowUserToAddRows = False
        Me.TableDataGrid.AllowUserToDeleteRows = False
        Me.TableDataGrid.AllowUserToResizeRows = False
        Me.TableDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableDataGrid.Location = New System.Drawing.Point(3, 3)
        Me.TableDataGrid.Name = "TableDataGrid"
        Me.TableDataGrid.RowHeadersVisible = False
        Me.TableDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.TableDataGrid.ShowCellErrors = False
        Me.TableDataGrid.ShowEditingIcon = False
        Me.TableDataGrid.ShowRowErrors = False
        Me.TableDataGrid.Size = New System.Drawing.Size(764, 294)
        Me.TableDataGrid.TabIndex = 1
        '
        'SplitterData
        '
        Me.SplitterData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitterData.Location = New System.Drawing.Point(3, 297)
        Me.SplitterData.Name = "SplitterData"
        Me.SplitterData.Size = New System.Drawing.Size(764, 5)
        Me.SplitterData.TabIndex = 3
        Me.SplitterData.TabStop = False
        '
        'PanelDataFilters
        '
        Me.PanelDataFilters.Controls.Add(Me.PanelWhereClause)
        Me.PanelDataFilters.Controls.Add(Me.SplitterFilter)
        Me.PanelDataFilters.Controls.Add(Me.FilterDataGrid)
        Me.PanelDataFilters.Controls.Add(Me.ToolStripFilters)
        Me.PanelDataFilters.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelDataFilters.Location = New System.Drawing.Point(3, 302)
        Me.PanelDataFilters.Name = "PanelDataFilters"
        Me.PanelDataFilters.Size = New System.Drawing.Size(764, 101)
        Me.PanelDataFilters.TabIndex = 4
        '
        'PanelWhereClause
        '
        Me.PanelWhereClause.Controls.Add(Me.TxtWhereClause)
        Me.PanelWhereClause.Controls.Add(Me.Label1)
        Me.PanelWhereClause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWhereClause.Location = New System.Drawing.Point(429, 25)
        Me.PanelWhereClause.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelWhereClause.Name = "PanelWhereClause"
        Me.PanelWhereClause.Size = New System.Drawing.Size(335, 76)
        Me.PanelWhereClause.TabIndex = 5
        '
        'TxtWhereClause
        '
        Me.TxtWhereClause.BackColor = System.Drawing.SystemColors.Info
        Me.TxtWhereClause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtWhereClause.Location = New System.Drawing.Point(0, 13)
        Me.TxtWhereClause.Multiline = True
        Me.TxtWhereClause.Name = "TxtWhereClause"
        Me.TxtWhereClause.ReadOnly = True
        Me.TxtWhereClause.Size = New System.Drawing.Size(335, 63)
        Me.TxtWhereClause.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Where Clause"
        '
        'SplitterFilter
        '
        Me.SplitterFilter.Location = New System.Drawing.Point(426, 25)
        Me.SplitterFilter.Name = "SplitterFilter"
        Me.SplitterFilter.Size = New System.Drawing.Size(3, 76)
        Me.SplitterFilter.TabIndex = 4
        Me.SplitterFilter.TabStop = False
        '
        'FilterDataGrid
        '
        Me.FilterDataGrid.AllowUserToAddRows = False
        Me.FilterDataGrid.AllowUserToDeleteRows = False
        Me.FilterDataGrid.AllowUserToResizeRows = False
        Me.FilterDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FilterDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FilterDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Editable, Me.Active, Me.Column, Me.Clause, Me.Value, Me.AND_OR})
        Me.FilterDataGrid.Dock = System.Windows.Forms.DockStyle.Left
        Me.FilterDataGrid.Location = New System.Drawing.Point(0, 25)
        Me.FilterDataGrid.Name = "FilterDataGrid"
        Me.FilterDataGrid.RowHeadersVisible = False
        Me.FilterDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.FilterDataGrid.ShowCellErrors = False
        Me.FilterDataGrid.ShowEditingIcon = False
        Me.FilterDataGrid.ShowRowErrors = False
        Me.FilterDataGrid.Size = New System.Drawing.Size(426, 76)
        Me.FilterDataGrid.TabIndex = 2
        '
        'Editable
        '
        Me.Editable.HeaderText = "Editable"
        Me.Editable.Name = "Editable"
        Me.Editable.ReadOnly = True
        Me.Editable.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Editable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Editable.Visible = False
        '
        'Active
        '
        Me.Active.HeaderText = "A"
        Me.Active.Name = "Active"
        Me.Active.Width = 20
        '
        'Column
        '
        Me.Column.HeaderText = "Column"
        Me.Column.Name = "Column"
        Me.Column.ReadOnly = True
        '
        'Clause
        '
        Me.Clause.HeaderText = "Criteria"
        Me.Clause.Items.AddRange(New Object() {"", "=", "!=", ">", ">=", "<", "<=", "is null", "not is null", "starting with", "not starting with", "contains", "not contains"})
        Me.Clause.Name = "Clause"
        Me.Clause.Width = 70
        '
        'Value
        '
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        Me.Value.Width = 130
        '
        'AND_OR
        '
        Me.AND_OR.HeaderText = "AND/OR"
        Me.AND_OR.Items.AddRange(New Object() {"", "AND", "OR"})
        Me.AND_OR.Name = "AND_OR"
        Me.AND_OR.Width = 60
        '
        'ToolStripFilters
        '
        Me.ToolStripFilters.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsbAddFilter, Me.TsbRemoveFilter, Me.TsbSearch})
        Me.ToolStripFilters.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripFilters.Name = "ToolStripFilters"
        Me.ToolStripFilters.Size = New System.Drawing.Size(764, 25)
        Me.ToolStripFilters.TabIndex = 0
        Me.ToolStripFilters.Text = "ToolStrip2"
        '
        'TsbAddFilter
        '
        Me.TsbAddFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbAddFilter.Enabled = False
        Me.TsbAddFilter.Image = Global.DatabaseManager.My.Resources.Resources.plus_16
        Me.TsbAddFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbAddFilter.Name = "TsbAddFilter"
        Me.TsbAddFilter.Size = New System.Drawing.Size(23, 22)
        Me.TsbAddFilter.Text = "Add filter"
        '
        'TsbRemoveFilter
        '
        Me.TsbRemoveFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbRemoveFilter.Enabled = False
        Me.TsbRemoveFilter.Image = Global.DatabaseManager.My.Resources.Resources.minus_16
        Me.TsbRemoveFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbRemoveFilter.Name = "TsbRemoveFilter"
        Me.TsbRemoveFilter.Size = New System.Drawing.Size(23, 22)
        Me.TsbRemoveFilter.Text = "Remove Filter"
        '
        'TsbSearch
        '
        Me.TsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbSearch.Image = Global.DatabaseManager.My.Resources.Resources.Refresh_16
        Me.TsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbSearch.Name = "TsbSearch"
        Me.TsbSearch.Size = New System.Drawing.Size(23, 22)
        Me.TsbSearch.Text = "Search"
        '
        'PictureLoad
        '
        Me.PictureLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureLoad.Image = Global.DatabaseManager.My.Resources.Resources.Loading_64
        Me.PictureLoad.Location = New System.Drawing.Point(315, 78)
        Me.PictureLoad.Name = "PictureLoad"
        Me.PictureLoad.Size = New System.Drawing.Size(64, 64)
        Me.PictureLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureLoad.TabIndex = 2
        Me.PictureLoad.TabStop = False
        '
        'BackgroundWorkerSearch
        '
        Me.BackgroundWorkerSearch.WorkerReportsProgress = True
        Me.BackgroundWorkerSearch.WorkerSupportsCancellation = True
        '
        'FrmTableEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(778, 432)
        Me.Controls.Add(Me.TabControlPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "FrmTableEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table: "
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPageEstructure.ResumeLayout(False)
        Me.TableLayoutPanelEstructure.ResumeLayout(False)
        Me.TableLayoutPanelEstructure.PerformLayout()
        Me.ToolStripEstructure.ResumeLayout(False)
        Me.ToolStripEstructure.PerformLayout()
        Me.PanelEstructureView.ResumeLayout(False)
        CType(Me.EstructureGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIndexes.ResumeLayout(False)
        Me.TabPageData.ResumeLayout(False)
        Me.TabPageData.PerformLayout()
        CType(Me.TableDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDataFilters.ResumeLayout(False)
        Me.PanelDataFilters.PerformLayout()
        Me.PanelWhereClause.ResumeLayout(False)
        Me.PanelWhereClause.PerformLayout()
        CType(Me.FilterDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripFilters.ResumeLayout(False)
        Me.ToolStripFilters.PerformLayout()
        CType(Me.PictureLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents TabPageEstructure As System.Windows.Forms.TabPage
    Friend WithEvents EstructureGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageData As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripEstructure As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalve As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents BackgroundWorkerSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureLoad As System.Windows.Forms.PictureBox
    Friend WithEvents PanelIndexes As System.Windows.Forms.Panel
    Friend WithEvents TreeViewIndex As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents key As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Character_Lenght As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numeric_Scale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEGMENT_LENGTH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabelSeparator As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TableLayoutPanelEstructure As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanelEstructureView As System.Windows.Forms.Panel
    Friend WithEvents SplitterEstructure As System.Windows.Forms.Splitter
    Friend WithEvents PanelDataFilters As System.Windows.Forms.Panel
    Friend WithEvents SplitterData As System.Windows.Forms.Splitter
    Friend WithEvents tsbAddField As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripFilters As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitterFilter As System.Windows.Forms.Splitter
    Friend WithEvents TxtWhereClause As System.Windows.Forms.TextBox
    Friend WithEvents FilterDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TsbAddFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbRemoveFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelWhereClause As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TsbSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRemoveField As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditField As System.Windows.Forms.ToolStripButton
    Friend WithEvents Editable As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Active As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clause As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AND_OR As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
