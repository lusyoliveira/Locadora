Imports System.Data.SqlClient

Public Class frmCadProdutos
    Dim dtCadProdutos As DataTable
    Private Sub limpar()
        txtCodigo.Text = ""
        cboProduto.Text = ""
        txtTitulo.Text = ""
        txtAutor.Text = ""
        cboGenero.Text = ""
        cboGenerojogo.Text = ""
        txtCensura.Text = ""
        txtDuracao.Text = ""
        txtQuantidade.Text = ""
        txtvalor.Text = ""
        mskDcad.Text = ""
        cbolegenda.Text = ""
        'txtoriginal.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged
        If cboProduto.Text = "JOGO" Then
            cboGenerojogo.Visible = True
            txtDuracao.Enabled = False
            lblDuracao.Enabled = False
        Else
            cboGenerojogo.Visible = False
            txtDuracao.Enabled = True
            lblDuracao.Enabled = True
        End If
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregaproduto()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        cboProduto.Focus()
    End Sub
    Private Sub cboGereno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGenero.SelectedIndexChanged
        If cboGenero.Text = "Adulto" Then
            txtCensura.Text = "18"
        Else
            txtCensura.Text = ""
            If cboGenero.Text = "Desenho" Then
                txtCensura.Text = "Livre"
            Else
                txtCensura.Text = ""
            End If
        End If
    End Sub
    Private Sub frmCadProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaproduto()
    End Sub
    Private Sub carregaproduto()
        limpar()
        lstgrade.Items.Clear()

        Dim x As Integer = 0
        Dim sql As String

        sql = "select * from tbProdutos where codigo=" & txtCodigo.Text
        If Not IsNumeric(cboProduto.Text) Then
            sql = "select * from tbProdutos where produto like '" & txtCodigo.Text & "%'"
        End If

        ' Recebe o DataTable preenchido com os dados dos produtos
        dtCadProdutos = RecebeTabela(sql)

        If dtCadProdutos.Rows.Count > 0 Then
            For Each row As DataRow In dtCadProdutos.Rows
                Dim item As New ListViewItem(row("codigo").ToString())
                item.SubItems.Add(row("produto").ToString())
                item.SubItems.Add(row("titulo").ToString())
                item.SubItems.Add(row("genero").ToString())
                item.SubItems.Add(row("censura").ToString())
                item.SubItems.Add(row("dtcad").ToString())

                lstgrade.Items.Add(item)
                x += 1
            Next
        End If
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text

        ' Recebe o DataTable preenchido com os dados do produto correspondente
        dtCadProdutos = RecebeTabela("select * from tbProdutos where codigo=" & codigo)

        Dim row As DataRow
        If dtCadProdutos.Rows.Count = 0 Then
            row = dtCadProdutos.NewRow()
            dtCadProdutos.Rows.Add(row)
        Else
            row = dtCadProdutos.Rows(0)
        End If

        ' Atualiza os campos do DataRow com os valores dos controles do formulário
        row("produto") = cboProduto.Text
        row("titulo") = txtTitulo.Text
        row("autor") = txtAutor.Text
        If cboProduto.Text = "JOGO" Then
            row("genero") = cboGenerojogo.Text
        Else
            row("genero") = cboGenero.Text
        End If
        row("censura") = txtCensura.Text
        row("duracao") = txtDuracao.Text
        ' row("original") = txtoriginal.Text
        row("valor") = txtvalor.Text
        row("dtcad") = mskDcad.Text
        row("legenda") = cbolegenda.Text

        ' Atualiza o banco de dados com as mudanças no DataTable
        AtualizaBancoDados(dtCadProdutos)

        ' Recarrega os produtos na lista
        carregaproduto()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text

        If (MsgBox("Confirma a Exclusão ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            ' Recebe o DataTable preenchido com os dados do produto correspondente
            dtCadProdutos = RecebeTabela("select * from tbProdutos where codigo=" & codigo)

            If dtCadProdutos.Rows.Count > 0 Then
                ' Marca a linha para exclusão
                dtCadProdutos.Rows(0).Delete()

                ' Atualiza o banco de dados com as mudanças no DataTable
                AtualizaBancoDados(dtCadProdutos)

                ' Recarrega os produtos na lista
                carregaproduto()
            End If
        End If
    End Sub

    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        ' Recebe o DataTable preenchido com os dados do produto correspondente
        dtCadProdutos = RecebeTabela("select * from tbProdutos where codigo=" & lstgrade.SelectedItems(0).Text)

        If dtCadProdutos.Rows.Count = 0 Then
            limpar()
            MsgBox("Registro não localizado!")
            Exit Sub
        End If

        Dim row As DataRow = dtCadProdutos.Rows(0)

        cboProduto.Text = row("produto").ToString()
        txtTitulo.Text = row("titulo").ToString()
        txtAutor.Text = row("autor").ToString()
        If cboProduto.Text = "JOGO" Then
            cboGenerojogo.Text = row("genero").ToString()
        Else
            cboGenero.Text = row("genero").ToString()
        End If

        txtCensura.Text = row("censura").ToString()
        txtDuracao.Text = row("duracao").ToString()
        txtQuantidade.Text = row("quantidade").ToString()
        ' txtoriginal.Text = row("original").ToString()
        txtvalor.Text = row("valor").ToString()
        mskDcad.Text = row("dtcad").ToString()
        cbolegenda.Text = row("legenda").ToString()
        btnExcluir.Visible = True
    End Sub

    ' Método para atualizar o banco de dados com as mudanças no DataTable
    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        ' Conexão com o banco de dados via RecebeTabela
        dtCadProdutos = RecebeTabela("SELECT * FROM tbProdutos WHERE 1=0")

        ' Configura o adaptador
        Dim adapter As New SqlDataAdapter()

        ' Configura o comando de inserção
        Dim insertCommand As New SqlCommand("INSERT INTO tbProdutos (produto, titulo, autor, genero, censura, duracao, valor, dtcad, legenda) VALUES (@produto, @titulo, @autor, @genero, @censura, @duracao, @valor, @dtcad, @legenda)")
        insertCommand.Parameters.Add("@produto", SqlDbType.NVarChar, 50, "produto")
        insertCommand.Parameters.Add("@titulo", SqlDbType.NVarChar, 100, "titulo")
        insertCommand.Parameters.Add("@autor", SqlDbType.NVarChar, 100, "autor")
        insertCommand.Parameters.Add("@genero", SqlDbType.NVarChar, 50, "genero")
        insertCommand.Parameters.Add("@censura", SqlDbType.NVarChar, 10, "censura")
        insertCommand.Parameters.Add("@duracao", SqlDbType.NVarChar, 10, "duracao")
        insertCommand.Parameters.Add("@valor", SqlDbType.Decimal, 10, "valor")
        insertCommand.Parameters.Add("@dtcad", SqlDbType.Date, 0, "dtcad")
        insertCommand.Parameters.Add("@legenda", SqlDbType.NVarChar, 50, "legenda")
        adapter.InsertCommand = insertCommand

        ' Configura o comando de atualização
        Dim updateCommand As New SqlCommand("UPDATE tbProdutos SET produto=@produto, titulo=@titulo, autor=@autor, genero=@genero, censura=@censura, duracao=@duracao, valor=@valor, dtcad=@dtcad, legenda=@legenda WHERE codigo=@codigo")
        updateCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        updateCommand.Parameters.Add("@produto", SqlDbType.NVarChar, 50, "produto")
        updateCommand.Parameters.Add("@titulo", SqlDbType.NVarChar, 100, "titulo")
        updateCommand.Parameters.Add("@autor", SqlDbType.NVarChar, 100, "autor")
        updateCommand.Parameters.Add("@genero", SqlDbType.NVarChar, 50, "genero")
        updateCommand.Parameters.Add("@censura", SqlDbType.NVarChar, 10, "censura")
        updateCommand.Parameters.Add("@duracao", SqlDbType.NVarChar, 10, "duracao")
        updateCommand.Parameters.Add("@valor", SqlDbType.Decimal, 10, "valor")
        updateCommand.Parameters.Add("@dtcad", SqlDbType.Date, 0, "dtcad")
        updateCommand.Parameters.Add("@legenda", SqlDbType.NVarChar, 50, "legenda")
        adapter.UpdateCommand = updateCommand

        '' Configura o comando de exclusão
        'Dim deleteCommand As New SqlCommand("DELETE FROM tbProdutos WHERE codigo=@codigo")
        'deleteCommand.Parameters.Add("@codigo", SqlDbType.Int, 0, "codigo")
        'adapter.DeleteCommand = deleteCommand

        ' Atualiza o banco de dados com as mudanças no DataTable
        dtCadProdutos = dt.GetChanges()
        If dtCadProdutos IsNot Nothing Then
            adapter.Update(dtCadProdutos)
            dt.AcceptChanges()
        End If
    End Sub


End Class
