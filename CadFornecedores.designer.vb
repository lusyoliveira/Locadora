<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadFornecedores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadFornecedores))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblFornecedor = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.lblCnpj = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mskcel = New System.Windows.Forms.MaskedTextBox()
        Me.msktel = New System.Windows.Forms.MaskedTextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSite = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.mskcnpj = New System.Windows.Forms.MaskedTextBox()
        Me.mskcpf = New System.Windows.Forms.MaskedTextBox()
        Me.cbouf = New System.Windows.Forms.ComboBox()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.clmcodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmfornecedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmempresa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmcnpj = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmuf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmcpf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmtelefone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmcelular = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1071, 92)
        Me.Panel1.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(14, 111)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Código"
        Me.lblCodigo.Visible = False
        '
        'lblFornecedor
        '
        Me.lblFornecedor.AutoSize = True
        Me.lblFornecedor.Location = New System.Drawing.Point(119, 111)
        Me.lblFornecedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFornecedor.Name = "lblFornecedor"
        Me.lblFornecedor.Size = New System.Drawing.Size(77, 16)
        Me.lblFornecedor.TabIndex = 3
        Me.lblFornecedor.Text = "Fornecedor"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(18, 130)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(97, 22)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Visible = False
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Location = New System.Drawing.Point(123, 130)
        Me.txtFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(380, 22)
        Me.txtFornecedor.TabIndex = 1
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(13, 169)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(66, 16)
        Me.lblEndereco.TabIndex = 6
        Me.lblEndereco.Text = "Endereço"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Location = New System.Drawing.Point(507, 111)
        Me.lblEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(62, 16)
        Me.lblEmpresa.TabIndex = 7
        Me.lblEmpresa.Text = "Empresa"
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(423, 169)
        Me.lblComplemento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(91, 16)
        Me.lblComplemento.TabIndex = 8
        Me.lblComplemento.Text = "Complemento"
        '
        'lblCnpj
        '
        Me.lblCnpj.AutoSize = True
        Me.lblCnpj.Location = New System.Drawing.Point(863, 111)
        Me.lblCnpj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCnpj.Name = "lblCnpj"
        Me.lblCnpj.Size = New System.Drawing.Size(42, 16)
        Me.lblCnpj.TabIndex = 9
        Me.lblCnpj.Text = "CNPJ"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(511, 130)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(339, 22)
        Me.txtEmpresa.TabIndex = 2
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(13, 225)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 16)
        Me.lblBairro.TabIndex = 12
        Me.lblBairro.Text = "Bairro"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(13, 286)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(51, 16)
        Me.lblCidade.TabIndex = 13
        Me.lblCidade.Text = "Cidade"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(423, 286)
        Me.lblUf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(25, 16)
        Me.lblUf.TabIndex = 14
        Me.lblUf.Text = "UF"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(17, 189)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(379, 22)
        Me.txtEndereco.TabIndex = 15
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(427, 189)
        Me.txtComplemento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(107, 22)
        Me.txtComplemento.TabIndex = 5
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(17, 245)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(380, 22)
        Me.txtBairro.TabIndex = 6
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(17, 306)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(380, 22)
        Me.txtCidade.TabIndex = 8
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(423, 225)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(32, 16)
        Me.lblCep.TabIndex = 20
        Me.lblCep.Text = "Cep"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskcel)
        Me.GroupBox1.Controls.Add(Me.msktel)
        Me.GroupBox1.Controls.Add(Me.lblCelular)
        Me.GroupBox1.Controls.Add(Me.lblTelefone)
        Me.GroupBox1.Controls.Add(Me.txtSite)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblSite)
        Me.GroupBox1.Location = New System.Drawing.Point(575, 170)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(480, 206)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contatos"
        '
        'mskcel
        '
        Me.mskcel.Location = New System.Drawing.Point(211, 161)
        Me.mskcel.Margin = New System.Windows.Forms.Padding(4)
        Me.mskcel.Mask = "(00)0000-0000"
        Me.mskcel.Name = "mskcel"
        Me.mskcel.Size = New System.Drawing.Size(132, 22)
        Me.mskcel.TabIndex = 13
        '
        'msktel
        '
        Me.msktel.Location = New System.Drawing.Point(25, 162)
        Me.msktel.Margin = New System.Windows.Forms.Padding(4)
        Me.msktel.Mask = "(00)0000-0000"
        Me.msktel.Name = "msktel"
        Me.msktel.Size = New System.Drawing.Size(132, 22)
        Me.msktel.TabIndex = 12
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(207, 142)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(49, 16)
        Me.lblCelular.TabIndex = 28
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(21, 142)
        Me.lblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefone.TabIndex = 27
        Me.lblTelefone.Text = "Telefone"
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(25, 44)
        Me.txtSite.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(399, 22)
        Me.txtSite.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(25, 100)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(399, 22)
        Me.txtEmail.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(21, 79)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 24
        Me.lblEmail.Text = "E-Mail"
        '
        'lblSite
        '
        Me.lblSite.AutoSize = True
        Me.lblSite.Location = New System.Drawing.Point(21, 25)
        Me.lblSite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(30, 16)
        Me.lblSite.TabIndex = 23
        Me.lblSite.Text = "Site"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSair)
        Me.GroupBox2.Controls.Add(Me.btnExcluir)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnSalvar)
        Me.GroupBox2.Controls.Add(Me.btnNovo)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 613)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(749, 98)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(600, 23)
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
        Me.btnExcluir.Location = New System.Drawing.Point(449, 23)
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
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnSalvar.Location = New System.Drawing.Point(303, 23)
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
        Me.btnNovo.Location = New System.Drawing.Point(155, 23)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(141, 55)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'mskcnpj
        '
        Me.mskcnpj.Location = New System.Drawing.Point(867, 130)
        Me.mskcnpj.Margin = New System.Windows.Forms.Padding(4)
        Me.mskcnpj.Mask = "000.000.000/0000-00"
        Me.mskcnpj.Name = "mskcnpj"
        Me.mskcnpj.Size = New System.Drawing.Size(192, 22)
        Me.mskcnpj.TabIndex = 3
        '
        'mskcpf
        '
        Me.mskcpf.Location = New System.Drawing.Point(427, 245)
        Me.mskcpf.Margin = New System.Windows.Forms.Padding(4)
        Me.mskcpf.Mask = "00000-000"
        Me.mskcpf.Name = "mskcpf"
        Me.mskcpf.Size = New System.Drawing.Size(107, 22)
        Me.mskcpf.TabIndex = 7
        '
        'cbouf
        '
        Me.cbouf.FormattingEnabled = True
        Me.cbouf.Items.AddRange(New Object() {" AC", " AL", " AP", " AM", " BA", " CE", " DF", " ES", " GO", " MA", " MT", " MS", " MG", " PA", " PB", " PR", " PE", " PI", " RJ", " RN", " RS", " RO", " RR", " SC", " SP", " SE", " TO"})
        Me.cbouf.Location = New System.Drawing.Point(427, 306)
        Me.cbouf.Margin = New System.Windows.Forms.Padding(4)
        Me.cbouf.Name = "cbouf"
        Me.cbouf.Size = New System.Drawing.Size(107, 24)
        Me.cbouf.TabIndex = 9
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmcodigo, Me.clmfornecedor, Me.clmempresa, Me.clmcnpj, Me.clmuf, Me.clmcpf, Me.clmtelefone, Me.clmcelular})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(16, 383)
        Me.lstgrade.Margin = New System.Windows.Forms.Padding(4)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(1039, 222)
        Me.lstgrade.TabIndex = 37
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'clmcodigo
        '
        Me.clmcodigo.Text = "Código"
        Me.clmcodigo.Width = 57
        '
        'clmfornecedor
        '
        Me.clmfornecedor.Text = "Fornecedor"
        Me.clmfornecedor.Width = 191
        '
        'clmempresa
        '
        Me.clmempresa.Text = "Empresa"
        Me.clmempresa.Width = 194
        '
        'clmcnpj
        '
        Me.clmcnpj.Text = "CNPJ"
        Me.clmcnpj.Width = 100
        '
        'clmuf
        '
        Me.clmuf.Text = "Uf"
        Me.clmuf.Width = 40
        '
        'clmcpf
        '
        Me.clmcpf.Text = "CPF"
        Me.clmcpf.Width = 89
        '
        'clmtelefone
        '
        Me.clmtelefone.Text = "Telefone"
        Me.clmtelefone.Width = 80
        '
        'clmcelular
        '
        Me.clmcelular.Text = "Celular"
        Me.clmcelular.Width = 84
        '
        'frmCadFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 720)
        Me.Controls.Add(Me.lstgrade)
        Me.Controls.Add(Me.cbouf)
        Me.Controls.Add(Me.mskcpf)
        Me.Controls.Add(Me.mskcnpj)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.lblUf)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtEmpresa)
        Me.Controls.Add(Me.lblCnpj)
        Me.Controls.Add(Me.lblComplemento)
        Me.Controls.Add(Me.lblEmpresa)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblFornecedor)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCadFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fonecedores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblFornecedor As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblComplemento As System.Windows.Forms.Label
    Friend WithEvents lblCnpj As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblUf As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCelular As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblSite As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents mskcel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents msktel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskcnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbouf As System.Windows.Forms.ComboBox
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents clmcodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmfornecedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmempresa As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmcnpj As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmcpf As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmuf As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmtelefone As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmcelular As System.Windows.Forms.ColumnHeader
End Class
