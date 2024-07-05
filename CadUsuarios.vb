Imports System.Data.SqlClient

Public Class frmCadUsuarios
    Dim dtCadUsuarios As DataTable
    Private Sub limpar()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtSenha.Text = ""
        txtConfSenha.Text = ""
        cboPermissao.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregausuario()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        txtNome.Focus()
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub carregausuario()
        limpar()
        lstgrade.Items.Clear()

        Dim x As Integer = 0
        Dim sql As String

        sql = "select * from tbUsuarios where codigo=" & txtCodigo.Text
        If Not IsNumeric(txtNome.Text) Then
            sql = "select * from tbUsuarios where nome like '" & txtCodigo.Text & "%'"
        End If

        ' Recebe o DataTable preenchido com os dados dos usuários
        dtCadUsuarios = RecebeTabela(sql)

        If dtCadUsuarios.Rows.Count > 0 Then
            For Each row As DataRow In dtCadUsuarios.Rows
                Dim item As New ListViewItem(row("codigo").ToString())
                item.SubItems.Add(row("nome").ToString())
                item.SubItems.Add(row("permissao").ToString())
                item.SubItems.Add(row("senha").ToString())
                item.SubItems.Add(row("confsenha").ToString())

                lstgrade.Items.Add(item)
                x += 1
            Next
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text

        ' Recebe o DataTable preenchido com os dados do usuário correspondente
        dtCadUsuarios = RecebeTabela("select * from tbUsuarios where codigo=" & codigo)

        Dim row As DataRow
        If dtCadUsuarios.Rows.Count = 0 Then
            row = dtCadUsuarios.NewRow()
            dtCadUsuarios.Rows.Add(row)
        Else
            row = dtCadUsuarios.Rows(0)
        End If

        ' Atualiza os campos do DataRow com os valores dos controles do formulário
        row("nome") = txtNome.Text
        row("permissao") = cboPermissao.Text
        row("senha") = txtSenha.Text
        row("confsenha") = txtConfSenha.Text

        ' Atualiza o banco de dados com as mudanças no DataTable
        AtualizaBancoDados(dtCadUsuarios)

        ' Recarrega os usuários na lista
        carregausuario()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text

        If (MsgBox("Confirma a Exclusão ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            ' Recebe o DataTable preenchido com os dados do usuário correspondente
            dtCadUsuarios = RecebeTabela("select * from tbUsuarios where codigo=" & codigo)

            If dtCadUsuarios.Rows.Count > 0 Then
                ' Marca a linha para exclusão
                dtCadUsuarios.Rows(0).Delete()

                ' Atualiza o banco de dados com as mudanças no DataTable
                AtualizaBancoDados(dtCadUsuarios)

                ' Recarrega os usuários na lista
                carregausuario()
            End If
        End If
    End Sub

    ' Método para atualizar o banco de dados com as mudanças no DataTable
    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        ' Conexão com o banco de dados via RecebeTabela
        dtCadUsuarios = RecebeTabela("SELECT * FROM tbUsuarios WHERE 1=0")

        ' Configura o adaptador
        Dim adapter As New SqlDataAdapter()

        ' Configura o comando de inserção
        Dim insertCommand As New SqlCommand("INSERT INTO tbUsuarios (nome, permissao, senha, confsenha) VALUES (@nome, @permissao, @senha, @confsenha)")
        insertCommand.Parameters.Add("@nome", SqlDbType.NVarChar, 50, "nome")
        insertCommand.Parameters.Add("@permissao", SqlDbType.NVarChar, 50, "permissao")
        insertCommand.Parameters.Add("@senha", SqlDbType.NVarChar, 50, "senha")
        insertCommand.Parameters.Add("@confsenha", SqlDbType.NVarChar, 50, "confsenha")
        adapter.InsertCommand = insertCommand

        ' Configura o comando de atualização
        Dim updateCommand As New SqlCommand("UPDATE tbUsuarios SET nome=@nome, permissao=@permissao, senha=@senha, confsenha=@confsenha WHERE codigo=@codigo")
        updateCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        updateCommand.Parameters.Add("@nome", SqlDbType.NVarChar, 50, "nome")
        updateCommand.Parameters.Add("@permissao", SqlDbType.NVarChar, 50, "permissao")
        updateCommand.Parameters.Add("@senha", SqlDbType.NVarChar, 50, "senha")
        updateCommand.Parameters.Add("@confsenha", SqlDbType.NVarChar, 50, "confsenha")
        adapter.UpdateCommand = updateCommand

        '' Configura o comando de exclusão
        'Dim deleteCommand As New SqlCommand("DELETE FROM tbUsuarios WHERE codigo=@codigo")
        'deleteCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        'adapter.DeleteCommand = deleteCommand

        ' Atualiza o banco de dados com as mudanças no DataTable
        dtCadUsuarios = dt.GetChanges()
        If dtCadUsuarios IsNot Nothing Then
            adapter.Update(dtCadUsuarios)
            dt.AcceptChanges()
        End If
    End Sub

    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If
        txtNome.Text = lstgrade.SelectedItems(0).SubItems(1).Text
        cboPermissao.Text = lstgrade.SelectedItems(0).SubItems(2).Text
        txtSenha.Text = lstgrade.SelectedItems(0).SubItems(3).Text
        txtConfSenha.Text = lstgrade.SelectedItems(0).SubItems(4).Text
        lstgrade.Tag = lstgrade.SelectedItems(0).Text
        btnExcluir.Visible = True
    End Sub
    Private Sub cboPermissao_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.Click
        If txtSenha.Text <> txtConfSenha.Text Then
            MsgBox("Senha Inválida,favor corrigir!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub frmCadUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class