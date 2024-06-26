<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalizar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalizar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblItens = New System.Windows.Forms.Label()
        Me.lstLocalizar = New System.Windows.Forms.ListView()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtLocalizar = New System.Windows.Forms.TextBox()
        Me.cboItens = New System.Windows.Forms.ComboBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Digite o valor referente sua pesquisa"
        '
        'lblItens
        '
        Me.lblItens.AutoSize = True
        Me.lblItens.Location = New System.Drawing.Point(32, 98)
        Me.lblItens.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItens.Name = "lblItens"
        Me.lblItens.Size = New System.Drawing.Size(51, 16)
        Me.lblItens.TabIndex = 8
        Me.lblItens.Text = "Tabela"
        '
        'lstLocalizar
        '
        Me.lstLocalizar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nome})
        Me.lstLocalizar.FullRowSelect = True
        Me.lstLocalizar.HideSelection = False
        Me.lstLocalizar.Location = New System.Drawing.Point(36, 166)
        Me.lstLocalizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstLocalizar.MultiSelect = False
        Me.lstLocalizar.Name = "lstLocalizar"
        Me.lstLocalizar.Size = New System.Drawing.Size(645, 144)
        Me.lstLocalizar.TabIndex = 10
        Me.lstLocalizar.UseCompatibleStateImageBehavior = False
        Me.lstLocalizar.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "Código"
        Me.codigo.Width = 80
        '
        'nome
        '
        Me.nome.Text = "Nome / Descrição"
        Me.nome.Width = 380
        '
        'txtLocalizar
        '
        Me.txtLocalizar.Location = New System.Drawing.Point(239, 118)
        Me.txtLocalizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(388, 22)
        Me.txtLocalizar.TabIndex = 1
        '
        'cboItens
        '
        Me.cboItens.FormattingEnabled = True
        Me.cboItens.Items.AddRange(New Object() {"Clientes", "Produtos"})
        Me.cboItens.Location = New System.Drawing.Point(36, 118)
        Me.cboItens.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboItens.Name = "cboItens"
        Me.cboItens.Size = New System.Drawing.Size(160, 24)
        Me.cboItens.TabIndex = 0
        Me.cboItens.Text = "Selecione..."
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.Projeto_Locadora.My.Resources.Resources.external_hd
        Me.btnSalvar.Location = New System.Drawing.Point(145, 16)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(95, 69)
        Me.btnSalvar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Adicionar Registro não Encontrado")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Image = Global.Projeto_Locadora.My.Resources.Resources.binoculars
        Me.btnLocalizar.Location = New System.Drawing.Point(27, 16)
        Me.btnLocalizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(95, 69)
        Me.btnLocalizar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnLocalizar, "Localizar")
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.Projeto_Locadora.My.Resources.Resources.trash
        Me.btnExcluir.Location = New System.Drawing.Point(396, 16)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(95, 69)
        Me.btnExcluir.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir Registro")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.btnFechar.Location = New System.Drawing.Point(527, 16)
        Me.btnFechar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(95, 69)
        Me.btnFechar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnFechar, "Fechar")
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = Global.Projeto_Locadora.My.Resources.Resources.paste1
        Me.btnAlterar.Location = New System.Drawing.Point(272, 16)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(95, 69)
        Me.btnAlterar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar Registro")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(733, 79)
        Me.Panel1.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.btnLocalizar)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnAlterar)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 319)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(647, 92)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'frmLocalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 442)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstLocalizar)
        Me.Controls.Add(Me.cboItens)
        Me.Controls.Add(Me.txtLocalizar)
        Me.Controls.Add(Me.lblItens)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLocalizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Localizar"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboItens As System.Windows.Forms.ComboBox
    Friend WithEvents txtLocalizar As System.Windows.Forms.TextBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItens As System.Windows.Forms.Label
    Friend WithEvents lstLocalizar As System.Windows.Forms.ListView
    Friend WithEvents codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents nome As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
