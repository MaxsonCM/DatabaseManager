<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("users", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tables", 1, 1, New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CallFunction", 2, 2)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Procedures", 2, 2, New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("search", 3, 3)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Views", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode5})
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateProcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScriptyExecuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblCaptionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersionDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel_Tables = New System.Windows.Forms.TableLayoutPanel()
        Me.TrvEstructure = New System.Windows.Forms.TreeView()
        Me.TrvContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteProcedureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListTreeView = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefresh = New System.Windows.Forms.ToolStripButton()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.TableLayoutPanel_Tables.SuspendLayout()
        Me.TrvContextMenuStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(67, 20)
        Me.FileMenu.Text = "&Database"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.OpenToolStripMenuItem.Text = "&Open or Connect Database"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(256, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateTableToolStripMenuItem, Me.CreateProcToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(39, 20)
        Me.EditMenu.Text = "&Edit"
        '
        'CreateTableToolStripMenuItem
        '
        Me.CreateTableToolStripMenuItem.Image = Global.DatabaseManager.My.Resources.Resources.plus_16
        Me.CreateTableToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CreateTableToolStripMenuItem.Name = "CreateTableToolStripMenuItem"
        Me.CreateTableToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CreateTableToolStripMenuItem.Text = "&Create Table"
        '
        'CreateProcToolStripMenuItem
        '
        Me.CreateProcToolStripMenuItem.Image = Global.DatabaseManager.My.Resources.Resources.plus_16
        Me.CreateProcToolStripMenuItem.Name = "CreateProcToolStripMenuItem"
        Me.CreateProcToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CreateProcToolStripMenuItem.Text = "Create Procedure"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScriptyExecuteToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(48, 20)
        Me.ToolsMenu.Text = "&Tools"
        '
        'ScriptyExecuteToolStripMenuItem
        '
        Me.ScriptyExecuteToolStripMenuItem.Name = "ScriptyExecuteToolStripMenuItem"
        Me.ScriptyExecuteToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ScriptyExecuteToolStripMenuItem.Text = "&Script Execution"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCaptionLabel, Me.lblVersionDB})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'lblCaptionLabel
        '
        Me.lblCaptionLabel.Name = "lblCaptionLabel"
        Me.lblCaptionLabel.Size = New System.Drawing.Size(55, 17)
        Me.lblCaptionLabel.Text = "DB Info.: "
        '
        'lblVersionDB
        '
        Me.lblVersionDB.Name = "lblVersionDB"
        Me.lblVersionDB.Size = New System.Drawing.Size(102, 17)
        Me.lblVersionDB.Text = "Open an database"
        '
        'TableLayoutPanel_Tables
        '
        Me.TableLayoutPanel_Tables.ColumnCount = 1
        Me.TableLayoutPanel_Tables.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel_Tables.Controls.Add(Me.TrvEstructure, 0, 1)
        Me.TableLayoutPanel_Tables.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel_Tables.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel_Tables.Location = New System.Drawing.Point(0, 24)
        Me.TableLayoutPanel_Tables.Name = "TableLayoutPanel_Tables"
        Me.TableLayoutPanel_Tables.RowCount = 2
        Me.TableLayoutPanel_Tables.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel_Tables.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel_Tables.Size = New System.Drawing.Size(146, 516)
        Me.TableLayoutPanel_Tables.TabIndex = 9
        '
        'TrvEstructure
        '
        Me.TrvEstructure.CheckBoxes = True
        Me.TrvEstructure.ContextMenuStrip = Me.TrvContextMenuStrip
        Me.TrvEstructure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrvEstructure.ImageIndex = 0
        Me.TrvEstructure.ImageList = Me.ImageListTreeView
        Me.TrvEstructure.Location = New System.Drawing.Point(3, 28)
        Me.TrvEstructure.Name = "TrvEstructure"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "users"
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "users"
        TreeNode2.ImageIndex = 1
        TreeNode2.Name = "Tables"
        TreeNode2.SelectedImageIndex = 1
        TreeNode2.Text = "Tables"
        TreeNode3.ImageIndex = 2
        TreeNode3.Name = "CallFunction"
        TreeNode3.SelectedImageIndex = 2
        TreeNode3.Text = "CallFunction"
        TreeNode4.ImageIndex = 2
        TreeNode4.Name = "Procedures"
        TreeNode4.SelectedImageIndex = 2
        TreeNode4.Text = "Procedures"
        TreeNode5.ImageIndex = 3
        TreeNode5.Name = "search"
        TreeNode5.SelectedImageIndex = 3
        TreeNode5.Text = "search"
        TreeNode6.ImageIndex = 3
        TreeNode6.Name = "Views"
        TreeNode6.SelectedImageIndex = 3
        TreeNode6.Text = "Views"
        Me.TrvEstructure.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode6})
        Me.TrvEstructure.SelectedImageIndex = 0
        Me.TrvEstructure.Size = New System.Drawing.Size(140, 485)
        Me.TrvEstructure.TabIndex = 12
        '
        'TrvContextMenuStrip
        '
        Me.TrvContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteTableToolStripMenuItem, Me.DeleteProcedureToolStripMenuItem})
        Me.TrvContextMenuStrip.Name = "TrvContextMenuStrip"
        Me.TrvContextMenuStrip.Size = New System.Drawing.Size(165, 48)
        '
        'DeleteTableToolStripMenuItem
        '
        Me.DeleteTableToolStripMenuItem.Image = Global.DatabaseManager.My.Resources.Resources.minus_16
        Me.DeleteTableToolStripMenuItem.Name = "DeleteTableToolStripMenuItem"
        Me.DeleteTableToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DeleteTableToolStripMenuItem.Text = "Delete Table"
        '
        'DeleteProcedureToolStripMenuItem
        '
        Me.DeleteProcedureToolStripMenuItem.Image = Global.DatabaseManager.My.Resources.Resources.minus_16
        Me.DeleteProcedureToolStripMenuItem.Name = "DeleteProcedureToolStripMenuItem"
        Me.DeleteProcedureToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DeleteProcedureToolStripMenuItem.Text = "Delete Procedure"
        '
        'ImageListTreeView
        '
        Me.ImageListTreeView.ImageStream = CType(resources.GetObject("ImageListTreeView.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListTreeView.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListTreeView.Images.SetKeyName(0, "blank_16.png")
        Me.ImageListTreeView.Images.SetKeyName(1, "table_16.png")
        Me.ImageListTreeView.Images.SetKeyName(2, "gears_16.png")
        Me.ImageListTreeView.Images.SetKeyName(3, "window_16.png")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.tsbRefresh})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(146, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.Image = CType(resources.GetObject("tsbOpen.Image"), System.Drawing.Image)
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbOpen.Text = "Open Database"
        '
        'tsbRefresh
        '
        Me.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefresh.Image = Global.DatabaseManager.My.Resources.Resources.Refresh_16
        Me.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Black
        Me.tsbRefresh.Name = "tsbRefresh"
        Me.tsbRefresh.Size = New System.Drawing.Size(23, 22)
        Me.tsbRefresh.Text = "Refresh List"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(146, 24)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 516)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.TableLayoutPanel_Tables)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FrmMenu"
        Me.Text = "Database Manager"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TableLayoutPanel_Tables.ResumeLayout(False)
        Me.TableLayoutPanel_Tables.PerformLayout()
        Me.TrvContextMenuStrip.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScriptyExecuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblCaptionLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableLayoutPanel_Tables As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbOpen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblVersionDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TrvEstructure As System.Windows.Forms.TreeView
    Friend WithEvents ImageListTreeView As System.Windows.Forms.ImageList
    Friend WithEvents CreateProcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrvContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteProcedureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
