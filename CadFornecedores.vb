Imports System.Data.SqlClient

Public Class frmCadFornecedores
    Dim dtCadFornecedores As DataTable
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
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregafornecedores()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        txtFornecedor.Focus()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub txtFornecedor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFornecedor.KeyUp
        If e.KeyCode = Keys.Enter Then carregafornecedores()
    End Sub
    Private Sub carregafornecedores()
        limpar()
        lstgrade.Items.Clear()
        Dim sql As String
        Dim x As Integer = 0

        sql = "select * from tbFornecedores where codigo=" & txtCodigo.Text
        If Not IsNumeric(txtFornecedor.Text) Then
            sql = "select * from tbFornecedores where fornecedor like '" & txtCodigo.Text & "%'"
        End If

        dtCadFornecedores = RecebeTabela(sql)

        If dtCadFornecedores.Rows.Count > 0 Then
            For Each row As DataRow In dtCadFornecedores.Rows
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
        End If
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim row As DataRow
        dtCadFornecedores = RecebeTabela("select * from tbFornecedores where codigo=" & lstgrade.Tag)

        If dtCadFornecedores.Rows.Count = 0 Then
            row = dtCadFornecedores.NewRow()
            dtCadFornecedores.Rows.Add(row)
        Else
            row = dtCadFornecedores.Rows(0)
        End If

        row("fornecedor") = txtFornecedor.Text
        row("empresa") = txtEmpresa.Text
        row("cnpj") = mskcnpj.Text
        row("endereco") = txtEndereco.Text
        row("complemento") = txtComplemento.Text
        row("bairro") = txtBairro.Text
        row("cidade") = txtCidade.Text
        row("uf") = cbouf.Text
        row("cep") = mskcpf.Text
        row("site") = txtSite.Text
        row("email") = txtEmail.Text
        row("telefone") = msktel.Text
        row("celular") = mskcel.Text

        AtualizaBancoDados(dtCadFornecedores)
        carregafornecedores()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        dtCadFornecedores = RecebeTabela("select * from tbFornecedores where codigo=" & lstgrade.Tag)

        If dtCadFornecedores.Rows.Count > 0 Then
            dtCadFornecedores.Rows(0).Delete()
            AtualizaBancoDados(dtCadFornecedores)
        End If

        carregafornecedores()
    End Sub


    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        dtCadFornecedores = RecebeTabela("select * from tbfornecedores where codigo=" & lstgrade.SelectedItems(0).Text)

        If dtCadFornecedores.Rows.Count = 0 Then
            MsgBox("Registro não localizado!")
            limpar()
            Exit Sub
        End If

        Dim row As DataRow = dtCadFornecedores.Rows(0)

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
    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        ' Conexão com o banco de dados via RecebeTabela
        dtCadFornecedores = RecebeTabela("SELECT * FROM tbFornecedores")

        ' Configura o adaptador
        Dim adapter As New SqlDataAdapter()

        ' Configura o comando de inserção
        Dim insertCommand As New SqlCommand("INSERT INTO tbFornecedores (fornecedor, empresa, cnpj, endereco, complemento, bairro, cidade, uf, cep, site, email, telefone, celular) VALUES (@fornecedor, @empresa, @cnpj, @endereco, @complemento, @bairro, @cidade, @uf, @cep, @site, @email, @telefone, @celular)")
        insertCommand.Parameters.Add("@fornecedor", SqlDbType.NVarChar, 50, "fornecedor")
        insertCommand.Parameters.Add("@empresa", SqlDbType.NVarChar, 50, "empresa")
        insertCommand.Parameters.Add("@cnpj", SqlDbType.NVarChar, 20, "cnpj")
        insertCommand.Parameters.Add("@endereco", SqlDbType.NVarChar, 100, "endereco")
        insertCommand.Parameters.Add("@complemento", SqlDbType.NVarChar, 100, "complemento")
        insertCommand.Parameters.Add("@bairro", SqlDbType.NVarChar, 50, "bairro")
        insertCommand.Parameters.Add("@cidade", SqlDbType.NVarChar, 50, "cidade")
        insertCommand.Parameters.Add("@uf", SqlDbType.NVarChar, 2, "uf")
        insertCommand.Parameters.Add("@cep", SqlDbType.NVarChar, 10, "cep")
        insertCommand.Parameters.Add("@site", SqlDbType.NVarChar, 50, "site")
        insertCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        insertCommand.Parameters.Add("@telefone", SqlDbType.NVarChar, 15, "telefone")
        insertCommand.Parameters.Add("@celular", SqlDbType.NVarChar, 15, "celular")
        adapter.InsertCommand = insertCommand

        ' Configura o comando de atualização
        Dim updateCommand As New SqlCommand("UPDATE tbFornecedores SET fornecedor=@fornecedor, empresa=@empresa, cnpj=@cnpj, endereco=@endereco, complemento=@complemento, bairro=@bairro, cidade=@cidade, uf=@uf, cep=@cep, site=@site, email=@email, telefone=@telefone, celular=@celular WHERE codigo=@codigo")
        updateCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        updateCommand.Parameters.Add("@fornecedor", SqlDbType.NVarChar, 50, "fornecedor")
        updateCommand.Parameters.Add("@empresa", SqlDbType.NVarChar, 50, "empresa")
        updateCommand.Parameters.Add("@cnpj", SqlDbType.NVarChar, 20, "cnpj")
        updateCommand.Parameters.Add("@endereco", SqlDbType.NVarChar, 100, "endereco")
        updateCommand.Parameters.Add("@complemento", SqlDbType.NVarChar, 100, "complemento")
        updateCommand.Parameters.Add("@bairro", SqlDbType.NVarChar, 50, "bairro")
        updateCommand.Parameters.Add("@cidade", SqlDbType.NVarChar, 50, "cidade")
        updateCommand.Parameters.Add("@uf", SqlDbType.NVarChar, 2, "uf")
        updateCommand.Parameters.Add("@cep", SqlDbType.NVarChar, 10, "cep")
        updateCommand.Parameters.Add("@site", SqlDbType.NVarChar, 50, "site")
        updateCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        updateCommand.Parameters.Add("@telefone", SqlDbType.NVarChar, 15, "telefone")
        updateCommand.Parameters.Add("@celular", SqlDbType.NVarChar, 15, "celular")
        adapter.UpdateCommand = updateCommand

        ' Configura o comando de exclusão
        Dim deleteCommand As New SqlCommand("DELETE FROM tbFornecedores WHERE codigo=@codigo")
        deleteCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        adapter.DeleteCommand = deleteCommand

        ' Atualiza o banco de dados com as mudanças no DataTable
        dtCadFornecedores = dt.GetChanges()
        If dtCadFornecedores IsNot Nothing Then
            adapter.Update(dtCadFornecedores)
            dt.AcceptChanges()
        End If
    End Sub

End Class