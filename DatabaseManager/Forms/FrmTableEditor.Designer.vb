<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("id", 6, 6)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PrimaryKey", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("id_name", 6, 6)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ForenigKey", 4, 4, New System.Windows.Forms.TreeNode() {TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Name", 6, 6)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Birthday", 6, 6)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UniqueKey", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Name", 6, 6)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Index", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Indexes", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode14, TreeNode17, TreeNode19})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTableEditor))
        Me.PanelDetails = New System.Windows.Forms.Panel()
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPageEstructure = New System.Windows.Forms.TabPage()
        Me.EstructureGrid = New System.Windows.Forms.DataGridView()
        Me.key = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Character_Lenght = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numeric_Scale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitterEstructure = New System.Windows.Forms.Splitter()
        Me.PanelIndexes = New System.Windows.Forms.Panel()
        Me.TreeViewIndex = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPageData = New System.Windows.Forms.TabPage()
        Me.TableDataGrid = New System.Windows.Forms.DataGridView()
        Me.PictureLoad = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbSalve = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PanelDetails.SuspendLayout()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPageEstructure.SuspendLayout()
        CType(Me.EstructureGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIndexes.SuspendLayout()
        Me.TabPageData.SuspendLayout()
        CType(Me.TableDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDetails
        '
        Me.PanelDetails.Controls.Add(Me.TabControlPrincipal)
        Me.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetails.Location = New System.Drawing.Point(0, 25)
        Me.PanelDetails.Name = "PanelDetails"
        Me.PanelDetails.Size = New System.Drawing.Size(792, 400)
        Me.PanelDetails.TabIndex = 1
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPageEstructure)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageData)
        Me.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(792, 400)
        Me.TabControlPrincipal.TabIndex = 0
        '
        'TabPageEstructure
        '
        Me.TabPageEstructure.Controls.Add(Me.EstructureGrid)
        Me.TabPageEstructure.Controls.Add(Me.SplitterEstructure)
        Me.TabPageEstructure.Controls.Add(Me.PanelIndexes)
        Me.TabPageEstructure.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEstructure.Name = "TabPageEstructure"
        Me.TabPageEstructure.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEstructure.Size = New System.Drawing.Size(784, 374)
        Me.TabPageEstructure.TabIndex = 0
        Me.TabPageEstructure.Text = "Estructure"
        Me.TabPageEstructure.UseVisualStyleBackColor = True
        '
        'EstructureGrid
        '
        Me.EstructureGrid.AllowUserToAddRows = False
        Me.EstructureGrid.AllowUserToDeleteRows = False
        Me.EstructureGrid.AllowUserToResizeRows = False
        Me.EstructureGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EstructureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstructureGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.key, Me.Position, Me.Column_Name, Me.Data_Type, Me.Character_Lenght, Me.Precision, Me.Numeric_Scale, Me.Description})
        Me.EstructureGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EstructureGrid.Location = New System.Drawing.Point(150, 3)
        Me.EstructureGrid.Name = "EstructureGrid"
        Me.EstructureGrid.RowHeadersVisible = False
        Me.EstructureGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.EstructureGrid.ShowCellErrors = False
        Me.EstructureGrid.ShowEditingIcon = False
        Me.EstructureGrid.ShowRowErrors = False
        Me.EstructureGrid.Size = New System.Drawing.Size(631, 368)
        Me.EstructureGrid.TabIndex = 0
        '
        'key
        '
        Me.key.DataPropertyName = "key"
        Me.key.HeaderText = "key"
        Me.key.Name = "key"
        Me.key.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.key.Width = 30
        '
        'Position
        '
        Me.Position.DataPropertyName = "Position"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Position.DefaultCellStyle = DataGridViewCellStyle6
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
        '
        'Data_Type
        '
        Me.Data_Type.DataPropertyName = "Data Type"
        Me.Data_Type.HeaderText = "Data Type"
        Me.Data_Type.Name = "Data_Type"
        '
        'Character_Lenght
        '
        Me.Character_Lenght.DataPropertyName = "Character Lenght"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Character_Lenght.DefaultCellStyle = DataGridViewCellStyle7
        Me.Character_Lenght.HeaderText = "Character Lenght"
        Me.Character_Lenght.MaxInputLength = 4
        Me.Character_Lenght.Name = "Character_Lenght"
        Me.Character_Lenght.Width = 115
        '
        'Precision
        '
        Me.Precision.DataPropertyName = "Precision"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Precision.DefaultCellStyle = DataGridViewCellStyle8
        Me.Precision.HeaderText = "Precision"
        Me.Precision.MaxInputLength = 3
        Me.Precision.Name = "Precision"
        Me.Precision.Width = 60
        '
        'Numeric_Scale
        '
        Me.Numeric_Scale.DataPropertyName = "Scale"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Numeric_Scale.DefaultCellStyle = DataGridViewCellStyle9
        Me.Numeric_Scale.HeaderText = "Scale"
        Me.Numeric_Scale.MaxInputLength = 3
        Me.Numeric_Scale.Name = "Numeric_Scale"
        Me.Numeric_Scale.Width = 40
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Description.DefaultCellStyle = DataGridViewCellStyle10
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'SplitterEstructure
        '
        Me.SplitterEstructure.Location = New System.Drawing.Point(146, 3)
        Me.SplitterEstructure.Name = "SplitterEstructure"
        Me.SplitterEstructure.Size = New System.Drawing.Size(4, 368)
        Me.SplitterEstructure.TabIndex = 2
        Me.SplitterEstructure.TabStop = False
        '
        'PanelIndexes
        '
        Me.PanelIndexes.Controls.Add(Me.TreeViewIndex)
        Me.PanelIndexes.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIndexes.Location = New System.Drawing.Point(3, 3)
        Me.PanelIndexes.Name = "PanelIndexes"
        Me.PanelIndexes.Size = New System.Drawing.Size(143, 368)
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
        TreeNode11.ImageIndex = 6
        TreeNode11.Name = "id"
        TreeNode11.SelectedImageIndex = 6
        TreeNode11.Text = "id"
        TreeNode12.ImageIndex = 5
        TreeNode12.Name = "PrimaryKey"
        TreeNode12.SelectedImageIndex = 5
        TreeNode12.Text = "PrimaryKey"
        TreeNode13.ImageIndex = 6
        TreeNode13.Name = "id_name"
        TreeNode13.SelectedImageIndex = 6
        TreeNode13.Text = "id_name"
        TreeNode14.ImageIndex = 4
        TreeNode14.Name = "ForenigKey"
        TreeNode14.SelectedImageIndex = 4
        TreeNode14.Text = "ForenigKey"
        TreeNode15.ImageIndex = 6
        TreeNode15.Name = "Name"
        TreeNode15.SelectedImageIndex = 6
        TreeNode15.Text = "Name"
        TreeNode16.ImageIndex = 6
        TreeNode16.Name = "Birthday"
        TreeNode16.SelectedImageIndex = 6
        TreeNode16.Text = "Birthday"
        TreeNode17.ImageIndex = 2
        TreeNode17.Name = "UniqueKey"
        TreeNode17.SelectedImageIndex = 2
        TreeNode17.Text = "UniqueKey"
        TreeNode18.ImageIndex = 6
        TreeNode18.Name = "Name"
        TreeNode18.SelectedImageIndex = 6
        TreeNode18.Text = "Name"
        TreeNode19.ImageIndex = 3
        TreeNode19.Name = "Index"
        TreeNode19.SelectedImageIndex = 3
        TreeNode19.Text = "Index"
        TreeNode20.ImageIndex = 1
        TreeNode20.Name = "Indexes"
        TreeNode20.SelectedImageIndex = 1
        TreeNode20.Text = "Indexes"
        Me.TreeViewIndex.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode20})
        Me.TreeViewIndex.SelectedImageIndex = 0
        Me.TreeViewIndex.Size = New System.Drawing.Size(143, 368)
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
        Me.TabPageData.Controls.Add(Me.TableDataGrid)
        Me.TabPageData.Controls.Add(Me.PictureLoad)
        Me.TabPageData.Location = New System.Drawing.Point(4, 22)
        Me.TabPageData.Name = "TabPageData"
        Me.TabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageData.Size = New System.Drawing.Size(784, 374)
        Me.TabPageData.TabIndex = 1
        Me.TabPageData.Text = "Registres"
        Me.TabPageData.UseVisualStyleBackColor = True
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
        Me.TableDataGrid.Size = New System.Drawing.Size(778, 368)
        Me.TableDataGrid.TabIndex = 1
        '
        'PictureLoad
        '
        Me.PictureLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureLoad.Image = Global.DatabaseManager.My.Resources.Resources.Loading_32
        Me.PictureLoad.Location = New System.Drawing.Point(319, 159)
        Me.PictureLoad.Name = "PictureLoad"
        Me.PictureLoad.Size = New System.Drawing.Size(33, 33)
        Me.PictureLoad.TabIndex = 2
        Me.PictureLoad.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalve, Me.tsbRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbSalve
        '
        Me.tsbSalve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalve.Image = CType(resources.GetObject("tsbSalve.Image"), System.Drawing.Image)
        Me.tsbSalve.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsbSalve.Name = "tsbSalve"
        Me.tsbSalve.Size = New System.Drawing.Size(23, 22)
        Me.tsbSalve.Text = "Save"
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
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.ToolStrip1)
        Me.PanelButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButton.Location = New System.Drawing.Point(0, 0)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(792, 25)
        Me.PanelButton.TabIndex = 0
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'FrmTableEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(792, 425)
        Me.Controls.Add(Me.PanelDetails)
        Me.Controls.Add(Me.PanelButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTableEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table: "
        Me.PanelDetails.ResumeLayout(False)
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPageEstructure.ResumeLayout(False)
        CType(Me.EstructureGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIndexes.ResumeLayout(False)
        Me.TabPageData.ResumeLayout(False)
        CType(Me.TableDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        Me.PanelButton.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelDetails As System.Windows.Forms.Panel
    Friend WithEvents TabControlPrincipal As System.Windows.Forms.TabControl
    Friend WithEvents TabPageEstructure As System.Windows.Forms.TabPage
    Friend WithEvents EstructureGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPageData As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalve As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelButton As System.Windows.Forms.Panel
    Friend WithEvents TableDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents key As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Position As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Character_Lenght As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Numeric_Scale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureLoad As System.Windows.Forms.PictureBox
    Friend WithEvents SplitterEstructure As System.Windows.Forms.Splitter
    Friend WithEvents PanelIndexes As System.Windows.Forms.Panel
    Friend WithEvents TreeViewIndex As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
End Class
