Imports System.Data
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
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
        lblTotalPg.Text = ""
        txtQuantidade.Text = ""
        txtCodLocacao.Text = ""
        lstgrade.Items.Clear()
        lstConsulta.Items.Clear()
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
            lblTotalPg.Text = Total
        Else
            lblTotalPg.Text = 0
        End If

    End Sub
    Private Sub frmLocacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tbLocacao Is Nothing Then
            ConsultaLocacao()
        Else
            tbLocacao.Clear()
            ConsultaLocacao()
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
    Private Sub ConsultaLocacao()
        Dim DevolucaoIni As String = "", DevolucaoFim As String = ""

        'Valida data de cadastro
        If dtpDevolucaoIni.Checked = True And dtpDevolucaoFim.Checked = True Then
            DevolucaoIni = dtpDevolucaoIni.Value.ToString("yyyy-MM-dd")
            DevolucaoFim = dtpDevolucaoFim.Value.ToString("yyyy-MM-dd")
        ElseIf dtpDevolucaoIni.Checked = True And dtpDevolucaoFim.Checked = False Then
            DevolucaoIni = dtpDevolucaoIni.Value.ToString("yyyy-MM-dd")
        ElseIf dtpDevolucaoIni.Checked = False And dtpDevolucaoFim.Checked = True Then
            DevolucaoFim = dtpDevolucaoFim.Value.ToString("yyyy-MM-dd")
        Else
            DevolucaoIni = ""
            DevolucaoFim = ""
        End If

        Dim tbLocacao As DataTable = ClasseLocacao.PesquisaLocacao(Val(lblCodigo.Text), "TODOS", DevolucaoIni, DevolucaoFim)
        ' Limpar ListView
        lstConsulta.Items.Clear()

        ' Verificar se tbPreco contém linhas
        If tbLocacao.Rows.Count > 0 Then
            For Each row As DataRow In tbLocacao.Rows
                ' Criar um novo item do ListView
                Dim listViewItem As New ListViewItem(If(IsDBNull(row("Codigo")), String.Empty, row("Codigo").ToString()))
                ' Adicionar subitens
                listViewItem.SubItems.Add(If(IsDBNull(row("Funcionario")), String.Empty, row("Funcionario").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("Cliente")), String.Empty, row("Cliente").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("Quantidade")), String.Empty, row("Quantidade").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("Total")), String.Empty, row("Total").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("Multa")), String.Empty, row("Multa").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("Pago")), String.Empty, row("Pago").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("Dt_Locacao")), String.Empty, row("Dt_Locacao").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("Dt_Devolucao")), String.Empty, row("Dt_Devolucao").ToString()))

                ' Adicionar o item ao ListView
                lstConsulta.Items.Add(listViewItem)
            Next
        Else
            MessageBox.Show("Essa locação não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        Dim tbLocacao As DataTable = ClasseLocacao.ConsultaLocacao("SELECT CASE WHEN IDENT_CURRENT('tbLocacao') IS NULL THEN 1 ELSE IDENT_CURRENT('tbLocacao')+1 END AS Codigo")
        txtCodLocacao.Text = tbLocacao.Rows(0)("Codigo").ToString()
        CalculaDevolucao(Val(txtQuantidade.Text))
        Habilitar()
        SalvarToolStripButton.Enabled = True
        NovoToolStripButton.Enabled = False
        tcLocacao.SelectTab(1)
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

    Private Sub lstConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConsulta.SelectedIndexChanged

        If lstConsulta.SelectedItems.Count > 0 Then
            txtCodLocacao.Text = Val(lstConsulta.SelectedItems(0).SubItems(0).Text)
            cboFuncionario.Text = lstConsulta.SelectedItems(0).SubItems(1).Text
            cboclientes.Text = lstConsulta.SelectedItems(0).SubItems(2).Text
            txtQuantidade.Text = lstConsulta.SelectedItems(0).SubItems(3).Text
            lblTotalPg.Text = lstConsulta.SelectedItems(0).SubItems(4).Text
            dtpLocacao.Text = lstConsulta.SelectedItems(0).SubItems(7).Text
            dtpDevolucao.Text = lstConsulta.SelectedItems(0).SubItems(8).Text
        End If
        lstgrade.Items.Clear()
        Dim tbLocacaoProd As DataTable = ClasseLocacao.ConsultaLocacao("SELECT * FROM CS_LocacaoProd WHERE CodLocacao = @CodLocacao", Val(txtCodLocacao.Text))
        Dim x As Integer = 0

        If tbLocacaoProd IsNot Nothing AndAlso tbLocacaoProd.Rows.Count > 0 Then
            For Each row As DataRow In tbLocacaoProd.Rows
                ' Adiciona o código (assumindo que nunca é nulo)
                lstgrade.Items.Add(row("CodProd").ToString())

                ' Adiciona os subitens, verificando se cada valor é nulo
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Titulo")), String.Empty, row("Titulo").ToString()))
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Valor")), String.Empty, row("Valor").ToString()))
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Total")), String.Empty, row("Total").ToString()))
                x += 1
            Next
        Else
            MessageBox.Show("Não existe filmes nessa locação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        tcLocacao.SelectTab(1)
        AlterarToolStripButton.Enabled = True
        ExcluirToolStripButton.Enabled = True
        Habilitar()
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        lstConsulta.Items.Clear()
        If tbLocacao Is Nothing Then
            ConsultaLocacao()
        Else
            tbLocacao.Clear()
            ConsultaLocacao()
        End If
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão da locação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseLocacao.SalvarLocacao(cboFuncionario.SelectedValue, Val(txtQuantidade.Text), cboclientes.SelectedValue, lblTotalPg.Text, dtpLocacao.Value, dtpDevolucao.Value)
            For Each item As ListViewItem In lstgrade.Items
                ClasseLocacao.SalvarDetLocacao(Val(txtCodLocacao.Text), item.SubItems(0).Text, item.SubItems(2).Text, item.SubItems(3).Text)
            Next
            'Peguntar se deseja pagar agora se sim abrir pagamento
            Using frmAbreContasPagar As New frmGerarFinanceiro(Val(txtCodLocacao.Text), 0, lblTotalPg.Text)
                frmAbreContasPagar.ShowDialog()
            End Using
            Limpar()
            Desabilitar()
            SalvarToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ImprimirToolStripButton_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripButton.Click
        'Dim sql As String = "SELECT * FROM TBLOCACAO"
        'tbLocacao = ClasseCombo.Listar(sql)
        'If tbLocacao.Rows.Count = 0 Then
        '    MsgBox("Nenhuma Locação Selecionada!", MsgBoxStyle.Information)
        '    Exit Sub
        'End If
        'PrintPreviewDialog1.ShowDialog()
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
        Dim tbProduto As DataTable = ClasseProdutos.ConsultaProduto("SELECT * FROM tbProdutos WHERE Codigo = @Codigo", cboProduto.SelectedValue, Nothing)
        If tbProduto IsNot Nothing AndAlso tbProduto.Rows.Count > 0 Then
            txtValorUnit.Text = tbProduto.Rows(0)("Valor").ToString()
        End If
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
        Else
            'verificar se o título já foi reservado pelo mesmo cliente ou por outro cliente
            Dim tbReserva As DataTable = ClasseLocacao.ConsultaReserva("SELECT * FROM CS_ReservasDetalhes WHERE CodProd = @CodProd", 0, cboProduto.SelectedValue)
            If tbReserva IsNot Nothing AndAlso tbReserva.Rows.Count > 0 Then
                For Each row As DataRow In tbReserva.Rows
                    If tbReserva.Rows(0)("CodProd").ToString() = cboProduto.SelectedValue Then

                        If tbReserva.Rows(0)("Cliente").ToString() = cboclientes.Text Then
                            ' Cria um novo item para o ListView com o código do produto.
                            Dim item As New ListViewItem(cboProduto.SelectedValue.ToString())

                            ' Adiciona o nome do produto como subitem na segunda coluna.
                            item.SubItems.Add(cboProduto.Text)
                            item.SubItems.Add(txtValorUnit.Text)
                            item.SubItems.Add(txtTotal.Text)

                            ' Adiciona o item ao ListView.
                            lstgrade.Items.Add(item)
                        Else
                            MessageBox.Show("O título informado já está reservado para outro cliente!")
                            Exit Sub
                        End If
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
                Next
                cboProduto.Text = ""
                txtValorUnit.Text = ""
                txtTotal.Text = ""
                AtualizaValor()
            End If
        End If
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