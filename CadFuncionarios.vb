Public Class frmCadFuncionarios
    Private Sub limpar()
        txtCodigo.Text = ""
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
    Private Sub carregafuncionarios()
        limpar()
        lstgrade.Items.Clear()
        Dim frmCadFuncionarios As ADODB.Recordset, x As Integer, sql As String
        lstgrade.Items.Clear()
        sql = "select * from tbFuncionarios where codfunc=" & txtCodigo.Text
        If Not IsNumeric(txtNome.Text) Then
            sql = "select * from tbFuncionarios  where matricula like '" & txtCodigo.Text & "%'"
        End If
        frmCadFuncionarios = RecebeTabela(sql)
        If frmCadFuncionarios.RecordCount > 0 Then
            frmCadFuncionarios.MoveFirst()
            Do Until frmCadFuncionarios.EOF
                lstgrade.Items.Add(frmCadFuncionarios("codfunc").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("matricula").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("nome").Value)
                ''lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("dtnasc").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("estadocivil").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("endereco").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("complemento").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("bairro").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("cidade").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("uf").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("cep").Value)
                lstgrade.Items(x).SubItems.Add(IIf(frmCadFuncionarios("sexo").Value, "Masculino", "Feminino"))
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("telefone1").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("telefone2").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("celular").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("email").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("rg").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("cpf").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("carteiraprofissional").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("cargo").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("salario").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("expediente").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFuncionarios("obs").Value)
                x += 1
                frmCadFuncionarios.MoveNext()

            Loop
            frmCadFuncionarios.Close()

        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregafuncionarios()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtMatricula.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim frmCadFuncionarios As ADODB.Recordset
        frmCadFuncionarios = RecebeTabela("select * from tbFuncionarios where codfunc=" & lstgrade.Tag)
        If frmCadFuncionarios.RecordCount = 0 Then frmCadFuncionarios.AddNew()
        'frmCadFuncionarios("matricula").Value = txtMatricula.Text
        frmCadFuncionarios("nome").Value = txtNome.Text
        'frmCadFuncionarios("dtnasc").Value = mskDnascimento.Text
        frmCadFuncionarios("estadocivil").Value = cboEstadoCivil.Text
        frmCadFuncionarios("endereco").Value = txtEndereco.Text
        frmCadFuncionarios("complemento").Value = txtComplemento.Text
        frmCadFuncionarios("bairro").Value = txtBairro.Text
        frmCadFuncionarios("cidade").Value = txtCidade.Text
        frmCadFuncionarios("uf").Value = cboUf.Text
        frmCadFuncionarios("cep").Value = mskCep.Text
        frmCadFuncionarios("sexo").Value = rbdMasculino.Checked
        frmCadFuncionarios("telefone1").Value = mskTel1.Text
        frmCadFuncionarios("telefone2").Value = mskTel2.Text
        frmCadFuncionarios("celular").Value = mskCel.Text
        frmCadFuncionarios("email").Value = txtEmail.Text
        frmCadFuncionarios("rg").Value = mskRG.Text
        frmCadFuncionarios("cpf").Value = mskCpf.Text
        frmCadFuncionarios("carteiraprofissional").Value = mskCartprof.Text
        frmCadFuncionarios("cargo").Value = cboCargo.Text
        'frmCadFuncionarios("salario").Value = txtSalario.Text
        frmCadFuncionarios("expediente").Value = cboExpediente.Text
        frmCadFuncionarios("obs").Value = txtObs.Text
        frmCadFuncionarios.Update()
        carregafuncionarios()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim frmCadFuncionarios As ADODB.Recordset
        If (MsgBox("Confirma a Exclusão ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            frmCadFuncionarios = RecebeTabela("select * from tbFuncionarios where codfunc=" & lstgrade.Tag)
            If frmCadFuncionarios.EOF = False Then frmCadFuncionarios.Delete()
            carregafuncionarios()
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
        carregafuncionarios()
    End Sub
    Private Sub txtMatricula_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMatricula.KeyUp
        If e.KeyCode = Keys.Enter Then carregafuncionarios()
    End Sub
End Class