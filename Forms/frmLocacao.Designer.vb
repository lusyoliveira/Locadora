<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLocacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocacao))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDtLocacao = New System.Windows.Forms.Label()
        Me.lblDtDevolucao = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboclientes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.dtpLocacao = New System.Windows.Forms.DateTimePicker()
        Me.dtpDevolucao = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.chCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTitulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chValor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtValorUnit = New System.Windows.Forms.TextBox()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.lblTotalPg = New System.Windows.Forms.Label()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.txtCodLocacao = New System.Windows.Forms.TextBox()
        Me.ER = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlterarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ConsultarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ColarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tcLocacao = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.lstConsulta = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Funcionario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Multa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Pago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Locacao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Devolucao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tpLocacao = New System.Windows.Forms.TabPage()
        Me.dtpDevolucaoIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpDevolucaoFim = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tcLocacao.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tpLocacao.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 75)
        Me.Panel1.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(8, 6)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(76, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "N°da Locação"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(458, 86)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(31, 13)
        Me.lblValor.TabIndex = 5
        Me.lblValor.Text = "Valor"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(581, 46)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 6
        Me.lblQuantidade.Text = "Quantidade"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(526, 87)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        '
        'lblDtLocacao
        '
        Me.lblDtLocacao.AutoSize = True
        Me.lblDtLocacao.Location = New System.Drawing.Point(434, 6)
        Me.lblDtLocacao.Name = "lblDtLocacao"
        Me.lblDtLocacao.Size = New System.Drawing.Size(90, 13)
        Me.lblDtLocacao.TabIndex = 8
        Me.lblDtLocacao.Text = "Data da Locação"
        '
        'lblDtDevolucao
        '
        Me.lblDtDevolucao.AutoSize = True
        Me.lblDtDevolucao.Location = New System.Drawing.Point(541, 6)
        Me.lblDtDevolucao.Name = "lblDtDevolucao"
        Me.lblDtDevolucao.Size = New System.Drawing.Size(102, 13)
        Me.lblDtDevolucao.TabIndex = 9
        Me.lblDtDevolucao.Text = "Prev. de Devolução"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Enabled = False
        Me.txtQuantidade.Location = New System.Drawing.Point(584, 61)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(56, 20)
        Me.txtQuantidade.TabIndex = 3
        Me.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cliente"
        '
        'cboclientes
        '
        Me.cboclientes.Enabled = False
        Me.cboclientes.FormattingEnabled = True
        Me.cboclientes.Location = New System.Drawing.Point(9, 60)
        Me.cboclientes.Name = "cboclientes"
        Me.cboclientes.Size = New System.Drawing.Size(569, 21)
        Me.cboclientes.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Titulo"
        '
        'cboProduto
        '
        Me.cboProduto.Enabled = False
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(9, 102)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(445, 21)
        Me.cboProduto.TabIndex = 4
        '
        'dtpLocacao
        '
        Me.dtpLocacao.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpLocacao.Enabled = False
        Me.dtpLocacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLocacao.Location = New System.Drawing.Point(437, 23)
        Me.dtpLocacao.Name = "dtpLocacao"
        Me.dtpLocacao.Size = New System.Drawing.Size(99, 20)
        Me.dtpLocacao.TabIndex = 45
        '
        'dtpDevolucao
        '
        Me.dtpDevolucao.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpDevolucao.Enabled = False
        Me.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDevolucao.Location = New System.Drawing.Point(542, 23)
        Me.dtpDevolucao.Name = "dtpDevolucao"
        Me.dtpDevolucao.Size = New System.Drawing.Size(101, 20)
        Me.dtpDevolucao.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Funcionario"
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodigo, Me.chTitulo, Me.chValor, Me.chTotal})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(9, 131)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(634, 251)
        Me.lstgrade.TabIndex = 51
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'chCodigo
        '
        Me.chCodigo.Text = "Codigo"
        '
        'chTitulo
        '
        Me.chTitulo.Text = "Titulo"
        Me.chTitulo.Width = 400
        '
        'chValor
        '
        Me.chValor.Text = "Valor"
        '
        'chTotal
        '
        Me.chTotal.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(529, 103)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(60, 20)
        Me.txtTotal.TabIndex = 6
        '
        'txtValorUnit
        '
        Me.txtValorUnit.Enabled = False
        Me.txtValorUnit.Location = New System.Drawing.Point(460, 103)
        Me.txtValorUnit.Name = "txtValorUnit"
        Me.txtValorUnit.Size = New System.Drawing.Size(64, 20)
        Me.txtValorUnit.TabIndex = 5
        '
        'btnremove
        '
        Me.btnremove.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnremove.Enabled = False
        Me.btnremove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnremove.Location = New System.Drawing.Point(621, 103)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(20, 20)
        Me.btnremove.TabIndex = 53
        Me.btnremove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionar.Enabled = False
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnAdicionar.Location = New System.Drawing.Point(595, 103)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(20, 20)
        Me.btnAdicionar.TabIndex = 52
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'lblTotalPg
        '
        Me.lblTotalPg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPg.ForeColor = System.Drawing.Color.Red
        Me.lblTotalPg.Location = New System.Drawing.Point(564, 385)
        Me.lblTotalPg.Name = "lblTotalPg"
        Me.lblTotalPg.Size = New System.Drawing.Size(79, 20)
        Me.lblTotalPg.TabIndex = 64
        Me.lblTotalPg.Text = "0,00"
        Me.lblTotalPg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboFuncionario
        '
        Me.cboFuncionario.Enabled = False
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(88, 22)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(343, 21)
        Me.cboFuncionario.TabIndex = 1
        '
        'txtCodLocacao
        '
        Me.txtCodLocacao.Enabled = False
        Me.txtCodLocacao.Location = New System.Drawing.Point(9, 22)
        Me.txtCodLocacao.Name = "txtCodLocacao"
        Me.txtCodLocacao.Size = New System.Drawing.Size(75, 20)
        Me.txtCodLocacao.TabIndex = 64
        '
        'ER
        '
        Me.ER.ContainerControl = Me
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(492, 389)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Tot. a Pagar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.SalvarToolStripButton, Me.AlterarToolStripButton, Me.ExcluirToolStripButton, Me.ConsultarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.RecortarToolStripButton, Me.CopiarToolStripButton, Me.ColarToolStripButton, Me.toolStripSeparator1, Me.AjudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 75)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(683, 25)
        Me.ToolStrip1.TabIndex = 70
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NovoToolStripButton.Text = "&Novo"
        '
        'SalvarToolStripButton
        '
        Me.SalvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalvarToolStripButton.Enabled = False
        Me.SalvarToolStripButton.Image = CType(resources.GetObject("SalvarToolStripButton.Image"), System.Drawing.Image)
        Me.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripButton.Name = "SalvarToolStripButton"
        Me.SalvarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SalvarToolStripButton.Text = "&Salvar"
        '
        'AlterarToolStripButton
        '
        Me.AlterarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlterarToolStripButton.Enabled = False
        Me.AlterarToolStripButton.Image = Global.ProjetoLocadora.My.Resources.Resources.Alterar
        Me.AlterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlterarToolStripButton.Name = "AlterarToolStripButton"
        Me.AlterarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AlterarToolStripButton.Text = "Alterar"
        '
        'ExcluirToolStripButton
        '
        Me.ExcluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExcluirToolStripButton.Enabled = False
        Me.ExcluirToolStripButton.Image = CType(resources.GetObject("ExcluirToolStripButton.Image"), System.Drawing.Image)
        Me.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirToolStripButton.Name = "ExcluirToolStripButton"
        Me.ExcluirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ExcluirToolStripButton.Text = "Excluir"
        '
        'ConsultarToolStripButton
        '
        Me.ConsultarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConsultarToolStripButton.Image = Global.ProjetoLocadora.My.Resources.Resources.Consultar
        Me.ConsultarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConsultarToolStripButton.Name = "ConsultarToolStripButton"
        Me.ConsultarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ConsultarToolStripButton.Text = "Consultar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'RecortarToolStripButton
        '
        Me.RecortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecortarToolStripButton.Image = CType(resources.GetObject("RecortarToolStripButton.Image"), System.Drawing.Image)
        Me.RecortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RecortarToolStripButton.Name = "RecortarToolStripButton"
        Me.RecortarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RecortarToolStripButton.Text = "Recor&tar"
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        '
        'ColarToolStripButton
        '
        Me.ColarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColarToolStripButton.Image = CType(resources.GetObject("ColarToolStripButton.Image"), System.Drawing.Image)
        Me.ColarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ColarToolStripButton.Name = "ColarToolStripButton"
        Me.ColarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ColarToolStripButton.Text = "C&olar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AjudaToolStripButton
        '
        Me.AjudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AjudaToolStripButton.Image = CType(resources.GetObject("AjudaToolStripButton.Image"), System.Drawing.Image)
        Me.AjudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AjudaToolStripButton.Name = "AjudaToolStripButton"
        Me.AjudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AjudaToolStripButton.Text = "&Ajuda"
        '
        'tcLocacao
        '
        Me.tcLocacao.Controls.Add(Me.tpListagem)
        Me.tcLocacao.Controls.Add(Me.tpLocacao)
        Me.tcLocacao.Location = New System.Drawing.Point(12, 103)
        Me.tcLocacao.Name = "tcLocacao"
        Me.tcLocacao.SelectedIndex = 0
        Me.tcLocacao.Size = New System.Drawing.Size(660, 434)
        Me.tcLocacao.TabIndex = 71
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.GroupBox1)
        Me.tpListagem.Controls.Add(Me.lstConsulta)
        Me.tpListagem.Location = New System.Drawing.Point(4, 22)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(652, 408)
        Me.tpListagem.TabIndex = 1
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'lstConsulta
        '
        Me.lstConsulta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Funcionario, Me.Cliente, Me.Quantidade, Me.Total, Me.Multa, Me.Pago, Me.Locacao, Me.Devolucao})
        Me.lstConsulta.FullRowSelect = True
        Me.lstConsulta.HideSelection = False
        Me.lstConsulta.Location = New System.Drawing.Point(6, 63)
        Me.lstConsulta.Name = "lstConsulta"
        Me.lstConsulta.Size = New System.Drawing.Size(640, 342)
        Me.lstConsulta.TabIndex = 5
        Me.lstConsulta.UseCompatibleStateImageBehavior = False
        Me.lstConsulta.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "N° da Locação"
        Me.Codigo.Width = 85
        '
        'Funcionario
        '
        Me.Funcionario.Text = "Funcionário"
        Me.Funcionario.Width = 120
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 169
        '
        'Quantidade
        '
        Me.Quantidade.Text = "Quantidade"
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.Width = 55
        '
        'Multa
        '
        Me.Multa.Text = "Multa"
        '
        'Pago
        '
        Me.Pago.Text = "Pago"
        '
        'Locacao
        '
        Me.Locacao.Text = "Data da Locação"
        '
        'Devolucao
        '
        Me.Devolucao.Text = "Data Devolução"
        Me.Devolucao.Width = 97
        '
        'tpLocacao
        '
        Me.tpLocacao.Controls.Add(Me.lstgrade)
        Me.tpLocacao.Controls.Add(Me.txtTotal)
        Me.tpLocacao.Controls.Add(Me.Label4)
        Me.tpLocacao.Controls.Add(Me.txtCodLocacao)
        Me.tpLocacao.Controls.Add(Me.lblTotalPg)
        Me.tpLocacao.Controls.Add(Me.lblCodigo)
        Me.tpLocacao.Controls.Add(Me.txtValorUnit)
        Me.tpLocacao.Controls.Add(Me.lblDtLocacao)
        Me.tpLocacao.Controls.Add(Me.lblDtDevolucao)
        Me.tpLocacao.Controls.Add(Me.btnAdicionar)
        Me.tpLocacao.Controls.Add(Me.Label2)
        Me.tpLocacao.Controls.Add(Me.cboProduto)
        Me.tpLocacao.Controls.Add(Me.lblQuantidade)
        Me.tpLocacao.Controls.Add(Me.Label3)
        Me.tpLocacao.Controls.Add(Me.cboclientes)
        Me.tpLocacao.Controls.Add(Me.btnremove)
        Me.tpLocacao.Controls.Add(Me.dtpLocacao)
        Me.tpLocacao.Controls.Add(Me.lblTotal)
        Me.tpLocacao.Controls.Add(Me.txtQuantidade)
        Me.tpLocacao.Controls.Add(Me.lblValor)
        Me.tpLocacao.Controls.Add(Me.dtpDevolucao)
        Me.tpLocacao.Controls.Add(Me.Label8)
        Me.tpLocacao.Controls.Add(Me.cboFuncionario)
        Me.tpLocacao.Location = New System.Drawing.Point(4, 22)
        Me.tpLocacao.Name = "tpLocacao"
        Me.tpLocacao.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLocacao.Size = New System.Drawing.Size(652, 408)
        Me.tpLocacao.TabIndex = 0
        Me.tpLocacao.Text = "Locação"
        Me.tpLocacao.UseVisualStyleBackColor = True
        '
        'dtpDevolucaoIni
        '
        Me.dtpDevolucaoIni.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpDevolucaoIni.Checked = False
        Me.dtpDevolucaoIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDevolucaoIni.Location = New System.Drawing.Point(6, 19)
        Me.dtpDevolucaoIni.Name = "dtpDevolucaoIni"
        Me.dtpDevolucaoIni.ShowCheckBox = True
        Me.dtpDevolucaoIni.Size = New System.Drawing.Size(98, 20)
        Me.dtpDevolucaoIni.TabIndex = 78
        '
        'dtpDevolucaoFim
        '
        Me.dtpDevolucaoFim.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpDevolucaoFim.Checked = False
        Me.dtpDevolucaoFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDevolucaoFim.Location = New System.Drawing.Point(110, 19)
        Me.dtpDevolucaoFim.Name = "dtpDevolucaoFim"
        Me.dtpDevolucaoFim.ShowCheckBox = True
        Me.dtpDevolucaoFim.Size = New System.Drawing.Size(98, 20)
        Me.dtpDevolucaoFim.TabIndex = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDevolucaoIni)
        Me.GroupBox1.Controls.Add(Me.dtpDevolucaoFim)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 51)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Devolução"
        '
        'frmLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 549)
        Me.Controls.Add(Me.tcLocacao)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLocacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locação"
        CType(Me.ER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tcLocacao.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tpLocacao.ResumeLayout(False)
        Me.tpLocacao.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDtLocacao As System.Windows.Forms.Label
    Friend WithEvents lblDtDevolucao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboclientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboProduto As System.Windows.Forms.ComboBox
    Friend WithEvents dtpLocacao As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDevolucao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents lblTotalPg As System.Windows.Forms.Label
    Friend WithEvents cboFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents txtValorUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodLocacao As System.Windows.Forms.TextBox
    Friend WithEvents ER As System.Windows.Forms.ErrorProvider
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents chCodigo As ColumnHeader
    Friend WithEvents chTitulo As ColumnHeader
    Friend WithEvents chValor As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents SalvarToolStripButton As ToolStripButton
    Friend WithEvents AlterarToolStripButton As ToolStripButton
    Friend WithEvents ExcluirToolStripButton As ToolStripButton
    Friend WithEvents ConsultarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents RecortarToolStripButton As ToolStripButton
    Friend WithEvents CopiarToolStripButton As ToolStripButton
    Friend WithEvents ColarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AjudaToolStripButton As ToolStripButton
    Friend WithEvents chTotal As ColumnHeader
    Friend WithEvents tcLocacao As TabControl
    Friend WithEvents tpLocacao As TabPage
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents lstConsulta As ListView
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Cliente As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents Multa As ColumnHeader
    Friend WithEvents Locacao As ColumnHeader
    Friend WithEvents Devolucao As ColumnHeader
    Friend WithEvents Funcionario As ColumnHeader
    Friend WithEvents Quantidade As ColumnHeader
    Friend WithEvents Pago As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpDevolucaoIni As DateTimePicker
    Friend WithEvents dtpDevolucaoFim As DateTimePicker
End Class
