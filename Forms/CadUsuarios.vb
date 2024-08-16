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
            ClasseUsuario.PesquisaUsuario(lstgrade, Val(lblCodigo.Text), txtNome.Text)
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
            ClasseUsuario.PesquisaUsuario(lstgrade, Val(lblCodigo.Text), txtNome.Text)
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
            ClasseUsuario.PesquisaUsuario(lstgrade, Val(lblCodigo.Text), txtNome.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        ClasseUsuario.PesquisaUsuario(lstgrade, Val(lblCodigo.Text), txtNome.Text)
    End Sub

    Private Sub frmCadUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class