Imports System.Data
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
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
    Private Sub PreencherGridFornecedor()
        Dim tbClientes As DataTable = ClasseFornecedor.PesquisaEntidade(Val(lblCodigo.Text), txtFornecedor.Text, "F")
        Dim x As Integer = 0
        If tbClientes.Rows.Count > 0 Then
            For Each row As DataRow In tbClientes.Rows
                lstEntidade.Items.Add(row("Codigo").ToString())
                lstEntidade.Items(x).SubItems.Add(row("NomeFantasia").ToString())
                lstEntidade.Items(x).SubItems.Add(row("RazaoSocial").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataNasc").ToString())
                lstEntidade.Items(x).SubItems.Add(row("EstadoCivil").ToString())
                lstEntidade.Items(x).SubItems.Add(row("endereco").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Complemento").ToString())
                lstEntidade.Items(x).SubItems.Add(row("bairro").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Cidade").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Uf").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Cep").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Sexo").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Rg").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Documento").ToString())
                lstEntidade.Items(x).SubItems.Add(row("obs").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataCadastro").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataAlteracao").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataInativacao").ToString())
                x += 1
            Next
        Else
            MessageBox.Show("Essa entidade não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub txtFornecedor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFornecedor.KeyUp
        If e.KeyCode = Keys.Enter Then
            PreencherGridFornecedor()
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
        Dim tbContato As DataTable = ClasseFornecedor.ConsultaEntidade("SELECT * FROM tbEntidadeContatos WHERE CodEntidade = @CodEntidade", Val(lblCodigo.Text))
        msktel.Text = tbContato.Rows(0)("Telefone1").ToString()
        mskcel.Text = tbContato.Rows(0)("Celular").ToString()
        txtEmail.Text = tbContato.Rows(0)("Email").ToString()
        tcFornecedor.SelectTab(1)
    End Sub
    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        txtFornecedor.Focus()
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.SalvarEntidade(txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbouf.Text, mskCEP.Text, "", "", mskcnpj.Text, "", "F")
            ClasseFornecedor.SalvarContato(Val(lblCodigo.Text), msktel.Text, "", mskcel.Text, txtEmail.Text)
            PreencherGridFornecedor()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AlterarToolStripButton_Click(sender As Object, e As EventArgs) Handles AlterarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.AlterarEntidade(Val(lblCodigo.Text), txtFornecedor.Text, txtEmpresa.Text, "", "", txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbouf.Text, mskCEP.Text, "", "", "", "")
            ClasseFornecedor.AlterarContato(Val(lblCodigo.Text), ClasseFornecedor.CodContato, msktel.Text, "", mskcel.Text, txtEmail.Text)
            PreencherGridFornecedor()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ExcluirToolStripButton_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFornecedor.ExcluirContato(Val(lblCodigo.Text))
            ClasseFornecedor.ExcluirEntidade(Val(lblCodigo.Text))
            PreencherGridFornecedor()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        PreencherGridFornecedor()
    End Sub
End Class