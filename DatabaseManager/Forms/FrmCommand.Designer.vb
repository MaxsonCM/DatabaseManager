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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnArquivo = New DatabaseManager.ccoBotaoPasta()
        Me.SuspendLayout()
        '
        'txtCommand
        '
        Me.txtCommand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCommand.Location = New System.Drawing.Point(15, 12)
        Me.txtCommand.Multiline = True
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(436, 180)
        Me.txtCommand.TabIndex = 3
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Location = New System.Drawing.Point(16, 195)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(468, 16)
        Me.lblStatus.TabIndex = 7
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.BackColor = System.Drawing.Color.Transparent
        Me.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExecute.Image = Global.DatabaseManager.My.Resources.Resources.Play_32
        Me.btnExecute.Location = New System.Drawing.Point(457, 12)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(27, 180)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.UseVisualStyleBackColor = False
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
        Me.ClientSize = New System.Drawing.Size(492, 220)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtCommand)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(280, 220)
        Me.Name = "FrmCommand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Execution of SQL commands"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnArquivo As DatabaseManager.ccoBotaoPasta
    Friend WithEvents txtCommand As System.Windows.Forms.TextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
