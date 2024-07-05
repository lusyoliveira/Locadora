Imports System.Data.SqlClient

Public Class frmCadClientes
    Dim dtCadClientes As DataTable

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
        CarregaClientes()
    End Sub
    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then CarregaClientes()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        CarregaClientes()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtNome.Focus()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub CarregaClientes()
        Dim x As Integer = 0
        Dim sql As String

        sql = "SELECT * FROM tbClientes WHERE codigo = " & txtNome.Text
        If Not IsNumeric(txtNome.Text) Then
            sql = "SELECT * FROM tbClientes WHERE nome LIKE '" & txtNome.Text & "%'"
        End If

        limpar()
        lstgrade.Items.Clear()

        ' Receber os dados em um DataTable
        dtCadClientes = RecebeTabela(sql)

        For Each row As DataRow In dtCadClientes.Rows
            lstgrade.Items.Add(row("codigo").ToString())
            lstgrade.Items(x).SubItems.Add(row("nome").ToString())
            lstgrade.Items(x).SubItems.Add(row("dtnasc").ToString())
            lstgrade.Items(x).SubItems.Add(row("telefone1").ToString())
            lstgrade.Items(x).SubItems.Add(row("email").ToString())
            lstgrade.Items(x).SubItems.Add(row("rg").ToString())
            lstgrade.Items(x).SubItems.Add(row("cpf").ToString())
            x += 1
        Next

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        dtCadClientes = RecebeTabela("select * from tbClientes")
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = CInt(lstgrade.SelectedItems(0).Text)

        Dim rows() As DataRow = dtCadClientes.Select("codigo = " & codigo)
        Dim row As DataRow

        If rows.Length > 0 Then
            row = rows(0)
        Else
            row = dtCadClientes.NewRow()
            dtCadClientes.Rows.Add(row)
        End If

        row("nome") = txtNome.Text
        row("dtnasc") = mskDnascimento.Text
        row("estadocivil") = cboEstadoCivil.Text
        row("endereco") = txtEndereco.Text
        row("complemento") = txtComplemento.Text
        row("bairro") = txtBairro.Text
        row("cidade") = txtCidade.Text
        row("uf") = cboUf.Text
        row("cep") = mskCep.Text
        row("sexo") = rbdMasculino.Checked
        row("telefone1") = mskTel1.Text
        row("telefone2") = mskTel2.Text
        row("celular") = mskCel.Text
        row("email") = txtEmail.Text
        row("rg") = mskrg.Text
        row("cpf") = mskcpf.Text
        row("nomedependente") = txtnome_dep.Text
        row("dtnascdependente") = mskdtdatadep.Text
        row("cpfdependente") = mskcpf_dep.Text
        row("grauparentesco") = cbopzrentesco.Text
        row("obs") = txtObs.Text
        row("dep_extras") = txtextra.Text

        ' Assumindo que há um método para atualizar o banco de dados com os dados do DataTable
        AtualizaBancoDados(dtCadClientes)

        CarregaClientes()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        dtCadClientes = RecebeTabela("select * from tbClientes")
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = CInt(lstgrade.SelectedItems(0).Text)

        If (MsgBox("Confirma a Exclusão?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            Dim rows() As DataRow = dtCadClientes.Select("codigo = " & codigo)
            If rows.Length > 0 Then
                dtCadClientes.Rows.Remove(rows(0))

                ' Assumindo que há um método para atualizar o banco de dados com os dados do DataTable
                AtualizaBancoDados(dtCadClientes)

                CarregaClientes()
            End If
        End If
    End Sub

    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        dtCadClientes = RecebeTabela("select * from tbClientes")
        Dim rows() As DataRow = dtCadClientes.Select("codigo = " & CInt(lstgrade.SelectedItems(0).Text))

        If rows.Length = 0 Then
            limpar()
            MsgBox("Registro não localizado!")
            Exit Sub
        End If

        Dim row As DataRow = rows(0)

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
        btnExcluir.Visible = True
    End Sub
    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        ' Conexão com o banco de dados via RecebeTabela
        dtCadClientes = RecebeTabela("SELECT * FROM tbClientes")

        ' Inicializa o adaptador
        Dim adapter As New SqlDataAdapter()

        ' Configura o comando de inserção
        Dim insertCommand As New SqlCommand("INSERT INTO tbClientes (nome, dtnasc, estadocivil, endereco, complemento, bairro, cidade, uf, cep, sexo, telefone1, telefone2, celular, email, rg, cpf, nomedependente, dtnascdependente, cpfdependente, grauparentesco, obs, dep_extras) VALUES (@nome, @dtnasc, @estadocivil, @endereco, @complemento, @bairro, @cidade, @uf, @cep, @sexo, @telefone1, @telefone2, @celular, @email, @rg, @cpf, @nomedependente, @dtnascdependente, @cpfdependente, @grauparentesco, @obs, @dep_extras)")
        insertCommand.Parameters.Add("@nome", SqlDbType.NVarChar, 50, "nome")
        insertCommand.Parameters.Add("@dtnasc", SqlDbType.Date, 0, "dtnasc")
        insertCommand.Parameters.Add("@estadocivil", SqlDbType.NVarChar, 50, "estadocivil")
        insertCommand.Parameters.Add("@endereco", SqlDbType.NVarChar, 100, "endereco")
        insertCommand.Parameters.Add("@complemento", SqlDbType.NVarChar, 100, "complemento")
        insertCommand.Parameters.Add("@bairro", SqlDbType.NVarChar, 50, "bairro")
        insertCommand.Parameters.Add("@cidade", SqlDbType.NVarChar, 50, "cidade")
        insertCommand.Parameters.Add("@uf", SqlDbType.NVarChar, 2, "uf")
        insertCommand.Parameters.Add("@cep", SqlDbType.NVarChar, 10, "cep")
        insertCommand.Parameters.Add("@sexo", SqlDbType.Bit, 0, "sexo")
        insertCommand.Parameters.Add("@telefone1", SqlDbType.NVarChar, 15, "telefone1")
        insertCommand.Parameters.Add("@telefone2", SqlDbType.NVarChar, 15, "telefone2")
        insertCommand.Parameters.Add("@celular", SqlDbType.NVarChar, 15, "celular")
        insertCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        insertCommand.Parameters.Add("@rg", SqlDbType.NVarChar, 20, "rg")
        insertCommand.Parameters.Add("@cpf", SqlDbType.NVarChar, 11, "cpf")
        insertCommand.Parameters.Add("@nomedependente", SqlDbType.NVarChar, 50, "nomedependente")
        insertCommand.Parameters.Add("@dtnascdependente", SqlDbType.Date, 0, "dtnascdependente")
        insertCommand.Parameters.Add("@cpfdependente", SqlDbType.NVarChar, 11, "cpfdependente")
        insertCommand.Parameters.Add("@grauparentesco", SqlDbType.NVarChar, 50, "grauparentesco")
        insertCommand.Parameters.Add("@obs", SqlDbType.NVarChar, 255, "obs")
        insertCommand.Parameters.Add("@dep_extras", SqlDbType.NVarChar, 255, "dep_extras")
        adapter.InsertCommand = insertCommand

        ' Configura o comando de atualização
        Dim updateCommand As New SqlCommand("UPDATE tbClientes SET nome=@nome, dtnasc=@dtnasc, estadocivil=@estadocivil, endereco=@endereco, complemento=@complemento, bairro=@bairro, cidade=@cidade, uf=@uf, cep=@cep, sexo=@sexo, telefone1=@telefone1, telefone2=@telefone2, celular=@celular, email=@email, rg=@rg, cpf=@cpf, nomedependente=@nomedependente, dtnascdependente=@dtnascdependente, cpfdependente=@cpfdependente, grauparentesco=@grauparentesco, obs=@obs, dep_extras=@dep_extras WHERE codigo=@codigo")
        updateCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        updateCommand.Parameters.Add("@nome", SqlDbType.NVarChar, 50, "nome")
        updateCommand.Parameters.Add("@dtnasc", SqlDbType.Date, 0, "dtnasc")
        updateCommand.Parameters.Add("@estadocivil", SqlDbType.NVarChar, 50, "estadocivil")
        updateCommand.Parameters.Add("@endereco", SqlDbType.NVarChar, 100, "endereco")
        updateCommand.Parameters.Add("@complemento", SqlDbType.NVarChar, 100, "complemento")
        updateCommand.Parameters.Add("@bairro", SqlDbType.NVarChar, 50, "bairro")
        updateCommand.Parameters.Add("@cidade", SqlDbType.NVarChar, 50, "cidade")
        updateCommand.Parameters.Add("@uf", SqlDbType.NVarChar, 2, "uf")
        updateCommand.Parameters.Add("@cep", SqlDbType.NVarChar, 10, "cep")
        updateCommand.Parameters.Add("@sexo", SqlDbType.Bit, 0, "sexo")
        updateCommand.Parameters.Add("@telefone1", SqlDbType.NVarChar, 15, "telefone1")
        updateCommand.Parameters.Add("@telefone2", SqlDbType.NVarChar, 15, "telefone2")
        updateCommand.Parameters.Add("@celular", SqlDbType.NVarChar, 15, "celular")
        updateCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        updateCommand.Parameters.Add("@rg", SqlDbType.NVarChar, 20, "rg")
        updateCommand.Parameters.Add("@cpf", SqlDbType.NVarChar, 11, "cpf")
        updateCommand.Parameters.Add("@nomedependente", SqlDbType.NVarChar, 50, "nomedependente")
        updateCommand.Parameters.Add("@dtnascdependente", SqlDbType.Date, 0, "dtnascdependente")
        updateCommand.Parameters.Add("@cpfdependente", SqlDbType.NVarChar, 11, "cpfdependente")
        updateCommand.Parameters.Add("@grauparentesco", SqlDbType.NVarChar, 50, "grauparentesco")
        updateCommand.Parameters.Add("@obs", SqlDbType.NVarChar, 255, "obs")
        updateCommand.Parameters.Add("@dep_extras", SqlDbType.NVarChar, 255, "dep_extras")
        adapter.UpdateCommand = updateCommand

        '' Configura o comando de exclusão
        'Dim deleteCommand As New SqlCommand("DELETE FROM tbClientes WHERE codigo=@codigo")
        'deleteCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        'adapter.DeleteCommand = deleteCommand

        ' Atualiza o banco de dados com as mudanças no DataTable
        dtCadClientes = dt.GetChanges()
        If dtCadClientes IsNot Nothing Then
            adapter.Update(dtCadClientes)
            dt.AcceptChanges()
        End If
    End Sub
End Class