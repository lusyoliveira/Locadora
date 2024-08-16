
Public Class frmReserva
    Dim ClasseLocacao As New clsLocacao, ClasseCombo As New clsCombo, ClasseProdutos As New clsProdutos,
        tbClientes, tbProdutos, tbReserva As DataTable
    Dim sql As String
    Private Sub Limpar()
        cboCliente.Text = ""
        cboProduto.Text = ""
        txtCodReserva.Text = ""
        lblTotal.Text = ""
        lblValorTotal.Text = ""
        lstgrade.Items.Clear()
    End Sub
    Private Sub Habilitar()
        cboCliente.Enabled = True
        cboProduto.Enabled = True
        txtCodReserva.Enabled = True
        lblTotal.Enabled = True
        lblValorTotal.Enabled = True
    End Sub
    Private Sub Desabilitar()
        cboCliente.Enabled = False
        cboProduto.Enabled = False
        txtCodReserva.Enabled = False
        lblTotal.Enabled = False
        lblValorTotal.Enabled = False
    End Sub
    Private Sub CampoZero()
        If cboCliente.Text = "" Then
            cboCliente.Text = 0
        End If
        If cboProduto.Text = "" Then
            cboProduto.Text = 0
        End If
    End Sub
    Private Sub CalculaReserva()
        Dim Dias As Double
        If dtpInicio.Value = "" Or dtpFim.Value = "" Then
            MessageBox.Show("Informe o período da reserva!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dias = DateDiff(DateInterval.Day, dtpInicio.Value, dtpFim.Value)

            lblTotal.Text = (Dias * lblValorUnit.Text)
        End If
    End Sub
    Private Sub AtualizaValor()
        Dim x As Integer, Total As Decimal

        If lstgrade.Items.Count >= 0 Then
            For x = 0 To lstgrade.Items.Count - 1
                Total += lstgrade.Items(x).SubItems(2).Text
            Next
            lblTotal.Text = Total
        Else
            lblTotal.Text = 0
        End If
    End Sub

    Private Sub cboCliente_Enter(sender As Object, e As EventArgs) Handles cboCliente.Enter
        Dim ListaCLientes = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'C' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboCliente
            .DataSource = ListaCLientes
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboProduto_Enter(sender As Object, e As EventArgs) Handles cboProduto.Enter
        Dim ListaProdutos = ClasseCombo.PreencherComboBox("SELECT * FROM tbProdutos ORDER BY Titulo", "Codigo", "Titulo")
        With Me.cboProduto
            .DataSource = ListaProdutos
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        ClasseLocacao.ObterReserva(ClasseLocacao, "SELECT CASE WHEN IDENT_CURRENT('tbReserva') IS NULL THEN 1 ELSE IDENT_CURRENT('tbReserva')+1 END AS Codigo")
        txtCodReserva.Text = ClasseLocacao.CodReserva
        Habilitar()
        SalvarToolStripButton.Enabled = True
        NovoToolStripButton.Enabled = False
    End Sub

    Private Sub cboProduto_Leave(sender As Object, e As EventArgs) Handles cboProduto.Leave
        ClasseProdutos.ObterProduto(ClasseProdutos, cboProduto.SelectedValue, cboProduto.Text)
        lblValorUnit.Text = ClasseProdutos.ValorUnit
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

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão da reserva?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseLocacao.IncluirReserva(cboCliente.Text, cboProduto.Text, dtpInicio.Text, dtpFim.Text, lblTotal.Text)
        Else
            Exit Sub
        End If
    End Sub
End Class