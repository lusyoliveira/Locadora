Imports System.Data.SqlClient
Public Class frmCadFornecedores
    Dim tbFornecedores As DataTable
    Dim ClasseFornecedor As New clsFornecedores

    Private Sub limpar()
        txtFornecedor.Text = ""
        txtEmpresa.Text = ""
        mskcnpj.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        txtComplemento.Text = ""
        mskcpf.Text = ""
        cbouf.Text = ""
        txtSite.Text = ""
        txtEmail.Text = ""
        msktel.Text = ""
        mskcel.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub PreencheListaFornecedores()
        Dim x As Integer = 0

        For Each row As DataRow In tbFornecedores.Rows
            lstgrade.Items.Add(row("codigo").ToString())
            lstgrade.Items(x).SubItems.Add(row("fornecedor").ToString())
            lstgrade.Items(x).SubItems.Add(row("empresa").ToString())
            lstgrade.Items(x).SubItems.Add(row("cnpj").ToString())
            lstgrade.Items(x).SubItems.Add(row("uf").ToString())
            lstgrade.Items(x).SubItems.Add(row("cep").ToString())
            lstgrade.Items(x).SubItems.Add(row("telefone").ToString())
            lstgrade.Items(x).SubItems.Add(row("celular").ToString())
            x += 1
        Next
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        tbFornecedores = ClasseFornecedor.ConsultaFornecedor(Val(lblCodigo.Text), txtFornecedor.Text)
        PreencheListaFornecedores()
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
            tbFornecedores = ClasseFornecedor.ConsultaFornecedor(Val(lblCodigo.Text), txtFornecedor.Text)
            PreencheListaFornecedores()
        End If
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.SalvarFornecedor(txtFornecedor.Text, txtEmpresa.Text, mskcnpj.Text,
                                              cbouf.Text, mskcpf.Text, msktel.Text, mskcel.Text)
            tbFornecedores = ClasseFornecedor.ConsultaFornecedor(Val(lblCodigo.Text), txtFornecedor.Text)
            PreencheListaFornecedores()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.ExcluirFornecedor(Val(lblCodigo.Text))
            tbFornecedores = ClasseFornecedor.ConsultaFornecedor(Val(lblCodigo.Text), txtFornecedor.Text)
            PreencheListaFornecedores()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.AlterarFornecedor(Val(lblCodigo.Text), txtFornecedor.Text, txtEmpresa.Text, mskcnpj.Text, cbouf.Text, mskcpf.Text, msktel.Text, mskcel.Text)
            tbFornecedores = ClasseFornecedor.ConsultaFornecedor(Val(lblCodigo.Text), txtFornecedor.Text)
            PreencheListaFornecedores()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frmCadFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstgrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        ' Obtém o código do produto selecionado na lstgrade
        Dim Codigo As Integer = CInt(lstgrade.SelectedItems(0).Text)

        ' Chama o método para obter os dados do produto por código
        tbFornecedores = ClasseFornecedor.ConsultaFornecedor(Codigo, txtFornecedor.Text)

        ' Verifica se encontrou algum registro
        If tbFornecedores.Rows.Count = 0 Then
            limpar()
            MessageBox.Show("Produto não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim row As DataRow = tbFornecedores.Rows(0)
        lblCodigo.Text = row("Codigo").ToString()
        txtFornecedor.Text = row("fornecedor").ToString()
        txtEmpresa.Text = row("empresa").ToString()
        mskcnpj.Text = row("cnpj").ToString()
        txtEndereco.Text = row("endereco").ToString()
        txtComplemento.Text = row("complemento").ToString()
        txtBairro.Text = row("bairro").ToString()
        txtCidade.Text = row("cidade").ToString()
        cbouf.Text = row("uf").ToString()
        mskcpf.Text = row("cep").ToString()
        txtSite.Text = row("site").ToString()
        txtEmail.Text = row("email").ToString()
        msktel.Text = row("telefone").ToString()
        mskcel.Text = row("celular").ToString()
        btnExcluir.Visible = True
    End Sub
End Class