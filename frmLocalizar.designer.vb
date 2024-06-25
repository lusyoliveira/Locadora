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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocalizar))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblItens = New System.Windows.Forms.Label
        Me.lstLocalizar = New System.Windows.Forms.ListView
        Me.codigo = New System.Windows.Forms.ColumnHeader
        Me.nome = New System.Windows.Forms.ColumnHeader
        Me.txtLocalizar = New System.Windows.Forms.TextBox
        Me.cboItens = New System.Windows.Forms.ComboBox
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnLocalizar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnFechar = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Digite o valor referente sua pesquisa"
        '
        'lblItens
        '
        Me.lblItens.AutoSize = True
        Me.lblItens.Location = New System.Drawing.Point(24, 80)
        Me.lblItens.Name = "lblItens"
        Me.lblItens.Size = New System.Drawing.Size(40, 13)
        Me.lblItens.TabIndex = 8
        Me.lblItens.Text = "Tabela"
        '
        'lstLocalizar
        '
        Me.lstLocalizar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nome})
        Me.lstLocalizar.FullRowSelect = True
        Me.lstLocalizar.Location = New System.Drawing.Point(27, 135)
        Me.lstLocalizar.MultiSelect = False
        Me.lstLocalizar.Name = "lstLocalizar"
        Me.lstLocalizar.Size = New System.Drawing.Size(485, 118)
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
        Me.txtLocalizar.Location = New System.Drawing.Point(179, 96)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(292, 20)
        Me.txtLocalizar.TabIndex = 1
        '
        'cboItens
        '
        Me.cboItens.FormattingEnabled = True
        Me.cboItens.Items.AddRange(New Object() {"Clientes", "Produtos"})
        Me.cboItens.Location = New System.Drawing.Point(27, 96)
        Me.cboItens.Name = "cboItens"
        Me.cboItens.Size = New System.Drawing.Size(121, 21)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 64)
        Me.Panel1.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalvar)
        Me.GroupBox1.Controls.Add(Me.btnLocalizar)
        Me.GroupBox1.Controls.Add(Me.btnExcluir)
        Me.GroupBox1.Controls.Add(Me.btnFechar)
        Me.GroupBox1.Controls.Add(Me.btnAlterar)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 75)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.Projeto_Locadora.My.Resources.Resources.external_hd
        Me.btnSalvar.Location = New System.Drawing.Point(109, 13)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(71, 56)
        Me.btnSalvar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btnSalvar, "Adicionar Registro não Encontrado")
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Image = Global.Projeto_Locadora.My.Resources.Resources.binoculars
        Me.btnLocalizar.Location = New System.Drawing.Point(20, 13)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(71, 56)
        Me.btnLocalizar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnLocalizar, "Localizar")
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.Projeto_Locadora.My.Resources.Resources.trash
        Me.btnExcluir.Location = New System.Drawing.Point(297, 13)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(71, 56)
        Me.btnExcluir.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnExcluir, "Excluir Registro")
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.btnFechar.Location = New System.Drawing.Point(395, 13)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(71, 56)
        Me.btnFechar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnFechar, "Fechar")
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = Global.Projeto_Locadora.My.Resources.Resources.paste1
        Me.btnAlterar.Location = New System.Drawing.Point(204, 13)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(71, 56)
        Me.btnAlterar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnAlterar, "Alterar Registro")
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'frmLocalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 359)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lstLocalizar)
        Me.Controls.Add(Me.cboItens)
        Me.Controls.Add(Me.txtLocalizar)
        Me.Controls.Add(Me.lblItens)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
