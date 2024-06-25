<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadProdutos))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblProduto = New System.Windows.Forms.Label
        Me.cboProduto = New System.Windows.Forms.ComboBox
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblAutor = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.lblGenero = New System.Windows.Forms.Label
        Me.lblDuracao = New System.Windows.Forms.Label
        Me.lblCensura = New System.Windows.Forms.Label
        Me.lblDtCad = New System.Windows.Forms.Label
        Me.lblQuantidade = New System.Windows.Forms.Label
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.txtAutor = New System.Windows.Forms.TextBox
        Me.txtCensura = New System.Windows.Forms.TextBox
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDuracao = New System.Windows.Forms.TextBox
        Me.cboGenero = New System.Windows.Forms.ComboBox
        Me.lstgrade = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.cboGenerojogo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbolegenda = New System.Windows.Forms.ComboBox
        Me.Valor = New System.Windows.Forms.Label
        Me.mskDcad = New System.Windows.Forms.DateTimePicker
        Me.txtvalor = New System.Windows.Forms.MaskedTextBox
        Me.txtoriginal = New System.Windows.Forms.TextBox
        Me.lbloriginal = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 75)
        Me.Panel1.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(595, 92)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Codigo"
        Me.lblCodigo.Visible = False
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(33, 91)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(44, 13)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto"
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Items.AddRange(New Object() {"DVD", "JOGO", "VHS"})
        Me.cboProduto.Location = New System.Drawing.Point(36, 105)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(151, 21)
        Me.cboProduto.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(215, 89)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Título"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(35, 135)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(76, 13)
        Me.lblAutor.TabIndex = 8
        Me.lblAutor.Text = "Diretor/Criador"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(598, 108)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(46, 20)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.Visible = False
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(336, 133)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(42, 13)
        Me.lblGenero.TabIndex = 9
        Me.lblGenero.Text = "Gênero"
        '
        'lblDuracao
        '
        Me.lblDuracao.AutoSize = True
        Me.lblDuracao.Location = New System.Drawing.Point(35, 182)
        Me.lblDuracao.Name = "lblDuracao"
        Me.lblDuracao.Size = New System.Drawing.Size(48, 13)
        Me.lblDuracao.TabIndex = 10
        Me.lblDuracao.Text = "Duração"
        '
        'lblCensura
        '
        Me.lblCensura.AutoSize = True
        Me.lblCensura.Location = New System.Drawing.Point(480, 134)
        Me.lblCensura.Name = "lblCensura"
        Me.lblCensura.Size = New System.Drawing.Size(46, 13)
        Me.lblCensura.TabIndex = 11
        Me.lblCensura.Text = "Censura"
        '
        'lblDtCad
        '
        Me.lblDtCad.AutoSize = True
        Me.lblDtCad.Location = New System.Drawing.Point(292, 182)
        Me.lblDtCad.Name = "lblDtCad"
        Me.lblDtCad.Size = New System.Drawing.Size(90, 13)
        Me.lblDtCad.TabIndex = 12
        Me.lblDtCad.Text = "Data do Cadastro"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(125, 182)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 14
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(218, 105)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(344, 20)
        Me.txtTitulo.TabIndex = 15
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(36, 150)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(273, 20)
        Me.txtAutor.TabIndex = 16
        '
        'txtCensura
        '
        Me.txtCensura.Location = New System.Drawing.Point(484, 150)
        Me.txtCensura.Name = "txtCensura"
        Me.txtCensura.Size = New System.Drawing.Size(78, 20)
        Me.txtCensura.TabIndex = 19
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(128, 198)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(59, 20)
        Me.txtQuantidade.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSair)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnExcluir)
        Me.GroupBox2.Controls.Add(Me.btnSalvar)
        Me.GroupBox2.Controls.Add(Me.btnNovo)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 435)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 80)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'txtDuracao
        '
        Me.txtDuracao.Location = New System.Drawing.Point(38, 198)
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.Size = New System.Drawing.Size(75, 20)
        Me.txtDuracao.TabIndex = 33
        '
        'cboGenero
        '
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Ação", "Adulto", "Aventura", "Comédia", "Desenho", "Ficção", "Musical", "Religioso", "Romantico", "Suspense", "Terror"})
        Me.cboGenero.Location = New System.Drawing.Point(337, 149)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(121, 21)
        Me.cboGenero.TabIndex = 36
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader10})
        Me.lstgrade.Location = New System.Drawing.Point(38, 230)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(619, 200)
        Me.lstgrade.TabIndex = 37
        Me.lstgrade.Tag = "0"
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Produto"
        Me.ColumnHeader2.Width = 70
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
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Data Cadastro"
        Me.ColumnHeader10.Width = 100
        '
        'cboGenerojogo
        '
        Me.cboGenerojogo.FormattingEnabled = True
        Me.cboGenerojogo.Items.AddRange(New Object() {"Aventura", "Corrida", "Esporte", "Estrategia", "Guerra", "Luta", "RPG", "Simulador", "Tiro", "Vida Virtual"})
        Me.cboGenerojogo.Location = New System.Drawing.Point(337, 149)
        Me.cboGenerojogo.Name = "cboGenerojogo"
        Me.cboGenerojogo.Size = New System.Drawing.Size(121, 21)
        Me.cboGenerojogo.TabIndex = 39
        Me.cboGenerojogo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Legenda"
        '
        'cbolegenda
        '
        Me.cbolegenda.FormattingEnabled = True
        Me.cbolegenda.Items.AddRange(New Object() {"Dublado", "Legendado"})
        Me.cbolegenda.Location = New System.Drawing.Point(410, 198)
        Me.cbolegenda.Name = "cbolegenda"
        Me.cbolegenda.Size = New System.Drawing.Size(121, 21)
        Me.cbolegenda.TabIndex = 41
        '
        'Valor
        '
        Me.Valor.AutoSize = True
        Me.Valor.Location = New System.Drawing.Point(204, 182)
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
        Me.mskDcad.Location = New System.Drawing.Point(295, 198)
        Me.mskDcad.Name = "mskDcad"
        Me.mskDcad.Size = New System.Drawing.Size(99, 20)
        Me.mskDcad.TabIndex = 45
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(207, 197)
        Me.txtvalor.Mask = "0,00"
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(59, 20)
        Me.txtvalor.TabIndex = 46
        '
        'txtoriginal
        '
        Me.txtoriginal.Enabled = False
        Me.txtoriginal.Location = New System.Drawing.Point(598, 153)
        Me.txtoriginal.Name = "txtoriginal"
        Me.txtoriginal.Size = New System.Drawing.Size(59, 20)
        Me.txtoriginal.TabIndex = 48
        Me.txtoriginal.Visible = False
        '
        'lbloriginal
        '
        Me.lbloriginal.AutoSize = True
        Me.lbloriginal.Enabled = False
        Me.lbloriginal.Location = New System.Drawing.Point(595, 137)
        Me.lbloriginal.Name = "lbloriginal"
        Me.lbloriginal.Size = New System.Drawing.Size(42, 13)
        Me.lbloriginal.TabIndex = 49
        Me.lbloriginal.Text = "Original"
        Me.lbloriginal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 50
        '
        'btnSair
        '
        Me.btnSair.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(459, 19)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(106, 45)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "&Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Projeto_Locadora.My.Resources.Resources.binoculars
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(6, 19)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(106, 45)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "C&onsultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.Projeto_Locadora.My.Resources.Resources.trash
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(347, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(106, 45)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.UseVisualStyleBackColor = True
        Me.btnExcluir.Visible = False
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
        'frmCadProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(690, 526)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbloriginal)
        Me.Controls.Add(Me.txtoriginal)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.mskDcad)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.cbolegenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboGenerojogo)
        Me.Controls.Add(Me.lstgrade)
        Me.Controls.Add(Me.cboGenero)
        Me.Controls.Add(Me.txtDuracao)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.txtCensura)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.lblDtCad)
        Me.Controls.Add(Me.lblCensura)
        Me.Controls.Add(Me.lblDuracao)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cboProduto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblProduto)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadProdutos"
        Me.Text = "Cadastro de Produtos"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblProduto As System.Windows.Forms.Label
    Friend WithEvents cboProduto As System.Windows.Forms.ComboBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblDuracao As System.Windows.Forms.Label
    Friend WithEvents lblCensura As System.Windows.Forms.Label
    Friend WithEvents lblDtCad As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtCensura As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents txtDuracao As System.Windows.Forms.TextBox
    Friend WithEvents cboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents cboGenerojogo As System.Windows.Forms.ComboBox
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

End Class
