
Public Class frmLocacao
    Dim imagem As Image, wcpagina, X, Y, z As Integer, sql As String, tbclientes, tbProdutos, tbLocacao, tbFuncionarios As DataTable,
        ClasseLocacao As New clsLocacao, ClasseCombo As New clsCombo

    Private Sub cboproduto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProduto.GotFocus
    End Sub
    Private Sub AtualizaValor()
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

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If lstgrade.SelectedItems.Count = 0 Then Exit Sub
        lstgrade.SelectedItems(0).Remove()
        AtualizaValor()
    End Sub
    Private Sub txtQuantidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantidade.TextChanged
        On Error Resume Next
        txtTotal.Text = FormatCurrency(txtValorUnit.Text * txtQuantidade.Text)
        lbltotalpg.Text = txtTotal.Text
    End Sub
    Private Sub txtdinheiro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblTroco.Text = txtDinheiro.Text - lbltotalpg.Text
    End Sub
    Private Sub cbopagar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPagar.SelectedIndexChanged
        If cboPagar.Text = "Na Entrega" Then
            txtDinheiro.Enabled = False
            lbldinheiro.Enabled = False
            lblTroco.Enabled = False
            lblpagar.Enabled = False
        Else
            txtDinheiro.Enabled = True
            lbldinheiro.Enabled = True
            lblTroco.Enabled = True
            lblpagar.Enabled = True
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim sql As String = "SELECT * FROM TBLOCACAO"
        tbLocacao = ClasseCombo.Listar(sql)
        If tbLocacao.Rows.Count = 0 Then
            MsgBox("Nenhuma Locação Selecionada!", MsgBoxStyle.Information)
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub cboFuncionario_Enter(sender As Object, e As EventArgs) Handles cboFuncionario.Enter
        Dim ListaFuncionario = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'FU' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboFuncionario
            .DataSource = ListaFuncionario
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboProduto_Enter(sender As Object, e As EventArgs) Handles cboProduto.Enter
        Dim ListaProduto = ClasseCombo.PreencherComboBox("SELECT * FROM tbProdutos ORDER BY titulo", "codigo", "titulo")
        With Me.cboProduto
            .DataSource = ListaProduto
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboclientes_Enter(sender As Object, e As EventArgs) Handles cboclientes.Enter
        Dim ListaClientes = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'C' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboclientes
            .DataSource = ListaClientes
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub frmLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Pagamento()
        If txtDinheiro.Text = "" Then
            MsgBox("PAGAMENTO NAO EFETUADO!")
            Exit Sub
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpar()
    End Sub

    Private Sub Limpar()
        cboFuncionario.Text = ""
        cboclientes.Text = ""
        cboProduto.Text = ""
        txtValorUnit.Text = ""
        lblTotal.Text = ""
        txtTotal.Text = ""
        cboPagar.Text = ""
        lbltotalpg.Text = ""
        txtDinheiro.Text = ""
        lblTroco.Text = ""
        lblQuantidade.Text = ""
        lstgrade.Clear()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão ds locacao?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            For Each item As ListViewItem In lstgrade.Items
                ClasseLocacao.SalvarDetLocacao(Val(txtCodLocacao.Text), item.SubItems(0).Text, item.SubItems(2).Text)
            Next
            ClasseLocacao.SalvarLocacao(cboFuncionario.SelectedValue, txtQuantidade.Text, dtpLocacao.Value, cboclientes.SelectedValue, txtTotal.Text)
            Limpar()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txtDinheiro_TextChanged_1(sender As Object, e As EventArgs) Handles txtDinheiro.TextChanged
        On Error Resume Next
        lblTroco.Text = txtDinheiro.Text - lbltotalpg.Text
    End Sub

    Private Sub CampoZero()
        If cboFuncionario.Text = "" Then
            cboFuncionario.Text = 0
        End If
        If cboclientes.Text = "" Then
            cboclientes.Text = 0
        End If
        If cboProduto.Text = "" Then
            cboProduto.Text = 0
        End If
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If cboProduto.SelectedItem Is Nothing OrElse txtValorUnit.Text.Trim() = "" OrElse txtTotal.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos.")
            Exit Sub
        End If

        ' Captura os valores dos controles
        Dim codigo As Integer = Integer.Parse(cboProduto.SelectedValue.ToString())
        Dim titulo As String = cboProduto.SelectedItem.ToString()
        Dim valorUnitario As Decimal = Decimal.Parse(txtValorUnit.Text)
        Dim quantidade As Integer = Integer.Parse(txtTotal.Text)

        ' Cria um novo item para adicionar ao ListView
        Dim novoItem As New ListViewItem(codigo)
        novoItem.SubItems.Add(titulo.ToString())
        novoItem.SubItems.Add(FormatCurrency(valorUnitario))
        novoItem.SubItems.Add(quantidade.ToString())
        novoItem.SubItems.Add(FormatCurrency(valorUnitario * quantidade)) ' Calcula o total

        ' Adiciona o item ao ListView
        lstgrade.Items.Add(novoItem)

        ' Limpa os campos após adicionar o produto
        Limpar()
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load
        wcpagina = 1
    End Sub
    Private Sub cboproduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged
        tbProdutos = ClasseCombo.Listar("Select * from tbProdutos where titulo like '" & cboProduto.Text & "'")

        txtValorUnit.Text = FormatCurrency(0)
        If tbProdutos.Rows.Count = 0 Then Exit Sub

        Dim row As DataRow = tbProdutos.Rows(0)
        txtValorUnit.Text = FormatCurrency(row("valor").ToString())
        txtValorUnit.Tag = row("codigo").ToString()
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
        For Each row As DataRow In tbLocacao.Rows
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



End Class