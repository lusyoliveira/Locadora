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

End Class
