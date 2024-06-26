<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadUsuarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblPermissao = New System.Windows.Forms.Label()
        Me.cboPermissao = New System.Windows.Forms.ComboBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lblConfSenha = New System.Windows.Forms.Label()
        Me.txtConfSenha = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.lstgrade = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(852, 92)
        Me.Panel1.TabIndex = 2
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 100)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Código"
        Me.lblCodigo.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(25, 119)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(97, 22)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.Visible = False
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(126, 100)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
        Me.lblNome.TabIndex = 5
        Me.lblNome.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(130, 119)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(523, 22)
        Me.txtNome.TabIndex = 6
        '
        'lblPermissao
        '
        Me.lblPermissao.AutoSize = True
        Me.lblPermissao.Location = New System.Drawing.Point(472, 165)
        Me.lblPermissao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPermissao.Name = "lblPermissao"
        Me.lblPermissao.Size = New System.Drawing.Size(72, 16)
        Me.lblPermissao.TabIndex = 7
        Me.lblPermissao.Text = "Permissão"
        '
        'cboPermissao
        '
        Me.cboPermissao.FormattingEnabled = True
        Me.cboPermissao.Items.AddRange(New Object() {"Atendente", "Fiscal", "Gerente", "Master", "top"})
        Me.cboPermissao.Location = New System.Drawing.Point(476, 185)
        Me.cboPermissao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPermissao.Name = "cboPermissao"
        Me.cboPermissao.Size = New System.Drawing.Size(177, 24)
        Me.cboPermissao.TabIndex = 8
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(21, 165)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(46, 16)
        Me.lblSenha.TabIndex = 9
        Me.lblSenha.Text = "Senha"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(25, 185)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(179, 22)
        Me.txtSenha.TabIndex = 10
        '
        'lblConfSenha
        '
        Me.lblConfSenha.AutoSize = True
        Me.lblConfSenha.Location = New System.Drawing.Point(248, 165)
        Me.lblConfSenha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfSenha.Name = "lblConfSenha"
        Me.lblConfSenha.Size = New System.Drawing.Size(106, 16)
        Me.lblConfSenha.TabIndex = 11
        Me.lblConfSenha.Text = "Confirmar Senha"
        '
        'txtConfSenha
        '
        Me.txtConfSenha.Location = New System.Drawing.Point(252, 185)
        Me.txtConfSenha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfSenha.Name = "txtConfSenha"
        Me.txtConfSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfSenha.Size = New System.Drawing.Size(181, 22)
        Me.txtConfSenha.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnSalvar)
        Me.GroupBox2.Controls.Add(Me.btnNovo)
        Me.GroupBox2.Controls.Add(Me.btnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(672, 205)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(161, 274)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Projeto_Locadora.My.Resources.Resources.binoculars
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.Location = New System.Drawing.Point(12, 18)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(141, 55)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "C&onsultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.Projeto_Locadora.My.Resources.Resources.external_hd
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.Location = New System.Drawing.Point(12, 144)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(141, 55)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "S&alvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Image = Global.Projeto_Locadora.My.Resources.Resources.document
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.Location = New System.Drawing.Point(12, 81)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(141, 55)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "&Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.Projeto_Locadora.My.Resources.Resources.trash
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(12, 207)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(141, 55)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "&Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.UseVisualStyleBackColor = True
        Me.btnExcluir.Visible = False
        '
        'lstgrade
        '
        Me.lstgrade.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstgrade.HideSelection = False
        Me.lstgrade.Location = New System.Drawing.Point(25, 245)
        Me.lstgrade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstgrade.Name = "lstgrade"
        Me.lstgrade.Size = New System.Drawing.Size(628, 374)
        Me.lstgrade.TabIndex = 7
        Me.lstgrade.Tag = "0"
        Me.lstgrade.UseCompatibleStateImageBehavior = False
        Me.lstgrade.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome"
        Me.ColumnHeader2.Width = 250
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Permissão"
        Me.ColumnHeader3.Width = 113
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSair)
        Me.GroupBox3.Location = New System.Drawing.Point(672, 487)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(161, 82)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.Location = New System.Drawing.Point(12, 16)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(141, 55)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "&Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmCadUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 646)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lstgrade)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtConfSenha)
        Me.Controls.Add(Me.lblConfSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.cboPermissao)
        Me.Controls.Add(Me.lblPermissao)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmCadUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuários"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents lblPermissao As System.Windows.Forms.Label
    Friend WithEvents cboPermissao As System.Windows.Forms.ComboBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents lblConfSenha As System.Windows.Forms.Label
    Friend WithEvents txtConfSenha As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents lstgrade As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
