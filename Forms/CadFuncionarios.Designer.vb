<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadFuncionarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tcFuncionario = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstEntidade = New System.Windows.Forms.ListView()
        Me.CodEntidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NomeFantasia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RazaoSocial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataNasc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EstadoCivil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Endereco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Complemento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Bairro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cidade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CEP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RG = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Documento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OBS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cadastro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Alteracao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Inativacao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtRazaoSocial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskTel1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskCel = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.mskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.mskRG = New System.Windows.Forms.MaskedTextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskCep = New System.Windows.Forms.MaskedTextBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbdMasculino = New System.Windows.Forms.RadioButton()
        Me.rbdFeminino = New System.Windows.Forms.RadioButton()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.cboExpediente = New System.Windows.Forms.ComboBox()
        Me.mskCartprof = New System.Windows.Forms.MaskedTextBox()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.t = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lblExpediente = New System.Windows.Forms.Label()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
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
        Me.mskDnascimento = New System.Windows.Forms.DateTimePicker()
        Me.tcFuncionario.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 75)
        Me.Panel1.TabIndex = 33
        '
        'tcFuncionario
        '
        Me.tcFuncionario.Controls.Add(Me.TabPage3)
        Me.tcFuncionario.Controls.Add(Me.TabPage1)
        Me.tcFuncionario.Controls.Add(Me.TabPage2)
        Me.tcFuncionario.Location = New System.Drawing.Point(12, 103)
        Me.tcFuncionario.Name = "tcFuncionario"
        Me.tcFuncionario.SelectedIndex = 0
        Me.tcFuncionario.Size = New System.Drawing.Size(822, 424)
        Me.tcFuncionario.TabIndex = 66
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lstEntidade)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(814, 398)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Listagem"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lstEntidade
        '
        Me.lstEntidade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodEntidade, Me.NomeFantasia, Me.RazaoSocial, Me.DataNasc, Me.EstadoCivil, Me.Endereco, Me.Complemento, Me.Bairro, Me.Cidade, Me.Estado, Me.CEP, Me.Sexo, Me.RG, Me.Documento, Me.OBS, Me.Cadastro, Me.Alteracao, Me.Inativacao})
        Me.lstEntidade.FullRowSelect = True
        Me.lstEntidade.HideSelection = False
        Me.lstEntidade.Location = New System.Drawing.Point(3, 3)
        Me.lstEntidade.MultiSelect = False
        Me.lstEntidade.Name = "lstEntidade"
        Me.lstEntidade.Size = New System.Drawing.Size(808, 392)
        Me.lstEntidade.TabIndex = 42
        Me.lstEntidade.Tag = "0"
        Me.lstEntidade.UseCompatibleStateImageBehavior = False
        Me.lstEntidade.View = System.Windows.Forms.View.Details
        '
        'CodEntidade
        '
        Me.CodEntidade.Text = "Código"
        '
        'NomeFantasia
        '
        Me.NomeFantasia.Text = "Nome Fantasia"
        '
        'RazaoSocial
        '
        Me.RazaoSocial.Text = "Razão Social"
        '
        'DataNasc
        '
        Me.DataNasc.Text = "Nascimento"
        '
        'EstadoCivil
        '
        Me.EstadoCivil.Text = "Estado Civil"
        '
        'Endereco
        '
        Me.Endereco.Text = "Endereço"
        '
        'Complemento
        '
        Me.Complemento.Text = "Complemento"
        '
        'Bairro
        '
        Me.Bairro.Text = "Bairro"
        '
        'Cidade
        '
        Me.Cidade.Text = "Cidade"
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        '
        'CEP
        '
        Me.CEP.Text = "CEP"
        '
        'Sexo
        '
        Me.Sexo.Text = "Sexo"
        '
        'RG
        '
        Me.RG.Text = "RG"
        '
        'Documento
        '
        Me.Documento.Text = "Documento"
        '
        'OBS
        '
        Me.OBS.Text = "OBS"
        '
        'Cadastro
        '
        Me.Cadastro.Text = "Cadastro"
        '
        'Alteracao
        '
        Me.Alteracao.Text = "Alteração"
        '
        'Inativacao
        '
        Me.Inativacao.Text = "Inativação"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.mskDnascimento)
        Me.TabPage1.Controls.Add(Me.txtRazaoSocial)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.mskTel1)
        Me.TabPage1.Controls.Add(Me.mskTel2)
        Me.TabPage1.Controls.Add(Me.mskCel)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.lblTelefone2)
        Me.TabPage1.Controls.Add(Me.lblCelular)
        Me.TabPage1.Controls.Add(Me.mskCpf)
        Me.TabPage1.Controls.Add(Me.mskRG)
        Me.TabPage1.Controls.Add(Me.lblCpf)
        Me.TabPage1.Controls.Add(Me.lblRg)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Controls.Add(Me.cboUf)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.lblUf)
        Me.TabPage1.Controls.Add(Me.lblCidade)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.mskCep)
        Me.TabPage1.Controls.Add(Me.cboEstadoCivil)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtComplemento)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.lblCep)
        Me.TabPage1.Controls.Add(Me.lblBairro)
        Me.TabPage1.Controls.Add(Me.lblComplemento)
        Me.TabPage1.Controls.Add(Me.lblEndereco)
        Me.TabPage1.Controls.Add(Me.lblEstadoCivil)
        Me.TabPage1.Controls.Add(Me.lblDtNasc)
        Me.TabPage1.Controls.Add(Me.lblNome)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(814, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro Pessoal"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazaoSocial.Location = New System.Drawing.Point(424, 24)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(375, 20)
        Me.txtRazaoSocial.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(421, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Razão Social"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Telefone1"
        '
        'mskTel1
        '
        Me.mskTel1.Location = New System.Drawing.Point(22, 205)
        Me.mskTel1.Mask = "(99) 000-0000"
        Me.mskTel1.Name = "mskTel1"
        Me.mskTel1.Size = New System.Drawing.Size(88, 20)
        Me.mskTel1.TabIndex = 97
        '
        'mskTel2
        '
        Me.mskTel2.Location = New System.Drawing.Point(116, 205)
        Me.mskTel2.Mask = "(99) 000-0000"
        Me.mskTel2.Name = "mskTel2"
        Me.mskTel2.Size = New System.Drawing.Size(87, 20)
        Me.mskTel2.TabIndex = 98
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(208, 205)
        Me.mskCel.Mask = "(99) 000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(81, 20)
        Me.mskCel.TabIndex = 99
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(294, 207)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(329, 20)
        Me.txtEmail.TabIndex = 96
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.Location = New System.Drawing.Point(112, 190)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefone2.TabIndex = 94
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(205, 190)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 95
        Me.lblCelular.Text = "Celular"
        '
        'mskCpf
        '
        Me.mskCpf.Location = New System.Drawing.Point(335, 67)
        Me.mskCpf.Mask = "000.000.000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(100, 20)
        Me.mskCpf.TabIndex = 92
        '
        'mskRG
        '
        Me.mskRG.Location = New System.Drawing.Point(229, 67)
        Me.mskRG.Mask = "00-000.000"
        Me.mskRG.Name = "mskRG"
        Me.mskRG.Size = New System.Drawing.Size(100, 20)
        Me.mskRG.TabIndex = 93
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(331, 52)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 91
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(226, 52)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 90
        Me.lblRg.Text = "RG"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(20, 26)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 18)
        Me.lblCodigo.TabIndex = 89
        '
        'cboUf
        '
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cboUf.Location = New System.Drawing.Point(209, 162)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(170, 21)
        Me.cboUf.TabIndex = 88
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(21, 163)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(182, 20)
        Me.txtCidade.TabIndex = 87
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(206, 146)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(21, 13)
        Me.lblUf.TabIndex = 86
        Me.lblUf.Text = "UF"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(18, 147)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 85
        Me.lblCidade.Text = "Cidade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Código "
        '
        'mskCep
        '
        Me.mskCep.Location = New System.Drawing.Point(625, 119)
        Me.mskCep.Mask = "00000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(79, 20)
        Me.mskCep.TabIndex = 82
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(22, 67)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(89, 21)
        Me.cboEstadoCivil.TabIndex = 81
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbdMasculino)
        Me.GroupBox6.Controls.Add(Me.rbdFeminino)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(637, 52)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(162, 48)
        Me.GroupBox6.TabIndex = 79
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sexo"
        '
        'rbdMasculino
        '
        Me.rbdMasculino.AutoSize = True
        Me.rbdMasculino.Location = New System.Drawing.Point(80, 19)
        Me.rbdMasculino.Name = "rbdMasculino"
        Me.rbdMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbdMasculino.TabIndex = 27
        Me.rbdMasculino.TabStop = True
        Me.rbdMasculino.Text = "Masculino"
        Me.rbdMasculino.UseVisualStyleBackColor = True
        '
        'rbdFeminino
        '
        Me.rbdFeminino.AutoSize = True
        Me.rbdFeminino.Location = New System.Drawing.Point(9, 19)
        Me.rbdFeminino.Name = "rbdFeminino"
        Me.rbdFeminino.Size = New System.Drawing.Size(67, 17)
        Me.rbdFeminino.TabIndex = 26
        Me.rbdFeminino.TabStop = True
        Me.rbdFeminino.Text = "Feminino"
        Me.rbdFeminino.UseVisualStyleBackColor = True
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(419, 119)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(200, 20)
        Me.txtBairro.TabIndex = 78
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(345, 119)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(68, 20)
        Me.txtComplemento.TabIndex = 77
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(22, 119)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(317, 20)
        Me.txtEndereco.TabIndex = 76
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(78, 24)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(340, 20)
        Me.txtNome.TabIndex = 75
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(622, 103)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 73
        Me.lblCep.Text = "CEP"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(416, 103)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 72
        Me.lblBairro.Text = "Bairro"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(342, 103)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(71, 13)
        Me.lblComplemento.TabIndex = 71
        Me.lblComplemento.Text = "Complemento"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(19, 103)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 70
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(19, 51)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lblEstadoCivil.TabIndex = 69
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(114, 51)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(104, 13)
        Me.lblDtNasc.TabIndex = 68
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(76, 8)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 67
        Me.lblNome.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.txtMatricula)
        Me.TabPage2.Controls.Add(Me.lblMatricula)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtObs)
        Me.TabPage2.Controls.Add(Me.cboExpediente)
        Me.TabPage2.Controls.Add(Me.mskCartprof)
        Me.TabPage2.Controls.Add(Me.cboCargo)
        Me.TabPage2.Controls.Add(Me.t)
        Me.TabPage2.Controls.Add(Me.txtSalario)
        Me.TabPage2.Controls.Add(Me.lblExpediente)
        Me.TabPage2.Controls.Add(Me.lblSalario)
        Me.TabPage2.Controls.Add(Me.lblCargo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(814, 398)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro do Empregador"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(17, 30)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(85, 20)
        Me.txtMatricula.TabIndex = 76
        Me.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(15, 12)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(52, 13)
        Me.lblMatricula.TabIndex = 75
        Me.lblMatricula.Text = "Matrícula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Observações:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(18, 76)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(774, 174)
        Me.txtObs.TabIndex = 0
        '
        'cboExpediente
        '
        Me.cboExpediente.FormattingEnabled = True
        Me.cboExpediente.Items.AddRange(New Object() {"Diurno", "Noturno"})
        Me.cboExpediente.Location = New System.Drawing.Point(423, 31)
        Me.cboExpediente.Name = "cboExpediente"
        Me.cboExpediente.Size = New System.Drawing.Size(241, 21)
        Me.cboExpediente.TabIndex = 8
        '
        'mskCartprof
        '
        Me.mskCartprof.Location = New System.Drawing.Point(672, 32)
        Me.mskCartprof.Mask = "000-00-0000"
        Me.mskCartprof.Name = "mskCartprof"
        Me.mskCartprof.Size = New System.Drawing.Size(120, 20)
        Me.mskCartprof.TabIndex = 8
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Items.AddRange(New Object() {"Atendente", "Caixa", "Gerente"})
        Me.cboCargo.Location = New System.Drawing.Point(107, 30)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(203, 21)
        Me.cboCargo.TabIndex = 7
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Location = New System.Drawing.Point(669, 16)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(99, 13)
        Me.t.TabIndex = 4
        Me.t.Text = "Carteira Profissional"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(315, 32)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(102, 20)
        Me.txtSalario.TabIndex = 5
        '
        'lblExpediente
        '
        Me.lblExpediente.AutoSize = True
        Me.lblExpediente.Location = New System.Drawing.Point(420, 14)
        Me.lblExpediente.Name = "lblExpediente"
        Me.lblExpediente.Size = New System.Drawing.Size(60, 13)
        Me.lblExpediente.TabIndex = 2
        Me.lblExpediente.Text = "Expediente"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(311, 16)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblSalario.TabIndex = 1
        Me.lblSalario.Text = "Salário"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(104, 16)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(35, 13)
        Me.lblCargo.TabIndex = 0
        Me.lblCargo.Text = "Cargo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.SalvarToolStripButton, Me.AlterarToolStripButton, Me.ExcluirToolStripButton, Me.ConsultarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.RecortarToolStripButton, Me.CopiarToolStripButton, Me.ColarToolStripButton, Me.toolStripSeparator1, Me.AjudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 75)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(846, 25)
        Me.ToolStrip1.TabIndex = 67
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
        'mskDnascimento
        '
        Me.mskDnascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mskDnascimento.Location = New System.Drawing.Point(117, 67)
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(106, 20)
        Me.mskDnascimento.TabIndex = 104
        '
        'frmCadFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 537)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tcFuncionario)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        Me.tcFuncionario.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tcFuncionario As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cboUf As System.Windows.Forms.ComboBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbdMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents rbdFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lblDtNasc As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cboExpediente As System.Windows.Forms.ComboBox
    Friend WithEvents cboCargo As System.Windows.Forms.ComboBox
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents lblExpediente As System.Windows.Forms.Label
    Friend WithEvents lblSalario As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents mskCartprof As System.Windows.Forms.MaskedTextBox
    Friend WithEvents t As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents mskCpf As MaskedTextBox
    Friend WithEvents mskRG As MaskedTextBox
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblRg As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents lblMatricula As Label
    Friend WithEvents lstEntidade As ListView
    Friend WithEvents CodEntidade As ColumnHeader
    Friend WithEvents NomeFantasia As ColumnHeader
    Friend WithEvents RazaoSocial As ColumnHeader
    Friend WithEvents DataNasc As ColumnHeader
    Friend WithEvents EstadoCivil As ColumnHeader
    Friend WithEvents Endereco As ColumnHeader
    Friend WithEvents Complemento As ColumnHeader
    Friend WithEvents Bairro As ColumnHeader
    Friend WithEvents Cidade As ColumnHeader
    Friend WithEvents Estado As ColumnHeader
    Friend WithEvents CEP As ColumnHeader
    Friend WithEvents Sexo As ColumnHeader
    Friend WithEvents RG As ColumnHeader
    Friend WithEvents Documento As ColumnHeader
    Friend WithEvents OBS As ColumnHeader
    Friend WithEvents Cadastro As ColumnHeader
    Friend WithEvents Alteracao As ColumnHeader
    Friend WithEvents Inativacao As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mskTel1 As MaskedTextBox
    Friend WithEvents mskTel2 As MaskedTextBox
    Friend WithEvents mskCel As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblTelefone2 As Label
    Friend WithEvents lblCelular As Label
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
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents mskDnascimento As DateTimePicker
End Class
