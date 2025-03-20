Imports System.Data
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class frmGerarFinanceiro

    Dim ClasseFinanceiro As New clsFinanceiro, ClasseEntidades As New clsEntidades, ClasseLocacao As New clsLocacao, ClasseCombo As New clsCombo
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

    End Sub
    Public Sub New(CodLocacao As Integer, DiasAtraso As Integer, Optional total As Decimal = 0)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        CarragaCombos()
        Dim tbLocacao As DataTable = ClasseLocacao.ConsultaLocacao("SELECT * FROM cs_Locacao WHERE Codigo = @CodLocacao")
        lblCodigo.Text = tbLocacao.Rows(0)("Codigo").ToString()
        lblAtraso.Text = DiasAtraso
        cboEntidade.Text = tbLocacao.Rows(0)("Cliente").ToString()
        lblTotal.Text = total
        If DiasAtraso > 0 Then
            Dim tbTaxa As DataTable = ClasseFinanceiro.ConsultaTaxas("SELECT * FROM tbTaxas WHERE Codigo = 1", 1)
            txtMulta.Text = ClasseFinanceiro.Multa * DiasAtraso
        End If
    End Sub
    Public Sub CarragaCombos()
        Dim ListaClientes = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'C' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboEntidade
            .DataSource = ListaClientes
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With

        Dim ListaCobranca = ClasseCombo.PreencherComboBox("SELECT * FROM TbCobranca ORDER BY Cobranca", "Codigo", "Cobranca")
        With Me.cboCobranca
            .DataSource = ListaCobranca
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With

        Dim ListaFormaPagto = ClasseCombo.PreencherComboBox("SELECT * FROM tbFormaPgto ORDER BY FormaPgto", "Codigo", "FormaPgto")
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
        Dim tbFormaPagto As DataTable = ClasseFinanceiro.ConsultaFormaPagto("SELECT * FROM tbFormaPgto WHERE Codigo = @CodFormaPagto", cboFormaPgto.Text)
        If tbFormaPagto IsNot Nothing AndAlso tbFormaPagto.Rows.Count > 0 Then
            lblNrPacelas.Text = tbFormaPagto.Rows(0)("NParcelas").ToString()
        End If
    End Sub
    Private Sub btnGerarParcelas_Click(sender As Object, e As EventArgs) Handles btnGerarParcelas.Click
        If dgvParcelas.Rows.Count = lblNrPacelas.Text Then
            Exit Sub
        Else
            ClasseFinanceiro.CalculaParcelas(lblTotal.Text, Date.Now.Date, lblNrPacelas.Text, Val(lblAtraso.Text), txtMulta.Text, ClasseFinanceiro)
            dgvParcelas.Rows.Add(ClasseFinanceiro.NParcelas, ClasseFinanceiro.DataVencto, ClasseFinanceiro.ValorParcela)
        End If
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Try
            If ValidarForm() Then
                For Each row As DataGridViewRow In dgvParcelas.Rows
                    ClasseFinanceiro.GerarPagamento(Val(lblCodigo.Text),
                                                    cboEntidade.SelectedValue,
                                                    row.Cells("Vencimento").Value,
                                                    Val(lblNrPacelas.Text),
                                                    Date.Now.Date,
                                                    row.Cells("vlrParcela").Value,
                                                    lblTotal.Text,
                                                    "DEVOLUÇÃO " + lblCodigo.Text + " - " + cboEntidade.Text,
                                                    txtDesconto.Text,
                                                    txtMulta.Text,
                                                    txtAcrescimo.Text,
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
            MessageBox.Show("Não foi possível gerar o pagamento!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboFormaPgto_Leave(sender As Object, e As EventArgs) Handles cboFormaPgto.Leave
        Dim tbFormaPagto As DataTable = ClasseFinanceiro.ConsultaFormaPagto("SELECT * FROM tbFormaPgto WHERE Codigo = @CodFormaPagto", cboFormaPgto.Text)
        If tbFormaPagto IsNot Nothing AndAlso tbFormaPagto.Rows.Count > 0 Then
            lblNrPacelas.Text = tbFormaPagto.Rows(0)("NParcelas").ToString()
        End If
    End Sub
End Class