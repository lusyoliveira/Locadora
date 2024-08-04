Public Class frmCadClientes
    Dim ClasseClientes As New clsEntidades, ClasseDependentes As New clsDependente, ClasseCombo As New clsCombo, tbClientes As DataTable

    Private Sub limpar()
        txtNome.Text = ""
        mskDnascimento.Text = ""
        cboEstadoCivil.Text = ""
        txtEndereco.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        rbdFeminino.Checked = False
        rbdMasculino.Checked = False
        txtCidade.Text = ""
        cboUf.Text = ""
        mskCep.Text = ""
        mskTel1.Text = ""
        mskTel2.Text = ""
        mskCel.Text = ""
        txtEmail.Text = ""
        mskrg.Text = ""
        mskcpf.Text = ""
        txtnome_dep.Text = ""
        mskDnasc.Text = ""
        txtnome_dep.Text = ""
        mskcpf_dep.Text = ""
        cbopzrentesco.Text = ""
        mskdtdatadep.Text = ""
        txtObs.Text = ""
        txtextra.Text = ""
        txtEmail.Text = ""
        lstEntidade.Items.Clear()
    End Sub

    Private Sub frmCadClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseClientes.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub
    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ClasseClientes.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseClientes.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtNome.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.SalvarEntidade(txtNome.Text, "", mskDnascimento.Text, cboEstadoCivil.Text, txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, mskCep.Text, "", mskrg.Text, mskcpf.Text, txtObs.Text, "C")
            ClasseClientes.SalvarContato(Val(lblCodigo.Text), mskTel1.Text, mskTel2.Text, mskCel.Text, txtEmail.Text)
            ClasseClientes.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lstEntidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEntidade.SelectedIndexChanged
        If lstEntidade.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstEntidade.SelectedItems(0).SubItems(0).Text)
            txtNome.Text = lstEntidade.SelectedItems(0).SubItems(1).Text
            mskDnascimento.Text = Format(CDate(lstEntidade.SelectedItems(0).SubItems(3).Text), "dd/MM/yyyy")
            cboEstadoCivil.Text = lstEntidade.SelectedItems(0).SubItems(4).Text
            txtEndereco.Text = lstEntidade.SelectedItems(0).SubItems(5).Text
            txtComplemento.Text = lstEntidade.SelectedItems(0).SubItems(6).Text
            txtBairro.Text = lstEntidade.SelectedItems(0).SubItems(7).Text
            txtCidade.Text = lstEntidade.SelectedItems(0).SubItems(8).Text
            cboUf.Text = lstEntidade.SelectedItems(0).SubItems(9).Text
            mskCep.Text = lstEntidade.SelectedItems(0).SubItems(10).Text
            If lstEntidade.SelectedItems(0).SubItems(11).Text Then
                rbdMasculino.Checked = True
            Else
                rbdFeminino.Checked = True
            End If
        End If
        ClasseDependentes.ConsultaDependente(lstDependente, Val(lblCodigo.Text))
        ClasseClientes.ObterContato(Val(lblCodigo.Text), ClasseClientes)
        mskTel1.Text = ClasseClientes.Telefone1
        mskTel2.Text = ClasseClientes.Telefone2
        mskCel.Text = ClasseClientes.Celular
        txtEmail.Text = ClasseClientes.Email

    End Sub

    Private Sub cboEstadoCivil_Enter(sender As Object, e As EventArgs) Handles cboEstadoCivil.Enter
        Dim ListaCivil = ClasseCombo.PreencherComboBox("SELECT * FROM tbEstadoCivil ORDER BY Descricao", "Codigo", "Descricao")
        With Me.cboEstadoCivil
            .DataSource = ListaCivil
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cbopzrentesco_Enter(sender As Object, e As EventArgs) Handles cbopzrentesco.Enter
        Dim ListaParentesco = ClasseCombo.PreencherComboBox("SELECT * FROM tbParentesco ORDER BY Parentesco", "Codigo", "Parentesco")
        With Me.cbopzrentesco
            .DataSource = ListaParentesco
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.ExcluirContato(Val(lblCodigo.Text))
            ClasseClientes.ExcluirEntidade(Val(lblCodigo.Text))
            ClasseClientes.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.AlterarEntidade(Val(lblCodigo.Text), txtNome.Text, "", mskDnascimento.Text, cboEstadoCivil.Text, txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, mskCep.Text, "", mskrg.Text, mskcpf.Text, txtObs.Text)
            ClasseClientes.AlterarContato(Val(lblCodigo.Text), ClasseClientes.CodContato, mskTel1.Text, mskTel2.Text, mskCel.Text, txtEmail.Text)
            ClasseClientes.PesquisaEntidade(lstEntidade, Val(lblCodigo.Text), txtNome.Text, "C")
        Else
            Exit Sub
        End If
    End Sub
End Class