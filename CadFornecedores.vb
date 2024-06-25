Public Class frmCadFornecedores
    Private Sub limpar()
        txtCodigo.Text = ""
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
    Private Sub carregafornecedores()
        limpar()
        lstgrade.Items.Clear()
        Dim frmCadFornecedores As ADODB.Recordset, x As Integer, sql As String
        lstgrade.Items.Clear()
        sql = "select * from tbFornecedores where codigo=" & txtCodigo.Text
        If Not IsNumeric(txtFornecedor.Text) Then
            sql = "select * from tbFornecedores  where fornecedor like '" & txtCodigo.Text & "%'"
        End If
        frmCadFornecedores = RecebeTabela(sql)
        If frmCadFornecedores.RecordCount > 0 Then
            frmCadFornecedores.MoveFirst()
            Do Until frmCadFornecedores.EOF
                lstgrade.Items.Add(frmCadFornecedores("codigo").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFornecedores("fornecedor").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFornecedores("empresa").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFornecedores("cnpj").Value)
                'lstgrade.Items(x).SubItems.Add(frmCadFornecedores("endereco").Value)
                'lstgrade.Items(x).SubItems.Add(frmCadFornecedores("complemento").Value)
                'lstgrade.Items(x).SubItems.Add(frmCadFornecedores("bairro").Value)
                'lstgrade.Items(x).SubItems.Add(frmCadFornecedores("cidade").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFornecedores("uf").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFornecedores("cep").Value)
                'lstgrade.Items(x).SubItems.Add(frmCadFornecedores("site").Value)
                'lstgrade.Items(x).SubItems.Add(frmCadFornecedores("email").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFornecedores("telefone").Value)
                lstgrade.Items(x).SubItems.Add(frmCadFornecedores("celular").Value)
                x += 1
                frmCadFornecedores.MoveNext()

            Loop
            frmCadFornecedores.Close()

        End If
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregafornecedores()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        txtFornecedor.Focus()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim frmCadFornecedores As ADODB.Recordset
        frmCadFornecedores = RecebeTabela("select * from tbFornecedores where codigo=" & lstgrade.Tag)
        If frmCadFornecedores.RecordCount = 0 Then frmCadFornecedores.AddNew()
        frmCadFornecedores("fornecedor").Value = txtFornecedor.Text
        frmCadFornecedores("empresa").Value = txtEmpresa.Text
        frmCadFornecedores("cnpj").Value = mskcnpj.Text
        frmCadFornecedores("endereco").Value = txtEndereco.Text
        frmCadFornecedores("complemento").Value = txtComplemento.Text
        frmCadFornecedores("bairro").Value = txtBairro.Text
        frmCadFornecedores("cidade").Value = txtCidade.Text
        frmCadFornecedores("uf").Value = cbouf.Text
        frmCadFornecedores("cep").Value = mskcpf.Text
        frmCadFornecedores("site").Value = txtSite.Text
        frmCadFornecedores("email").Value = txtEmail.Text
        frmCadFornecedores("telefone").Value = msktel.Text
        frmCadFornecedores("celular").Value = mskcel.Text
        frmCadFornecedores.Update()
        carregafornecedores()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim frmCadFornecedores As ADODB.Recordset
        frmCadFornecedores = RecebeTabela("select * from tbFornecedores where codigo=" & lstgrade.Tag)
        If frmCadFornecedores.EOF = False Then frmCadFornecedores.Delete()
        carregafornecedores()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        Dim frmCadFornecedores As ADODB.Recordset
        frmCadFornecedores = RecebeTabela("select * from tbfornecedores where codigo=" & lstgrade.SelectedItems(0).Text)
        If frmCadFornecedores.RecordCount = 0 Then
            MsgBox("Registro não localizado!")
            limpar()
            Exit Sub
        End If

        txtFornecedor.Text = frmCadFornecedores("fornecedor").Value.ToString
        txtEmpresa.Text = frmCadFornecedores("empresa").Value.ToString
        mskcnpj.Text = frmCadFornecedores("cnpj").Value.ToString
        txtEndereco.Text = frmCadFornecedores("endereco").Value.ToString
        txtComplemento.Text = frmCadFornecedores("complemento").Value.ToString
        txtBairro.Text = frmCadFornecedores("bairro").Value.ToString
        txtCidade.Text = frmCadFornecedores("cidade").Value.ToString
        cbouf.Text = frmCadFornecedores("uf").Value.ToString
        mskcpf.Text = frmCadFornecedores("cep").Value.ToString
        txtSite.Text = frmCadFornecedores("site").Value.ToString
        txtEmail.Text = frmCadFornecedores("email").Value.ToString
        msktel.Text = frmCadFornecedores("telefone").Value.ToString
        mskcel.Text = frmCadFornecedores("celular").Value.ToString
        btnExcluir.Visible = True
    End Sub
    Private Sub txtFornecedor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFornecedor.KeyUp
        If e.KeyCode = Keys.Enter Then carregafornecedores()
    End Sub
End Class