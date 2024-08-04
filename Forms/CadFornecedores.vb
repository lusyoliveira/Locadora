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
        lstEntidade.Tag = 0
    End Sub
    Private Sub PreencheListaFornecedores()
        Dim x As Integer = 0

        For Each row As DataRow In tbFornecedores.Rows
            lstEntidade.Items.Add(row("codigo").ToString())
            lstEntidade.Items(x).SubItems.Add(row("fornecedor").ToString())
            lstEntidade.Items(x).SubItems.Add(row("empresa").ToString())
            lstEntidade.Items(x).SubItems.Add(row("cnpj").ToString())
            lstEntidade.Items(x).SubItems.Add(row("uf").ToString())
            lstEntidade.Items(x).SubItems.Add(row("cep").ToString())
            lstEntidade.Items(x).SubItems.Add(row("telefone").ToString())
            lstEntidade.Items(x).SubItems.Add(row("celular").ToString())
            x += 1
        Next
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        txtFornecedor.Focus()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub txtFornecedor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFornecedor.KeyUp
        If e.KeyCode = Keys.Enter Then
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        End If
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.SalvarEntidade(txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbouf.Text, mskCEP.Text, "", "", mskcnpj.Text, "", "F")
            ClasseFornecedor.SalvarContato(Val(lblCodigo.Text), msktel.Text, "", mskcel.Text, txtEmail.Text)
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.ExcluirContato(Val(lblCodigo.Text))
            ClasseFornecedor.ExcluirEntidade(Val(lblCodigo.Text))
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.AlterarEntidade(Val(lblCodigo.Text), txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbouf.Text, mskCEP.Text, "", "", "", "")
            ClasseFornecedor.AlterarContato(Val(lblCodigo.Text), ClasseFornecedor.CodContato, msktel.Text, "", mskcel.Text, txtEmail.Text)
            ClasseFornecedor.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Else
            Exit Sub
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
    End Sub
End Class