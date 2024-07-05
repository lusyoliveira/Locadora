Imports System.Data.SqlClient

Public Class frmLocacao
    Dim wcpagina As Integer, imagem As Image, tbCliente As ADODB.Recordset
    Dim X As Integer
    Dim Y As Integer
    Dim z As Integer
    Dim SQL As String
    Dim tbclientes, tbProdutos, TBLOCACAO, tbFuncionarios As DataTable
    Private Sub cboClientes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboclientes.GotFocus
        CarregaCombo(cboclientes, "Select codigo ,nome from tbClientes order by nome")

    End Sub
    Private Sub cboproduto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboproduto.GotFocus
        CarregaCombo(cboproduto, "Select codigo ,titulo from tbProdutos order by titulo")
    End Sub

    Private Sub atualizaValor()
        Dim x As Integer, total As Decimal = 0
        If lstgrade.Items.Count > 0 Then
            For x = 0 To lstgrade.Items.Count - 1
                total += lstgrade.Items(x).SubItems(1).Text
            Next
            lbltotalpg.Text = FormatCurrency(total)
        Else
            lbltotalpg.Text = 0
        End If
    End Sub
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        On Error Resume Next
        X = lblvalunit.Text
        ''Y = lbltotal1.Text
        ''z = txtQuantidade.Text
        lbltotalpg.Text = lbltotalpg.Text + X

        If lblvalunit.Tag = "" Then Exit Sub
        Dim tbProdutos As ADODB.Recordset
        tbProdutos = RecebeTabela("Select * from tbProdutos where codigo = " & lblvalunit.Tag)
        If tbProdutos.RecordCount = 0 Then Exit Sub
        tbProdutos.MoveFirst()
        lstgrade.Items.Add(tbProdutos("titulo").Value.ToString)
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(FormatCurrency(tbProdutos("valor").Value.ToString))
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(txtQuantidade.Text)
        ''lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(FormatCurrency(lbltotal1.Text))
        lstgrade.Items(lstgrade.Items.Count - 1).Tag = tbProdutos("codigo").Value.ToString
    End Sub
    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        'X = 0
        'Y = 0
        'z = 0

        If lstgrade.SelectedItems.Count = 0 Then Exit Sub
        lstgrade.SelectedItems(0).Remove()
        atualizaValor()
    End Sub
    Private Sub txtQuantidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantidade.TextChanged
        On Error Resume Next
        lbltotal1.Text = FormatCurrency(lblvalunit.Text * txtQuantidade.Text)
        lbltotalpg.Text = lbltotal1.Text
    End Sub
    Private Sub txtdinheiro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LBLTROCO.Text = txtdinheiro.Text - lbltotalpg.Text
    End Sub
    Private Sub cbopagar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopagar.SelectedIndexChanged
        If cbopagar.Text = "Na Entrega" Then
            txtdinheiro.Enabled = False
            lbldinheiro.Enabled = False
            LBLTROCO.Enabled = False
            lblpagar.Enabled = False
        Else
            txtdinheiro.Enabled = True
            lbldinheiro.Enabled = True
            LBLTROCO.Enabled = True
            lblpagar.Enabled = True
        End If
    End Sub
    Private Sub PAGAMETO()
        If txtdinheiro.Text = "" Then
            MsgBox("PAGAMENTO NAO EFETUADO!")
            Exit Sub
        End If
    End Sub
    Private Sub LIMPAR()
        CBO_FUNCIONARIO.Text = ""
        cboclientes.Text = ""
        cboproduto.Text = ""
        lblvalunit.Text = ""
        lblTotal.Text = ""
        lbltotal1.Text = ""
        cbopagar.Text = ""
        lbltotalpg.Text = ""
        txtdinheiro.Text = ""
        LBLTROCO.Text = ""
        lblQuantidade.Text = ""
        lstgrade.Clear()
    End Sub
    Private Sub CAMPOZERO()
        If CBO_FUNCIONARIO.Text = "" Then
            CBO_FUNCIONARIO.Text = 0
        End If
        If cboclientes.Text = "" Then
            cboclientes.Text = 0
        End If
        If cboproduto.Text = "" Then
            cboproduto.Text = 0
        End If
    End Sub
    Private Sub CBO_FUNCIONARIO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBO_FUNCIONARIO.GotFocus
        On Error Resume Next
        '' CarregaCombo(tbFuncionarios, "Select codfunc ,nome from tbFuncionarios order by nome")
        CarregaCombo(CBO_FUNCIONARIO, "Select codfunc ,nome from tbFuncionarios order by nome")
    End Sub

    Private Sub lbltotal1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotal1.TextChanged
        ''lbltotal1.Text = FormatCurrency(0)
    End Sub

    Private Sub txtdinheiro_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdinheiro.TextChanged
        On Error Resume Next
        LBLTROCO.Text = txtdinheiro.Text - lbltotalpg.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        wcpagina = 1
    End Sub
    Private Sub cboproduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboproduto.SelectedIndexChanged
        tbProdutos = RecebeTabela("Select * from tbProdutos where titulo like '" & cboproduto.Text & "'")

        lblvalunit.Text = FormatCurrency(0)
        If tbProdutos.Rows.Count = 0 Then Exit Sub

        Dim row As DataRow = tbProdutos.Rows(0)
        lblvalunit.Text = FormatCurrency(row("valor").ToString())
        lblvalunit.Tag = row("codigo").ToString()
    End Sub

    Private Sub frmLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALVAR.Click
        On Error Resume Next
        CAMPOZERO()
        If txtdinheiro.Text = "" Then
            MsgBox("PAGAMENTO NAO EFETUADO!")
            Exit Sub
        End If

        SQL = "SELECT * FROM TBLOCACAO"
        TBLOCACAO = RecebeTabela(SQL)
        TBLOCACAO.Rows.Add()

        Dim newRow As DataRow = TBLOCACAO.Rows(TBLOCACAO.Rows.Count - 1)
        newRow("FUNCIONARIO") = LerCombo(CBO_FUNCIONARIO)
        newRow("DT_LOCACAO") = DTP_LOCACAO.Text
        newRow("DT_DEVOLUCAO") = DTP_DEVOLUCAO.Text
        newRow("CLIENTE") = LerCombo(cboclientes)
        newRow("FILME") = LerCombo(cboproduto)
        newRow("VALOR") = moeda(lblvalunit.Text)
        newRow("TOTAL") = lblTotal.Text
        TBLOCACAO.AcceptChanges()

        ' Atualiza no banco de dados
        AtualizaBancoDados(TBLOCACAO, "TBLOCACAO")

        LIMPAR()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TXT_NSEQ.Text = "" Then
            ER.SetError(TXT_NSEQ, "Digite um Código!")
            Exit Sub
        End If

        SQL = "SELECT * FROM TBLOCACAO WHERE CODIGO=" & TXT_NSEQ.Text
        TBLOCACAO = RecebeTabela(SQL)

        If TBLOCACAO.Rows.Count = 0 Then
            MsgBox("LOCACAO NAO EXISTE!")
            Exit Sub
        End If

        SQL = "DELETE FROM TBLOCACAO WHERE CODIGO=" & TXT_NSEQ.Text
        RecebeTabela(SQL)
        AtualizaBancoDados(TBLOCACAO, "TBLOCACAO")
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT4 As New Font("ARIAL", 8, FontStyle.Bold)
        Dim MYFONT3 As New Font("ARIAL", 30, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 16, FontStyle.Bold)
        Dim MYFONT5 As New Font("ARIAL", 6)
        Dim pulou As Boolean = False

        Dim X1 As Single = e.MarginBounds.Left ' Variável que controla a coluna
        Dim Y1 As Single = e.MarginBounds.Top  ' Variável que controla a linha
        Dim Line As Single = MYFONT.GetHeight(e.Graphics) ' Pega o tamanho da linha a ser adicionada quando usar a myfont
        Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics) ' Pega o tamanho da linha
        Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics) ' Pega o tamanho da linha

        e.Graphics.DrawString("Relatório de Locação", MYFONT3, Brushes.Black, X1 + 120, Y1)
        Y1 += Line3
        Y1 += Line
        e.Graphics.DrawString("Código", MYFONT4, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Funcionário", MYFONT4, Brushes.Black, X1 + 60, Y1)
        e.Graphics.DrawString("Filme", MYFONT4, Brushes.Black, X1 + 306, Y1)
        e.Graphics.DrawString("Valor", MYFONT4, Brushes.Black, X1 + 410, Y1)
        Y1 += Line

        ' Os dados que vão ser buscados no banco de dados
        For Each row As DataRow In TBLOCACAO.Rows
            e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
            e.Graphics.DrawString(row("codigo").ToString(), MYFONT, Brushes.Black, X1 + 10, Y1)
            e.Graphics.DrawString(row("funcionario").ToString(), MYFONT, Brushes.Black, X1 + 60, Y1)
            e.Graphics.DrawString(row("filme").ToString(), MYFONT, Brushes.Black, X1 + 300, Y1)
            e.Graphics.DrawString(row("valor").ToString(), MYFONT, Brushes.Black, X1 + 400, Y1)
            Y1 += Line
            e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
            If Y1 >= e.MarginBounds.Bottom - 50 Then
                pulou = True
                Exit For
            End If
        Next

        If pulou = True Then
            Y1 = e.MarginBounds.Bottom
            e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 700, Y1)
            e.Graphics.DrawString("Página:" & wcpagina, MYFONT, Brushes.Silver, X1, Y1)
            wcpagina += 1
            e.HasMorePages = True
        End If
    End Sub

    Private Sub BTN_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.Click
        Dim sql As String = "SELECT * FROM TBLOCACAO"
        TBLOCACAO = RecebeTabela(sql)
        If TBLOCACAO.Rows.Count = 0 Then
            MsgBox("Nenhuma Locação Selecionada!", MsgBoxStyle.Information)
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub AtualizaBancoDados(ByVal dt As DataTable, ByVal tableName As String)
        Dim connectionString As String = "SuaConnectionString" ' Substitua com a sua string de conexão
        Dim sql As String = $"SELECT * FROM {tableName} WHERE 1 = 0" ' Consulta SQL para obter a estrutura da tabela

        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter()
                adapter.SelectCommand = New SqlCommand(sql, connection)

                ' Define os comandos de atualização (INSERT, UPDATE, DELETE)
                Dim builder As New SqlCommandBuilder(adapter)

                Try
                    connection.Open()

                    ' Preenche o DataTable com os dados do banco de dados
                    adapter.Fill(TBLOCACAO)

                    ' Atualiza o banco de dados com as mudanças no DataTable
                    adapter.Update(dt)
                Catch ex As Exception
                    ' Trate exceções aqui conforme necessário
                    MessageBox.Show($"Erro ao atualizar banco de dados: {ex.Message}")
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

End Class