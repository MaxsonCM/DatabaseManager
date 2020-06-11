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
        Me.PanelCommand = New System.Windows.Forms.Panel()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.btnArquivo = New DatabaseManager.ccoBotaoPasta()
        Me.PanelCommand.SuspendLayout()
        Me.PanelStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCommand
        '
        Me.txtCommand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.Location = New System.Drawing.Point(5, 4)
        Me.txtCommand.Multiline = True
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(376, 176)
        Me.txtCommand.TabIndex = 3
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.BackColor = System.Drawing.Color.Transparent
        Me.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExecute.Image = Global.DatabaseManager.My.Resources.Resources.Play_32
        Me.btnExecute.Location = New System.Drawing.Point(386, 4)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(27, 176)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'PanelCommand
        '
        Me.PanelCommand.Controls.Add(Me.txtCommand)
        Me.PanelCommand.Controls.Add(Me.btnExecute)
        Me.PanelCommand.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCommand.Location = New System.Drawing.Point(0, 0)
        Me.PanelCommand.Name = "PanelCommand"
        Me.PanelCommand.Size = New System.Drawing.Size(416, 185)
        Me.PanelCommand.TabIndex = 8
        '
        'txtStatus
        '
        Me.txtStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStatus.BackColor = System.Drawing.SystemColors.Info
        Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStatus.Location = New System.Drawing.Point(5, 6)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(406, 48)
        Me.txtStatus.TabIndex = 9
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 185)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(416, 3)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'PanelStatus
        '
        Me.PanelStatus.Controls.Add(Me.txtStatus)
        Me.PanelStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelStatus.Location = New System.Drawing.Point(0, 188)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(416, 60)
        Me.PanelStatus.TabIndex = 11
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
        Me.ClientSize = New System.Drawing.Size(416, 248)
        Me.Controls.Add(Me.PanelStatus)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.PanelCommand)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(280, 220)
        Me.Name = "FrmCommand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Execution of SQL commands"
        Me.PanelCommand.ResumeLayout(False)
        Me.PanelCommand.PerformLayout()
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArquivo As DatabaseManager.ccoBotaoPasta
    Friend WithEvents txtCommand As System.Windows.Forms.TextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents PanelCommand As System.Windows.Forms.Panel
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents PanelStatus As System.Windows.Forms.Panel

End Class
