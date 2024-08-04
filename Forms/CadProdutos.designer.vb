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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodigo = New System.Windows.Forms.Label()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtDuracao = New System.Windows.Forms.TextBox()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.lstFilmes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbolegenda = New System.Windows.Forms.ComboBox()
        Me.Valor = New System.Windows.Forms.Label()
        Me.mskDcad = New System.Windows.Forms.DateTimePicker()
        Me.txtvalor = New System.Windows.Forms.MaskedTextBox()
        Me.txtoriginal = New System.Windows.Forms.TextBox()
        Me.lbloriginal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
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
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 84)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Codigo"
        Me.lblCodigo.Visible = False
        '
        'lblProduto
        '
        Me.lblProduto.AutoSize = True
        Me.lblProduto.Location = New System.Drawing.Point(447, 84)
        Me.lblProduto.Name = "lblProduto"
        Me.lblProduto.Size = New System.Drawing.Size(54, 16)
        Me.lblProduto.TabIndex = 2
        Me.lblProduto.Text = "Produto"
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Items.AddRange(New Object() {"DVD", "JOGO", "VHS"})
        Me.cboProduto.Location = New System.Drawing.Point(450, 103)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(193, 24)
        Me.cboProduto.TabIndex = 5
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(83, 84)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(40, 16)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Título"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(646, 84)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(95, 16)
        Me.lblAutor.TabIndex = 8
        Me.lblAutor.Text = "Diretor/Criador"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Location = New System.Drawing.Point(21, 136)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(52, 16)
        Me.lblGenero.TabIndex = 9
        Me.lblGenero.Text = "Gênero"
        '
        'lblDuracao
        '
        Me.lblDuracao.AutoSize = True
        Me.lblDuracao.Location = New System.Drawing.Point(346, 136)
        Me.lblDuracao.Name = "lblDuracao"
        Me.lblDuracao.Size = New System.Drawing.Size(59, 16)
        Me.lblDuracao.TabIndex = 10
        Me.lblDuracao.Text = "Duração"
        '
        'lblCensura
        '
        Me.lblCensura.AutoSize = True
        Me.lblCensura.Location = New System.Drawing.Point(168, 136)
        Me.lblCensura.Name = "lblCensura"
        Me.lblCensura.Size = New System.Drawing.Size(57, 16)
        Me.lblCensura.TabIndex = 11
        Me.lblCensura.Text = "Censura"
        '
        'lblDtCad
        '
        Me.lblDtCad.AutoSize = True
        Me.lblDtCad.Location = New System.Drawing.Point(578, 136)
        Me.lblDtCad.Name = "lblDtCad"
        Me.lblDtCad.Size = New System.Drawing.Size(113, 16)
        Me.lblDtCad.TabIndex = 12
        Me.lblDtCad.Text = "Data do Cadastro"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(425, 136)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(77, 16)
        Me.lblQuantidade.TabIndex = 14
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(86, 105)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(358, 22)
        Me.txtTitulo.TabIndex = 15
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(649, 105)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(273, 22)
        Me.txtAutor.TabIndex = 16
        '
        'txtCensura
        '
        Me.txtCensura.Location = New System.Drawing.Point(171, 156)
        Me.txtCensura.Name = "txtCensura"
        Me.txtCensura.Size = New System.Drawing.Size(105, 22)
        Me.txtCensura.TabIndex = 19
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(428, 155)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(74, 22)
        Me.txtQuantidade.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSair)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnExcluir)
        Me.GroupBox2.Controls.Add(Me.btnSalvar)
        Me.GroupBox2.Controls.Add(Me.btnNovo)
        Me.GroupBox2.Location = New System.Drawing.Point(167, 436)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 86)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(468, 19)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(106, 55)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "&Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(6, 19)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(120, 55)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "C&onsultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.shell32_033
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(356, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(106, 55)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.add
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.Location = New System.Drawing.Point(244, 19)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(106, 55)
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
        Me.btnNovo.Location = New System.Drawing.Point(132, 19)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(106, 55)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtDuracao
        '
        Me.txtDuracao.Location = New System.Drawing.Point(347, 155)
        Me.txtDuracao.Name = "txtDuracao"
        Me.txtDuracao.Size = New System.Drawing.Size(75, 22)
        Me.txtDuracao.TabIndex = 33
        '
        'cboGenero
        '
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Location = New System.Drawing.Point(24, 155)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(141, 24)
        Me.cboGenero.TabIndex = 36
        '
        'lstFilmes
        '
        Me.lstFilmes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader10})
        Me.lstFilmes.HideSelection = False
        Me.lstFilmes.Location = New System.Drawing.Point(24, 185)
        Me.lstFilmes.Name = "lstFilmes"
        Me.lstFilmes.Size = New System.Drawing.Size(898, 245)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(697, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Legenda"
        '
        'cbolegenda
        '
        Me.cbolegenda.FormattingEnabled = True
        Me.cbolegenda.Location = New System.Drawing.Point(697, 152)
        Me.cbolegenda.Name = "cbolegenda"
        Me.cbolegenda.Size = New System.Drawing.Size(225, 24)
        Me.cbolegenda.TabIndex = 41
        '
        'Valor
        '
        Me.Valor.AutoSize = True
        Me.Valor.Location = New System.Drawing.Point(508, 136)
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(39, 16)
        Me.Valor.TabIndex = 44
        Me.Valor.Text = "Valor"
        '
        'mskDcad
        '
        Me.mskDcad.CalendarForeColor = System.Drawing.Color.Black
        Me.mskDcad.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.mskDcad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.mskDcad.Location = New System.Drawing.Point(581, 154)
        Me.mskDcad.Name = "mskDcad"
        Me.mskDcad.Size = New System.Drawing.Size(110, 22)
        Me.mskDcad.TabIndex = 45
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(508, 154)
        Me.txtvalor.Mask = "0,00"
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(67, 22)
        Me.txtvalor.TabIndex = 46
        '
        'txtoriginal
        '
        Me.txtoriginal.Enabled = False
        Me.txtoriginal.Location = New System.Drawing.Point(282, 155)
        Me.txtoriginal.Name = "txtoriginal"
        Me.txtoriginal.Size = New System.Drawing.Size(59, 22)
        Me.txtoriginal.TabIndex = 48
        Me.txtoriginal.Visible = False
        '
        'lbloriginal
        '
        Me.lbloriginal.AutoSize = True
        Me.lbloriginal.Enabled = False
        Me.lbloriginal.Location = New System.Drawing.Point(282, 136)
        Me.lbloriginal.Name = "lbloriginal"
        Me.lbloriginal.Size = New System.Drawing.Size(53, 16)
        Me.lbloriginal.TabIndex = 49
        Me.lbloriginal.Text = "Original"
        Me.lbloriginal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(793, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(24, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 22)
        Me.Label3.TabIndex = 90
        '
        'frmCadProdutos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(943, 545)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbloriginal)
        Me.Controls.Add(Me.txtoriginal)
        Me.Controls.Add(Me.txtvalor)
        Me.Controls.Add(Me.mskDcad)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.cbolegenda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstFilmes)
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
        Me.Controls.Add(Me.lblProduto)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label3 As Label
End Class
