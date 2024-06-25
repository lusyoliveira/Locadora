Public Class frmLocacao
    Dim wcpagina As Integer, imagem As Image, tbCliente As ADODB.Recordset
    Dim X As Integer
    Dim Y As Integer
    Dim z As Integer
    Dim SQL As String
    Dim tbclientes As ADODB.Recordset
    Dim tbProdutos As ADODB.Recordset
    Dim TBLOCACAO As ADODB.Recordset
    Dim tbFuncionarios As ADODB.Recordset
    Private Sub cboClientes_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboclientes.GotFocus
        ''CarregaCombo(tbProdutos, "Select codigo ,produto from tbProdutos order by produtos")
        CarregaCombo(cboclientes, "Select codigo ,nome from tbClientes order by nome")
        'cboclientes.Items.Clear()
        'tbClientes = RecebeTabela("Select * from tbClientes order by nome")
        'If tbClientes.RecordCount <> 0 Then
        '    tbClientes.MoveFirst()
        '    While tbClientes.EOF = False
        '        cboclientes.Items.Add(tbClientes.Fields("nome").Value.ToString)
        '        tbClientes.MoveNext()
        '    End While
        'End If
    End Sub
    Private Sub cboproduto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboproduto.GotFocus
        CarregaCombo(cboproduto, "Select codigo ,titulo from tbProdutos order by titulo")
        'Dim tbProdutos As ADODB.Recordset
        'cboproduto.Items.Clear()
        'tbProdutos = RecebeTabela("Select * from tbProdutos order by titulo")
        'If tbProdutos.RecordCount <> 0 Then
        '    tbProdutos.MoveFirst()
        '    Do Until tbProdutos.EOF
        '        cboproduto.Items.Add(tbProdutos.Fields("titulo").Value.ToString)
        '        tbProdutos.MoveNext()
        '    Loop
        'End If
    End Sub
    Private Sub cboproduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboproduto.SelectedIndexChanged

        tbProdutos = RecebeTabela("Select * from tbProdutos where titulo like '" & cboproduto.Text & "'")
        lblvalunit.Text = FormatCurrency(0)
        If tbProdutos.RecordCount = 0 Then Exit Sub
        tbProdutos.MoveFirst()
        lblvalunit.Text = FormatCurrency(tbProdutos("valor").Value.ToString)
        lblvalunit.Tag = tbProdutos("codigo").Value.ToString
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSALVAR.Click
        On Error Resume Next
        CAMPOZERO()
        If txtdinheiro.Text = "" Then
            MsgBox("PAGAMENTO NAO EFETUADO!")
            Exit Sub
        End If
        ''PAGAMETO()
        SQL = "select * from TBLOCACAO "
        TBLOCACAO = RecebeTabela(SQL)
        TBLOCACAO.AddNew()
        TBLOCACAO("FUNCIONARIO").Value = LerCombo(CBO_FUNCIONARIO)
        TBLOCACAO("DT_LOCACAO").Value = DTP_LOCACAO.Text
        TBLOCACAO("DT_DEVOLUCAO").Value = DTP_DEVOLUCAO.Text
        TBLOCACAO("CLIENTE").Value = LerCombo(cboclientes)
        TBLOCACAO("FILME").Value = LerCombo(cboproduto)
        TBLOCACAO("VALOR").Value = moeda(lblvalunit.Text)
        TBLOCACAO("TOTAL").Value = lblTotal.Text
        TBLOCACAO.Update()
        LIMPAR()
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TXT_NSEQ.Text = "" Then
            ER.SetError(TXT_NSEQ, "Digite um Código!")
            Exit Sub
        End If
        SQL = "Select * from TBLOCACAO  where CODIGO=" & TXT_NSEQ.Text
        TBLOCACAO = RecebeTabela(SQL)
        If TBLOCACAO.RecordCount = 0 Then
            MsgBox("LOCACAO NAO EXISTE!")
            Exit Sub
        End If
        SQL = "delete from TBLOCACAO where CODIGO = " & TXT_NSEQ.Text
        TBLOCACAO = RecebeTabela(SQL)

    End Sub

    Private Sub cboclientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboclientes.SelectedIndexChanged

    End Sub

    Private Sub CBO_FUNCIONARIO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBO_FUNCIONARIO.GotFocus
        On Error Resume Next
        '' CarregaCombo(tbFuncionarios, "Select codfunc ,nome from tbFuncionarios order by nome")
        CarregaCombo(CBO_FUNCIONARIO, "Select codfunc ,nome from tbFuncionarios order by nome")
    End Sub

    Private Sub CBO_FUNCIONARIO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_FUNCIONARIO.SelectedIndexChanged

    End Sub

    Private Sub frmLocacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblvalunit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbltotal1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotal1.TextChanged
        ''lbltotal1.Text = FormatCurrency(0)
    End Sub

    Private Sub lblvalunit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvalunit.TextChanged

    End Sub

    Private Sub lbltotalpg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotalpg.Click

    End Sub

    Private Sub txtdinheiro_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdinheiro.TextChanged
        On Error Resume Next
        LBLTROCO.Text = txtdinheiro.Text - lbltotalpg.Text
    End Sub

    Private Sub lblpaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLTROCO.Click

    End Sub

    Private Sub lblnlocacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        wcpagina = 1
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MYFONT As New Font("ARIAL", 8)
        Dim MYFONT4 As New Font("ARIAL", 8, FontStyle.Bold)
        Dim MYFONT3 As New Font("ARIAL", 30, FontStyle.Bold)
        Dim MYFONT2 As New Font("ARIAL", 16, FontStyle.Bold)
        Dim MYFONT5 As New Font("ARIAL", 6)
        Dim pulou As Boolean = False

        Dim X1 As Single = e.MarginBounds.Left ' Variavel que controla a coluna
        Dim Y1 As Single = e.MarginBounds.Top  ' Variavel que controla a linha
        Dim Line As Single = MYFONT.GetHeight(e.Graphics) ' Pega o tamanho da linha a ser adicionada quando usar a myfont
        Dim Line2 As Single = MYFONT2.GetHeight(e.Graphics) ' Pega o tamanho da
        Dim Line3 As Single = MYFONT3.GetHeight(e.Graphics) ' Pega o tamanho da
        'cabeçalho
        'e.Graphics.DrawImage(imagem, X1 - 20, Y1 - 50, 111, 83)
        e.Graphics.DrawString("Relatório de Locação", MYFONT3, Brushes.Black, X1 + 120, Y1)
        Y1 += Line3
        Y1 += Line
        e.Graphics.DrawString("Código", MYFONT4, Brushes.Black, X1, Y1)
        e.Graphics.DrawString("Funcionário", MYFONT4, Brushes.Black, X1 + 60, Y1)
        e.Graphics.DrawString("Filme", MYFONT4, Brushes.Black, X1 + 306, Y1)
        e.Graphics.DrawString("Valor", MYFONT4, Brushes.Black, X1 + 410, Y1)
        Y1 += Line
        'os dados que vão ser buscado no banco de dados
        Do Until TBLOCACAO.EOF
            e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
            e.Graphics.DrawString(TBLOCACAO.Fields("codigo").Value.ToString, MYFONT, Brushes.Black, X1 + 10, Y1)
            e.Graphics.DrawString(TBLOCACAO.Fields("funcionario").Value.ToString, MYFONT, Brushes.Black, X1 + 60, Y1)
            e.Graphics.DrawString(TBLOCACAO.Fields("filme").Value.ToString, MYFONT, Brushes.Black, X1 + 300, Y1)
            e.Graphics.DrawString(TBLOCACAO.Fields("valor").Value.ToString, MYFONT, Brushes.Black, X1 + 400, Y1)
            Y1 += Line
            e.Graphics.DrawLine(Pens.Black, X1, Y1, 700, Y1)
            TBLOCACAO.MoveNext()
            If Y1 >= e.MarginBounds.Bottom - 50 Then
                pulou = True
                Exit Do
            End If
        Loop
        If pulou = True Then
            Y1 = e.MarginBounds.Bottom
            e.Graphics.DrawLine(Pens.Black, X1, Y1, X1 + 700, Y1)
            e.Graphics.DrawString("Página:" & wcpagina, MYFONT, Brushes.Silver, X1, Y1)
            wcpagina += 1
            e.HasMorePages = True
        End If
    End Sub

    Private Sub BTN_IMPRIMIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_IMPRIMIR.Click
        Dim sql As String
        sql = "Select * from TBLOCACAO "
        TBLOCACAO = RecebeTabela(sql)
        If TBLOCACAO.RecordCount = 0 Then
            MsgBox("Nenhuma Locação Selecionada!", MsgBoxStyle.Information)
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnok_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnok.MouseClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class