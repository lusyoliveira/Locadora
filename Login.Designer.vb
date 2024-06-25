<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEntrar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLogin = New System.Windows.Forms.TextBox
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.lblSenha = New System.Windows.Forms.Label
        Me.lblLogin = New System.Windows.Forms.Label
        Me.btnacesso = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(546, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Sistema"
        '
        'btnEntrar
        '
        Me.btnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEntrar.Image = Global.Projeto_Locadora.My.Resources.Resources.ok
        Me.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntrar.Location = New System.Drawing.Point(185, 534)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(91, 45)
        Me.btnEntrar.TabIndex = 22
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrar.UseVisualStyleBackColor = True
        Me.btnEntrar.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkRed
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(90, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(582, 118)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "  LOCTECH"
        '
        'txtLogin
        '
        Me.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(184, 485)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(123, 22)
        Me.txtLogin.TabIndex = 20
        Me.txtLogin.Visible = False
        '
        'txtSenha
        '
        Me.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(328, 485)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 22)
        Me.txtSenha.TabIndex = 19
        Me.txtSenha.Visible = False
        '
        'lblSenha
        '
        Me.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.DarkRed
        Me.lblSenha.Font = New System.Drawing.Font("OCR A Extended", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.White
        Me.lblSenha.Location = New System.Drawing.Point(325, 467)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(58, 17)
        Me.lblSenha.TabIndex = 18
        Me.lblSenha.Text = "SENHA"
        Me.lblSenha.Visible = False
        '
        'lblLogin
        '
        Me.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.DarkRed
        Me.lblLogin.Font = New System.Drawing.Font("OCR A Extended", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(181, 467)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(58, 17)
        Me.lblLogin.TabIndex = 17
        Me.lblLogin.Text = "LOGIN"
        Me.lblLogin.Visible = False
        '
        'btnacesso
        '
        Me.btnacesso.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnacesso.ForeColor = System.Drawing.Color.White
        Me.btnacesso.Image = Global.Projeto_Locadora.My.Resources.Resources.halfencrypted
        Me.btnacesso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnacesso.Location = New System.Drawing.Point(2, 2)
        Me.btnacesso.Name = "btnacesso"
        Me.btnacesso.Size = New System.Drawing.Size(88, 35)
        Me.btnacesso.TabIndex = 23
        Me.btnacesso.Text = "Acessar"
        Me.btnacesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnacesso.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Projeto_Locadora.My.Resources.Resources.TRABALHO2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1271, 746)
        Me.Controls.Add(Me.btnacesso)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblLogin)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents btnacesso As System.Windows.Forms.Button

End Class
