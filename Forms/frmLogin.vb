Public Class frmLogin
    Dim ClasseCombo As New clsCombo, ClasseUsuario As New clsUsuario, tbaux, tbUsuarios As DataTable, sql, Tentativas As String
    Private Sub btnacesso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnacesso.Click
        txtLogin.Visible = True
        txtSenha.Visible = True
        lblLogin.Visible = True
        lblSenha.Visible = True
        btnEntrar.Visible = True
        btnacesso.Visible = False
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbaux = ClasseCombo.Listar("SELECT * FROM tbUsuarios ORDER BY nome")
        If tbaux.Rows.Count <> 0 Then
            For Each row As DataRow In tbaux.Rows
                txtLogin.AutoCompleteCustomSource.Add(row("nome").ToString())
            Next
            txtLogin.Focus()
        End If
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        ClasseUsuario.Autenticar(txtLogin.Text, txtSenha.Text)

        'Dim sql As String = "SELECT * FROM tbUsuarios WHERE nome = '" & txtLogin.Text & "'"
        'tbUsuarios = ClasseCombo.Listar(sql)
        'If tbUsuarios.Rows.Count = 0 Then
        '    MsgBox("Usuário não existe!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'If txtSenha.Text.ToUpper = tbUsuarios.Rows(0)("senha").ToString().ToUpper() Then
        '    frmPrincipal.Show()
        '    MsgBox("Seja Bem-Vindo a Loctech sistema")
        '    tbUsuarios = ClasseCombo.Listar("SELECT * FROM tbUsuarios")
        'Else
        '    MsgBox("Senha inválida!")
        '    Beep()
        '    txtSenha.Text = ""
        '    txtSenha.Focus()
        'End If
    End Sub
End Class
