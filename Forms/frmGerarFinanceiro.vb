Public Class frmGerarFinanceiro
    Dim ClasseFinanceiro As New clsFinanceiro, ClasseEntidades As New clsEntidades, ClasseCombo As New clsCombo
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

    End Sub
    Public Sub CarragaCombos()
        Dim ListaEntidade = ClasseCombo.PreencherComboBox("SELECT * From tbl_Entidades WHERE TipoEntidade = 'C'", "Codigo", "NomeFantasia")
        With Me.cboEntidade
            .DataSource = ListaEntidade
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With

        Dim ListaCobranca = ClasseCombo.PreencherComboBox("SELECT * FROM Tbl_Cobranca ORDER BY Cobranca", "Codigo", "Cobranca")
        With Me.cboCobranca
            .DataSource = ListaCobranca
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With

        Dim ListaFormaPagto = ClasseCombo.PreencherComboBox("SELECT * FROM tbl_FormaPgto ORDER BY Forma_Pgto", "Cod_Pgto", "Forma_Pgto")
        With Me.cboFormaPgto
            .DataSource = ListaFormaPagto
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With

    End Sub
    Private Function ValidarForm() As Boolean
        Dim result As Boolean

        If cboEntidade.SelectedValue = 0 Then
            MessageBox.Show("Por favor preencha o a entidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            result = False
        ElseIf cboFormaPgto.SelectedValue = 0 Then
            MessageBox.Show("Por favor preencha o campo forma de pagamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            result = False
        ElseIf cboCobranca.SelectedValue = 0 Then
            MessageBox.Show("Por favor preencha o campo cobrança!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            result = False
        ElseIf dgvParcelas.Rows.Count = 0 Then
            MessageBox.Show("É necessário gerar a parcela para confirmar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub frmGerarPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClasseFinanceiro.ListaNParcelas(cboFormaPgto.Text, ClasseFinanceiro)
        lblNrPacelas.Text = ClasseFinanceiro.NParcelas
    End Sub
    Private Sub btnGerarParcelas_Click(sender As Object, e As EventArgs) Handles btnGerarParcelas.Click
        If dgvParcelas.Rows.Count = lblNrPacelas.Text Then
            Exit Sub
        Else
            ClasseFinanceiro.CalculaParcelas(lblTotal.Text, Date.Now.Date, lblNrPacelas.Text, ClasseFinanceiro)
            dgvParcelas.Rows.Add(ClasseFinanceiro.NParcelas, ClasseFinanceiro.DataVencto, ClasseFinanceiro.ValorParcela)
        End If
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If ValidarForm() Then
                For Each row As DataGridViewRow In dgvParcelas.Rows
                    ClasseFinanceiro.GerarPagamento(0,
                                                        lblCodigo.Text,
                                                        row.Cells("Vencimento").Value,
                                                        row.Cells("Parcela").Value,
                                                        Date.Now.Date,
                                                        row.Cells("vlrParcela").Value, lblTotal.Text,
                                                        "DEVOLUÇÃO " + lblCodigo.Text + " - " + cboEntidade.Text,
                                                        txtDesconto.Text,
                                                        txtFrete.Text,
                                                        txtTaxas.Text,
                                                        txtAcrescimo.Text,
                                                        cboEntidade.SelectedValue,
                                                        cboCobranca.SelectedValue,
                                                        cboFormaPgto.SelectedValue
                                                        )
                Next
                MessageBox.Show("Pagamento gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Não foi possível gerar o pagamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível gerar o pagamento ou recebimento!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboFormaPgto_Leave(sender As Object, e As EventArgs) Handles cboFormaPgto.Leave
        ClasseFinanceiro.ListaNParcelas(cboFormaPgto.Text, ClasseFinanceiro)
        lblNrPacelas.Text = ClasseFinanceiro.NParcelas
    End Sub
End Class