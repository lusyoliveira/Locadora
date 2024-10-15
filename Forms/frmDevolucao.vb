Public Class frmDevolucao
    Dim ClasseLocacao As New clsLocacao, ClasseFinanceiro As New clsFinanceiro, tbLocacao As DataTable
    Dim x As Integer

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub frmDevolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultaLocacao()
    End Sub
    Private Sub ConsultaLocacao()
        Dim DevolucaoIni, DevolucaoFim As String

        'Valida data de cadastro
        If dtpDevolver.Checked = True And dtpDevolvido.Checked = True Then
            DevolucaoIni = dtpDevolver.Value.ToString("yyyy-MM-dd")
            DevolucaoFim = dtpDevolvido.Value.ToString("yyyy-MM-dd")
        ElseIf dtpDevolver.Checked = True And dtpDevolvido.Checked = False Then
            DevolucaoIni = dtpDevolver.Value.ToString("yyyy-MM-dd")
        ElseIf dtpDevolver.Checked = False And dtpDevolvido.Checked = True Then
            DevolucaoFim = dtpDevolvido.Value.ToString("yyyy-MM-dd")
        Else
            DevolucaoIni = ""
            DevolucaoFim = ""
        End If
        tbLocacao = ClasseLocacao.PesquisaLocacao(0, "NÃO", DevolucaoIni, DevolucaoFim)
        If tbLocacao.Rows.Count > 0 Then
            For Each row As DataRow In tbLocacao.Rows
                ' Adiciona o código (assumindo que nunca é nulo)
                lstgrade.Items.Add(row("codigo").ToString())

                ' Adiciona os subitens, verificando se cada valor é nulo
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Cliente")), String.Empty, row("Cliente").ToString()))
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Total")), String.Empty, row("Total").ToString()))
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Dt_Locacao")), String.Empty, row("Dt_Locacao").ToString()))
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Pago")), String.Empty, row("Pago").ToString()))
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Dt_Devolucao")), String.Empty, row("Dt_Devolucao").ToString()))
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Atraso")), String.Empty, row("Atraso").ToString()))

                x += 1
            Next
        Else
            MessageBox.Show("Essa locação não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs)
        ConsultaLocacao()
    End Sub

    Private Sub lblPago_Validated(sender As Object, e As EventArgs) Handles lblPago.Validated
        If lblPago.Text = "SIM" Then
            lblPago.ForeColor = Color.Green
            lblTotal.ForeColor = Color.Green
        Else
            lblPago.ForeColor = Color.Red
            lblTotal.ForeColor = Color.Red
        End If
    End Sub

    Private Sub lstgrade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count > 0 Then
            txtCodigo.Text = Val(lstgrade.SelectedItems(0).SubItems(0).Text)
            lblTotal.Text = lstgrade.SelectedItems(0).SubItems(2).Text
            lblPago.Text = lstgrade.SelectedItems(0).SubItems(4).Text
            dtpDevolver.Text = lstgrade.SelectedItems(0).SubItems(5).Text
            txtAtraso.Text = lstgrade.SelectedItems(0).SubItems(6).Text
        End If
    End Sub

    Private Sub DevolverToolStripButton_Click(sender As Object, e As EventArgs) Handles DevolverToolStripButton.Click
        ''Peguntar se deseja pagar agora se sim abrir pagamento. Deve verificar se já foi pago ou não.
        ''Caso já tinha sido pago mais devolvido em atraso deve gerar o pagamento apenas da multa
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão da locação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ''Peguntar se deseja pagar agora se sim abrir pagamento
            If txtCodigo.Text Is Nothing Or txtCodigo.Text = "" Then
                MessageBox.Show("Favor informar a locação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If lblPago.Text = "NÃO" Then
                    Using frmAbreContasPagar As New frmGerarFinanceiro(Val(txtCodigo.Text), Val(txtAtraso.Text), lblTotal.Text)
                        frmAbreContasPagar.ShowDialog()
                    End Using
                    ClasseLocacao.DevolverLocacao(Val(txtCodigo.Text))
                ElseIf lblPago.Text = "SIM" And Val(txtAtraso.Text) > 0 Then
                    Using frmAbreContasPagar As New frmGerarFinanceiro(Val(txtCodigo.Text), Val(txtAtraso.Text), 0)
                        frmAbreContasPagar.ShowDialog()
                    End Using
                    ClasseLocacao.DevolverLocacao(Val(txtCodigo.Text))
                End If
            End If
        End If
    End Sub
End Class