Public Class frmCadClientes
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
    Private Sub carregaclientes()
        Dim frmCadClientes As ADODB.Recordset, x As Integer, sql As String
        sql = "select * from tbClientes where codigo=" & txtNome.Text
        If Not IsNumeric(txtNome.Text) Then
            sql = "select * from tbClientes  where nome like '" & txtNome.Text & "%'"
        End If
        limpar()
        lstgrade.Items.Clear()
        frmCadClientes = RecebeTabela(sql)
        If frmCadClientes.RecordCount > 0 Then
            frmCadClientes.MoveFirst()
            Do Until frmCadClientes.EOF
                lstgrade.Items.Add(frmCadClientes("codigo").Value)
                lstgrade.Items(x).SubItems.Add(frmCadClientes("nome").Value)
                lstgrade.Items(x).SubItems.Add(frmCadClientes("dtnasc").Value)
                lstgrade.Items(x).SubItems.Add(frmCadClientes("telefone1").Value)
                lstgrade.Items(x).SubItems.Add(frmCadClientes("email").Value)
                lstgrade.Items(x).SubItems.Add(frmCadClientes("rg").Value)
                lstgrade.Items(x).SubItems.Add(frmCadClientes("cpf").Value)
                x += 1
                frmCadClientes.MoveNext()
            Loop
            frmCadClientes.Close()

        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregaclientes()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtNome.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim frmCadClientes As ADODB.Recordset
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text

        frmCadClientes = RecebeTabela("select * from tbClientes where codigo=" & codigo)
        If frmCadClientes.EOF Then frmCadClientes.AddNew()
        frmCadClientes("nome").Value = txtNome.Text
        frmCadClientes("dtnasc").Value = mskDnascimento.Text
        frmCadClientes("estadocivil").Value = cboEstadoCivil.Text
        frmCadClientes("endereco").Value = txtEndereco.Text
        frmCadClientes("complemento").Value = txtComplemento.Text
        frmCadClientes("bairro").Value = txtBairro.Text
        frmCadClientes("cidade").Value = txtCidade.Text
        frmCadClientes("uf").Value = cboUf.Text
        frmCadClientes("cep").Value = mskcpf.Text
        frmCadClientes("sexo").Value = rbdMasculino.Checked
        frmCadClientes("telefone1").Value = mskTel1.Text
        frmCadClientes("telefone2").Value = mskTel2.Text
        frmCadClientes("celular").Value = mskCel.Text
        frmCadClientes("email").Value = txtEmail.Text
        frmCadClientes("rg").Value = mskrg.Text
        frmCadClientes("cpf").Value = mskcpf.Text
        frmCadClientes("nomedependente").Value = txtnome_dep.Text
        frmCadClientes("dtnascdependente").Value = mskdtdatadep.Text
        frmCadClientes("cpfdependente").Value = mskcpf_dep.Text
        frmCadClientes("grauparentesco").Value = cbopzrentesco.Text
        frmCadClientes("obs").Value = txtObs.Text
        frmCadClientes("dep_extras").Value = txtextra.Text
        frmCadClientes.Update()
        carregaclientes()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim frmCadClientes As ADODB.Recordset
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text
        If (MsgBox("Confirma a Exclusão ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            frmCadClientes = RecebeTabela("select * from tbClientes where codigo=" & codigo)
            If frmCadClientes.EOF = False Then frmCadClientes.Delete()
            carregaclientes()
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

        Dim frmCadClientes As ADODB.Recordset
        frmCadClientes = RecebeTabela("select * from tbClientes where codigo=" & lstgrade.SelectedItems(0).Text)
        If frmCadClientes.RecordCount = 0 Then
            limpar()
            MsgBox("Registro não localizado!")
            Exit Sub
        End If

        txtNome.Text = frmCadClientes("nome").Value.ToString
        mskDnascimento.Text = Format(CDate(frmCadClientes("dtnasc").Value), "dd/MM/yyyy")
        cboEstadoCivil.Text = frmCadClientes("estadocivil").Value.ToString
        txtEndereco.Text = frmCadClientes("endereco").Value.ToString
        txtComplemento.Text = frmCadClientes("complemento").Value.ToString
        txtBairro.Text = frmCadClientes("bairro").Value.ToString
        txtCidade.Text = frmCadClientes("cidade").Value.ToString
        cboUf.Text = frmCadClientes("uf").Value.ToString
        mskCep.Text = frmCadClientes("cep").Value.ToString
        If frmCadClientes("sexo").Value Then
            rbdMasculino.Checked = True
        Else
            rbdFeminino.Checked = True
        End If
        mskTel1.Text = frmCadClientes("telefone1").Value.ToString
        mskTel2.Text = frmCadClientes("telefone2").Value.ToString
        mskCel.Text = frmCadClientes("celular").Value.ToString
        txtEmail.Text = frmCadClientes("email").Value.ToString
        mskrg.Text = frmCadClientes("rg").Value.ToString
        mskcpf.Text = frmCadClientes("cpf").Value.ToString
        txtnome_dep.Text = frmCadClientes("nomedependente").Value.ToString
        mskdtdatadep.Text = Format(CDate(frmCadClientes("dtnascdependente").Value), "dd/MM/yyyy")
        mskcpf_dep.Text = frmCadClientes("cpfdependente").Value.ToString
        cbopzrentesco.Text = frmCadClientes("grauparentesco").Value.ToString
        txtObs.Text = frmCadClientes("obs").Value.ToString
        txtextra.Text = frmCadClientes("dep_extras").Value.ToString
        btnExcluir.Visible = True
    End Sub
    Private Sub frmCadClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaclientes()
    End Sub
    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then carregaclientes()
    End Sub
End Class