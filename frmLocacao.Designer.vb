<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocacao
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocacao))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblValor = New System.Windows.Forms.Label
        Me.lblQuantidade = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblDtLocacao = New System.Windows.Forms.Label
        Me.lblDtDevolucao = New System.Windows.Forms.Label
        Me.txtQuantidade = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.BTNSALVAR = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboclientes = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboproduto = New System.Windows.Forms.ComboBox
        Me.DTP_LOCACAO = New System.Windows.Forms.DateTimePicker
        Me.DTP_DEVOLUCAO = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.lstgrade = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbltotal1 = New System.Windows.Forms.TextBox
        Me.lblvalunit = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnremove = New System.Windows.Forms.Button
        Me.btnok = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblpagar = New System.Windows.Forms.Label
        Me.lbldinheiro = New System.Windows.Forms.Label
        Me.txtdinheiro = New System.Windows.Forms.TextBox
        Me.LBLTROCO = New System.Windows.Forms.Label
        Me.lbltotalpg = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbopagar = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CBO_FUNCIONARIO = New System.Windows.Forms.ComboBox
        Me.TXT_NSEQ = New System.Windows.Forms.TextBox
        Me.ER = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BTN_IMPRIMIR = New System.Windows.Forms.Button
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 75)
        Me.Panel1.TabIndex = 0
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(32, 90)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(76, 13)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "N°da Locação"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(303, 15)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(31, 13)
        Me.lblValor.TabIndex = 5
        Me.lblValor.Text = "Valor"
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(422, 157)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 6
        Me.lblQuantidade.Text = "Quantidade"
        Me.lblQuantidade.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(399, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total"
        Me.lblTotal.Visible = False
        '
        'lblDtLocacao
        '
        Me.lblDtLocacao.AutoSize = True
        Me.lblDtLocacao.Location = New System.Drawing.Point(394, 90)
        Me.lblDtLocacao.Name = "lblDtLocacao"
        Me.lblDtLocacao.Size = New System.Drawing.Size(90, 13)
        Me.lblDtLocacao.TabIndex = 8
        Me.lblDtLocacao.Text = "Data da Locação"
        '
        'lblDtDevolucao
        '
        Me.lblDtDevolucao.AutoSize = True
        Me.lblDtDevolucao.Location = New System.Drawing.Point(512, 87)
        Me.lblDtDevolucao.Name = "lblDtDevolucao"
        Me.lblDtDevolucao.Size = New System.Drawing.Size(100, 13)
        Me.lblDtDevolucao.TabIndex = 9
        Me.lblDtDevolucao.Text = "Data da Devolução"
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(425, 175)
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(60, 20)
        Me.txtQuantidade.TabIndex = 17
        Me.txtQuantidade.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.BTNSALVAR)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 473)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(485, 80)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(259, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 45)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "&Sair"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Projeto_Locadora.My.Resources.Resources.doc_info
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(12, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BTNSALVAR
        '
        Me.BTNSALVAR.Image = Global.Projeto_Locadora.My.Resources.Resources.external_hd
        Me.BTNSALVAR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTNSALVAR.Location = New System.Drawing.Point(137, 19)
        Me.BTNSALVAR.Name = "BTNSALVAR"
        Me.BTNSALVAR.Size = New System.Drawing.Size(106, 45)
        Me.BTNSALVAR.TabIndex = 1
        Me.BTNSALVAR.Text = "S&alvar"
        Me.BTNSALVAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALVAR.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(8, 10)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 45)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "&Sair"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cliente"
        '
        'cboclientes
        '
        Me.cboclientes.FormattingEnabled = True
        Me.cboclientes.Location = New System.Drawing.Point(35, 157)
        Me.cboclientes.Name = "cboclientes"
        Me.cboclientes.Size = New System.Drawing.Size(354, 21)
        Me.cboclientes.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Titulo"
        '
        'cboproduto
        '
        Me.cboproduto.FormattingEnabled = True
        Me.cboproduto.Location = New System.Drawing.Point(13, 32)
        Me.cboproduto.Name = "cboproduto"
        Me.cboproduto.Size = New System.Drawing.Size(281, 21)
        Me.cboproduto.TabIndex = 41
        '
        'DTP_LOCACAO
        '
        Me.DTP_LOCACAO.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.DTP_LOCACAO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_LOCACAO.Location = New System.Drawing.Point(397, 103)
        Me.DTP_LOCACAO.Name = "DTP_LOCACAO"
        Me.DTP_LOCACAO.Size = New System.Drawing.Size(99, 20)
        Me.DTP_LOCACAO.TabIndex = 45
        '
        'DTP_DEVOLUCAO
        '
        Me.DTP_DEVOLUCAO.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.DTP_DEVOLUCAO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DEVOLUCAO.Location = New System.Drawing.Point(515, 104)
        Me.DTP_DEVOLUCAO.Name = "DTP_DEVOLUCAO"
        Me.DTP_DEVOLUCAO.Size = New System.Drawing.Size(99, 20)
        Me.DTP_DEVOLUCAO.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Funcionario"
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstgrade.Location = New System.Drawing.Point(13, 64)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(449, 204)
        Me.lstgrade.TabIndex = 51
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Titulo"
        Me.ColumnHeader1.Width = 206
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Valor"
        Me.ColumnHeader2.Width = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbltotal1)
        Me.GroupBox1.Controls.Add(Me.lblvalunit)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.btnremove)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.lstgrade)
        Me.GroupBox1.Controls.Add(Me.cboproduto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblValor)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(594, 273)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'lbltotal1
        '
        Me.lbltotal1.Location = New System.Drawing.Point(402, 32)
        Me.lbltotal1.Name = "lbltotal1"
        Me.lbltotal1.Size = New System.Drawing.Size(106, 20)
        Me.lbltotal1.TabIndex = 57
        Me.lbltotal1.Visible = False
        '
        'lblvalunit
        '
        Me.lblvalunit.Location = New System.Drawing.Point(302, 34)
        Me.lblvalunit.Name = "lblvalunit"
        Me.lblvalunit.Size = New System.Drawing.Size(91, 20)
        Me.lblvalunit.TabIndex = 56
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Location = New System.Drawing.Point(484, 273)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 79)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'btnremove
        '
        Me.btnremove.Image = Global.Projeto_Locadora.My.Resources.Resources.trash
        Me.btnremove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnremove.Location = New System.Drawing.Point(477, 114)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(106, 43)
        Me.btnremove.TabIndex = 53
        Me.btnremove.Text = "Remover"
        Me.btnremove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.Image = Global.Projeto_Locadora.My.Resources.Resources.add
        Me.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnok.Location = New System.Drawing.Point(477, 64)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(106, 43)
        Me.btnok.TabIndex = 52
        Me.btnok.Text = "Adicionar"
        Me.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblpagar)
        Me.GroupBox4.Controls.Add(Me.lbldinheiro)
        Me.GroupBox4.Controls.Add(Me.txtdinheiro)
        Me.GroupBox4.Controls.Add(Me.LBLTROCO)
        Me.GroupBox4.Controls.Add(Me.lbltotalpg)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cbopagar)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(652, 195)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 273)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        '
        'lblpagar
        '
        Me.lblpagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagar.Location = New System.Drawing.Point(44, 193)
        Me.lblpagar.Name = "lblpagar"
        Me.lblpagar.Size = New System.Drawing.Size(120, 20)
        Me.lblpagar.TabIndex = 68
        Me.lblpagar.Text = "Troco"
        '
        'lbldinheiro
        '
        Me.lbldinheiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldinheiro.Location = New System.Drawing.Point(44, 138)
        Me.lbldinheiro.Name = "lbldinheiro"
        Me.lbldinheiro.Size = New System.Drawing.Size(90, 19)
        Me.lbldinheiro.TabIndex = 67
        Me.lbldinheiro.Text = "Dinheiro"
        '
        'txtdinheiro
        '
        Me.txtdinheiro.Location = New System.Drawing.Point(47, 158)
        Me.txtdinheiro.Name = "txtdinheiro"
        Me.txtdinheiro.Size = New System.Drawing.Size(87, 20)
        Me.txtdinheiro.TabIndex = 66
        '
        'LBLTROCO
        '
        Me.LBLTROCO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTROCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTROCO.ForeColor = System.Drawing.Color.Red
        Me.LBLTROCO.Location = New System.Drawing.Point(47, 213)
        Me.LBLTROCO.Name = "LBLTROCO"
        Me.LBLTROCO.Size = New System.Drawing.Size(87, 31)
        Me.LBLTROCO.TabIndex = 65
        Me.LBLTROCO.Text = "0,00"
        Me.LBLTROCO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotalpg
        '
        Me.lbltotalpg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotalpg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalpg.ForeColor = System.Drawing.Color.Red
        Me.lbltotalpg.Location = New System.Drawing.Point(47, 93)
        Me.lbltotalpg.Name = "lbltotalpg"
        Me.lbltotalpg.Size = New System.Drawing.Size(87, 30)
        Me.lbltotalpg.TabIndex = 64
        Me.lbltotalpg.Text = "0,00"
        Me.lbltotalpg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Total a pagar"
        '
        'cbopagar
        '
        Me.cbopagar.FormattingEnabled = True
        Me.cbopagar.Items.AddRange(New Object() {"Na Locação", "Na Entrega"})
        Me.cbopagar.Location = New System.Drawing.Point(35, 37)
        Me.cbopagar.Name = "cbopagar"
        Me.cbopagar.Size = New System.Drawing.Size(131, 21)
        Me.cbopagar.TabIndex = 62
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(32, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Pagar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Projeto_Locadora.My.Resources.Resources.Filmadora_rolo_de_filmes_e_claquete_01
        Me.PictureBox1.Location = New System.Drawing.Point(652, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'CBO_FUNCIONARIO
        '
        Me.CBO_FUNCIONARIO.FormattingEnabled = True
        Me.CBO_FUNCIONARIO.Location = New System.Drawing.Point(114, 102)
        Me.CBO_FUNCIONARIO.Name = "CBO_FUNCIONARIO"
        Me.CBO_FUNCIONARIO.Size = New System.Drawing.Size(275, 21)
        Me.CBO_FUNCIONARIO.TabIndex = 63
        '
        'TXT_NSEQ
        '
        Me.TXT_NSEQ.Location = New System.Drawing.Point(35, 104)
        Me.TXT_NSEQ.Name = "TXT_NSEQ"
        Me.TXT_NSEQ.Size = New System.Drawing.Size(73, 20)
        Me.TXT_NSEQ.TabIndex = 64
        '
        'ER
        '
        Me.ER.ContainerControl = Me
        '
        'BTN_IMPRIMIR
        '
        Me.BTN_IMPRIMIR.Location = New System.Drawing.Point(397, 492)
        Me.BTN_IMPRIMIR.Name = "BTN_IMPRIMIR"
        Me.BTN_IMPRIMIR.Size = New System.Drawing.Size(104, 45)
        Me.BTN_IMPRIMIR.TabIndex = 65
        Me.BTN_IMPRIMIR.Text = "I&mprimir"
        Me.BTN_IMPRIMIR.UseVisualStyleBackColor = True
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 567)
        Me.Controls.Add(Me.BTN_IMPRIMIR)
        Me.Controls.Add(Me.TXT_NSEQ)
        Me.Controls.Add(Me.CBO_FUNCIONARIO)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTP_DEVOLUCAO)
        Me.Controls.Add(Me.txtQuantidade)
        Me.Controls.Add(Me.DTP_LOCACAO)
        Me.Controls.Add(Me.cboclientes)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblDtDevolucao)
        Me.Controls.Add(Me.lblDtLocacao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLocacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locação"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BTNSALVAR As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboclientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboproduto As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_LOCACAO As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_DEVOLUCAO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblpagar As System.Windows.Forms.Label
    Friend WithEvents lbldinheiro As System.Windows.Forms.Label
    Friend WithEvents txtdinheiro As System.Windows.Forms.TextBox
    Friend WithEvents LBLTROCO As System.Windows.Forms.Label
    Friend WithEvents lbltotalpg As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbopagar As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CBO_FUNCIONARIO As System.Windows.Forms.ComboBox
    Friend WithEvents lblvalunit As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal1 As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NSEQ As System.Windows.Forms.TextBox
    Friend WithEvents ER As System.Windows.Forms.ErrorProvider
    Friend WithEvents BTN_IMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
