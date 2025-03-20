Imports System.Data
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class frmCadUsuarios
    Dim ClasseUsuario As New clsUsuario, tbUsuarios As DataTable
    Private Sub limpar()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtSenha.Text = ""
        txtConfSenha.Text = ""
        cboPermissao.Text = ""
        lstgrade.Items.Clear()
    End Sub
    Private Sub PreencherGridUsuario()
        Dim tbUsuario As DataTable = ClasseUsuario.PesquisaUsuario(Val(lblCodigo.Text), txtNome.Text)
        Dim x As Integer = 0
        If tbUsuario IsNot Nothing AndAlso tbUsuario.Rows.Count > 0 Then
            For Each row As DataRow In tbUsuario.Rows
                Dim item As New ListViewItem(row("codigo").ToString())
                item.SubItems.Add(row("nome").ToString())
                item.SubItems.Add(row("permissao").ToString())
                item.SubItems.Add(row("senha").ToString())
                item.SubItems.Add(row("confsenha").ToString())

                lstgrade.Items.Add(item)
                x += 1
            Next
        Else
            MessageBox.Show("Essa entidade não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count > 0 Then
            txtNome.Text = lstgrade.SelectedItems(0).SubItems(1).Text
            cboPermissao.Text = lstgrade.SelectedItems(0).SubItems(2).Text
            txtSenha.Text = lstgrade.SelectedItems(0).SubItems(3).Text
            txtConfSenha.Text = lstgrade.SelectedItems(0).SubItems(4).Text
            lstgrade.Tag = lstgrade.SelectedItems(0).Text
            SalvarToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = True
            ExcluirToolStripButton.Enabled = True
            NovoToolStripButton.Enabled = False
        End If
    End Sub
    Private Sub cboPermissao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.Click
        If txtSenha.Text <> txtConfSenha.Text Then
            MsgBox("Senha Inválida,favor corrigir!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        SalvarToolStripButton.Enabled = True
        AlterarToolStripButton.Enabled = False
        ExcluirToolStripButton.Enabled = False
        NovoToolStripButton.Enabled = False
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.SalvarUsuario(txtNome.Text, cboPermissao.Text, txtSenha.Text, txtConfSenha.Text)
            PreencherGridUsuario()
            limpar()
            SalvarToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AlterarToolStripButton_Click(sender As Object, e As EventArgs) Handles AlterarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.AlterarUsuario(Val(lblCodigo.Text), txtNome.Text, cboPermissao.Text, txtSenha.Text, txtConfSenha.Text)
            PreencherGridUsuario()
            limpar()
        Else
            Exit Sub
        End If
        SalvarToolStripButton.Enabled = False
        AlterarToolStripButton.Enabled = False
        ExcluirToolStripButton.Enabled = False
        NovoToolStripButton.Enabled = True
    End Sub

    Private Sub ExcluirToolStripButton_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseUsuario.ExcluirUsuario(Val(lblCodigo.Text))
            PreencherGridUsuario()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        PreencherGridUsuario()
    End Sub

    Private Sub frmCadUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class