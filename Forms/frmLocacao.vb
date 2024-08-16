
Public Class frmLocacao
    Dim imagem As Image, wcpagina, X, Y, z As Integer, sql As String, tbclientes, tbProdutos, tbLocacao, tbFuncionarios As DataTable,
        ClasseLocacao As New clsLocacao, ClasseCombo As New clsCombo, ClasseProdutos As New clsProdutos
    Public Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        txtQuantidade.Text = 7
    End Sub
    Private Sub Limpar()
        cboFuncionario.Text = ""
        cboclientes.Text = ""
        cboProduto.Text = ""
        txtValorUnit.Text = ""
        txtTotal.Text = ""
        lbltotalpg.Text = ""
        lblQuantidade.Text = ""
        lstgrade.Items.Clear()
    End Sub
    Private Sub Habilitar()
        cboFuncionario.Enabled = True
        cboclientes.Enabled = True
        cboProduto.Enabled = True
        txtValorUnit.Enabled = True
        txtTotal.Enabled = True
        txtQuantidade.Enabled = True
        dtpDevolucao.Enabled = True
        dtpLocacao.Enabled = True
        btnAdicionar.Enabled = True
        btnremove.Enabled = True
    End Sub
    Private Sub Desabilitar()
        cboFuncionario.Enabled = False
        cboclientes.Enabled = False
        cboProduto.Enabled = False
        txtValorUnit.Enabled = False
        txtTotal.Enabled = False
        txtQuantidade.Enabled = False
        dtpDevolucao.Enabled = False
        dtpLocacao.Enabled = False
        btnAdicionar.Enabled = False
        btnremove.Enabled = False
    End Sub
    Private Sub CalculaDevolucao(Dias As Double)

        If Val(txtQuantidade.Text) = 0 Then
            MessageBox.Show("Informe a quantidade de dias do alugel!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtQuantidade.Focus()
            Exit Sub
        Else
            Dias = Val(txtQuantidade.Text)
            dtpDevolucao.Value = DateAdd("d", Dias, Date.Now.Date)
        End If
    End Sub
    Private Sub AtualizaValor()
        Dim x As Integer, Total As Decimal

        If lstgrade.Items.Count >= 0 Then
            For x = 0 To lstgrade.Items.Count - 1
                Total += lstgrade.Items(x).SubItems(3).Text
            Next
            lbltotalpg.Text = Total
        Else
            lbltotalpg.Text = 0
        End If

    End Sub
    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        If lstgrade.SelectedItems.Count = 0 Then Exit Sub
        lstgrade.SelectedItems(0).Remove()
        AtualizaValor()
    End Sub

    Private Sub txtValorUnit_Leave(sender As Object, e As EventArgs) Handles txtValorUnit.Leave
        txtTotal.Text = Val(txtQuantidade.Text * txtValorUnit.Text)
    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        ClasseLocacao.ObterLocacao(ClasseLocacao, "SELECT CASE WHEN IDENT_CURRENT('tbLocacao') IS NULL THEN 1 ELSE IDENT_CURRENT('tbLocacao')+1 END AS Codigo")
        txtCodLocacao.Text = ClasseLocacao.CodLocacao
        Habilitar()
        SalvarToolStripButton.Enabled = True
        NovoToolStripButton.Enabled = False
    End Sub

    Private Sub AlterarToolStripButton_Click(sender As Object, e As EventArgs) Handles AlterarToolStripButton.Click
        SalvarToolStripButton.Enabled = False
        NovoToolStripButton.Enabled = False
        AlterarToolStripButton.Enabled = True
        ExcluirToolStripButton.Enabled = True
    End Sub

    Private Sub ExcluirToolStripButton_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripButton.Click
        SalvarToolStripButton.Enabled = False
        NovoToolStripButton.Enabled = False
        AlterarToolStripButton.Enabled = True
        ExcluirToolStripButton.Enabled = True
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        ClasseLocacao.PesquisaLocacao(lstgrade, Val(lblCodigo.Text))
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão ds locação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseLocacao.SalvarLocacao(cboFuncionario.SelectedValue, txtQuantidade.Text, dtpLocacao.Value, cboclientes.SelectedValue, txtTotal.Text)
            For Each item As ListViewItem In lstgrade.Items
                ClasseLocacao.SalvarDetLocacao(Val(txtCodLocacao.Text), item.SubItems(0).Text, item.SubItems(2).Text)
            Next
            'Peguntar se deseja pagar agora se sim abrir pagamento
            Using frmAbreContasPagar As New frmGerarFinanceiro()
                frmAbreContasPagar.CarragaCombos()
                frmAbreContasPagar.cboEntidade.Text = cboclientes.Text
                frmAbreContasPagar.lblCodigo.Text = txtCodLocacao.Text
                frmAbreContasPagar.lblTotal.Text = txtTotal.Text
                frmAbreContasPagar.lblDescEntidade.Text = "Cliente"
                frmAbreContasPagar.Text = "Geração do Contas a Pagar"
                frmAbreContasPagar.ShowDialog()
            End Using
            Limpar()
            Desabilitar()
            SalvarToolStripButton.Enabled = True
            NovoToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        Dim sql As String = "SELECT * FROM TBLOCACAO"
        tbLocacao = ClasseCombo.Listar(sql)
        If tbLocacao.Rows.Count = 0 Then
            MsgBox("Nenhuma Locação Selecionada!", MsgBoxStyle.Information)
            Exit Sub
        End If
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub txtQuantidade_Leave(sender As Object, e As EventArgs) Handles txtQuantidade.Leave
        CalculaDevolucao(Val(txtQuantidade.Text))
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

    Private Sub cboProduto_Leave(sender As Object, e As EventArgs) Handles cboProduto.Leave
        ClasseProdutos.ObterProduto(ClasseProdutos, cboProduto.SelectedValue, cboProduto.Text)
        txtValorUnit.Text = ClasseProdutos.ValorUnit
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

        If cboProduto.SelectedValue = 0 OrElse txtValorUnit.Text.Trim() = "" Then
            MessageBox.Show("Por favor, preencha todos os campos.")
            Exit Sub
            'fazer if para verificar se o título já foi reservado pelo mesmo cliente ou por outro cliente
        Else
            ' Cria um novo item para o ListView com o código do produto.
            Dim item As New ListViewItem(cboProduto.SelectedValue.ToString())

            ' Adiciona o nome do produto como subitem na segunda coluna.
            item.SubItems.Add(cboProduto.Text)
            item.SubItems.Add(txtValorUnit.Text)
            item.SubItems.Add(txtTotal.Text)

            ' Adiciona o item ao ListView.
            lstgrade.Items.Add(item)
        End If
        cboProduto.Text = ""
        txtValorUnit.Text = ""
        txtTotal.Text = ""
        AtualizaValor()
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