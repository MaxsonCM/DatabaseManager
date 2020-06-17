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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("id")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PrimaryKey", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Name")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Birthday")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UniqueKey", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Name")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Index", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ForenigKey", 4, 4)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Index", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode5, TreeNode7, TreeNode8})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTableEditor))
        Me.PanelDetails = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.EstructureGrid = New System.Windows.Forms.DataGridView()
        Me.key = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Character_Lenght = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numeric_Scale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelIndexes = New System.Windows.Forms.Panel()
        Me.TreeViewIndex = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableDataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureLoad = New System.Windows.Forms.PictureBox()
        Me.tsbSalve = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PanelDetails.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.EstructureGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIndexes.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TableDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDetails
        '
        Me.PanelDetails.Controls.Add(Me.TabControl1)
        Me.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetails.Location = New System.Drawing.Point(0, 25)
        Me.PanelDetails.Name = "PanelDetails"
        Me.PanelDetails.Size = New System.Drawing.Size(792, 400)
        Me.PanelDetails.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(792, 400)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.EstructureGrid)
        Me.TabPage1.Controls.Add(Me.Splitter1)
        Me.TabPage1.Controls.Add(Me.PanelIndexes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(784, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estructure"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.EstructureGrid.Location = New System.Drawing.Point(149, 3)
        Me.EstructureGrid.Name = "EstructureGrid"
        Me.EstructureGrid.RowHeadersVisible = False
        Me.EstructureGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.EstructureGrid.ShowCellErrors = False
        Me.EstructureGrid.ShowEditingIcon = False
        Me.EstructureGrid.ShowRowErrors = False
        Me.EstructureGrid.Size = New System.Drawing.Size(632, 368)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Character_Lenght.DefaultCellStyle = DataGridViewCellStyle2
        Me.Character_Lenght.HeaderText = "Character Lenght"
        Me.Character_Lenght.MaxInputLength = 4
        Me.Character_Lenght.Name = "Character_Lenght"
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
        Me.Numeric_Scale.Width = 40
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Description.DefaultCellStyle = DataGridViewCellStyle5
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(146, 3)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 368)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
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
        TreeNode1.Name = "id"
        TreeNode1.Text = "id"
        TreeNode2.ImageIndex = 5
        TreeNode2.Name = "PrimaryKey"
        TreeNode2.SelectedImageIndex = 5
        TreeNode2.Text = "PrimaryKey"
        TreeNode3.Name = "Name"
        TreeNode3.Text = "Name"
        TreeNode4.Name = "Birthday"
        TreeNode4.Text = "Birthday"
        TreeNode5.ImageIndex = 2
        TreeNode5.Name = "UniqueKey"
        TreeNode5.SelectedImageIndex = 2
        TreeNode5.Text = "UniqueKey"
        TreeNode6.Name = "Name"
        TreeNode6.Text = "Name"
        TreeNode7.ImageIndex = 3
        TreeNode7.Name = "Index"
        TreeNode7.SelectedImageIndex = 3
        TreeNode7.Text = "Index"
        TreeNode8.ImageIndex = 4
        TreeNode8.Name = "ForenigKey"
        TreeNode8.SelectedImageIndex = 4
        TreeNode8.Text = "ForenigKey"
        TreeNode9.ImageIndex = 1
        TreeNode9.Name = "Index"
        TreeNode9.SelectedImageIndex = 1
        TreeNode9.Text = "Index"
        Me.TreeViewIndex.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode9})
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
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableDataGrid)
        Me.TabPage2.Controls.Add(Me.PictureLoad)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(784, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registres"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalve, Me.tsbRefresh, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(792, 25)
        Me.Panel1.TabIndex = 0
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "New Field"
        '
        'FrmTableEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(792, 425)
        Me.Controls.Add(Me.PanelDetails)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmTableEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Table: "
        Me.PanelDetails.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.EstructureGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIndexes.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TableDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelDetails As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents EstructureGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalve As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents PanelIndexes As System.Windows.Forms.Panel
    Friend WithEvents TreeViewIndex As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
End Class
