<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCadClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadClientes))
        Me.tcCliente = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
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
        Me.mskDnascimento = New System.Windows.Forms.DateTimePicker()
        Me.mskrg = New System.Windows.Forms.MaskedTextBox()
        Me.mskCel = New System.Windows.Forms.MaskedTextBox()
        Me.mskcpf = New System.Windows.Forms.MaskedTextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.mskTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.mskTel1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefone1 = New System.Windows.Forms.Label()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.mskCep = New System.Windows.Forms.MaskedTextBox()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbdMasculino = New System.Windows.Forms.RadioButton()
        Me.rbdFeminino = New System.Windows.Forms.RadioButton()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstDependente = New System.Windows.Forms.ListView()
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Parentesco = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mskcpf_dep = New System.Windows.Forms.MaskedTextBox()
        Me.mskdtdatadep = New System.Windows.Forms.MaskedTextBox()
        Me.txtnome_dep = New System.Windows.Forms.TextBox()
        Me.cbopzrentesco = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.mskcpfdep = New System.Windows.Forms.MaskedTextBox()
        Me.mskDnasc = New System.Windows.Forms.MaskedTextBox()
        Me.cboGrauParentesco = New System.Windows.Forms.ComboBox()
        Me.txtNomeDependente = New System.Windows.Forms.TextBox()
        Me.lblGrauParentesco = New System.Windows.Forms.Label()
        Me.lblCpfDependente = New System.Windows.Forms.Label()
        Me.lblDtNascDependente = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ColarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlterarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ConsultarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tcCliente.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcCliente
        '
        Me.tcCliente.Controls.Add(Me.TabPage4)
        Me.tcCliente.Controls.Add(Me.TabPage1)
        Me.tcCliente.Controls.Add(Me.TabPage3)
        Me.tcCliente.Location = New System.Drawing.Point(12, 99)
        Me.tcCliente.Name = "tcCliente"
        Me.tcCliente.SelectedIndex = 0
        Me.tcCliente.Size = New System.Drawing.Size(808, 469)
        Me.tcCliente.TabIndex = 37
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lstEntidade)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(800, 443)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Listagem"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lstEntidade
        '
        Me.lstEntidade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodEntidade, Me.NomeFantasia, Me.RazaoSocial, Me.DataNasc, Me.EstadoCivil, Me.Endereco, Me.Complemento, Me.Bairro, Me.Cidade, Me.Estado, Me.CEP, Me.Sexo, Me.RG, Me.Documento, Me.OBS, Me.Cadastro, Me.Alteracao, Me.Inativacao})
        Me.lstEntidade.FullRowSelect = True
        Me.lstEntidade.HideSelection = False
        Me.lstEntidade.Location = New System.Drawing.Point(6, 6)
        Me.lstEntidade.MultiSelect = False
        Me.lstEntidade.Name = "lstEntidade"
        Me.lstEntidade.Size = New System.Drawing.Size(789, 432)
        Me.lstEntidade.TabIndex = 40
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
        Me.TabPage1.Controls.Add(Me.txtRazaoSocial)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.mskDnascimento)
        Me.TabPage1.Controls.Add(Me.mskrg)
        Me.TabPage1.Controls.Add(Me.mskCel)
        Me.TabPage1.Controls.Add(Me.mskcpf)
        Me.TabPage1.Controls.Add(Me.lblCpf)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.lblRg)
        Me.TabPage1.Controls.Add(Me.mskTel2)
        Me.TabPage1.Controls.Add(Me.mskTel1)
        Me.TabPage1.Controls.Add(Me.lblEmail)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.lblCelular)
        Me.TabPage1.Controls.Add(Me.lblTelefone1)
        Me.TabPage1.Controls.Add(Me.lblTelefone2)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Controls.Add(Me.mskCep)
        Me.TabPage1.Controls.Add(Me.cboUf)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.lblCep)
        Me.TabPage1.Controls.Add(Me.lblUf)
        Me.TabPage1.Controls.Add(Me.lblCidade)
        Me.TabPage1.Controls.Add(Me.cboEstadoCivil)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtComplemento)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.lblBairro)
        Me.TabPage1.Controls.Add(Me.lblComplemento)
        Me.TabPage1.Controls.Add(Me.lblEndereco)
        Me.TabPage1.Controls.Add(Me.lblEstadoCivil)
        Me.TabPage1.Controls.Add(Me.lblDtNasc)
        Me.TabPage1.Controls.Add(Me.lblNome)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Gerais"
        '
        'txtRazaoSocial
        '
        Me.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazaoSocial.Location = New System.Drawing.Point(425, 27)
        Me.txtRazaoSocial.Name = "txtRazaoSocial"
        Me.txtRazaoSocial.Size = New System.Drawing.Size(354, 20)
        Me.txtRazaoSocial.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Razão Social"
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mskDnascimento.Location = New System.Drawing.Point(18, 72)
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(100, 20)
        Me.mskDnascimento.TabIndex = 3
        '
        'mskrg
        '
        Me.mskrg.Location = New System.Drawing.Point(251, 72)
        Me.mskrg.Mask = "00.000.000"
        Me.mskrg.Name = "mskrg"
        Me.mskrg.Size = New System.Drawing.Size(100, 20)
        Me.mskrg.TabIndex = 5
        Me.mskrg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(241, 208)
        Me.mskCel.Mask = "(00)0000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(107, 20)
        Me.mskCel.TabIndex = 16
        Me.mskCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskcpf
        '
        Me.mskcpf.Location = New System.Drawing.Point(357, 73)
        Me.mskcpf.Mask = "000.000.000-00"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.Size = New System.Drawing.Size(100, 20)
        Me.mskcpf.TabIndex = 6
        Me.mskcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(354, 57)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 58
        Me.lblCpf.Text = "CPF"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtObs)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(18, 246)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(761, 178)
        Me.GroupBox5.TabIndex = 66
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OBS"
        '
        'txtObs
        '
        Me.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs.Location = New System.Drawing.Point(6, 15)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(749, 157)
        Me.txtObs.TabIndex = 18
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(248, 57)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 56
        Me.lblRg.Text = "RG"
        '
        'mskTel2
        '
        Me.mskTel2.Location = New System.Drawing.Point(124, 208)
        Me.mskTel2.Mask = "(00)0000-0000"
        Me.mskTel2.Name = "mskTel2"
        Me.mskTel2.Size = New System.Drawing.Size(111, 20)
        Me.mskTel2.TabIndex = 15
        Me.mskTel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskTel1
        '
        Me.mskTel1.Location = New System.Drawing.Point(18, 208)
        Me.mskTel1.Mask = "(00)0000-0000"
        Me.mskTel1.Name = "mskTel1"
        Me.mskTel1.Size = New System.Drawing.Size(100, 20)
        Me.mskTel1.TabIndex = 14
        Me.mskTel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(351, 193)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 62
        Me.lblEmail.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(354, 208)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(329, 20)
        Me.txtEmail.TabIndex = 17
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(238, 193)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 60
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone1
        '
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.Location = New System.Drawing.Point(16, 193)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefone1.TabIndex = 57
        Me.lblTelefone1.Text = "Telefone 1"
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.Location = New System.Drawing.Point(121, 193)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefone2.TabIndex = 59
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(18, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(50, 20)
        Me.lblCodigo.TabIndex = 38
        '
        'mskCep
        '
        Me.mskCep.Location = New System.Drawing.Point(456, 155)
        Me.mskCep.Mask = "00000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(100, 20)
        Me.mskCep.TabIndex = 13
        Me.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'cboUf
        '
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cboUf.Location = New System.Drawing.Point(258, 155)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(192, 21)
        Me.cboUf.TabIndex = 12
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(18, 156)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(234, 20)
        Me.txtCidade.TabIndex = 11
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(453, 138)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 52
        Me.lblCep.Text = "CEP"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(255, 138)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(21, 13)
        Me.lblUf.TabIndex = 51
        Me.lblUf.Text = "UF"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(16, 141)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 50
        Me.lblCidade.Text = "Cidade"
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(124, 72)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadoCivil.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdMasculino)
        Me.GroupBox1.Controls.Add(Me.rbdFeminino)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(475, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 45)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'rbdMasculino
        '
        Me.rbdMasculino.AutoSize = True
        Me.rbdMasculino.Location = New System.Drawing.Point(83, 18)
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
        Me.rbdFeminino.Location = New System.Drawing.Point(6, 19)
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
        Me.txtBairro.Location = New System.Drawing.Point(457, 115)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(322, 20)
        Me.txtBairro.TabIndex = 10
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(382, 115)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(69, 20)
        Me.txtComplemento.TabIndex = 9
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(18, 115)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(359, 20)
        Me.txtEndereco.TabIndex = 8
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(74, 27)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(345, 20)
        Me.txtNome.TabIndex = 1
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(454, 98)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 41
        Me.lblBairro.Text = "Bairro"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(380, 98)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(44, 13)
        Me.lblComplemento.TabIndex = 40
        Me.lblComplemento.Text = "Número"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(16, 98)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 39
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(121, 56)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lblEstadoCivil.TabIndex = 38
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(14, 56)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(104, 13)
        Me.lblDtNasc.TabIndex = 37
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(71, 11)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 36
        Me.lblNome.Text = "Nome"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.lstDependente)
        Me.TabPage3.Controls.Add(Me.mskcpf_dep)
        Me.TabPage3.Controls.Add(Me.mskdtdatadep)
        Me.TabPage3.Controls.Add(Me.txtnome_dep)
        Me.TabPage3.Controls.Add(Me.cbopzrentesco)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.btnAdicionar)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(800, 443)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dependentes"
        '
        'lstDependente
        '
        Me.lstDependente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.codigo, Me.nome, Me.Parentesco})
        Me.lstDependente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDependente.HideSelection = False
        Me.lstDependente.Location = New System.Drawing.Point(17, 52)
        Me.lstDependente.Name = "lstDependente"
        Me.lstDependente.Size = New System.Drawing.Size(766, 372)
        Me.lstDependente.TabIndex = 45
        Me.lstDependente.UseCompatibleStateImageBehavior = False
        Me.lstDependente.View = System.Windows.Forms.View.Details
        '
        'codigo
        '
        Me.codigo.Text = "Código"
        Me.codigo.Width = 100
        '
        'nome
        '
        Me.nome.Text = "Nome"
        Me.nome.Width = 150
        '
        'Parentesco
        '
        Me.Parentesco.Text = "Parentesco"
        Me.Parentesco.Width = 120
        '
        'mskcpf_dep
        '
        Me.mskcpf_dep.Location = New System.Drawing.Point(423, 25)
        Me.mskcpf_dep.Mask = "000.000.000-00"
        Me.mskcpf_dep.Name = "mskcpf_dep"
        Me.mskcpf_dep.Size = New System.Drawing.Size(100, 20)
        Me.mskcpf_dep.TabIndex = 21
        '
        'mskdtdatadep
        '
        Me.mskdtdatadep.Location = New System.Drawing.Point(347, 25)
        Me.mskdtdatadep.Mask = "00/00/0000"
        Me.mskdtdatadep.Name = "mskdtdatadep"
        Me.mskdtdatadep.Size = New System.Drawing.Size(70, 20)
        Me.mskdtdatadep.TabIndex = 20
        Me.mskdtdatadep.ValidatingType = GetType(Date)
        '
        'txtnome_dep
        '
        Me.txtnome_dep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnome_dep.Location = New System.Drawing.Point(18, 25)
        Me.txtnome_dep.Name = "txtnome_dep"
        Me.txtnome_dep.Size = New System.Drawing.Size(323, 20)
        Me.txtnome_dep.TabIndex = 19
        '
        'cbopzrentesco
        '
        Me.cbopzrentesco.FormattingEnabled = True
        Me.cbopzrentesco.Location = New System.Drawing.Point(529, 25)
        Me.cbopzrentesco.Name = "cbopzrentesco"
        Me.cbopzrentesco.Size = New System.Drawing.Size(121, 21)
        Me.cbopzrentesco.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nascimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(526, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Parentesco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.Location = New System.Drawing.Point(708, 22)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(61, 25)
        Me.btnAdicionar.TabIndex = 40
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'mskcpfdep
        '
        Me.mskcpfdep.Location = New System.Drawing.Point(151, 88)
        Me.mskcpfdep.Mask = "000.000.000-00"
        Me.mskcpfdep.Name = "mskcpfdep"
        Me.mskcpfdep.Size = New System.Drawing.Size(100, 20)
        Me.mskcpfdep.TabIndex = 37
        '
        'mskDnasc
        '
        Me.mskDnasc.Location = New System.Drawing.Point(16, 88)
        Me.mskDnasc.Mask = "00/00/0000"
        Me.mskDnasc.Name = "mskDnasc"
        Me.mskDnasc.Size = New System.Drawing.Size(100, 20)
        Me.mskDnasc.TabIndex = 36
        Me.mskDnasc.ValidatingType = GetType(Date)
        '
        'cboGrauParentesco
        '
        Me.cboGrauParentesco.FormattingEnabled = True
        Me.cboGrauParentesco.Items.AddRange(New Object() {"Conjuge", "Filho(a)", "Mãe", "Pai", "Outros"})
        Me.cboGrauParentesco.Location = New System.Drawing.Point(262, 85)
        Me.cboGrauParentesco.Name = "cboGrauParentesco"
        Me.cboGrauParentesco.Size = New System.Drawing.Size(121, 21)
        Me.cboGrauParentesco.TabIndex = 7
        '
        'txtNomeDependente
        '
        Me.txtNomeDependente.Location = New System.Drawing.Point(17, 44)
        Me.txtNomeDependente.Name = "txtNomeDependente"
        Me.txtNomeDependente.Size = New System.Drawing.Size(366, 20)
        Me.txtNomeDependente.TabIndex = 4
        '
        'lblGrauParentesco
        '
        Me.lblGrauParentesco.AutoSize = True
        Me.lblGrauParentesco.Location = New System.Drawing.Point(259, 72)
        Me.lblGrauParentesco.Name = "lblGrauParentesco"
        Me.lblGrauParentesco.Size = New System.Drawing.Size(61, 13)
        Me.lblGrauParentesco.TabIndex = 3
        Me.lblGrauParentesco.Text = "Parentesco"
        '
        'lblCpfDependente
        '
        Me.lblCpfDependente.AutoSize = True
        Me.lblCpfDependente.Location = New System.Drawing.Point(148, 72)
        Me.lblCpfDependente.Name = "lblCpfDependente"
        Me.lblCpfDependente.Size = New System.Drawing.Size(27, 13)
        Me.lblCpfDependente.TabIndex = 2
        Me.lblCpfDependente.Text = "CPF"
        '
        'lblDtNascDependente
        '
        Me.lblDtNascDependente.AutoSize = True
        Me.lblDtNascDependente.Location = New System.Drawing.Point(14, 72)
        Me.lblDtNascDependente.Name = "lblDtNascDependente"
        Me.lblDtNascDependente.Size = New System.Drawing.Size(104, 13)
        Me.lblDtNascDependente.TabIndex = 1
        Me.lblDtNascDependente.Text = "Data de Nascimento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Nome"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 71)
        Me.Panel1.TabIndex = 0
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.SalvarToolStripButton, Me.AlterarToolStripButton, Me.ExcluirToolStripButton, Me.ConsultarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.RecortarToolStripButton, Me.CopiarToolStripButton, Me.ColarToolStripButton, Me.toolStripSeparator1, Me.AjudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 71)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(832, 25)
        Me.ToolStrip1.TabIndex = 38
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
        'frmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 580)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tcCliente)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.tcCliente.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcCliente As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents mskCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboUf As System.Windows.Forms.ComboBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents cboEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbdMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents rbdFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lblDtNasc As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents mskcpf_dep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskdtdatadep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtnome_dep As System.Windows.Forms.TextBox
    Friend WithEvents cbopzrentesco As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mskcpfdep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskDnasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboGrauParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents txtNomeDependente As System.Windows.Forms.TextBox
    Friend WithEvents lblGrauParentesco As System.Windows.Forms.Label
    Friend WithEvents lblCpfDependente As System.Windows.Forms.Label
    Friend WithEvents lblDtNascDependente As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents TabPage4 As TabPage
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
    Friend WithEvents lstDependente As ListView
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents nome As ColumnHeader
    Friend WithEvents Parentesco As ColumnHeader
    Friend WithEvents mskrg As MaskedTextBox
    Friend WithEvents mskCel As MaskedTextBox
    Friend WithEvents mskcpf As MaskedTextBox
    Friend WithEvents lblCpf As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents lblRg As Label
    Friend WithEvents mskTel2 As MaskedTextBox
    Friend WithEvents mskTel1 As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblTelefone1 As Label
    Friend WithEvents lblTelefone2 As Label
    Friend WithEvents mskDnascimento As DateTimePicker
    Friend WithEvents txtRazaoSocial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents RecortarToolStripButton As ToolStripButton
    Friend WithEvents CopiarToolStripButton As ToolStripButton
    Friend WithEvents ColarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AjudaToolStripButton As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents SalvarToolStripButton As ToolStripButton
    Friend WithEvents AlterarToolStripButton As ToolStripButton
    Friend WithEvents ExcluirToolStripButton As ToolStripButton
    Friend WithEvents ConsultarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
End Class
