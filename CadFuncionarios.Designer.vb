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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.clmcodfunc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmmatricula = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmnome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmdtnasc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmsexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmtelefone1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmcelular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmrg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmcpf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmcargo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mskCep = New System.Windows.Forms.MaskedTextBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.mskDnascimento = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbdMasculino = New System.Windows.Forms.RadioButton()
        Me.rbdFeminino = New System.Windows.Forms.RadioButton()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskTel1 = New System.Windows.Forms.MaskedTextBox()
        Me.mskTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.mskCel = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.lblTelefone2 = New System.Windows.Forms.Label()
        Me.cboExpediente = New System.Windows.Forms.ComboBox()
        Me.mskRG = New System.Windows.Forms.MaskedTextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.mskCartprof = New System.Windows.Forms.MaskedTextBox()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.t = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.lblExpediente = New System.Windows.Forms.Label()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSair)
        Me.GroupBox2.Controls.Add(Me.btnExcluir)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnSalvar)
        Me.GroupBox2.Controls.Add(Me.btnNovo)
        Me.GroupBox2.Location = New System.Drawing.Point(162, 642)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(769, 98)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(616, 23)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 55)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "&Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.shell32_033
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(463, 23)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(141, 55)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        Me.btnExcluir.Visible = False
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(8, 23)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(141, 55)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "C&onsultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.Location = New System.Drawing.Point(309, 23)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(141, 55)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "S&alvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.Location = New System.Drawing.Point(159, 25)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(141, 55)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 92)
        Me.Panel1.TabIndex = 33
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmcodfunc, Me.clmmatricula, Me.clmnome, Me.clmdtnasc, Me.clmsexo, Me.clmtelefone1, Me.clmcelular, Me.clmrg, Me.clmcpf, Me.clmcargo})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(26, 460)
        Me.lstgrade.Margin = New System.Windows.Forms.Padding(4)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(1077, 176)
        Me.lstgrade.TabIndex = 63
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'clmcodfunc
        '
        Me.clmcodfunc.Text = "Código"
        Me.clmcodfunc.Width = 48
        '
        'clmmatricula
        '
        Me.clmmatricula.Text = "Matricula"
        '
        'clmnome
        '
        Me.clmnome.Text = "Nome"
        Me.clmnome.Width = 137
        '
        'clmdtnasc
        '
        Me.clmdtnasc.Text = "Data Nascimento"
        Me.clmdtnasc.Width = 98
        '
        'clmsexo
        '
        Me.clmsexo.Text = "Sexo"
        Me.clmsexo.Width = 71
        '
        'clmtelefone1
        '
        Me.clmtelefone1.Text = "Telefone"
        Me.clmtelefone1.Width = 82
        '
        'clmcelular
        '
        Me.clmcelular.Text = "Celular"
        Me.clmcelular.Width = 80
        '
        'clmrg
        '
        Me.clmrg.Text = "Rg"
        Me.clmrg.Width = 61
        '
        'clmcpf
        '
        Me.clmcpf.Text = "Cpf"
        Me.clmcpf.Width = 77
        '
        'clmcargo
        '
        Me.clmcargo.Text = "Cargo"
        Me.clmcargo.Width = 76
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(26, 112)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1077, 341)
        Me.TabControl1.TabIndex = 66
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.cboUf)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.lblUf)
        Me.TabPage1.Controls.Add(Me.lblCidade)
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.mskCep)
        Me.TabPage1.Controls.Add(Me.cboEstadoCivil)
        Me.TabPage1.Controls.Add(Me.mskDnascimento)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.txtBairro)
        Me.TabPage1.Controls.Add(Me.txtComplemento)
        Me.TabPage1.Controls.Add(Me.txtEndereco)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.txtMatricula)
        Me.TabPage1.Controls.Add(Me.lblCep)
        Me.TabPage1.Controls.Add(Me.lblBairro)
        Me.TabPage1.Controls.Add(Me.lblComplemento)
        Me.TabPage1.Controls.Add(Me.lblEndereco)
        Me.TabPage1.Controls.Add(Me.lblEstadoCivil)
        Me.TabPage1.Controls.Add(Me.lblDtNasc)
        Me.TabPage1.Controls.Add(Me.lblNome)
        Me.TabPage1.Controls.Add(Me.lblMatricula)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1069, 312)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro Pessoal"
        '
        'cboUf
        '
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cboUf.Location = New System.Drawing.Point(467, 201)
        Me.cboUf.Margin = New System.Windows.Forms.Padding(4)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(89, 24)
        Me.cboUf.TabIndex = 88
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(28, 201)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(421, 22)
        Me.txtCidade.TabIndex = 87
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(463, 181)
        Me.lblUf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(25, 16)
        Me.lblUf.TabIndex = 86
        Me.lblUf.Text = "UF"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(24, 181)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(51, 16)
        Me.lblCidade.TabIndex = 85
        Me.lblCidade.Text = "Cidade"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(27, 32)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(104, 22)
        Me.txtCodigo.TabIndex = 84
        Me.txtCodigo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Código "
        Me.Label1.Visible = False
        '
        'mskCep
        '
        Me.mskCep.Location = New System.Drawing.Point(876, 143)
        Me.mskCep.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCep.Mask = "00000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(104, 22)
        Me.mskCep.TabIndex = 82
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"Solteiro(a)", "Casado(a)", "Divorsiado(a)", "Viuvo(a)"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(29, 82)
        Me.cboEstadoCivil.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(117, 24)
        Me.cboEstadoCivil.TabIndex = 81
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Location = New System.Drawing.Point(164, 82)
        Me.mskDnascimento.Margin = New System.Windows.Forms.Padding(4)
        Me.mskDnascimento.Mask = "00/00/0000"
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(132, 22)
        Me.mskDnascimento.TabIndex = 80
        Me.mskDnascimento.ValidatingType = GetType(Date)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbdMasculino)
        Me.GroupBox6.Controls.Add(Me.rbdFeminino)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(323, 63)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(216, 59)
        Me.GroupBox6.TabIndex = 79
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sexo"
        '
        'rbdMasculino
        '
        Me.rbdMasculino.AutoSize = True
        Me.rbdMasculino.Location = New System.Drawing.Point(107, 23)
        Me.rbdMasculino.Margin = New System.Windows.Forms.Padding(4)
        Me.rbdMasculino.Name = "rbdMasculino"
        Me.rbdMasculino.Size = New System.Drawing.Size(89, 20)
        Me.rbdMasculino.TabIndex = 27
        Me.rbdMasculino.TabStop = True
        Me.rbdMasculino.Text = "Masculino"
        Me.rbdMasculino.UseVisualStyleBackColor = True
        '
        'rbdFeminino
        '
        Me.rbdFeminino.AutoSize = True
        Me.rbdFeminino.Location = New System.Drawing.Point(12, 23)
        Me.rbdFeminino.Margin = New System.Windows.Forms.Padding(4)
        Me.rbdFeminino.Name = "rbdFeminino"
        Me.rbdFeminino.Size = New System.Drawing.Size(83, 20)
        Me.rbdFeminino.TabIndex = 26
        Me.rbdFeminino.TabStop = True
        Me.rbdFeminino.Text = "Feminino"
        Me.rbdFeminino.UseVisualStyleBackColor = True
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(579, 143)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(265, 22)
        Me.txtBairro.TabIndex = 78
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(468, 143)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(89, 22)
        Me.txtComplemento.TabIndex = 77
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(29, 143)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(421, 22)
        Me.txtEndereco.TabIndex = 76
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(259, 32)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(565, 22)
        Me.txtNome.TabIndex = 75
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(139, 32)
        Me.txtMatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(112, 22)
        Me.txtMatricula.TabIndex = 74
        Me.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(873, 123)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 16)
        Me.lblCep.TabIndex = 73
        Me.lblCep.Text = "CEP"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(575, 123)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 16)
        Me.lblBairro.TabIndex = 72
        Me.lblBairro.Text = "Bairro"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(464, 123)
        Me.lblComplemento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(91, 16)
        Me.lblComplemento.TabIndex = 71
        Me.lblComplemento.Text = "Complemento"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(25, 123)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(66, 16)
        Me.lblEndereco.TabIndex = 70
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(25, 63)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(78, 16)
        Me.lblEstadoCivil.TabIndex = 69
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(160, 62)
        Me.lblDtNasc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(130, 16)
        Me.lblDtNasc.TabIndex = 68
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(255, 12)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
        Me.lblNome.TabIndex = 67
        Me.lblNome.Text = "Nome"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(136, 10)
        Me.lblMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(61, 16)
        Me.lblMatricula.TabIndex = 66
        Me.lblMatricula.Text = "Matrícula"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.mskTel1)
        Me.TabPage2.Controls.Add(Me.mskTel2)
        Me.TabPage2.Controls.Add(Me.txtObs)
        Me.TabPage2.Controls.Add(Me.mskCel)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.mskCpf)
        Me.TabPage2.Controls.Add(Me.lblTelefone2)
        Me.TabPage2.Controls.Add(Me.cboExpediente)
        Me.TabPage2.Controls.Add(Me.mskRG)
        Me.TabPage2.Controls.Add(Me.lblCelular)
        Me.TabPage2.Controls.Add(Me.mskCartprof)
        Me.TabPage2.Controls.Add(Me.cboCargo)
        Me.TabPage2.Controls.Add(Me.t)
        Me.TabPage2.Controls.Add(Me.txtSalario)
        Me.TabPage2.Controls.Add(Me.lblCpf)
        Me.TabPage2.Controls.Add(Me.lblRg)
        Me.TabPage2.Controls.Add(Me.lblExpediente)
        Me.TabPage2.Controls.Add(Me.lblSalario)
        Me.TabPage2.Controls.Add(Me.lblCargo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1069, 312)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro do Empregador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(560, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Observações:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Telefone1"
        '
        'mskTel1
        '
        Me.mskTel1.Location = New System.Drawing.Point(24, 25)
        Me.mskTel1.Margin = New System.Windows.Forms.Padding(4)
        Me.mskTel1.Mask = "(99) 000-0000"
        Me.mskTel1.Name = "mskTel1"
        Me.mskTel1.Size = New System.Drawing.Size(116, 22)
        Me.mskTel1.TabIndex = 8
        '
        'mskTel2
        '
        Me.mskTel2.Location = New System.Drawing.Point(148, 25)
        Me.mskTel2.Margin = New System.Windows.Forms.Padding(4)
        Me.mskTel2.Mask = "(99) 000-0000"
        Me.mskTel2.Name = "mskTel2"
        Me.mskTel2.Size = New System.Drawing.Size(115, 22)
        Me.mskTel2.TabIndex = 9
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(563, 27)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(461, 277)
        Me.txtObs.TabIndex = 0
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(320, 25)
        Me.mskCel.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCel.Mask = "(99) 000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(107, 22)
        Me.mskCel.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(24, 76)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(437, 22)
        Me.txtEmail.TabIndex = 6
        '
        'mskCpf
        '
        Me.mskCpf.Location = New System.Drawing.Point(178, 232)
        Me.mskCpf.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCpf.Mask = "000.000.000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(132, 22)
        Me.mskCpf.TabIndex = 42
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.Location = New System.Drawing.Point(144, 7)
        Me.lblTelefone2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(71, 16)
        Me.lblTelefone2.TabIndex = 1
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'cboExpediente
        '
        Me.cboExpediente.FormattingEnabled = True
        Me.cboExpediente.Items.AddRange(New Object() {"Diurno", "Noturno"})
        Me.cboExpediente.Location = New System.Drawing.Point(24, 169)
        Me.cboExpediente.Margin = New System.Windows.Forms.Padding(4)
        Me.cboExpediente.Name = "cboExpediente"
        Me.cboExpediente.Size = New System.Drawing.Size(143, 24)
        Me.cboExpediente.TabIndex = 8
        '
        'mskRG
        '
        Me.mskRG.Location = New System.Drawing.Point(25, 232)
        Me.mskRG.Margin = New System.Windows.Forms.Padding(4)
        Me.mskRG.Mask = "00-000.000"
        Me.mskRG.Name = "mskRG"
        Me.mskRG.Size = New System.Drawing.Size(132, 22)
        Me.mskRG.TabIndex = 43
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(316, 7)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(49, 16)
        Me.lblCelular.TabIndex = 2
        Me.lblCelular.Text = "Celular"
        '
        'mskCartprof
        '
        Me.mskCartprof.Location = New System.Drawing.Point(334, 232)
        Me.mskCartprof.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCartprof.Mask = "000-00-0000"
        Me.mskCartprof.Name = "mskCartprof"
        Me.mskCartprof.Size = New System.Drawing.Size(159, 22)
        Me.mskCartprof.TabIndex = 8
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Items.AddRange(New Object() {"Atendente", "Caixa", "Gerente"})
        Me.cboCargo.Location = New System.Drawing.Point(24, 119)
        Me.cboCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(219, 24)
        Me.cboCargo.TabIndex = 7
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Location = New System.Drawing.Point(333, 213)
        Me.t.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(127, 16)
        Me.t.TabIndex = 4
        Me.t.Text = "Carteira Profissional"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(301, 120)
        Me.txtSalario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(129, 22)
        Me.txtSalario.TabIndex = 5
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(174, 213)
        Me.lblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 16)
        Me.lblCpf.TabIndex = 1
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(21, 213)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(27, 16)
        Me.lblRg.TabIndex = 0
        Me.lblRg.Text = "RG"
        '
        'lblExpediente
        '
        Me.lblExpediente.AutoSize = True
        Me.lblExpediente.Location = New System.Drawing.Point(20, 149)
        Me.lblExpediente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpediente.Name = "lblExpediente"
        Me.lblExpediente.Size = New System.Drawing.Size(75, 16)
        Me.lblExpediente.TabIndex = 2
        Me.lblExpediente.Text = "Expediente"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(296, 102)
        Me.lblSalario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(50, 16)
        Me.lblSalario.TabIndex = 1
        Me.lblSalario.Text = "Salário"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(18, 102)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(44, 16)
        Me.lblCargo.TabIndex = 0
        Me.lblCargo.Text = "Cargo"
        '
        'frmCadFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 753)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lstgrade)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCadFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents clmcodfunc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmmatricula As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmnome As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmdtnasc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmsexo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmtelefone1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmcelular As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmrg As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmcpf As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmcargo As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cboUf As System.Windows.Forms.ComboBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mskCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents mskDnascimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbdMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents rbdFeminino As System.Windows.Forms.RadioButton
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblEstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lblDtNasc As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
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
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents mskCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTel2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTel1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefone2 As System.Windows.Forms.Label
    Friend WithEvents mskCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskRG As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
