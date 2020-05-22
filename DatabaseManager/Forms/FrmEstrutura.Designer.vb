<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstrutura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstrutura))
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.TABLE_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABLE_CATALOG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABLE_SCHEMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABLE_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABLE_GUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TABLE_PROPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_CREATED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_MODIFIED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToOrderColumns = True
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TABLE_NAME, Me.TABLE_CATALOG, Me.TABLE_SCHEMA, Me.TABLE_TYPE, Me.TABLE_GUID, Me.DESCRIPTION, Me.TABLE_PROPID, Me.DATE_CREATED, Me.DATE_MODIFIED})
        Me.Grid.Location = New System.Drawing.Point(12, 12)
        Me.Grid.Name = "Grid"
        Me.Grid.ReadOnly = True
        Me.Grid.RowHeadersVisible = False
        Me.Grid.Size = New System.Drawing.Size(219, 269)
        Me.Grid.TabIndex = 1
        '
        'TABLE_NAME
        '
        Me.TABLE_NAME.DataPropertyName = "TABLE_NAME"
        Me.TABLE_NAME.HeaderText = "Tabelas"
        Me.TABLE_NAME.Name = "TABLE_NAME"
        Me.TABLE_NAME.ReadOnly = True
        '
        'TABLE_CATALOG
        '
        Me.TABLE_CATALOG.DataPropertyName = "TABLE_CATALOG"
        Me.TABLE_CATALOG.HeaderText = "Catalogo"
        Me.TABLE_CATALOG.Name = "TABLE_CATALOG"
        Me.TABLE_CATALOG.ReadOnly = True
        Me.TABLE_CATALOG.Visible = False
        '
        'TABLE_SCHEMA
        '
        Me.TABLE_SCHEMA.DataPropertyName = "TABLE_SCHEMA"
        Me.TABLE_SCHEMA.HeaderText = "Schema"
        Me.TABLE_SCHEMA.Name = "TABLE_SCHEMA"
        Me.TABLE_SCHEMA.ReadOnly = True
        Me.TABLE_SCHEMA.Visible = False
        '
        'TABLE_TYPE
        '
        Me.TABLE_TYPE.DataPropertyName = "TABLE_TYPE"
        Me.TABLE_TYPE.HeaderText = "Tipo"
        Me.TABLE_TYPE.Name = "TABLE_TYPE"
        Me.TABLE_TYPE.ReadOnly = True
        Me.TABLE_TYPE.Visible = False
        '
        'TABLE_GUID
        '
        Me.TABLE_GUID.DataPropertyName = "TABLE_GUID"
        Me.TABLE_GUID.HeaderText = "GUID"
        Me.TABLE_GUID.Name = "TABLE_GUID"
        Me.TABLE_GUID.ReadOnly = True
        Me.TABLE_GUID.Visible = False
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.DataPropertyName = "DESCRIPTION"
        Me.DESCRIPTION.HeaderText = "Descrição"
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.ReadOnly = True
        Me.DESCRIPTION.Visible = False
        '
        'TABLE_PROPID
        '
        Me.TABLE_PROPID.DataPropertyName = "TABLE_PROPID"
        Me.TABLE_PROPID.HeaderText = "P"
        Me.TABLE_PROPID.Name = "TABLE_PROPID"
        Me.TABLE_PROPID.ReadOnly = True
        Me.TABLE_PROPID.Visible = False
        '
        'DATE_CREATED
        '
        Me.DATE_CREATED.DataPropertyName = "DATE_CREATED"
        Me.DATE_CREATED.HeaderText = "Criação"
        Me.DATE_CREATED.Name = "DATE_CREATED"
        Me.DATE_CREATED.ReadOnly = True
        Me.DATE_CREATED.Visible = False
        '
        'DATE_MODIFIED
        '
        Me.DATE_MODIFIED.DataPropertyName = "DATE_MODIFIED"
        Me.DATE_MODIFIED.HeaderText = "Modificação"
        Me.DATE_MODIFIED.Name = "DATE_MODIFIED"
        Me.DATE_MODIFIED.ReadOnly = True
        Me.DATE_MODIFIED.Visible = False
        '
        'FrmEstrutura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 293)
        Me.Controls.Add(Me.Grid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEstrutura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estrutura"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents TABLE_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLE_CATALOG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLE_SCHEMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLE_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLE_GUID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TABLE_PROPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATE_CREATED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATE_MODIFIED As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
