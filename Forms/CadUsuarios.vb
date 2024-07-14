Imports System.Data.SqlClient

Public Class frmCadUsuarios
    Dim ClasseUsuario As New clsUsuario, tbUsuarios As DataTable
    Private Sub limpar()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtSenha.Text = ""
        txtConfSenha.Text = ""
        cboPermissao.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub PreencheListaUsuario()
        Dim x As Integer = 0

        For Each row As DataRow In tbUsuarios.Rows
            Dim item As New ListViewItem(row("codigo").ToString())
            item.SubItems.Add(row("nome").ToString())
            item.SubItems.Add(row("permissao").ToString())
            item.SubItems.Add(row("senha").ToString())
            item.SubItems.Add(row("confsenha").ToString())

            lstgrade.Items.Add(item)
            x += 1
        Next
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        tbUsuarios = ClasseUsuario.ConsultaUsuario(Val(lblCodigo.Text), txtNome.Text)
        PreencheListaUsuario()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        txtNome.Focus()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarUsuario(txtNome.Text, cboPermissao.Text, txtSenha.Text, txtConfSenha.Text)
            tbUsuarios = ClasseUsuario.ConsultaUsuario(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaUsuario()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.ExcluirUsuario(Val(lblCodigo.Text))
            tbUsuarios = ClasseUsuario.ConsultaUsuario(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaUsuario()
        Else
            Exit Sub
        End If
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

        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        ' Obtém o código do produto selecionado na lstgrade
        Dim Codigo As Integer = CInt(lstgrade.SelectedItems(0).Text)

        ' Chama o método para obter os dados do produto por código
        tbUsuarios = ClasseUsuario.ConsultaUsuario(Codigo, txtNome.Text)

        ' Verifica se encontrou algum registro
        If tbUsuarios.Rows.Count = 0 Then
            limpar()
            MessageBox.Show("Usuário não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim row As DataRow = tbUsuarios.Rows(0)
        lblCodigo.Text = row("Codigo").ToString
        txtNome.Text = row("Nome").ToString
        cboPermissao.Text = row("Permissao").ToString
        txtSenha.Text = row("Senha").ToString
        txtConfSenha.Text = row("ConfSenha").ToString
    End Sub
    Private Sub cboPermissao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.Click
        If txtSenha.Text <> txtConfSenha.Text Then
            MsgBox("Senha Inválida,favor corrigir!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub frmCadUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class