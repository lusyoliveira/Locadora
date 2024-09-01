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
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.cboProduto = New System.Windows.Forms.ComboBox()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dtpFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblDtReserva = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.AlterarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ConsultarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ImprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.RecortarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopiarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ColarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tcReserva = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.tpReserva = New System.Windows.Forms.TabPage()
        Me.txtCodReserva = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpReservaIni = New System.Windows.Forms.DateTimePicker()
        Me.dtpReservaFim = New System.Windows.Forms.DateTimePicker()
        Me.lstConsulta = New System.Windows.Forms.ListView()
        Me.CodReserva = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Inicio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fim = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Reserva = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
        Me.tcReserva.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tpReserva.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 76)
        Me.Panel1.TabIndex = 2
        '
        'btnRemover
        '
        Me.btnRemover.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.ball_stop
        Me.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemover.Location = New System.Drawing.Point(533, 67)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(20, 20)
        Me.btnRemover.TabIndex = 10
        Me.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemover.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.BackgroundImage = Global.ProjetoLocadora.My.Resources.Resources.add
        Me.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.Location = New System.Drawing.Point(500, 67)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(20, 20)
        Me.btnAdicionar.TabIndex = 9
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'cboProduto
        '
        Me.cboProduto.FormattingEnabled = True
        Me.cboProduto.Location = New System.Drawing.Point(12, 68)
        Me.cboProduto.Name = "cboProduto"
        Me.cboProduto.Size = New System.Drawing.Size(482, 21)
        Me.cboProduto.TabIndex = 42
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Titulo})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(12, 97)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(541, 227)
        Me.lstgrade.TabIndex = 41
        Me.lstgrade.Tag = "0"
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'Codigo
        '
        Me.Codigo.Text = "Codigo"
        '
        'Titulo
        '
        Me.Titulo.Text = "Titulo"
        Me.Titulo.Width = 293
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(9, 53)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(35, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Título"
        '
        'dtpFim
        '
        Me.dtpFim.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFim.Location = New System.Drawing.Point(466, 23)
        Me.dtpFim.Name = "dtpFim"
        Me.dtpFim.Size = New System.Drawing.Size(87, 20)
        Me.dtpFim.TabIndex = 40
        '
        'dtpInicio
        '
        Me.dtpInicio.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(374, 23)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(87, 20)
        Me.dtpInicio.TabIndex = 0
        '
        'cboCliente
        '
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(91, 23)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(277, 21)
        Me.cboCliente.TabIndex = 36
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(88, 7)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 35
        Me.lblCliente.Text = "Cliente"
        '
        'lblDtReserva
        '
        Me.lblDtReserva.AutoSize = True
        Me.lblDtReserva.Location = New System.Drawing.Point(372, 7)
        Me.lblDtReserva.Name = "lblDtReserva"
        Me.lblDtReserva.Size = New System.Drawing.Size(103, 13)
        Me.lblDtReserva.TabIndex = 3
        Me.lblDtReserva.Text = "Período de Reserva"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.SalvarToolStripButton, Me.AlterarToolStripButton, Me.ExcluirToolStripButton, Me.ConsultarToolStripButton, Me.ImprimirToolStripButton, Me.toolStripSeparator, Me.RecortarToolStripButton, Me.CopiarToolStripButton, Me.ColarToolStripButton, Me.toolStripSeparator1, Me.AjudaToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 76)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(595, 25)
        Me.ToolStrip1.TabIndex = 71
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NovoToolStripButton.Text = "&Novo"
        '
        'SalvarToolStripButton
        '
        Me.SalvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalvarToolStripButton.Enabled = False
        Me.SalvarToolStripButton.Image = CType(resources.GetObject("SalvarToolStripButton.Image"), System.Drawing.Image)
        Me.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripButton.Name = "SalvarToolStripButton"
        Me.SalvarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SalvarToolStripButton.Text = "&Salvar"
        '
        'AlterarToolStripButton
        '
        Me.AlterarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlterarToolStripButton.Enabled = False
        Me.AlterarToolStripButton.Image = Global.ProjetoLocadora.My.Resources.Resources.Alterar
        Me.AlterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AlterarToolStripButton.Name = "AlterarToolStripButton"
        Me.AlterarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AlterarToolStripButton.Text = "Alterar"
        '
        'ExcluirToolStripButton
        '
        Me.ExcluirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExcluirToolStripButton.Enabled = False
        Me.ExcluirToolStripButton.Image = CType(resources.GetObject("ExcluirToolStripButton.Image"), System.Drawing.Image)
        Me.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirToolStripButton.Name = "ExcluirToolStripButton"
        Me.ExcluirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ExcluirToolStripButton.Text = "Excluir"
        '
        'ConsultarToolStripButton
        '
        Me.ConsultarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConsultarToolStripButton.Image = Global.ProjetoLocadora.My.Resources.Resources.Consultar
        Me.ConsultarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConsultarToolStripButton.Name = "ConsultarToolStripButton"
        Me.ConsultarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ConsultarToolStripButton.Text = "Consultar"
        '
        'ImprimirToolStripButton
        '
        Me.ImprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImprimirToolStripButton.Image = CType(resources.GetObject("ImprimirToolStripButton.Image"), System.Drawing.Image)
        Me.ImprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImprimirToolStripButton.Name = "ImprimirToolStripButton"
        Me.ImprimirToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ImprimirToolStripButton.Text = "&Imprimir"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'RecortarToolStripButton
        '
        Me.RecortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecortarToolStripButton.Image = CType(resources.GetObject("RecortarToolStripButton.Image"), System.Drawing.Image)
        Me.RecortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RecortarToolStripButton.Name = "RecortarToolStripButton"
        Me.RecortarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.RecortarToolStripButton.Text = "Recor&tar"
        '
        'CopiarToolStripButton
        '
        Me.CopiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopiarToolStripButton.Image = CType(resources.GetObject("CopiarToolStripButton.Image"), System.Drawing.Image)
        Me.CopiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopiarToolStripButton.Name = "CopiarToolStripButton"
        Me.CopiarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopiarToolStripButton.Text = "&Copiar"
        '
        'ColarToolStripButton
        '
        Me.ColarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColarToolStripButton.Image = CType(resources.GetObject("ColarToolStripButton.Image"), System.Drawing.Image)
        Me.ColarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ColarToolStripButton.Name = "ColarToolStripButton"
        Me.ColarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ColarToolStripButton.Text = "C&olar"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AjudaToolStripButton
        '
        Me.AjudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AjudaToolStripButton.Image = CType(resources.GetObject("AjudaToolStripButton.Image"), System.Drawing.Image)
        Me.AjudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AjudaToolStripButton.Name = "AjudaToolStripButton"
        Me.AjudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AjudaToolStripButton.Text = "&Ajuda"
        '
        'tcReserva
        '
        Me.tcReserva.Controls.Add(Me.tpListagem)
        Me.tcReserva.Controls.Add(Me.tpReserva)
        Me.tcReserva.Location = New System.Drawing.Point(12, 104)
        Me.tcReserva.Name = "tcReserva"
        Me.tcReserva.SelectedIndex = 0
        Me.tcReserva.Size = New System.Drawing.Size(574, 361)
        Me.tcReserva.TabIndex = 72
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.GroupBox1)
        Me.tpListagem.Controls.Add(Me.lstConsulta)
        Me.tpListagem.Location = New System.Drawing.Point(4, 22)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(566, 335)
        Me.tpListagem.TabIndex = 1
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'tpReserva
        '
        Me.tpReserva.Controls.Add(Me.txtCodReserva)
        Me.tpReserva.Controls.Add(Me.lblCodigo)
        Me.tpReserva.Controls.Add(Me.btnRemover)
        Me.tpReserva.Controls.Add(Me.btnAdicionar)
        Me.tpReserva.Controls.Add(Me.dtpFim)
        Me.tpReserva.Controls.Add(Me.dtpInicio)
        Me.tpReserva.Controls.Add(Me.lblDtReserva)
        Me.tpReserva.Controls.Add(Me.lblCliente)
        Me.tpReserva.Controls.Add(Me.cboProduto)
        Me.tpReserva.Controls.Add(Me.lstgrade)
        Me.tpReserva.Controls.Add(Me.cboCliente)
        Me.tpReserva.Controls.Add(Me.lblTitulo)
        Me.tpReserva.Location = New System.Drawing.Point(4, 22)
        Me.tpReserva.Name = "tpReserva"
        Me.tpReserva.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReserva.Size = New System.Drawing.Size(566, 335)
        Me.tpReserva.TabIndex = 0
        Me.tpReserva.Text = "Reserva"
        Me.tpReserva.UseVisualStyleBackColor = True
        '
        'txtCodReserva
        '
        Me.txtCodReserva.Enabled = False
        Me.txtCodReserva.Location = New System.Drawing.Point(12, 23)
        Me.txtCodReserva.Name = "txtCodReserva"
        Me.txtCodReserva.Size = New System.Drawing.Size(73, 20)
        Me.txtCodReserva.TabIndex = 66
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(11, 7)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(62, 13)
        Me.lblCodigo.TabIndex = 65
        Me.lblCodigo.Text = "Nº Reserva"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpReservaIni)
        Me.GroupBox1.Controls.Add(Me.dtpReservaFim)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 51)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reserva"
        '
        'dtpReservaIni
        '
        Me.dtpReservaIni.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpReservaIni.Checked = False
        Me.dtpReservaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReservaIni.Location = New System.Drawing.Point(6, 19)
        Me.dtpReservaIni.Name = "dtpReservaIni"
        Me.dtpReservaIni.ShowCheckBox = True
        Me.dtpReservaIni.Size = New System.Drawing.Size(98, 20)
        Me.dtpReservaIni.TabIndex = 78
        '
        'dtpReservaFim
        '
        Me.dtpReservaFim.CalendarTitleBackColor = System.Drawing.Color.DarkRed
        Me.dtpReservaFim.Checked = False
        Me.dtpReservaFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReservaFim.Location = New System.Drawing.Point(110, 19)
        Me.dtpReservaFim.Name = "dtpReservaFim"
        Me.dtpReservaFim.ShowCheckBox = True
        Me.dtpReservaFim.Size = New System.Drawing.Size(98, 20)
        Me.dtpReservaFim.TabIndex = 77
        '
        'lstConsulta
        '
        Me.lstConsulta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CodReserva, Me.Cliente, Me.Inicio, Me.Fim, Me.Reserva})
        Me.lstConsulta.FullRowSelect = True
        Me.lstConsulta.HideSelection = False
        Me.lstConsulta.Location = New System.Drawing.Point(6, 63)
        Me.lstConsulta.Name = "lstConsulta"
        Me.lstConsulta.Size = New System.Drawing.Size(554, 266)
        Me.lstConsulta.TabIndex = 80
        Me.lstConsulta.UseCompatibleStateImageBehavior = False
        Me.lstConsulta.View = System.Windows.Forms.View.Details
        '
        'CodReserva
        '
        Me.CodReserva.Text = "Código"
        '
        'Cliente
        '
        Me.Cliente.Text = "Cliente"
        Me.Cliente.Width = 120
        '
        'Inicio
        '
        Me.Inicio.Text = "Inicio"
        Me.Inicio.Width = 100
        '
        'Fim
        '
        Me.Fim.Text = "Fim"
        Me.Fim.Width = 100
        '
        'Reserva
        '
        Me.Reserva.Text = "Reserva"
        Me.Reserva.Width = 100
        '
        'frmReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 472)
        Me.Controls.Add(Me.tcReserva)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tcReserva.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tpReserva.ResumeLayout(False)
        Me.tpReserva.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents cboProduto As System.Windows.Forms.ComboBox
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents Titulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents dtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboCliente As System.Windows.Forms.ComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblDtReserva As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents SalvarToolStripButton As ToolStripButton
    Friend WithEvents AlterarToolStripButton As ToolStripButton
    Friend WithEvents ExcluirToolStripButton As ToolStripButton
    Friend WithEvents ConsultarToolStripButton As ToolStripButton
    Friend WithEvents ImprimirToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents RecortarToolStripButton As ToolStripButton
    Friend WithEvents CopiarToolStripButton As ToolStripButton
    Friend WithEvents ColarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AjudaToolStripButton As ToolStripButton
    Friend WithEvents tcReserva As TabControl
    Friend WithEvents tpReserva As TabPage
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents txtCodReserva As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtpReservaIni As DateTimePicker
    Friend WithEvents dtpReservaFim As DateTimePicker
    Friend WithEvents lstConsulta As ListView
    Friend WithEvents CodReserva As ColumnHeader
    Friend WithEvents Cliente As ColumnHeader
    Friend WithEvents Inicio As ColumnHeader
    Friend WithEvents Fim As ColumnHeader
    Friend WithEvents Reserva As ColumnHeader
End Class
