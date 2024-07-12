Imports System.Data.SqlClient
Public Class frmCadFuncionarios
    Dim tbFuncionarios As DataTable, ClasseFuncionario As New clsFuncionarios
    Private Sub limpar()
        txtMatricula.Text = ""
        txtNome.Text = ""
        mskDnascimento.Text = ""
        cboEstadoCivil.Text = ""
        txtEndereco.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cboUf.Text = ""
        mskCep.Text = ""
        rbdFeminino.Checked = False
        rbdMasculino.Checked = False
        mskTel1.Text = ""
        mskTel2.Text = ""
        mskCel.Text = ""
        txtEmail.Text = ""
        mskRG.Text = ""
        mskCpf.Text = ""
        mskCartprof.Text = ""
        cboCargo.Text = ""
        txtSalario.Text = ""
        cboExpediente.Text = ""
        txtObs.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub PreencheListaFuncionarios()
        Dim x As Integer = 0

        For Each row As DataRow In tbFuncionarios.Rows
            lstgrade.Items.Add(row("codfunc").ToString())
            lstgrade.Items(x).SubItems.Add(row("matricula").ToString())
            lstgrade.Items(x).SubItems.Add(row("nome").ToString())
            ''lstgrade.Items(x).SubItems.Add(row("dtnasc").ToString())
            lstgrade.Items(x).SubItems.Add(row("estadocivil").ToString())
            lstgrade.Items(x).SubItems.Add(row("endereco").ToString())
            lstgrade.Items(x).SubItems.Add(row("complemento").ToString())
            lstgrade.Items(x).SubItems.Add(row("bairro").ToString())
            lstgrade.Items(x).SubItems.Add(row("cidade").ToString())
            lstgrade.Items(x).SubItems.Add(row("uf").ToString())
            lstgrade.Items(x).SubItems.Add(row("cep").ToString())
            lstgrade.Items(x).SubItems.Add(IIf(row("sexo").ToString(), "Masculino", "Feminino"))
            lstgrade.Items(x).SubItems.Add(row("telefone1").ToString())
            lstgrade.Items(x).SubItems.Add(row("telefone2").ToString())
            lstgrade.Items(x).SubItems.Add(row("celular").ToString())
            lstgrade.Items(x).SubItems.Add(row("email").ToString())
            lstgrade.Items(x).SubItems.Add(row("rg").ToString())
            lstgrade.Items(x).SubItems.Add(row("cpf").ToString())
            lstgrade.Items(x).SubItems.Add(row("carteiraprofissional").ToString())
            lstgrade.Items(x).SubItems.Add(row("cargo").ToString())
            lstgrade.Items(x).SubItems.Add(row("salario").ToString())
            lstgrade.Items(x).SubItems.Add(row("expediente").ToString())
            lstgrade.Items(x).SubItems.Add(row("obs").ToString())
            x += 1
        Next
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        tbFuncionarios = ClasseFuncionario.ConsultaFuncionario(Val(lblCodigo.Text), txtNome.Text)
        PreencheListaFuncionarios()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtMatricula.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do funcionario?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.SalvarFuncionario(txtMatricula.Text, txtNome.Text, cboEstadoCivil.Text, txtEndereco.Text, txtComplemento.Text,
txtBairro.Text, txtCidade.Text, cboUf.Text, mskCep.Text, rbdMasculino.Checked, mskTel1.Text, mskTel2.Text, mskCel.Text, txtEmail.Text, mskRG.Text,
mskCpf.Text, mskCartprof.Text, cboCargo.Text, txtSalario.Text, cboExpediente.Text, txtObs.Text)
            tbFuncionarios = ClasseFuncionario.ConsultaFuncionario(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaFuncionarios()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.ExcluirFuncionario(Val(lblCodigo.Text))
            tbFuncionarios = ClasseFuncionario.ConsultaFuncionario(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaFuncionarios()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseFuncionario.AlterarFuncionario(Val(lblCodigo.Text), txtMatricula.Text, txtNome.Text, cboEstadoCivil.Text, txtEndereco.Text, txtComplemento.Text,
txtBairro.Text, txtCidade.Text, cboUf.Text, mskCep.Text, rbdMasculino.Checked, mskTel1.Text, mskTel2.Text, mskCel.Text, txtEmail.Text, mskRG.Text,
mskCpf.Text, mskCartprof.Text, cboCargo.Text, txtSalario.Text, cboExpediente.Text, txtObs.Text)
            tbFuncionarios = ClasseFuncionario.ConsultaFuncionario(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaFuncionarios()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        ' Obtém o código do produto selecionado na lstgrade
        Dim Codigo As Integer = CInt(lstgrade.SelectedItems(0).Text)

        ' Chama o método para obter os dados do produto por código
        tbFuncionarios = ClasseFuncionario.ConsultaFuncionario(Codigo, txtNome.Text)

        ' Verifica se encontrou algum registro
        If tbFuncionarios.Rows.Count = 0 Then
            limpar()
            MessageBox.Show("Produto não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim row As DataRow = tbFuncionarios.Rows(0)
        txtMatricula.Text = lstgrade.SelectedItems(0).SubItems(1).Text
        txtNome.Text = lstgrade.SelectedItems(0).SubItems(2).Text
        mskDnascimento.Text = Format(CDate(lstgrade.SelectedItems(0).SubItems(3).Text), "dd/MM/yyyy")
        cboEstadoCivil.Text = lstgrade.SelectedItems(0).SubItems(4).Text
        txtEndereco.Text = lstgrade.SelectedItems(0).SubItems(5).Text
        txtComplemento.Text = lstgrade.SelectedItems(0).SubItems(6).Text
        txtBairro.Text = lstgrade.SelectedItems(0).SubItems(7).Text
        txtCidade.Text = lstgrade.SelectedItems(0).SubItems(8).Text
        cboUf.Text = lstgrade.SelectedItems(0).SubItems(9).Text
        mskCep.Text = lstgrade.SelectedItems(0).SubItems(10).Text
        If lstgrade.SelectedItems(0).SubItems(11).Text = "Masculino" Then
            rbdMasculino.Checked = True
        Else
            rbdFeminino.Checked = True
        End If
        mskTel1.Text = lstgrade.SelectedItems(0).SubItems(12).Text
        mskTel2.Text = lstgrade.SelectedItems(0).SubItems(13).Text
        mskCel.Text = lstgrade.SelectedItems(0).SubItems(14).Text
        txtEmail.Text = lstgrade.SelectedItems(0).SubItems(15).Text
        mskRG.Text = lstgrade.SelectedItems(0).SubItems(16).Text
        mskCpf.Text = lstgrade.SelectedItems(0).SubItems(17).Text
        mskCartprof.Text = lstgrade.SelectedItems(0).SubItems(18).Text
        cboCargo.Text = lstgrade.SelectedItems(0).SubItems(19).Text
        txtSalario.Text = lstgrade.SelectedItems(0).SubItems(20).Text
        cboExpediente.Text = lstgrade.SelectedItems(0).SubItems(21).Text
        txtObs.Text = lstgrade.SelectedItems(0).SubItems(22).Text
        lstgrade.Tag = lstgrade.SelectedItems(0).Text
        btnExcluir.Visible = True
    End Sub
    Private Sub frmCadFuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbFuncionarios = ClasseFuncionario.ConsultaFuncionario(Val(lblCodigo.Text), txtNome.Text)
        PreencheListaFuncionarios()
    End Sub
    Private Sub txtMatricula_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMatricula.KeyUp
        If e.KeyCode = Keys.Enter Then
            tbFuncionarios = ClasseFuncionario.ConsultaFuncionario(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaFuncionarios()
        End If
    End Sub
End Class