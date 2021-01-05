<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCommand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCommand))
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabControlCommand = New System.Windows.Forms.TabControl()
        Me.TabPageCommand = New System.Windows.Forms.TabPage()
        Me.TabPageResult = New System.Windows.Forms.TabPage()
        Me.GridResult = New System.Windows.Forms.DataGridView()
        Me.btnArquivo = New DatabaseManager.ccoFolderButton()
        Me.PanelStatus.SuspendLayout()
        Me.TabControlCommand.SuspendLayout()
        Me.TabPageCommand.SuspendLayout()
        Me.TabPageResult.SuspendLayout()
        CType(Me.GridResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCommand
        '
        Me.txtCommand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.Location = New System.Drawing.Point(3, 3)
        Me.txtCommand.Multiline = True
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(465, 197)
        Me.txtCommand.TabIndex = 3
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.BackColor = System.Drawing.Color.Transparent
        Me.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExecute.Image = Global.DatabaseManager.My.Resources.Resources.Play_32
        Me.btnExecute.Location = New System.Drawing.Point(474, 3)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(27, 197)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.BackColor = System.Drawing.SystemColors.Info
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(5, 3)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(502, 45)
        Me.txtStatus.TabIndex = 9
        '
        'PanelStatus
        '
        Me.PanelStatus.Controls.Add(Me.txtStatus)
        Me.PanelStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelStatus.Location = New System.Drawing.Point(0, 232)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(512, 54)
        Me.PanelStatus.TabIndex = 11
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 229)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(512, 3)
        Me.Splitter1.TabIndex = 12
        Me.Splitter1.TabStop = False
        '
        'TabControlCommand
        '
        Me.TabControlCommand.Controls.Add(Me.TabPageCommand)
        Me.TabControlCommand.Controls.Add(Me.TabPageResult)
        Me.TabControlCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlCommand.Location = New System.Drawing.Point(0, 0)
        Me.TabControlCommand.Name = "TabControlCommand"
        Me.TabControlCommand.SelectedIndex = 0
        Me.TabControlCommand.Size = New System.Drawing.Size(512, 229)
        Me.TabControlCommand.TabIndex = 13
        '
        'TabPageCommand
        '
        Me.TabPageCommand.BackColor = System.Drawing.Color.Transparent
        Me.TabPageCommand.Controls.Add(Me.txtCommand)
        Me.TabPageCommand.Controls.Add(Me.btnExecute)
        Me.TabPageCommand.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCommand.Name = "TabPageCommand"
        Me.TabPageCommand.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCommand.Size = New System.Drawing.Size(504, 203)
        Me.TabPageCommand.TabIndex = 0
        Me.TabPageCommand.Text = "Comand"
        '
        'TabPageResult
        '
        Me.TabPageResult.BackColor = System.Drawing.Color.Transparent
        Me.TabPageResult.Controls.Add(Me.GridResult)
        Me.TabPageResult.Location = New System.Drawing.Point(4, 22)
        Me.TabPageResult.Name = "TabPageResult"
        Me.TabPageResult.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageResult.Size = New System.Drawing.Size(453, 135)
        Me.TabPageResult.TabIndex = 1
        Me.TabPageResult.Text = "Result"
        '
        'GridResult
        '
        Me.GridResult.AllowUserToAddRows = False
        Me.GridResult.AllowUserToDeleteRows = False
        Me.GridResult.AllowUserToOrderColumns = True
        Me.GridResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridResult.Location = New System.Drawing.Point(1, 1)
        Me.GridResult.Name = "GridResult"
        Me.GridResult.ReadOnly = True
        Me.GridResult.RowHeadersVisible = False
        Me.GridResult.Size = New System.Drawing.Size(451, 133)
        Me.GridResult.TabIndex = 1
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArquivo.Image = CType(resources.GetObject("btnArquivo.Image"), System.Drawing.Image)
        Me.btnArquivo.Location = New System.Drawing.Point(571, 3)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.PUAuxControl = Nothing
        Me.btnArquivo.PUDataType = DatabaseManager.TYPE_FOLDER.FOLDER_FILE
        Me.btnArquivo.PUFilterType = DatabaseManager.TYPE_FILTER_FILE.ACCESS
        Me.btnArquivo.Size = New System.Drawing.Size(26, 21)
        Me.btnArquivo.TabIndex = 2
        Me.btnArquivo.UseVisualStyleBackColor = True
        '
        'FrmCommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(512, 286)
        Me.Controls.Add(Me.TabControlCommand)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.PanelStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(280, 220)
        Me.Name = "FrmCommand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Execution of SQL commands"
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        Me.TabControlCommand.ResumeLayout(False)
        Me.TabPageCommand.ResumeLayout(False)
        Me.TabPageCommand.PerformLayout()
        Me.TabPageResult.ResumeLayout(False)
        CType(Me.GridResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArquivo As DatabaseManager.ccoFolderButton
    Friend WithEvents txtCommand As System.Windows.Forms.TextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents PanelStatus As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TabControlCommand As System.Windows.Forms.TabControl
    Friend WithEvents TabPageCommand As System.Windows.Forms.TabPage
    Friend WithEvents TabPageResult As System.Windows.Forms.TabPage
    Friend WithEvents GridResult As System.Windows.Forms.DataGridView

End Class
