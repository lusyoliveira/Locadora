Public Class frmLogin
    Dim tbaux, tbUsuarios As ADODB.Recordset, sql, Tentativas As String
    Private Sub btnacesso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnacesso.Click
        txtLogin.Visible = True
        txtSenha.Visible = True
        lblLogin.Visible = True
        lblSenha.Visible = True
        btnEntrar.Visible = True
        btnacesso.Visible = False
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbaux = RecebeTabela("Select * from tbUsuarios order by nome")
        If tbaux.RecordCount <> 0 Then
            tbaux.MoveFirst()
            While tbaux.EOF = False
                txtLogin.AutoCompleteCustomSource.Add(tbaux.Fields("nome").Value.ToString)
                tbaux.MoveNext()
            End While
            txtLogin.Focus()
        End If
    End Sub
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        sql = "Select * from tbUsuarios where nome = '" & txtLogin.Text & "'"
        tbUsuarios = RecebeTabela(sql)
        If tbUsuarios.RecordCount = 0 Then
            MsgBox("Usuário não existe !", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtSenha.Text.ToUpper = tbUsuarios("senha").Value.ToString.ToUpper Then
            frmPrincipal.Show()
            MsgBox("Seja Bem-Vindo a Loctech sistema")
            tbUsuarios = RecebeTabela("select * from tbUsuarios")
        Else
            MsgBox("Senha inválida !")
            Beep()
            txtSenha.Text = ""
            txtSenha.Focus()
        End If
    End Sub
End Class
