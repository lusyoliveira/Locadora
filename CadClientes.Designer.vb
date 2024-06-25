<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadClientes))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.lstgrade = New System.Windows.Forms.ListView
        Me.clmcodigo = New System.Windows.Forms.ColumnHeader
        Me.clmnome = New System.Windows.Forms.ColumnHeader
        Me.clmdtnasc = New System.Windows.Forms.ColumnHeader
        Me.clmtelefone1 = New System.Windows.Forms.ColumnHeader
        Me.clmemail = New System.Windows.Forms.ColumnHeader
        Me.clmrg = New System.Windows.Forms.ColumnHeader
        Me.clmcpf = New System.Windows.Forms.ColumnHeader
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.mskCep = New System.Windows.Forms.MaskedTextBox
        Me.cboUf = New System.Windows.Forms.ComboBox
        Me.txtCidade = New System.Windows.Forms.TextBox
        Me.lblCep = New System.Windows.Forms.Label
        Me.lblUf = New System.Windows.Forms.Label
        Me.lblCidade = New System.Windows.Forms.Label
        Me.mskDnascimento = New System.Windows.Forms.MaskedTextBox
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbdMasculino = New System.Windows.Forms.RadioButton
        Me.rbdFeminino = New System.Windows.Forms.RadioButton
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.txtComplemento = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.lblBairro = New System.Windows.Forms.Label
        Me.lblComplemento = New System.Windows.Forms.Label
        Me.lblEndereco = New System.Windows.Forms.Label
        Me.lblEstadoCivil = New System.Windows.Forms.Label
        Me.lblDtNasc = New System.Windows.Forms.Label
        Me.lblNome = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.mskrg = New System.Windows.Forms.MaskedTextBox
        Me.mskCel = New System.Windows.Forms.MaskedTextBox
        Me.mskcpf = New System.Windows.Forms.MaskedTextBox
        Me.lblCpf = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtObs = New System.Windows.Forms.TextBox
        Me.lblRg = New System.Windows.Forms.Label
        Me.mskTel2 = New System.Windows.Forms.MaskedTextBox
        Me.mskTel1 = New System.Windows.Forms.MaskedTextBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.lblCelular = New System.Windows.Forms.Label
        Me.lblTelefone1 = New System.Windows.Forms.Label
        Me.lblTelefone2 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtextra = New System.Windows.Forms.TextBox
        Me.mskcpf_dep = New System.Windows.Forms.MaskedTextBox
        Me.mskdtdatadep = New System.Windows.Forms.MaskedTextBox
        Me.txtnome_dep = New System.Windows.Forms.TextBox
        Me.cbopzrentesco = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.mskcpfdep = New System.Windows.Forms.MaskedTextBox
        Me.mskDnasc = New System.Windows.Forms.MaskedTextBox
        Me.cboGrauParentesco = New System.Windows.Forms.ComboBox
        Me.txtNomeDependente = New System.Windows.Forms.TextBox
        Me.lblGrauParentesco = New System.Windows.Forms.Label
        Me.lblCpfDependente = New System.Windows.Forms.Label
        Me.lblDtNascDependente = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 71)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnSair)
        Me.GroupBox6.Controls.Add(Me.btnExcluir)
        Me.GroupBox6.Controls.Add(Me.btnConsultar)
        Me.GroupBox6.Controls.Add(Me.btnSalvar)
        Me.GroupBox6.Controls.Add(Me.btnNovo)
        Me.GroupBox6.Location = New System.Drawing.Point(26, 503)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(585, 80)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(456, 19)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(106, 45)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "&Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.Projeto_Locadora.My.Resources.Resources.trash
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(344, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(106, 45)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.UseVisualStyleBackColor = True
        Me.btnExcluir.Visible = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Projeto_Locadora.My.Resources.Resources.binoculars
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(8, 19)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(106, 45)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "C&onsultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.Projeto_Locadora.My.Resources.Resources.external_hd
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.Location = New System.Drawing.Point(232, 19)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(106, 45)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "S&alvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = Global.Projeto_Locadora.My.Resources.Resources.document
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.Location = New System.Drawing.Point(120, 19)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(106, 45)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmcodigo, Me.clmnome, Me.clmdtnasc, Me.clmtelefone1, Me.clmemail, Me.clmrg, Me.clmcpf})
        Me.lstgrade.FullRowSelect = True
        Me.lstgrade.Location = New System.Drawing.Point(26, 344)
        Me.lstgrade.MultiSelect = False
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(809, 153)
        Me.lstgrade.TabIndex = 36
        Me.lstgrade.Tag = "0"
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'clmcodigo
        '
        Me.clmcodigo.Text = "Código"
        Me.clmcodigo.Width = 48
        '
        'clmnome
        '
        Me.clmnome.Text = "Nome"
        Me.clmnome.Width = 177
        '
        'clmdtnasc
        '
        Me.clmdtnasc.Text = "Data Nascimento"
        Me.clmdtnasc.Width = 100
        '
        'clmtelefone1
        '
        Me.clmtelefone1.Text = "Telefone"
        Me.clmtelefone1.Width = 91
        '
        'clmemail
        '
        Me.clmemail.Text = "Email"
        Me.clmemail.Width = 161
        '
        'clmrg
        '
        Me.clmrg.Text = "Rg"
        Me.clmrg.Width = 100
        '
        'clmcpf
        '
        Me.clmcpf.Text = "Cpf"
        Me.clmcpf.Width = 99
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(26, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(809, 242)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.mskCep)
        Me.TabPage1.Controls.Add(Me.cboUf)
        Me.TabPage1.Controls.Add(Me.txtCidade)
        Me.TabPage1.Controls.Add(Me.lblCep)
        Me.TabPage1.Controls.Add(Me.lblUf)
        Me.TabPage1.Controls.Add(Me.lblCidade)
        Me.TabPage1.Controls.Add(Me.mskDnascimento)
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
        Me.TabPage1.Size = New System.Drawing.Size(801, 216)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Gerais"
        '
        'mskCep
        '
        Me.mskCep.Location = New System.Drawing.Point(350, 155)
        Me.mskCep.Mask = "00000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(100, 20)
        Me.mskCep.TabIndex = 54
        '
        'cboUf
        '
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cboUf.Location = New System.Drawing.Point(275, 156)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(61, 21)
        Me.cboUf.TabIndex = 49
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(22, 157)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(232, 20)
        Me.txtCidade.TabIndex = 53
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(347, 142)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 52
        Me.lblCep.Text = "CEP"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(272, 142)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(21, 13)
        Me.lblUf.TabIndex = 51
        Me.lblUf.Text = "UF"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(19, 141)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 50
        Me.lblCidade.Text = "Cidade"
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Location = New System.Drawing.Point(339, 44)
        Me.mskDnascimento.Mask = "00/00/0000"
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(100, 20)
        Me.mskDnascimento.TabIndex = 48
        Me.mskDnascimento.ValidatingType = GetType(Date)
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"Solteiro(a)", "Casado(a)", "Divorsiado(a)", "Viuvo(a)"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(466, 42)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.cboEstadoCivil.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdMasculino)
        Me.GroupBox1.Controls.Add(Me.rbdFeminino)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(611, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 45)
        Me.GroupBox1.TabIndex = 46
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
        Me.txtBairro.Location = New System.Drawing.Point(466, 102)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(218, 20)
        Me.txtBairro.TabIndex = 45
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(382, 102)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(68, 20)
        Me.txtComplemento.TabIndex = 44
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(22, 102)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(343, 20)
        Me.txtEndereco.TabIndex = 43
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(22, 46)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(302, 20)
        Me.txtNome.TabIndex = 42
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(463, 86)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 41
        Me.lblBairro.Text = "Bairro"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(379, 86)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(44, 13)
        Me.lblComplemento.TabIndex = 40
        Me.lblComplemento.Text = "Número"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(19, 85)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 39
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(463, 27)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lblEstadoCivil.TabIndex = 38
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(335, 29)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(104, 13)
        Me.lblDtNasc.TabIndex = 37
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(19, 30)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 36
        Me.lblNome.Text = "Nome"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.mskrg)
        Me.TabPage2.Controls.Add(Me.mskCel)
        Me.TabPage2.Controls.Add(Me.mskcpf)
        Me.TabPage2.Controls.Add(Me.lblCpf)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.lblRg)
        Me.TabPage2.Controls.Add(Me.mskTel2)
        Me.TabPage2.Controls.Add(Me.mskTel1)
        Me.TabPage2.Controls.Add(Me.lblEmail)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Controls.Add(Me.lblCelular)
        Me.TabPage2.Controls.Add(Me.lblTelefone1)
        Me.TabPage2.Controls.Add(Me.lblTelefone2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(801, 216)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dados Pessoais"
        '
        'mskrg
        '
        Me.mskrg.Location = New System.Drawing.Point(21, 145)
        Me.mskrg.Mask = "00.000.000"
        Me.mskrg.Name = "mskrg"
        Me.mskrg.Size = New System.Drawing.Size(100, 20)
        Me.mskrg.TabIndex = 39
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(247, 58)
        Me.mskCel.Mask = "(00)0000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(100, 20)
        Me.mskCel.TabIndex = 10
        '
        'mskcpf
        '
        Me.mskcpf.Location = New System.Drawing.Point(144, 145)
        Me.mskcpf.Mask = "000.000.000-00"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.Size = New System.Drawing.Size(100, 20)
        Me.mskcpf.TabIndex = 38
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(141, 132)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 1
        Me.lblCpf.Text = "CPF"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtObs)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(380, 45)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(396, 129)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OBS"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(11, 15)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(373, 105)
        Me.txtObs.TabIndex = 0
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(18, 132)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 0
        Me.lblRg.Text = "RG"
        '
        'mskTel2
        '
        Me.mskTel2.Location = New System.Drawing.Point(134, 58)
        Me.mskTel2.Mask = "(00)0000-0000"
        Me.mskTel2.Name = "mskTel2"
        Me.mskTel2.Size = New System.Drawing.Size(100, 20)
        Me.mskTel2.TabIndex = 9
        '
        'mskTel1
        '
        Me.mskTel1.Location = New System.Drawing.Point(18, 58)
        Me.mskTel1.Mask = "(00)0000-0000"
        Me.mskTel1.Name = "mskTel1"
        Me.mskTel1.Size = New System.Drawing.Size(100, 20)
        Me.mskTel1.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(15, 86)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(18, 102)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(329, 20)
        Me.txtEmail.TabIndex = 6
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(244, 42)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(39, 13)
        Me.lblCelular.TabIndex = 2
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone1
        '
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.Location = New System.Drawing.Point(15, 42)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefone1.TabIndex = 0
        Me.lblTelefone1.Text = "Telefone 1"
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.Location = New System.Drawing.Point(131, 42)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(58, 13)
        Me.lblTelefone2.TabIndex = 1
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.txtextra)
        Me.TabPage3.Controls.Add(Me.mskcpf_dep)
        Me.TabPage3.Controls.Add(Me.mskdtdatadep)
        Me.TabPage3.Controls.Add(Me.txtnome_dep)
        Me.TabPage3.Controls.Add(Me.cbopzrentesco)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(801, 216)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dados Complementares"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(421, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Dependentes Extras"
        '
        'txtextra
        '
        Me.txtextra.Location = New System.Drawing.Point(424, 55)
        Me.txtextra.Multiline = True
        Me.txtextra.Name = "txtextra"
        Me.txtextra.Size = New System.Drawing.Size(352, 105)
        Me.txtextra.TabIndex = 38
        '
        'mskcpf_dep
        '
        Me.mskcpf_dep.Location = New System.Drawing.Point(145, 115)
        Me.mskcpf_dep.Mask = "000.000.000-00"
        Me.mskcpf_dep.Name = "mskcpf_dep"
        Me.mskcpf_dep.Size = New System.Drawing.Size(100, 20)
        Me.mskcpf_dep.TabIndex = 37
        '
        'mskdtdatadep
        '
        Me.mskdtdatadep.Location = New System.Drawing.Point(21, 117)
        Me.mskdtdatadep.Mask = "00/00/0000"
        Me.mskdtdatadep.Name = "mskdtdatadep"
        Me.mskdtdatadep.Size = New System.Drawing.Size(100, 20)
        Me.mskdtdatadep.TabIndex = 36
        Me.mskdtdatadep.ValidatingType = GetType(Date)
        '
        'txtnome_dep
        '
        Me.txtnome_dep.Location = New System.Drawing.Point(22, 73)
        Me.txtnome_dep.Name = "txtnome_dep"
        Me.txtnome_dep.Size = New System.Drawing.Size(366, 20)
        Me.txtnome_dep.TabIndex = 4
        '
        'cbopzrentesco
        '
        Me.cbopzrentesco.FormattingEnabled = True
        Me.cbopzrentesco.Items.AddRange(New Object() {"Conjuge", "Filho(a)", "Mãe", "Pai", "Outros"})
        Me.cbopzrentesco.Location = New System.Drawing.Point(267, 114)
        Me.cbopzrentesco.Name = "cbopzrentesco"
        Me.cbopzrentesco.Size = New System.Drawing.Size(121, 21)
        Me.cbopzrentesco.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Data de Nascimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Parentesco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF"
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
        'frmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 590)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lstgrade)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents clmcodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmnome As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmdtnasc As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmtelefone1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmemail As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmrg As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmcpf As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents mskCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboUf As System.Windows.Forms.ComboBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents mskDnascimento As System.Windows.Forms.MaskedTextBox
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
    Friend WithEvents mskrg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents mskTel2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskTel1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefone1 As System.Windows.Forms.Label
    Friend WithEvents lblTelefone2 As System.Windows.Forms.Label
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtextra As System.Windows.Forms.TextBox
End Class
