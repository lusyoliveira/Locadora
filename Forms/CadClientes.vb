Public Class frmCadClientes
    Dim tbClientes As DataTable
    Dim ClasseClientes As New clsClientes
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
        lstgrade.Tag = 0
    End Sub
    Private Sub frmCadClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClasseClientes.CarregaClientes(lstgrade, txtNome.Text, 0)
    End Sub
    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then ClasseClientes.CarregaClientes(lstgrade, txtNome.Text, 0)
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseClientes.CarregaClientes(lstgrade, txtNome.Text, 0)
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
            ClasseClientes.SalvarCliente(txtNome.Text, mskDnascimento.Text, mskTel1.Text, txtEmail.Text, mskrg.Text, mskcpf.Text)

            ClasseClientes.CarregaClientes(lstgrade, txtNome.Text, 0)
        Else
            Exit Sub
        End If

        'txtEndereco.Text,
        'txtComplemento.Text,
        'txtBairro.Text,
        'txtCidade.Text,
        'cboUf.Text,
        'mskCep.Text,
        'rbdMasculino.Checked,
        'mskTel1.Text,
        'mskTel2.Text,
        'mskCel.Text,
        'txtEmail.Text,
        'mskrg.Text,
        'mskcpf.Text,
        'txtnome_dep.Text,
        'mskdtdatadep.Text,
        'mskcpf_dep.Text,
        'cbopzrentesco.Text,
        'txtObs.Text,
        'txtextra.Text)
    End Sub

    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        tbClientes = RecebeTabela("SELECT * FROM tbClientes")
        Dim rows() As DataRow = tbClientes.Select("codigo = " & CInt(lstgrade.SelectedItems(0).Text))

        If rows.Length = 0 Then
            limpar()
            MessageBox.Show("Registro não localizado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim row As DataRow = rows(0)
        lblCodigo.Text = row("Codigo").ToString
        txtNome.Text = row("nome").ToString
        mskDnascimento.Text = Format(CDate(row("dtnasc")), "dd/MM/yyyy")
        cboEstadoCivil.Text = row("estadocivil").ToString
        txtEndereco.Text = row("endereco").ToString
        txtComplemento.Text = row("complemento").ToString
        txtBairro.Text = row("bairro").ToString
        txtCidade.Text = row("cidade").ToString
        cboUf.Text = row("uf").ToString
        mskCep.Text = row("cep").ToString
        If CBool(row("sexo")) Then
            rbdMasculino.Checked = True
        Else
            rbdFeminino.Checked = True
        End If
        mskTel1.Text = row("telefone1").ToString
        mskTel2.Text = row("telefone2").ToString
        mskCel.Text = row("celular").ToString
        txtEmail.Text = row("email").ToString
        mskrg.Text = row("rg").ToString
        mskcpf.Text = row("cpf").ToString
        txtnome_dep.Text = row("nomedependente").ToString
        mskdtdatadep.Text = Format(CDate(row("dtnascdependente")), "dd/MM/yyyy")
        mskcpf_dep.Text = row("cpfdependente").ToString
        cbopzrentesco.Text = row("grauparentesco").ToString
        txtObs.Text = row("obs").ToString
        txtextra.Text = row("dep_extras").ToString
        btnAlterar.Visible = True
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.ExcluirCliente(Val(lblCodigo.Text))

            ClasseClientes.CarregaClientes(lstgrade, txtNome.Text, 0)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a slteração do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.AlterarCliente(Val(lblCodigo.Text), txtNome.Text, mskDnascimento.Text, mskTel1.Text, txtEmail.Text, mskrg.Text, mskcpf.Text)

            ClasseClientes.CarregaClientes(lstgrade, txtNome.Text, 0)
        Else
            Exit Sub
        End If
    End Sub
End Class