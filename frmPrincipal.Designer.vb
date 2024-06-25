<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InícioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NovoUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PermissõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LocaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevoluçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 75)
        Me.Panel1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InícioToolStripMenuItem, Me.CadastroToolStripMenuItem, Me.SairToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.SairToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InícioToolStripMenuItem
        '
        Me.InícioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuáriosToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.SairToolStripMenuItem2})
        Me.InícioToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.home
        Me.InícioToolStripMenuItem.Name = "InícioToolStripMenuItem"
        Me.InícioToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.InícioToolStripMenuItem.Text = "Início"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoUsuárioToolStripMenuItem, Me.PermissõesToolStripMenuItem})
        Me.UsuáriosToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.user_1
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'NovoUsuárioToolStripMenuItem
        '
        Me.NovoUsuárioToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.user_2
        Me.NovoUsuárioToolStripMenuItem.Name = "NovoUsuárioToolStripMenuItem"
        Me.NovoUsuárioToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.NovoUsuárioToolStripMenuItem.Text = "Novo Usuário"
        '
        'PermissõesToolStripMenuItem
        '
        Me.PermissõesToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.warning
        Me.PermissõesToolStripMenuItem.Name = "PermissõesToolStripMenuItem"
        Me.PermissõesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PermissõesToolStripMenuItem.Text = "Permissões"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.tools
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'SairToolStripMenuItem2
        '
        Me.SairToolStripMenuItem2.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.SairToolStripMenuItem2.Name = "SairToolStripMenuItem2"
        Me.SairToolStripMenuItem2.Size = New System.Drawing.Size(154, 22)
        Me.SairToolStripMenuItem2.Text = "Sair"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.FornecedoresToolStripMenuItem})
        Me.CadastroToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.paste
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.people
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.basket
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.guy_blue
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.ftp
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocaçãoToolStripMenuItem, Me.DevoluçãoToolStripMenuItem, Me.ReservaToolStripMenuItem})
        Me.SairToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.folder_open
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.SairToolStripMenuItem.Text = "Locação"
        '
        'LocaçãoToolStripMenuItem
        '
        Me.LocaçãoToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.folder_open
        Me.LocaçãoToolStripMenuItem.Name = "LocaçãoToolStripMenuItem"
        Me.LocaçãoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LocaçãoToolStripMenuItem.Text = "Locação"
        '
        'DevoluçãoToolStripMenuItem
        '
        Me.DevoluçãoToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.folder_clock
        Me.DevoluçãoToolStripMenuItem.Name = "DevoluçãoToolStripMenuItem"
        Me.DevoluçãoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DevoluçãoToolStripMenuItem.Text = "Devolução"
        '
        'ReservaToolStripMenuItem
        '
        Me.ReservaToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.agenda
        Me.ReservaToolStripMenuItem.Name = "ReservaToolStripMenuItem"
        Me.ReservaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReservaToolStripMenuItem.Text = "Reserva"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.Image = Global.Projeto_Locadora.My.Resources.Resources.print_view
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Image = Global.Projeto_Locadora.My.Resources.Resources.ball_stop
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1028, 562)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InícioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoUsuárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermissõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevoluçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
End Class
