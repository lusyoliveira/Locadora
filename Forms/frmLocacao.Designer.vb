<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLocacao
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocacao))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDtLocacao = New System.Windows.Forms.Label()
        Me.lblDtDevolucao = New System.Windows.Forms.Label()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboclientes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.dtpLocacao = New System.Windows.Forms.DateTimePicker()
        Me.dtpDevolucao = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtValorUnit = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblpagar = New System.Windows.Forms.Label()
        Me.lbldinheiro = New System.Windows.Forms.Label()
        Me.txtDinheiro = New System.Windows.Forms.TextBox()
        Me.lblTroco = New System.Windows.Forms.Label()
        Me.lbltotalpg = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPagar = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.txtCodLocacao = New System.Windows.Forms.TextBox()
        Me.ER = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 92)
        Me.Panel1.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(10, 98)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(93, 16)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "N�da Loca��o"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(441, 18)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(39, 16)
        Me.lblValor.TabIndex = 5
        Me.lblValor.Text = "Valor"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(488, 146)
        Me.lblQuantidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(77, 16)
        Me.lblQuantidade.TabIndex = 6
        Me.lblQuantidade.Text = "Quantidade"
        Me.lblQuantidade.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(532, 20)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        Me.lblTotal.Visible = False
        '
        'lblDtLocacao
        '
        Me.lblDtLocacao.AutoSize = True
        Me.lblDtLocacao.Location = New System.Drawing.Point(492, 99)
        Me.lblDtLocacao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtLocacao.Name = "lblDtLocacao"
        Me.lblDtLocacao.Size = New System.Drawing.Size(111, 16)
        Me.lblDtLocacao.TabIndex = 8
        Me.lblDtLocacao.Text = "Data da Loca��o"
        '
        'lblDtDevolucao
        '
        Me.lblDtDevolucao.AutoSize = True
        Me.lblDtDevolucao.Location = New System.Drawing.Point(649, 98)
        Me.lblDtDevolucao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtDevolucao.Name = "lblDtDevolucao"
        Me.lblDtDevolucao.Size = New System.Drawing.Size(124, 16)
        Me.lblDtDevolucao.TabIndex = 9
        Me.lblDtDevolucao.Text = "Data da Devolu��o"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(491, 167)
        Me.txtQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(73, 22)
        Me.txtQuantidade.TabIndex = 17
        Me.txtQuantidade.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(415, 554)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(141, 66)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.Location = New System.Drawing.Point(267, 554)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(141, 66)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "S&alvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(11, 12)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 55)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "&Sair"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cliente"
        '
        'cboclientes
        '
        Me.cboclientes.FormattingEnabled = True
        Me.cboclientes.Location = New System.Drawing.Point(12, 165)
        Me.cboclientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cboclientes.Name = "cboclientes"
        Me.cboclientes.Size = New System.Drawing.Size(471, 24)
        Me.cboclientes.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Titulo"
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(17, 39)
        Me.cboProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(419, 24)
        Me.cboProduto.TabIndex = 41
        '
        'dtpLocacao
        '
        Me.dtpLocacao.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpLocacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLocacao.Location = New System.Drawing.Point(495, 119)
        Me.dtpLocacao.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpLocacao.Name = "dtpLocacao"
        Me.dtpLocacao.Size = New System.Drawing.Size(131, 22)
        Me.dtpLocacao.TabIndex = 45
        '
        'dtpDevolucao
        '
        Me.dtpDevolucao.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDevolucao.Location = New System.Drawing.Point(653, 121)
        Me.dtpDevolucao.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDevolucao.Name = "dtpDevolucao"
        Me.dtpDevolucao.Size = New System.Drawing.Size(131, 22)
        Me.dtpDevolucao.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Funcionario"
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(17, 69)
        Me.lstgrade.Margin = New System.Windows.Forms.Padding(4)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(597, 260)
        Me.lstgrade.TabIndex = 51
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Titulo"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Valor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtValorUnit)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnremove)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.lstgrade)
        Me.GroupBox1.Controls.Add(Me.cboProduto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 197)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(760, 336)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(536, 39)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(79, 22)
        Me.txtTotal.TabIndex = 57
        Me.txtTotal.Visible = False
        '
        'txtValorUnit
        '
        Me.txtValorUnit.Location = New System.Drawing.Point(444, 39)
        Me.txtValorUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorUnit.Name = "txtValorUnit"
        Me.txtValorUnit.Size = New System.Drawing.Size(84, 22)
        Me.txtValorUnit.TabIndex = 56
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(645, 336)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(161, 97)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'btnremove
        '
        Me.btnremove.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnremove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnremove.Location = New System.Drawing.Point(622, 131)
        Me.btnremove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(123, 54)
        Me.btnremove.TabIndex = 53
        Me.btnremove.Text = "Remover"
        Me.btnremove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnAdicionar.Location = New System.Drawing.Point(622, 72)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(123, 54)
        Me.btnAdicionar.TabIndex = 52
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblpagar)
        Me.GroupBox4.Controls.Add(Me.lbldinheiro)
        Me.GroupBox4.Controls.Add(Me.txtDinheiro)
        Me.GroupBox4.Controls.Add(Me.lblTroco)
        Me.GroupBox4.Controls.Add(Me.lbltotalpg)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cboPagar)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(781, 201)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(219, 336)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        '
        'lblpagar
        '
        Me.lblpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagar.Location = New System.Drawing.Point(20, 233)
        Me.lblpagar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpagar.Name = "lblpagar"
        Me.lblpagar.Size = New System.Drawing.Size(160, 25)
        Me.lblpagar.TabIndex = 68
        Me.lblpagar.Text = "Troco"
        '
        'lbldinheiro
        '
        Me.lbldinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldinheiro.Location = New System.Drawing.Point(20, 162)
        Me.lbldinheiro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldinheiro.Name = "lbldinheiro"
        Me.lbldinheiro.Size = New System.Drawing.Size(120, 23)
        Me.lbldinheiro.TabIndex = 67
        Me.lbldinheiro.Text = "Dinheiro"
        '
        'txtDinheiro
        '
        Me.txtDinheiro.Location = New System.Drawing.Point(24, 190)
        Me.txtDinheiro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDinheiro.Name = "txtDinheiro"
        Me.txtDinheiro.Size = New System.Drawing.Size(173, 22)
        Me.txtDinheiro.TabIndex = 66
        '
        'lblTroco
        '
        Me.lblTroco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroco.ForeColor = System.Drawing.Color.Red
        Me.lblTroco.Location = New System.Drawing.Point(24, 258)
        Me.lblTroco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTroco.Name = "lblTroco"
        Me.lblTroco.Size = New System.Drawing.Size(173, 38)
        Me.lblTroco.TabIndex = 65
        Me.lblTroco.Text = "0,00"
        Me.lblTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotalpg
        '
        Me.lbltotalpg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotalpg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalpg.ForeColor = System.Drawing.Color.Red
        Me.lbltotalpg.Location = New System.Drawing.Point(24, 110)
        Me.lbltotalpg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalpg.Name = "lbltotalpg"
        Me.lbltotalpg.Size = New System.Drawing.Size(173, 37)
        Me.lbltotalpg.TabIndex = 64
        Me.lbltotalpg.Text = "0,00"
        Me.lbltotalpg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 25)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Total a pagar"
        '
        'cboPagar
        '
        Me.cboPagar.FormattingEnabled = True
        Me.cboPagar.Items.AddRange(New Object() {"Na Loca��o", "Na Entrega"})
        Me.cboPagar.Location = New System.Drawing.Point(24, 42)
        Me.cboPagar.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPagar.Name = "cboPagar"
        Me.cboPagar.Size = New System.Drawing.Size(173, 24)
        Me.cboPagar.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 20)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Pagar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(797, 103)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'cboFuncionario
        '
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(117, 118)
        Me.cboFuncionario.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(365, 24)
        Me.cboFuncionario.TabIndex = 63
        '
        'txtCodLocacao
        '
        Me.txtCodLocacao.Location = New System.Drawing.Point(12, 118)
        Me.txtCodLocacao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodLocacao.Name = "txtCodLocacao"
        Me.txtCodLocacao.Size = New System.Drawing.Size(96, 22)
        Me.txtCodLocacao.TabIndex = 64
        '
        'ER
        '
        Me.ER.ContainerControl = Me
        '
        'btnImprimir
        '
        Me.btnImprimir.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.print_view
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImprimir.Location = New System.Drawing.Point(564, 554)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(139, 66)
        Me.btnImprimir.TabIndex = 65
        Me.btnImprimir.Text = "I&mprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'frmLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 635)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtCodLocacao)
        Me.Controls.Add(Me.cboFuncionario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpDevolucao)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.dtpLocacao)
        Me.Controls.Add(Me.cboclientes)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDtDevolucao)
        Me.Controls.Add(Me.lblDtLocacao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLocacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loca��o"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblQuantidade As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDtLocacao As System.Windows.Forms.Label
    Friend WithEvents lblDtDevolucao As System.Windows.Forms.Label
    Friend WithEvents txtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboclientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboProduto As System.Windows.Forms.ComboBox
    Friend WithEvents dtpLocacao As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDevolucao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblpagar As System.Windows.Forms.Label
    Friend WithEvents lbldinheiro As System.Windows.Forms.Label
    Friend WithEvents txtDinheiro As System.Windows.Forms.TextBox
    Friend WithEvents lblTroco As System.Windows.Forms.Label
    Friend WithEvents lbltotalpg As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPagar As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents txtValorUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCodLocacao As System.Windows.Forms.TextBox
    Friend WithEvents ER As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
