Imports System.Data.SqlClient
Public Class frmCadFornecedores
    Dim tbFornecedores As DataTable
    Dim ClasseFornecedor As New clsEntidades
    Private Sub limpar()
        txtFornecedor.Text = ""
        txtEmpresa.Text = ""
        mskcnpj.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtComplemento.Text = ""
        mskCEP.Text = ""
        cbouf.Text = ""
        txtSite.Text = ""
        txtEmail.Text = ""
        msktel.Text = ""
        mskcel.Text = ""
        lstEntidade.Items.Clear()
    End Sub

    Private Sub txtFornecedor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFornecedor.KeyUp
        If e.KeyCode = Keys.Enter Then
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        End If
    End Sub

    Private Sub lstEntidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEntidade.SelectedIndexChanged
        If lstEntidade.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstEntidade.SelectedItems(0).SubItems(0).Text)
            txtFornecedor.Text = lstEntidade.SelectedItems(0).SubItems(1).Text
            txtEmpresa.Text = lstEntidade.SelectedItems(0).SubItems(2).Text
            txtEndereco.Text = lstEntidade.SelectedItems(0).SubItems(5).Text
            txtComplemento.Text = lstEntidade.SelectedItems(0).SubItems(6).Text
            txtBairro.Text = lstEntidade.SelectedItems(0).SubItems(7).Text
            txtCidade.Text = lstEntidade.SelectedItems(0).SubItems(8).Text
            cbouf.Text = lstEntidade.SelectedItems(0).SubItems(9).Text
            mskCEP.Text = lstEntidade.SelectedItems(0).SubItems(10).Text
        End If
        ClasseFornecedor.ObterContato(Val(lblCodigo.Text), ClasseFornecedor)
        msktel.Text = ClasseFornecedor.Telefone1
        mskcel.Text = ClasseFornecedor.Celular
        txtEmail.Text = ClasseFornecedor.Email
        tcFornecedor.SelectTab(1)
    End Sub
    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        txtFornecedor.Focus()
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclus�o do fornecedor?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.SalvarEntidade(txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbouf.Text, mskCEP.Text, "", "", mskcnpj.Text, "", "F")
            ClasseFornecedor.SalvarContato(Val(lblCodigo.Text), msktel.Text, "", mskcel.Text, txtEmail.Text)
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AlterarToolStripButton_Click(sender As Object, e As EventArgs) Handles AlterarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a altera��o do cliente?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.AlterarEntidade(Val(lblCodigo.Text), txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbouf.Text, mskCEP.Text, "", "", "", "")
            ClasseFornecedor.AlterarContato(Val(lblCodigo.Text), ClasseFornecedor.CodContato, msktel.Text, "", mskcel.Text, txtEmail.Text)
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ExcluirToolStripButton_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclus�o?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.ExcluirContato(Val(lblCodigo.Text))
            ClasseFornecedor.ExcluirEntidade(Val(lblCodigo.Text))
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
    End Sub
End Class