<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComando
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComando))
        Me.txtLocal_dados = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComando = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.btnEstrutura = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnPesquisaBase = New DatabaseManager.ccoBotaoPasta()
        Me.btnArquivo = New DatabaseManager.ccoBotaoPasta()
        Me.SuspendLayout()
        '
        'txtLocal_dados
        '
        Me.txtLocal_dados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLocal_dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLocal_dados.Location = New System.Drawing.Point(105, 36)
        Me.txtLocal_dados.Name = "txtLocal_dados"
        Me.txtLocal_dados.Size = New System.Drawing.Size(346, 13)
        Me.txtLocal_dados.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco de Dados"
        '
        'txtComando
        '
        Me.txtComando.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComando.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComando.Location = New System.Drawing.Point(15, 88)
        Me.txtComando.Multiline = True
        Me.txtComando.Name = "txtComando"
        Me.txtComando.Size = New System.Drawing.Size(436, 104)
        Me.txtComando.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Senha do Banco"
        '
        'txtSenha
        '
        Me.txtSenha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Location = New System.Drawing.Point(105, 62)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(346, 13)
        Me.txtSenha.TabIndex = 5
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
        Me.btnExecute.Location = New System.Drawing.Point(457, 88)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(27, 104)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.UseVisualStyleBackColor = False
        '
        'btnEstrutura
        '
        Me.btnEstrutura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEstrutura.BackColor = System.Drawing.Color.Transparent
        Me.btnEstrutura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEstrutura.Image = Global.DatabaseManager.My.Resources.Resources.Data_table_16
        Me.btnEstrutura.Location = New System.Drawing.Point(458, 58)
        Me.btnEstrutura.Name = "btnEstrutura"
        Me.btnEstrutura.Size = New System.Drawing.Size(26, 21)
        Me.btnEstrutura.TabIndex = 8
        Me.btnEstrutura.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFechar.Location = New System.Drawing.Point(457, 5)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(26, 21)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.Text = "X"
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(439, 17)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Execução de comandos SQL"
        '
        'btnPesquisaBase
        '
        Me.btnPesquisaBase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPesquisaBase.BackColor = System.Drawing.Color.Transparent
        Me.btnPesquisaBase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaBase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPesquisaBase.Image = CType(resources.GetObject("btnPesquisaBase.Image"), System.Drawing.Image)
        Me.btnPesquisaBase.Location = New System.Drawing.Point(457, 32)
        Me.btnPesquisaBase.Name = "btnPesquisaBase"
        Me.btnPesquisaBase.PUAuxControl = Me.txtLocal_dados
        Me.btnPesquisaBase.PUDataType = DatabaseManager.TYPE_FOLDER.FOLDER_FILE
        Me.btnPesquisaBase.PUFilterType = DatabaseManager.TYPE_FILTER_FILE.ACCESS
        Me.btnPesquisaBase.Size = New System.Drawing.Size(26, 21)
        Me.btnPesquisaBase.TabIndex = 9
        Me.btnPesquisaBase.UseVisualStyleBackColor = False
        '
        'btnArquivo
        '
        Me.btnArquivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArquivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArquivo.Image = CType(resources.GetObject("btnArquivo.Image"), System.Drawing.Image)
        Me.btnArquivo.Location = New System.Drawing.Point(571, 3)
        Me.btnArquivo.Name = "btnArquivo"
        Me.btnArquivo.PUAuxControl = Me.txtLocal_dados
        Me.btnArquivo.PUDataType = DatabaseManager.TYPE_FOLDER.FOLDER_FILE
        Me.btnArquivo.PUFilterType = DatabaseManager.TYPE_FILTER_FILE.ACCESS
        Me.btnArquivo.Size = New System.Drawing.Size(26, 21)
        Me.btnArquivo.TabIndex = 2
        Me.btnArquivo.UseVisualStyleBackColor = True
        '
        'FrmComando
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(492, 220)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.txtComando)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLocal_dados)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.btnEstrutura)
        Me.Controls.Add(Me.btnPesquisaBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(280, 220)
        Me.Name = "FrmComando"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Execução de comandos SQL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLocal_dados As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnArquivo As DatabaseManager.ccoBotaoPasta
    Friend WithEvents txtComando As System.Windows.Forms.TextBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents btnEstrutura As System.Windows.Forms.Button
    Friend WithEvents btnPesquisaBase As DatabaseManager.ccoBotaoPasta
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label

End Class
