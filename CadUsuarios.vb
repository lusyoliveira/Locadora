Public Class frmCadUsuarios
    Private Sub limpar()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtSenha.Text = ""
        txtConfSenha.Text = ""
        cboPermissao.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub carregausuario()
        limpar()
        lstgrade.Items.Clear()
        Dim frmCadUsuarios As ADODB.Recordset, x As Integer, sql As String
        lstgrade.Items.Clear()
        sql = "select * from tbUsuarios where codigo=" & txtCodigo.Text
        If Not IsNumeric(txtNome.Text) Then
            sql = "select * from tbUsuarios where nome like '" & txtCodigo.Text & "%'"
        End If
        frmCadUsuarios = RecebeTabela(sql)
        If frmCadUsuarios.RecordCount > 0 Then
            frmCadUsuarios.MoveFirst()
            Do Until frmCadUsuarios.EOF
                lstgrade.Items.Add(frmCadUsuarios("codigo").Value)
                lstgrade.Items(x).SubItems.Add(frmCadUsuarios("nome").Value)
                lstgrade.Items(x).SubItems.Add(frmCadUsuarios("permissao").Value)
                lstgrade.Items(x).SubItems.Add(frmCadUsuarios("senha").Value)
                lstgrade.Items(x).SubItems.Add(frmCadUsuarios("confsenha").Value)
                x += 1
                frmCadUsuarios.MoveNext()

            Loop
            frmCadUsuarios.Close()

        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregausuario()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        txtNome.Focus()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim frmCadUsuarios As ADODB.Recordset
        frmCadUsuarios = RecebeTabela("select * from tbUsuarios where codigo=" & lstgrade.Tag)
        If frmCadUsuarios.RecordCount = 0 Then frmCadUsuarios.AddNew()
        frmCadUsuarios("nome").Value = txtNome.Text
        frmCadUsuarios("permissao").Value = cboPermissao.Text
        frmCadUsuarios("senha").Value = txtSenha.Text
        frmCadUsuarios("confsenha").Value = txtConfSenha.Text
        frmCadUsuarios.Update()
        carregausuario()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim frmCadUsuarios As ADODB.Recordset
        frmCadUsuarios = RecebeTabela("select * from tbUsuarios where codigo=" & lstgrade.Tag)
        If frmCadUsuarios.EOF = False Then frmCadUsuarios.Delete()
        carregausuario()
    End Sub
    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If
        txtNome.Text = lstgrade.SelectedItems(0).SubItems(1).Text
        cboPermissao.Text = lstgrade.SelectedItems(0).SubItems(2).Text
        txtSenha.Text = lstgrade.SelectedItems(0).SubItems(3).Text
        txtConfSenha.Text = lstgrade.SelectedItems(0).SubItems(4).Text
        lstgrade.Tag = lstgrade.SelectedItems(0).Text
        btnExcluir.Visible = True
    End Sub
    Private Sub cboPermissao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.Click
        If txtSenha.Text <> txtConfSenha.Text Then
            MsgBox("Senha Inválida,favor corrigir!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class