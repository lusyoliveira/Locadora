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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.clmcodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmnome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmdtnasc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmtelefone1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmemail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmrg = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmcpf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.mskCep = New System.Windows.Forms.MaskedTextBox()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.mskDnascimento = New System.Windows.Forms.MaskedTextBox()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtextra = New System.Windows.Forms.TextBox()
        Me.mskcpf_dep = New System.Windows.Forms.MaskedTextBox()
        Me.mskdtdatadep = New System.Windows.Forms.MaskedTextBox()
        Me.txtnome_dep = New System.Windows.Forms.TextBox()
        Me.cbopzrentesco = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mskcpfdep = New System.Windows.Forms.MaskedTextBox()
        Me.mskDnasc = New System.Windows.Forms.MaskedTextBox()
        Me.cboGrauParentesco = New System.Windows.Forms.ComboBox()
        Me.txtNomeDependente = New System.Windows.Forms.TextBox()
        Me.lblGrauParentesco = New System.Windows.Forms.Label()
        Me.lblCpfDependente = New System.Windows.Forms.Label()
        Me.lblDtNascDependente = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnExcluir)
        Me.GroupBox6.Controls.Add(Me.btnAlterar)
        Me.GroupBox6.Controls.Add(Me.btnConsultar)
        Me.GroupBox6.Controls.Add(Me.btnSalvar)
        Me.GroupBox6.Controls.Add(Me.btnNovo)
        Me.GroupBox6.Location = New System.Drawing.Point(163, 594)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(780, 98)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(577, 23)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(114, 57)
        Me.btnExcluir.TabIndex = 6
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.doc_info
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.Location = New System.Drawing.Point(453, 22)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(116, 57)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "&Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(77, 23)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(124, 57)
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
        Me.btnSalvar.Location = New System.Drawing.Point(330, 23)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(115, 57)
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
        Me.btnNovo.Location = New System.Drawing.Point(209, 22)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(113, 57)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmcodigo, Me.clmnome, Me.clmdtnasc, Me.clmtelefone1, Me.clmemail, Me.clmrg, Me.clmcpf})
        Me.lstgrade.FullRowSelect = True
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(17, 343)
        Me.lstgrade.Margin = New System.Windows.Forms.Padding(4)
        Me.lstgrade.MultiSelect = False
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(1071, 244)
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
        Me.TabControl1.Location = New System.Drawing.Point(13, 95)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1079, 240)
        Me.TabControl1.TabIndex = 37
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblCodigo)
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
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1071, 211)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dados Gerais"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Código"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(24, 33)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 25)
        Me.lblCodigo.TabIndex = 38
        '
        'mskCep
        '
        Me.mskCep.Location = New System.Drawing.Point(463, 144)
        Me.mskCep.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCep.Mask = "00000-000"
        Me.mskCep.Name = "mskCep"
        Me.mskCep.Size = New System.Drawing.Size(132, 22)
        Me.mskCep.TabIndex = 54
        '
        'cboUf
        '
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cboUf.Location = New System.Drawing.Point(363, 145)
        Me.cboUf.Margin = New System.Windows.Forms.Padding(4)
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(80, 24)
        Me.cboUf.TabIndex = 49
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(25, 146)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(308, 22)
        Me.txtCidade.TabIndex = 53
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(459, 128)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 16)
        Me.lblCep.TabIndex = 52
        Me.lblCep.Text = "CEP"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(359, 128)
        Me.lblUf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(25, 16)
        Me.lblUf.TabIndex = 51
        Me.lblUf.Text = "UF"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(21, 127)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(51, 16)
        Me.lblCidade.TabIndex = 50
        Me.lblCidade.Text = "Cidade"
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Location = New System.Drawing.Point(509, 33)
        Me.mskDnascimento.Margin = New System.Windows.Forms.Padding(4)
        Me.mskDnascimento.Mask = "00/00/0000"
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(133, 22)
        Me.mskDnascimento.TabIndex = 48
        Me.mskDnascimento.ValidatingType = GetType(Date)
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Items.AddRange(New Object() {"Solteiro(a)", "Casado(a)", "Divorsiado(a)", "Viuvo(a)"})
        Me.cboEstadoCivil.Location = New System.Drawing.Point(652, 33)
        Me.cboEstadoCivil.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(160, 24)
        Me.cboEstadoCivil.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdMasculino)
        Me.GroupBox1.Controls.Add(Me.rbdFeminino)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(821, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(216, 55)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'rbdMasculino
        '
        Me.rbdMasculino.AutoSize = True
        Me.rbdMasculino.Location = New System.Drawing.Point(111, 22)
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
        Me.rbdFeminino.Location = New System.Drawing.Point(8, 23)
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
        Me.txtBairro.Location = New System.Drawing.Point(608, 95)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(428, 22)
        Me.txtBairro.TabIndex = 45
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(509, 95)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(89, 22)
        Me.txtComplemento.TabIndex = 44
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(24, 95)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(476, 22)
        Me.txtEndereco.TabIndex = 43
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(99, 33)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(401, 22)
        Me.txtNome.TabIndex = 42
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(604, 75)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 16)
        Me.lblBairro.TabIndex = 41
        Me.lblBairro.Text = "Bairro"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(505, 75)
        Me.lblComplemento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(55, 16)
        Me.lblComplemento.TabIndex = 40
        Me.lblComplemento.Text = "Número"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(20, 75)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(66, 16)
        Me.lblEndereco.TabIndex = 39
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(648, 14)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(78, 16)
        Me.lblEstadoCivil.TabIndex = 38
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(505, 14)
        Me.lblDtNasc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(130, 16)
        Me.lblDtNasc.TabIndex = 37
        Me.lblDtNasc.Text = "Data de Nascimento"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(95, 14)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1071, 211)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Dados Pessoais"
        '
        'mskrg
        '
        Me.mskrg.Location = New System.Drawing.Point(27, 146)
        Me.mskrg.Margin = New System.Windows.Forms.Padding(4)
        Me.mskrg.Mask = "00.000.000"
        Me.mskrg.Name = "mskrg"
        Me.mskrg.Size = New System.Drawing.Size(132, 22)
        Me.mskrg.TabIndex = 39
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(327, 39)
        Me.mskCel.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCel.Mask = "(00)0000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(132, 22)
        Me.mskCel.TabIndex = 10
        '
        'mskcpf
        '
        Me.mskcpf.Location = New System.Drawing.Point(189, 146)
        Me.mskcpf.Margin = New System.Windows.Forms.Padding(4)
        Me.mskcpf.Mask = "000.000.000-00"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.Size = New System.Drawing.Size(132, 22)
        Me.mskcpf.TabIndex = 38
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(187, 130)
        Me.lblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 16)
        Me.lblCpf.TabIndex = 1
        Me.lblCpf.Text = "CPF"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtObs)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(507, 21)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(528, 159)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "OBS"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(15, 18)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(496, 128)
        Me.txtObs.TabIndex = 0
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(21, 130)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(27, 16)
        Me.lblRg.TabIndex = 0
        Me.lblRg.Text = "RG"
        '
        'mskTel2
        '
        Me.mskTel2.Location = New System.Drawing.Point(177, 39)
        Me.mskTel2.Margin = New System.Windows.Forms.Padding(4)
        Me.mskTel2.Mask = "(00)0000-0000"
        Me.mskTel2.Name = "mskTel2"
        Me.mskTel2.Size = New System.Drawing.Size(132, 22)
        Me.mskTel2.TabIndex = 9
        '
        'mskTel1
        '
        Me.mskTel1.Location = New System.Drawing.Point(21, 39)
        Me.mskTel1.Margin = New System.Windows.Forms.Padding(4)
        Me.mskTel1.Mask = "(00)0000-0000"
        Me.mskTel1.Name = "mskTel1"
        Me.mskTel1.Size = New System.Drawing.Size(132, 22)
        Me.mskTel1.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(19, 75)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(21, 95)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(437, 22)
        Me.txtEmail.TabIndex = 6
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(323, 21)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(49, 16)
        Me.lblCelular.TabIndex = 2
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone1
        '
        Me.lblTelefone1.AutoSize = True
        Me.lblTelefone1.Location = New System.Drawing.Point(19, 21)
        Me.lblTelefone1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone1.Name = "lblTelefone1"
        Me.lblTelefone1.Size = New System.Drawing.Size(71, 16)
        Me.lblTelefone1.TabIndex = 0
        Me.lblTelefone1.Text = "Telefone 1"
        '
        'lblTelefone2
        '
        Me.lblTelefone2.AutoSize = True
        Me.lblTelefone2.Location = New System.Drawing.Point(173, 21)
        Me.lblTelefone2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone2.Name = "lblTelefone2"
        Me.lblTelefone2.Size = New System.Drawing.Size(71, 16)
        Me.lblTelefone2.TabIndex = 1
        Me.lblTelefone2.Text = "Telefone 2"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.btnAdicionar)
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
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1071, 211)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dependentes"
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.Location = New System.Drawing.Point(371, 123)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(141, 58)
        Me.btnAdicionar.TabIndex = 40
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(559, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Dependentes Extras"
        '
        'txtextra
        '
        Me.txtextra.Location = New System.Drawing.Point(563, 31)
        Me.txtextra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtextra.Multiline = True
        Me.txtextra.Name = "txtextra"
        Me.txtextra.Size = New System.Drawing.Size(483, 159)
        Me.txtextra.TabIndex = 38
        '
        'mskcpf_dep
        '
        Me.mskcpf_dep.Location = New System.Drawing.Point(188, 82)
        Me.mskcpf_dep.Margin = New System.Windows.Forms.Padding(4)
        Me.mskcpf_dep.Mask = "000.000.000-00"
        Me.mskcpf_dep.Name = "mskcpf_dep"
        Me.mskcpf_dep.Size = New System.Drawing.Size(132, 22)
        Me.mskcpf_dep.TabIndex = 37
        '
        'mskdtdatadep
        '
        Me.mskdtdatadep.Location = New System.Drawing.Point(23, 85)
        Me.mskdtdatadep.Margin = New System.Windows.Forms.Padding(4)
        Me.mskdtdatadep.Mask = "00/00/0000"
        Me.mskdtdatadep.Name = "mskdtdatadep"
        Me.mskdtdatadep.Size = New System.Drawing.Size(132, 22)
        Me.mskdtdatadep.TabIndex = 36
        Me.mskdtdatadep.ValidatingType = GetType(Date)
        '
        'txtnome_dep
        '
        Me.txtnome_dep.Location = New System.Drawing.Point(24, 31)
        Me.txtnome_dep.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnome_dep.Name = "txtnome_dep"
        Me.txtnome_dep.Size = New System.Drawing.Size(487, 22)
        Me.txtnome_dep.TabIndex = 4
        '
        'cbopzrentesco
        '
        Me.cbopzrentesco.FormattingEnabled = True
        Me.cbopzrentesco.Items.AddRange(New Object() {"Conjuge", "Filho(a)", "Mãe", "Pai", "Outros"})
        Me.cbopzrentesco.Location = New System.Drawing.Point(351, 81)
        Me.cbopzrentesco.Margin = New System.Windows.Forms.Padding(4)
        Me.cbopzrentesco.Name = "cbopzrentesco"
        Me.cbopzrentesco.Size = New System.Drawing.Size(160, 24)
        Me.cbopzrentesco.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Data de Nascimento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Parentesco"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CPF"
        '
        'mskcpfdep
        '
        Me.mskcpfdep.Location = New System.Drawing.Point(151, 88)
        Me.mskcpfdep.Mask = "000.000.000-00"
        Me.mskcpfdep.Name = "mskcpfdep"
        Me.mskcpfdep.Size = New System.Drawing.Size(100, 22)
        Me.mskcpfdep.TabIndex = 37
        '
        'mskDnasc
        '
        Me.mskDnasc.Location = New System.Drawing.Point(16, 88)
        Me.mskDnasc.Mask = "00/00/0000"
        Me.mskDnasc.Name = "mskDnasc"
        Me.mskDnasc.Size = New System.Drawing.Size(100, 22)
        Me.mskDnasc.TabIndex = 36
        Me.mskDnasc.ValidatingType = GetType(Date)
        '
        'cboGrauParentesco
        '
        Me.cboGrauParentesco.FormattingEnabled = True
        Me.cboGrauParentesco.Items.AddRange(New Object() {"Conjuge", "Filho(a)", "Mãe", "Pai", "Outros"})
        Me.cboGrauParentesco.Location = New System.Drawing.Point(262, 85)
        Me.cboGrauParentesco.Name = "cboGrauParentesco"
        Me.cboGrauParentesco.Size = New System.Drawing.Size(121, 24)
        Me.cboGrauParentesco.TabIndex = 7
        '
        'txtNomeDependente
        '
        Me.txtNomeDependente.Location = New System.Drawing.Point(17, 44)
        Me.txtNomeDependente.Name = "txtNomeDependente"
        Me.txtNomeDependente.Size = New System.Drawing.Size(366, 22)
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 87)
        Me.Panel1.TabIndex = 0
        '
        'frmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 714)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lstgrade)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
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
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents btnAdicionar As Button
End Class
