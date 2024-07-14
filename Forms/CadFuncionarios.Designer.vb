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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
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
        Me.GroupBox2.Location = New System.Drawing.Point(122, 522)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(577, 80)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(462, 17)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(106, 54)
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
        Me.btnExcluir.Location = New System.Drawing.Point(347, 17)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(106, 54)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(6, 16)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(106, 55)
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
        Me.btnSalvar.Location = New System.Drawing.Point(232, 17)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(106, 54)
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
        Me.btnNovo.Location = New System.Drawing.Point(119, 17)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(106, 54)
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 75)
        Me.Panel1.TabIndex = 33
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmcodfunc, Me.clmmatricula, Me.clmnome, Me.clmdtnasc, Me.clmsexo, Me.clmtelefone1, Me.clmcelular, Me.clmrg, Me.clmcpf, Me.clmcargo})
        Me.lstgrade.FullRowSelect = True
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(20, 333)
        Me.lstgrade.MultiSelect = False
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(809, 185)
        Me.lstgrade.TabIndex = 63
        Me.lstgrade.Tag = "0"
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
        Me.TabControl1.Location = New System.Drawing.Point(20, 91)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(808, 236)
        Me.TabControl1.TabIndex = 66
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.lblCodigo)
        Me.TabPage1.Controls.Add(Me.cboUf)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.lblUf)
        Me.TabPage1.Controls.Add(Me.lblCidade)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage1.Size = New System.Drawing.Size(800, 227)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cadastro Pessoal"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(20, 26)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(74, 18)
        Me.lblCodigo.TabIndex = 89
        '
        'cboUf
        '
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cboUf.Location = New System.Drawing.Point(350, 163)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(68, 21)
        Me.cboUf.TabIndex = 88
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(21, 163)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(317, 20)
        Me.txtCidade.TabIndex = 87
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(347, 147)
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
        Me.mskCep.Location = New System.Drawing.Point(657, 116)
        Me.mskCep.Mask = "00000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(79, 20)
        Me.mskCep.TabIndex = 82
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"Solteiro(a)", "Casado(a)", "Divorsiado(a)", "Viuvo(a)"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(22, 67)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(89, 21)
        Me.cboEstadoCivil.TabIndex = 81
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Location = New System.Drawing.Point(123, 67)
        Me.mskDnascimento.Mask = "00/00/0000"
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(100, 20)
        Me.mskDnascimento.TabIndex = 80
        Me.mskDnascimento.ValidatingType = GetType(Date)
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbdMasculino)
        Me.GroupBox6.Controls.Add(Me.rbdFeminino)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(242, 51)
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
        Me.txtBairro.Location = New System.Drawing.Point(434, 116)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(200, 20)
        Me.txtBairro.TabIndex = 78
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(351, 116)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(68, 20)
        Me.txtComplemento.TabIndex = 77
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(22, 116)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(317, 20)
        Me.txtEndereco.TabIndex = 76
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(194, 26)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(425, 20)
        Me.txtNome.TabIndex = 75
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(104, 26)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(85, 20)
        Me.txtMatricula.TabIndex = 74
        Me.txtMatricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(655, 100)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 73
        Me.lblCep.Text = "CEP"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(431, 100)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 72
        Me.lblBairro.Text = "Bairro"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(348, 100)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(71, 13)
        Me.lblComplemento.TabIndex = 71
        Me.lblComplemento.Text = "Complemento"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(19, 100)
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
        Me.lblDtNasc.Location = New System.Drawing.Point(120, 50)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(104, 13)
        Me.lblDtNasc.TabIndex = 68
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(191, 10)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 67
        Me.lblNome.Text = "Nome"
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(102, 8)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(52, 13)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage2.Size = New System.Drawing.Size(800, 210)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cadastro do Empregador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Observações:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Telefone1"
        '
        'mskTel1
        '
        Me.mskTel1.Location = New System.Drawing.Point(18, 20)
        Me.mskTel1.Mask = "(99) 000-0000"
        Me.mskTel1.Name = "mskTel1"
        Me.mskTel1.Size = New System.Drawing.Size(88, 20)
        Me.mskTel1.TabIndex = 8
        '
        'mskTel2
        '
        Me.mskTel2.Location = New System.Drawing.Point(111, 20)
        Me.mskTel2.Mask = "(99) 000-0000"
        Me.mskTel2.Name = "mskTel2"
        Me.mskTel2.Size = New System.Drawing.Size(87, 20)
        Me.mskTel2.TabIndex = 9
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(422, 22)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(347, 174)
        Me.txtObs.TabIndex = 0
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(240, 20)
        Me.mskCel.Mask = "(99) 000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(81, 20)
        Me.mskCel.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(18, 62)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(329, 20)
        Me.txtEmail.TabIndex = 6
        '
        'mskCpf
        '
        Me.mskCpf.Location = New System.Drawing.Point(133, 176)
        Me.mskCpf.Mask = "000.000.000-00"
        Me.mskCpf.Name = "mskCpf"
        Me.mskCpf.Size = New System.Drawing.Size(100, 20)
        Me.mskCpf.TabIndex = 42
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.Location = New System.Drawing.Point(108, 6)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefone2.TabIndex = 1
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'cboExpediente
        '
        Me.cboExpediente.FormattingEnabled = True
        Me.cboExpediente.Items.AddRange(New Object() {"Diurno", "Noturno"})
        Me.cboExpediente.Location = New System.Drawing.Point(18, 137)
        Me.cboExpediente.Name = "cboExpediente"
        Me.cboExpediente.Size = New System.Drawing.Size(108, 21)
        Me.cboExpediente.TabIndex = 8
        '
        'mskRG
        '
        Me.mskRG.Location = New System.Drawing.Point(18, 176)
        Me.mskRG.Mask = "00-000.000"
        Me.mskRG.Name = "mskRG"
        Me.mskRG.Size = New System.Drawing.Size(100, 20)
        Me.mskRG.TabIndex = 43
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(237, 6)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 2
        Me.lblCelular.Text = "Celular"
        '
        'mskCartprof
        '
        Me.mskCartprof.Location = New System.Drawing.Point(249, 176)
        Me.mskCartprof.Mask = "000-00-0000"
        Me.mskCartprof.Name = "mskCartprof"
        Me.mskCartprof.Size = New System.Drawing.Size(120, 20)
        Me.mskCartprof.TabIndex = 8
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Items.AddRange(New Object() {"Atendente", "Caixa", "Gerente"})
        Me.cboCargo.Location = New System.Drawing.Point(18, 97)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(165, 21)
        Me.cboCargo.TabIndex = 7
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Location = New System.Drawing.Point(249, 161)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(99, 13)
        Me.t.TabIndex = 4
        Me.t.Text = "Carteira Profissional"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(226, 98)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(98, 20)
        Me.txtSalario.TabIndex = 5
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(129, 161)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 1
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(15, 161)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 0
        Me.lblRg.Text = "RG"
        '
        'lblExpediente
        '
        Me.lblExpediente.AutoSize = True
        Me.lblExpediente.Location = New System.Drawing.Point(15, 121)
        Me.lblExpediente.Name = "lblExpediente"
        Me.lblExpediente.Size = New System.Drawing.Size(60, 13)
        Me.lblExpediente.TabIndex = 2
        Me.lblExpediente.Text = "Expediente"
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(222, 83)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(39, 13)
        Me.lblSalario.TabIndex = 1
        Me.lblSalario.Text = "Salário"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(14, 83)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(35, 13)
        Me.lblCargo.TabIndex = 0
        Me.lblCargo.Text = "Cargo"
        '
        'frmCadFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 612)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lstgrade)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents lblCodigo As Label
End Class
