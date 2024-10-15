<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadProdutos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblProduto = New System.Windows.Forms.Label()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblDuracao = New System.Windows.Forms.Label()
        Me.lblCensura = New System.Windows.Forms.Label()
        Me.lblDtCad = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtCensura = New System.Windows.Forms.TextBox()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.txtDuracao = New System.Windows.Forms.TextBox()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.lstFilmes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbolegenda = New System.Windows.Forms.ComboBox()
        Me.Valor = New System.Windows.Forms.Label()
        Me.mskDcad = New System.Windows.Forms.DateTimePicker()
        Me.txtvalor = New System.Windows.Forms.MaskedTextBox()
        Me.txtoriginal = New System.Windows.Forms.TextBox()
        Me.lbloriginal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.tcProduto = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.tpCadastro = New System.Windows.Forms.TabPage()
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
        Me.tcProduto.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tpCadastro.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 75)
        Me.Panel1.TabIndex = 0
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 13)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(40, 13)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Codigo"
        Me.label3.Visible = False
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(432, 13)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(28, 13)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Tipo"
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Items.AddRange(New Object() {"DVD", "JOGO", "VHS"})
        Me.cboProduto.Location = New System.Drawing.Point(435, 32)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(193, 21)
        Me.cboProduto.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(68, 13)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Título"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(631, 13)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(76, 13)
        Me.lblAutor.TabIndex = 8
        Me.lblAutor.Text = "Diretor/Criador"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(6, 65)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(42, 13)
        Me.lblGenero.TabIndex = 9
        Me.lblGenero.Text = "Gênero"
        '
        'lblDuracao
        '
        Me.lblDuracao.AutoSize = True
        Me.lblDuracao.Location = New System.Drawing.Point(331, 65)
        Me.lblDuracao.Name = "lblDuracao"
        Me.lblDuracao.Size = New System.Drawing.Size(48, 13)
        Me.lblDuracao.TabIndex = 10
        Me.lblDuracao.Text = "Duração"
        '
        'lblCensura
        '
        Me.lblCensura.AutoSize = True
        Me.lblCensura.Location = New System.Drawing.Point(153, 65)
        Me.lblCensura.Name = "lblCensura"
        Me.lblCensura.Size = New System.Drawing.Size(46, 13)
        Me.lblCensura.TabIndex = 11
        Me.lblCensura.Text = "Censura"
        '
        'lblDtCad
        '
        Me.lblDtCad.AutoSize = True
        Me.lblDtCad.Location = New System.Drawing.Point(563, 65)
        Me.lblDtCad.Name = "lblDtCad"
        Me.lblDtCad.Size = New System.Drawing.Size(90, 13)
        Me.lblDtCad.TabIndex = 12
        Me.lblDtCad.Text = "Data do Cadastro"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(410, 65)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 14
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(71, 34)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(358, 20)
        Me.txtTitulo.TabIndex = 15
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(634, 34)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(271, 20)
        Me.txtAutor.TabIndex = 16
        '
        'txtCensura
        '
        Me.txtCensura.Location = New System.Drawing.Point(156, 85)
        Me.txtCensura.Name = "txtCensura"
        Me.txtCensura.Size = New System.Drawing.Size(105, 20)
        Me.txtCensura.TabIndex = 19
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(413, 84)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(74, 20)
        Me.txtQuantidade.TabIndex = 22
        '
        'txtDuracao
        '
        Me.txtDuracao.Location = New System.Drawing.Point(332, 84)
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.Size = New System.Drawing.Size(75, 20)
        Me.txtDuracao.TabIndex = 33
        '
        'cboGenero
        '
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Location = New System.Drawing.Point(9, 84)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(141, 21)
        Me.cboGenero.TabIndex = 36
        '
        'lstFilmes
        '
        Me.lstFilmes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader10})
        Me.lstFilmes.FullRowSelect = True
        Me.lstFilmes.HideSelection = False
        Me.lstFilmes.Location = New System.Drawing.Point(6, 6)
        Me.lstFilmes.Name = "lstFilmes"
        Me.lstFilmes.Size = New System.Drawing.Size(898, 392)
        Me.lstFilmes.TabIndex = 37
        Me.lstFilmes.Tag = "0"
        Me.lstFilmes.UseCompatibleStateImageBehavior = False
        Me.lstFilmes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Produto"
        Me.ColumnHeader2.Width = 77
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Titulo"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Gênero"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Censura"
        Me.ColumnHeader6.Width = 65
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 6
        Me.ColumnHeader4.Text = "Legenda"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 7
        Me.ColumnHeader7.Text = "Autor"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 8
        Me.ColumnHeader8.Text = "Duracao"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.DisplayIndex = 9
        Me.ColumnHeader9.Text = "Quantidade"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.DisplayIndex = 10
        Me.ColumnHeader11.Text = "Valor"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.DisplayIndex = 5
        Me.ColumnHeader10.Text = "Data Cadastro"
        Me.ColumnHeader10.Width = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(682, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Legenda"
        '
        'cbolegenda
        '
        Me.cbolegenda.FormattingEnabled = True
        Me.cbolegenda.Location = New System.Drawing.Point(682, 81)
        Me.cbolegenda.Name = "cbolegenda"
        Me.cbolegenda.Size = New System.Drawing.Size(223, 21)
        Me.cbolegenda.TabIndex = 41
        '
        'Valor
        '
        Me.Valor.AutoSize = True
        Me.Valor.Location = New System.Drawing.Point(493, 65)
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(31, 13)
        Me.Valor.TabIndex = 44
        Me.Valor.Text = "Valor"
        '
        'mskDcad
        '
        Me.mskDcad.CalendarForeColor = System.Drawing.Color.Black
        Me.mskDcad.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.mskDcad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mskDcad.Location = New System.Drawing.Point(566, 83)
        Me.mskDcad.Name = "mskDcad"
        Me.mskDcad.Size = New System.Drawing.Size(110, 20)
        Me.mskDcad.TabIndex = 45
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(493, 83)
        Me.txtvalor.Mask = "0,00"
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(67, 20)
        Me.txtvalor.TabIndex = 46
        '
        'txtoriginal
        '
        Me.txtoriginal.Enabled = False
        Me.txtoriginal.Location = New System.Drawing.Point(267, 84)
        Me.txtoriginal.Name = "txtoriginal"
        Me.txtoriginal.Size = New System.Drawing.Size(59, 20)
        Me.txtoriginal.TabIndex = 48
        Me.txtoriginal.Visible = False
        '
        'lbloriginal
        '
        Me.lbloriginal.AutoSize = True
        Me.lbloriginal.Enabled = False
        Me.lbloriginal.Location = New System.Drawing.Point(267, 65)
        Me.lbloriginal.Name = "lbloriginal"
        Me.lbloriginal.Size = New System.Drawing.Size(42, 13)
        Me.lbloriginal.TabIndex = 49
        Me.lbloriginal.Text = "Original"
        Me.lbloriginal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(778, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 50
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(9, 34)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(55, 20)
        Me.lblCodigo.TabIndex = 90
        '
        'tcProduto
        '
        Me.tcProduto.Controls.Add(Me.tpListagem)
        Me.tcProduto.Controls.Add(Me.tpCadastro)
        Me.tcProduto.Location = New System.Drawing.Point(12, 103)
        Me.tcProduto.Name = "tcProduto"
        Me.tcProduto.SelectedIndex = 0
        Me.tcProduto.Size = New System.Drawing.Size(919, 430)
        Me.tcProduto.TabIndex = 91
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.lstFilmes)
        Me.tpListagem.Location = New System.Drawing.Point(4, 22)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(911, 404)
        Me.tpListagem.TabIndex = 0
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'tpCadastro
        '
        Me.tpCadastro.Controls.Add(Me.label3)
        Me.tpCadastro.Controls.Add(Me.lblCodigo)
        Me.tpCadastro.Controls.Add(Me.lblProduto)
        Me.tpCadastro.Controls.Add(Me.Label2)
        Me.tpCadastro.Controls.Add(Me.cboProduto)
        Me.tpCadastro.Controls.Add(Me.lbloriginal)
        Me.tpCadastro.Controls.Add(Me.lblTitulo)
        Me.tpCadastro.Controls.Add(Me.txtoriginal)
        Me.tpCadastro.Controls.Add(Me.lblAutor)
        Me.tpCadastro.Controls.Add(Me.txtvalor)
        Me.tpCadastro.Controls.Add(Me.lblGenero)
        Me.tpCadastro.Controls.Add(Me.mskDcad)
        Me.tpCadastro.Controls.Add(Me.lblDuracao)
        Me.tpCadastro.Controls.Add(Me.Valor)
        Me.tpCadastro.Controls.Add(Me.lblCensura)
        Me.tpCadastro.Controls.Add(Me.cbolegenda)
        Me.tpCadastro.Controls.Add(Me.lblDtCad)
        Me.tpCadastro.Controls.Add(Me.Label1)
        Me.tpCadastro.Controls.Add(Me.lblQuantidade)
        Me.tpCadastro.Controls.Add(Me.cboGenero)
        Me.tpCadastro.Controls.Add(Me.txtTitulo)
        Me.tpCadastro.Controls.Add(Me.txtDuracao)
        Me.tpCadastro.Controls.Add(Me.txtAutor)
        Me.tpCadastro.Controls.Add(Me.txtQuantidade)
        Me.tpCadastro.Controls.Add(Me.txtCensura)
        Me.tpCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastro.Size = New System.Drawing.Size(911, 404)
        Me.tpCadastro.TabIndex = 1
        Me.tpCadastro.Text = "Cadastro"
        Me.tpCadastro.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.SalvarToolStripButton, Me.AlterarToolStripButton, Me.ExcluirToolStripButton, Me.ConsultarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.RecortarToolStripButton, Me.CopiarToolStripButton, Me.ColarToolStripButton, Me.toolStripSeparator1, Me.AjudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 75)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(943, 25)
        Me.ToolStrip1.TabIndex = 92
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
        'frmCadProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(943, 545)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tcProduto)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        Me.tcProduto.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tpCadastro.ResumeLayout(False)
        Me.tpCadastro.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents cboProduto As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblDuracao As System.Windows.Forms.Label
    Friend WithEvents lblCensura As System.Windows.Forms.Label
    Friend WithEvents lblDtCad As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtCensura As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents txtDuracao As System.Windows.Forms.TextBox
    Friend WithEvents cboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents lstFilmes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbolegenda As System.Windows.Forms.ComboBox
    Friend WithEvents Valor As System.Windows.Forms.Label
    Private WithEvents mskDcad As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtvalor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtoriginal As System.Windows.Forms.TextBox
    Friend WithEvents lbloriginal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents tcProduto As TabControl
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents tpCadastro As TabPage
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
End Class
