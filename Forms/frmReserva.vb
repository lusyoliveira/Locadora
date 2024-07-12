
Public Class frmReserva
    Dim ClasseLocacao As New clsLocacao, ClasseCombo As New clsCombo, tbClientes, tbProdutos, tbReserva As DataTable
    Dim sql As String
    Private Sub Limpar()
        cboCliente.Text = ""
        cboProduto.Text = ""
        lblTotal.Text = ""
        lblValorTotal.Text = ""
        lstgrade.Clear()
    End Sub
    Private Sub CampoZero()
        If cboCliente.Text = "" Then
            cboCliente.Text = 0
        End If
        If cboProduto.Text = "" Then
            cboProduto.Text = 0
        End If
    End Sub
    Private Sub cboCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCliente.GotFocus
        ClasseCombo.CarregaCombo(cboCliente, "Select codigo ,nome from tbClientes order by nome")
    End Sub
    Private Sub CBO_PORDUTO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProduto.GotFocus
        ClasseCombo.CarregaCombo(cboProduto, "Select codigo ,titulo from tbProdutos order by titulo")
    End Sub
    Private Sub AtualizaValor()
        Dim x As Integer, total As Decimal = 0
        If lstgrade.Items.Count > 0 Then
            For x = 0 To lstgrade.Items.Count - 1
                total += lstgrade.Items(x).SubItems(1).Text
            Next
            lblTotal.Text = FormatCurrency(total)
        Else
            lblTotal.Text = 0
        End If
    End Sub
    Private Sub CBO_PRODUTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged
        tbProdutos = ClasseCombo.Listar("SELECT * FROM tbProdutos WHERE titulo LIKE '" & cboProduto.Text & "'")
        lblValorUnit.Text = FormatCurrency(0)
        If tbProdutos.Rows.Count = 0 Then Exit Sub

        Dim row As DataRow = tbProdutos.Rows(0)
        lblValorUnit.Text = FormatCurrency(row("valor").ToString())
        lblValorUnit.Tag = row("codigo").ToString()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        If lblValorUnit.Tag = "" Then Exit Sub

        tbProdutos = ClasseCombo.Listar("SELECT * FROM tbProdutos WHERE codigo = " & lblValorUnit.Tag)
        If tbProdutos.Rows.Count = 0 Then Exit Sub

        Dim row As DataRow = tbProdutos.Rows(0)
        lstgrade.Items.Add(row("Titulo").ToString())
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(FormatCurrency(row("valor").ToString()))
        lstgrade.Items(lstgrade.Items.Count - 1).Tag = row("codigo").ToString()

        AtualizaValor()
    End Sub
    Private Sub frmReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If lstgrade.SelectedItems.Count = 0 Then Exit Sub
        lstgrade.SelectedItems(0).Remove()
        AtualizaValor()
        cboProduto.Text = ""
        lblValorUnit.Text = ""
    End Sub

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão da reserva?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseLocacao.IncluirReserva(cboCliente.Text, cboProduto.Text, dtpReserva.Text, dtpDevolucao.Text, lblTotal.Text)
        Else
            Exit Sub
        End If
    End Sub
End Class