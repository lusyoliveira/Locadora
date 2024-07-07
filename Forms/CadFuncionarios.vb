Imports System.Data.SqlClient

Public Class frmCadFuncionarios
    Dim dtCadFuncionarios As DataTable
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
        Dim x As Integer = 0
        Dim sql As String

        sql = "SELECT * FROM tbFuncionarios where codfunc = " & txtNome.Text
        If Not IsNumeric(txtNome.Text) Then
            sql = "SELECT * FROM tbFuncionarios  where matricula like '" & txtNome.Text & "%'"
        End If

        limpar()
        lstgrade.Items.Clear()


        ' Receber os dados em um DataTable
        dtCadFuncionarios = RecebeTabela(sql)

        For Each row As DataRow In dtCadFuncionarios.Rows
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
        carregafuncionarios()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtMatricula.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        ' Recebe o DataTable preenchido com os dados do funcionário correspondente
        dtCadFuncionarios = RecebeTabela("select * from tbFuncionarios where codfunc=" & lstgrade.Tag)

        Dim row As DataRow
        If dtCadFuncionarios.Rows.Count = 0 Then
            row = dtCadFuncionarios.NewRow()
            dtCadFuncionarios.Rows.Add(row)
        Else
            row = dtCadFuncionarios.Rows(0)
        End If

        ' Atualiza os campos do DataRow com os valores dos controles do formulário
        ' row("matricula") = txtMatricula.Text
        row("nome") = txtNome.Text
        ' row("dtnasc") = mskDnascimento.Text
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
        row("rg") = mskRG.Text
        row("cpf") = mskCpf.Text
        row("carteiraprofissional") = mskCartprof.Text
        row("cargo") = cboCargo.Text
        ' row("salario") = txtSalario.Text
        row("expediente") = cboExpediente.Text
        row("obs") = txtObs.Text

        ' Atualiza o banco de dados com as mudanças no DataTable
        AtualizaBancoDados(dtCadFuncionarios)

        ' Recarrega os funcionários na lista
        carregafuncionarios()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If (MsgBox("Confirma a Exclusão ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            ' Recebe o DataTable preenchido com os dados do funcionário correspondente
            dtCadFuncionarios = RecebeTabela("select * from tbFuncionarios where codfunc=" & lstgrade.Tag)

            If dtCadFuncionarios.Rows.Count > 0 Then
                ' Marca a linha para exclusão
                dtCadFuncionarios.Rows(0).Delete()

                ' Atualiza o banco de dados com as mudanças no DataTable
                AtualizaBancoDados(dtCadFuncionarios)

                ' Recarrega os funcionários na lista
                carregafuncionarios()
            End If
        End If
    End Sub

    ' Método para atualizar o banco de dados com as mudanças no DataTable
    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        ' Conexão com o banco de dados via RecebeTabela
        dtCadFuncionarios = RecebeTabela("SELECT * FROM tbFuncionarios WHERE 1=0")

        ' Configura o adaptador
        Dim adapter As New SqlDataAdapter()

        ' Configura o comando de inserção
        Dim insertCommand As New SqlCommand("INSERT INTO tbFuncionarios (nome, estadocivil, endereco, complemento, bairro, cidade, uf, cep, sexo, telefone1, telefone2, celular, email, rg, cpf, carteiraprofissional, cargo, expediente, obs) VALUES (@nome, @estadocivil, @endereco, @complemento, @bairro, @cidade, @uf, @cep, @sexo, @telefone1, @telefone2, @celular, @email, @rg, @cpf, @carteiraprofissional, @cargo, @expediente, @obs)")
        insertCommand.Parameters.Add("@nome", SqlDbType.NVarChar, 50, "nome")
        insertCommand.Parameters.Add("@estadocivil", SqlDbType.NVarChar, 50, "estadocivil")
        insertCommand.Parameters.Add("@endereco", SqlDbType.NVarChar, 100, "endereco")
        insertCommand.Parameters.Add("@complemento", SqlDbType.NVarChar, 100, "complemento")
        insertCommand.Parameters.Add("@bairro", SqlDbType.NVarChar, 50, "bairro")
        insertCommand.Parameters.Add("@cidade", SqlDbType.NVarChar, 50, "cidade")
        insertCommand.Parameters.Add("@uf", SqlDbType.NVarChar, 2, "uf")
        insertCommand.Parameters.Add("@cep", SqlDbType.NVarChar, 10, "cep")
        insertCommand.Parameters.Add("@sexo", SqlDbType.Bit, 1, "sexo")
        insertCommand.Parameters.Add("@telefone1", SqlDbType.NVarChar, 15, "telefone1")
        insertCommand.Parameters.Add("@telefone2", SqlDbType.NVarChar, 15, "telefone2")
        insertCommand.Parameters.Add("@celular", SqlDbType.NVarChar, 15, "celular")
        insertCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        insertCommand.Parameters.Add("@rg", SqlDbType.NVarChar, 20, "rg")
        insertCommand.Parameters.Add("@cpf", SqlDbType.NVarChar, 20, "cpf")
        insertCommand.Parameters.Add("@carteiraprofissional", SqlDbType.NVarChar, 20, "carteiraprofissional")
        insertCommand.Parameters.Add("@cargo", SqlDbType.NVarChar, 50, "cargo")
        insertCommand.Parameters.Add("@expediente", SqlDbType.NVarChar, 50, "expediente")
        insertCommand.Parameters.Add("@obs", SqlDbType.NVarChar, 200, "obs")
        adapter.InsertCommand = insertCommand

        ' Configura o comando de atualização
        Dim updateCommand As New SqlCommand("UPDATE tbFuncionarios SET nome=@nome, estadocivil=@estadocivil, endereco=@endereco, complemento=@complemento, bairro=@bairro, cidade=@cidade, uf=@uf, cep=@cep, sexo=@sexo, telefone1=@telefone1, telefone2=@telefone2, celular=@celular, email=@email, rg=@rg, cpf=@cpf, carteiraprofissional=@carteiraprofissional, cargo=@cargo, expediente=@expediente, obs=@obs WHERE codfunc=@codfunc")
        updateCommand.Parameters.Add("@codfunc", SqlDbType.Int, 0, "codfunc")
        updateCommand.Parameters.Add("@nome", SqlDbType.NVarChar, 50, "nome")
        updateCommand.Parameters.Add("@estadocivil", SqlDbType.NVarChar, 50, "estadocivil")
        updateCommand.Parameters.Add("@endereco", SqlDbType.NVarChar, 100, "endereco")
        updateCommand.Parameters.Add("@complemento", SqlDbType.NVarChar, 100, "complemento")
        updateCommand.Parameters.Add("@bairro", SqlDbType.NVarChar, 50, "bairro")
        updateCommand.Parameters.Add("@cidade", SqlDbType.NVarChar, 50, "cidade")
        updateCommand.Parameters.Add("@uf", SqlDbType.NVarChar, 2, "uf")
        updateCommand.Parameters.Add("@cep", SqlDbType.NVarChar, 10, "cep")
        updateCommand.Parameters.Add("@sexo", SqlDbType.Bit, 1, "sexo")
        updateCommand.Parameters.Add("@telefone1", SqlDbType.NVarChar, 15, "telefone1")
        updateCommand.Parameters.Add("@telefone2", SqlDbType.NVarChar, 15, "telefone2")
        updateCommand.Parameters.Add("@celular", SqlDbType.NVarChar, 15, "celular")
        updateCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "email")
        updateCommand.Parameters.Add("@rg", SqlDbType.NVarChar, 20, "rg")
        updateCommand.Parameters.Add("@cpf", SqlDbType.NVarChar, 20, "cpf")
        updateCommand.Parameters.Add("@carteiraprofissional", SqlDbType.NVarChar, 20, "carteiraprofissional")
        updateCommand.Parameters.Add("@cargo", SqlDbType.NVarChar, 50, "cargo")
        updateCommand.Parameters.Add("@expediente", SqlDbType.NVarChar, 50, "expediente")
        updateCommand.Parameters.Add("@obs", SqlDbType.NVarChar, 200, "obs")
        adapter.UpdateCommand = updateCommand

        '' Configura o comando de exclusão
        'Dim deleteCommand As New SqlCommand("DELETE FROM tbFuncionarios WHERE codfunc=@codfunc")
        'deleteCommand.Parameters.Add("@codfunc", SqlDbType.Int, 0, "codfunc")
        'adapter.DeleteCommand = deleteCommand

        ' Atualiza o banco de dados com as mudanças no DataTable
        dtCadFuncionarios = dt.GetChanges()
        If dtCadFuncionarios IsNot Nothing Then
            adapter.Update(dtCadFuncionarios)
            dt.AcceptChanges()
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