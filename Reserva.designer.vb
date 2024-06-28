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
        Me.lblvalunit = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReservar = New System.Windows.Forms.Button()
        Me.btnok = New System.Windows.Forms.Button()
        Me.CBO_PRODUTO = New System.Windows.Forms.ComboBox()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblValorTotal = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DTP_DEVOLUCAO = New System.Windows.Forms.DateTimePicker()
        Me.DTP_RESERVA = New System.Windows.Forms.DateTimePicker()
        Me.lblDtDevolucao = New System.Windows.Forms.Label()
        Me.CBO_CLIENTE = New System.Windows.Forms.ComboBox()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(867, 94)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblvalunit)
        Me.GroupBox1.Controls.Add(Me.btnSair)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Controls.Add(Me.btnReservar)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.CBO_PRODUTO)
        Me.GroupBox1.Controls.Add(Me.lstgrade)
        Me.GroupBox1.Controls.Add(Me.lblTitulo)
        Me.GroupBox1.Controls.Add(Me.lblValorTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 176)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(799, 389)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'lblvalunit
        '
        Me.lblvalunit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblvalunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalunit.ForeColor = System.Drawing.Color.Blue
        Me.lblvalunit.Location = New System.Drawing.Point(481, 32)
        Me.lblvalunit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblvalunit.Name = "lblvalunit"
        Me.lblvalunit.Size = New System.Drawing.Size(125, 28)
        Me.lblvalunit.TabIndex = 48
        Me.lblvalunit.Text = "0,00"
        Me.lblvalunit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSair
        '
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(640, 324)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 55)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "&Cancelar"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(643, 95)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 55)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "R&emover"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.lbltotal)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Location = New System.Drawing.Point(619, 158)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox9.Size = New System.Drawing.Size(165, 82)
        Me.GroupBox9.TabIndex = 47
        Me.GroupBox9.TabStop = False
        '
        'lbltotal
        '
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Red
        Me.lbltotal.Location = New System.Drawing.Point(21, 46)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(133, 28)
        Me.lbltotal.TabIndex = 46
        Me.lbltotal.Text = "0,00"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReservar.Location = New System.Drawing.Point(465, 324)
        Me.btnReservar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReservar.Name = "btnReservar"
        Me.btnReservar.Size = New System.Drawing.Size(141, 55)
        Me.btnReservar.TabIndex = 8
        Me.btnReservar.Text = "&Reservar"
        Me.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReservar.UseVisualStyleBackColor = True
        '
        'btnok
        '
        Me.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnok.Location = New System.Drawing.Point(640, 32)
        Me.btnok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(141, 55)
        Me.btnok.TabIndex = 9
        Me.btnok.Text = "&Adicionar"
        Me.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnok.UseVisualStyleBackColor = True
        '
        'CBO_PRODUTO
        '
        Me.CBO_PRODUTO.FormattingEnabled = True
        Me.CBO_PRODUTO.Location = New System.Drawing.Point(20, 32)
        Me.CBO_PRODUTO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBO_PRODUTO.Name = "CBO_PRODUTO"
        Me.CBO_PRODUTO.Size = New System.Drawing.Size(452, 24)
        Me.CBO_PRODUTO.TabIndex = 42
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(20, 68)
        Me.lstgrade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(585, 228)
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
        Me.lblValorTotal.Location = New System.Drawing.Point(481, 12)
        Me.lblValorTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorTotal.Name = "lblValorTotal"
        Me.lblValorTotal.Size = New System.Drawing.Size(88, 16)
        Me.lblValorTotal.TabIndex = 9
        Me.lblValorTotal.Text = "Valor Unitário"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DTP_DEVOLUCAO)
        Me.GroupBox8.Controls.Add(Me.DTP_RESERVA)
        Me.GroupBox8.Controls.Add(Me.lblDtDevolucao)
        Me.GroupBox8.Controls.Add(Me.CBO_CLIENTE)
        Me.GroupBox8.Controls.Add(Me.lblCliente)
        Me.GroupBox8.Controls.Add(Me.lblDtReserva)
        Me.GroupBox8.Location = New System.Drawing.Point(36, 101)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Size = New System.Drawing.Size(799, 68)
        Me.GroupBox8.TabIndex = 46
        Me.GroupBox8.TabStop = False
        '
        'DTP_DEVOLUCAO
        '
        Me.DTP_DEVOLUCAO.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.DTP_DEVOLUCAO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DEVOLUCAO.Location = New System.Drawing.Point(644, 33)
        Me.DTP_DEVOLUCAO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTP_DEVOLUCAO.Name = "DTP_DEVOLUCAO"
        Me.DTP_DEVOLUCAO.Size = New System.Drawing.Size(115, 22)
        Me.DTP_DEVOLUCAO.TabIndex = 40
        '
        'DTP_RESERVA
        '
        Me.DTP_RESERVA.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.DTP_RESERVA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_RESERVA.Location = New System.Drawing.Point(493, 34)
        Me.DTP_RESERVA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTP_RESERVA.Name = "DTP_RESERVA"
        Me.DTP_RESERVA.Size = New System.Drawing.Size(115, 22)
        Me.DTP_RESERVA.TabIndex = 0
        '
        'lblDtDevolucao
        '
        Me.lblDtDevolucao.AutoSize = True
        Me.lblDtDevolucao.Location = New System.Drawing.Point(640, 15)
        Me.lblDtDevolucao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtDevolucao.Name = "lblDtDevolucao"
        Me.lblDtDevolucao.Size = New System.Drawing.Size(124, 16)
        Me.lblDtDevolucao.TabIndex = 7
        Me.lblDtDevolucao.Text = "Data da Devolução"
        '
        'CBO_CLIENTE
        '
        Me.CBO_CLIENTE.FormattingEnabled = True
        Me.CBO_CLIENTE.Location = New System.Drawing.Point(19, 34)
        Me.CBO_CLIENTE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBO_CLIENTE.Name = "CBO_CLIENTE"
        Me.CBO_CLIENTE.Size = New System.Drawing.Size(453, 24)
        Me.CBO_CLIENTE.TabIndex = 36
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
        Me.lblDtReserva.Location = New System.Drawing.Point(489, 15)
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
        Me.ClientSize = New System.Drawing.Size(867, 586)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents lblvalunit As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReservar As System.Windows.Forms.Button
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents CBO_PRODUTO As System.Windows.Forms.ComboBox
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblValorTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DTP_DEVOLUCAO As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_RESERVA As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDtDevolucao As System.Windows.Forms.Label
    Friend WithEvents CBO_CLIENTE As System.Windows.Forms.ComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDtReserva As System.Windows.Forms.Label
End Class
