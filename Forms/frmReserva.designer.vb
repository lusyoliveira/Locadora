<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReserva
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReserva))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblValorUnit = New System.Windows.Forms.Label()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.dtpDevolucao = New System.Windows.Forms.DateTimePicker()
        Me.dtpReserva = New System.Windows.Forms.DateTimePicker()
        Me.lblDtDevolucao = New System.Windows.Forms.Label()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDtReserva = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(825, 94)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblValorUnit)
        Me.GroupBox1.Controls.Add(Me.btnRemover)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.btnReservar)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.cboProduto)
        Me.GroupBox1.Controls.Add(Me.lstgrade)
        Me.GroupBox1.Controls.Add(Me.lblTitulo)
        Me.GroupBox1.Controls.Add(Me.lblValorTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 177)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(799, 363)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'lblValorUnit
        '
        Me.lblValorUnit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblValorUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValorUnit.ForeColor = System.Drawing.Color.Blue
        Me.lblValorUnit.Location = New System.Drawing.Point(501, 32)
        Me.lblValorUnit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorUnit.Name = "lblValorUnit"
        Me.lblValorUnit.Size = New System.Drawing.Size(125, 24)
        Me.lblValorUnit.TabIndex = 48
        Me.lblValorUnit.Text = "0,00"
        Me.lblValorUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRemover
        '
        Me.btnRemover.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemover.Location = New System.Drawing.Point(644, 131)
        Me.btnRemover.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(141, 55)
        Me.btnRemover.TabIndex = 10
        Me.btnRemover.Text = "R&emover"
        Me.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lblTotal)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Location = New System.Drawing.Point(634, 257)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(157, 82)
        Me.GroupBox9.TabIndex = 47
        Me.GroupBox9.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(12, 46)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(133, 28)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.Text = "0,00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 30)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Total a Pagar"
        '
        'btnReservar
        '
        Me.btnReservar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ok
        Me.btnReservar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReservar.Location = New System.Drawing.Point(644, 194)
        Me.btnReservar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(141, 55)
        Me.btnReservar.TabIndex = 8
        Me.btnReservar.Text = "&Reservar"
        Me.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.Location = New System.Drawing.Point(644, 68)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(141, 55)
        Me.btnAdicionar.TabIndex = 9
        Me.btnAdicionar.Text = "&Adicionar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(20, 32)
        Me.cboProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(473, 24)
        Me.cboProduto.TabIndex = 42
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(20, 68)
        Me.lstgrade.Margin = New System.Windows.Forms.Padding(4)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(606, 271)
        Me.lstgrade.TabIndex = 41
        Me.lstgrade.Tag = "0"
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Titulo"
        Me.ColumnHeader2.Width = 293
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Valor"
        Me.ColumnHeader3.Width = 110
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(16, 14)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(40, 16)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Título"
        '
        'lblValorTotal
        '
        Me.lblValorTotal.AutoSize = True
        Me.lblValorTotal.Location = New System.Drawing.Point(498, 14)
        Me.lblValorTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(88, 16)
        Me.lblValorTotal.TabIndex = 9
        Me.lblValorTotal.Text = "Valor Unitário"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.dtpDevolucao)
        Me.GroupBox8.Controls.Add(Me.dtpReserva)
        Me.GroupBox8.Controls.Add(Me.lblDtDevolucao)
        Me.GroupBox8.Controls.Add(Me.cboCliente)
        Me.GroupBox8.Controls.Add(Me.lblCliente)
        Me.GroupBox8.Controls.Add(Me.lblDtReserva)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox8.Size = New System.Drawing.Size(799, 68)
        Me.GroupBox8.TabIndex = 46
        Me.GroupBox8.TabStop = False
        '
        'dtpDevolucao
        '
        Me.dtpDevolucao.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDevolucao.Location = New System.Drawing.Point(624, 36)
        Me.dtpDevolucao.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDevolucao.Name = "dtpDevolucao"
        Me.dtpDevolucao.Size = New System.Drawing.Size(115, 22)
        Me.dtpDevolucao.TabIndex = 40
        '
        'dtpReserva
        '
        Me.dtpReserva.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpReserva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReserva.Location = New System.Drawing.Point(501, 35)
        Me.dtpReserva.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpReserva.Name = "dtpReserva"
        Me.dtpReserva.Size = New System.Drawing.Size(115, 22)
        Me.dtpReserva.TabIndex = 0
        '
        'lblDtDevolucao
        '
        Me.lblDtDevolucao.AutoSize = True
        Me.lblDtDevolucao.Location = New System.Drawing.Point(621, 15)
        Me.lblDtDevolucao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtDevolucao.Name = "lblDtDevolucao"
        Me.lblDtDevolucao.Size = New System.Drawing.Size(124, 16)
        Me.lblDtDevolucao.TabIndex = 7
        Me.lblDtDevolucao.Text = "Data da Devolução"
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(19, 34)
        Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(474, 24)
        Me.cboCliente.TabIndex = 36
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(16, 15)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 16)
        Me.lblCliente.TabIndex = 35
        Me.lblCliente.Text = "Cliente"
        '
        'lblDtReserva
        '
        Me.lblDtReserva.AutoSize = True
        Me.lblDtReserva.Location = New System.Drawing.Point(498, 15)
        Me.lblDtReserva.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtReserva.Name = "lblDtReserva"
        Me.lblDtReserva.Size = New System.Drawing.Size(110, 16)
        Me.lblDtReserva.TabIndex = 3
        Me.lblDtReserva.Text = "Data da Reserva"
        '
        'frmReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 566)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblValorUnit As System.Windows.Forms.Label
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReservar As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents cboProduto As System.Windows.Forms.ComboBox
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDevolucao As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReserva As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDtDevolucao As System.Windows.Forms.Label
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDtReserva As System.Windows.Forms.Label
End Class
