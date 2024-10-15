Imports System.Data.SqlClient

Public Class clsFinanceiro
    Dim ClasseConexao As New clsConexao
#Region "PROPRIEDADES"
    Public Property NParcelas As Integer
    Public Property DataVencto As Date
    Public Property ValorParcela As Decimal
    Private Property _Multa As Decimal
    Public Property Multa As Decimal
        Get
            Return _Multa
        End Get
        Set(value As Decimal)
            _Multa = value
        End Set
    End Property
    Private Property _Dias As Integer
    Public Property Dias As Integer
        Get
            Return _Dias
        End Get
        Set(value As Integer)
            _Dias = value
        End Set
    End Property
#End Region
#Region "METODOS"
    Public Sub CalculaParcelas(ValorTotal As Decimal, Data As DateTime, NumeroParcelas As Integer, Atraso As Integer, Multa As Decimal, ByRef DadosParcela As clsFinanceiro)
        Try
            Dim valorParcela As Decimal = FormatCurrency((ValorTotal + Multa) / NumeroParcelas)
            Dim i As Integer

            For i = 0 To Val(NumeroParcelas) - 1
                Dim novaParcela As DateTime
                novaParcela = Data.AddDays(i * 30)
                If novaParcela.DayOfWeek = DayOfWeek.Sunday Then
                    novaParcela = novaParcela.AddDays(1)
                ElseIf novaParcela.DayOfWeek = DayOfWeek.Saturday Then
                    novaParcela = novaParcela.AddDays(2)
                End If
                DadosParcela.NParcelas = i + 1
                DadosParcela.DataVencto = Mid(novaParcela.ToString, 1, 10)
                DadosParcela.ValorParcela = (Decimal.Parse(valorParcela).ToString("N2"))
            Next
        Catch ex As Exception
            MessageBox.Show("Erro ao calcular valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Este metódo realiza a gravação do pagamento no banco de dados.
    ''' </summary>
    ''' <param name="CodLocacao">Representa o código do lançamento da nota fiscal relacionada ao pagamento do tipo integer.</param>
    ''' <param name="DtVencimento">Representa a data em que o pagamento irá vencer do tipo date.</param>
    ''' <param name="Parcelas">Represente o número do parcelas do tipo integer.</param>
    ''' <param name="DtPgto">Representa a data na qual o pagamento foi realizado do tipo date.</param>
    ''' <param name="ValorParcela">Representa o valor da parcelas a ser pago do tipo decimal.</param>
    ''' <param name="ValorPago">Representa o valor pago do pagamento do tipo decimal.</param>
    ''' <param name="Complemento">Representa a descrição do pagamento do tipo string.</param>
    ''' <param name="Desconto">Representa o valor de desconto aplicado no pagamento do tipo decimal.</param>
    ''' <param name="Multa">Representa o valor de multa aplicado no pagamento do tipo decimal.</param>
    ''' <param name="Acrescimo">Representa o valor de acréscimo aplicado no pagamento do tipo decimal.</param>
    ''' <param name="Entidade">Representa o código da entidade para qual o pagamento foi realizado do tipo integer.</param>
    ''' <param name="Cobranca">Representa o código da  cobrança do pagamento do tipo integer.</param>
    ''' <param name="FormaPagto">Representa o código do da forma de pagamento do tipo integer.</param>
    Public Sub GerarPagamento(CodLocacao As Integer, Entidade As Integer, DtVencimento As String, Parcelas As Integer, DtPgto As String, ValorParcela As Decimal, ValorPago As Decimal, Complemento As String, Desconto As Decimal, Multa As Decimal, Acrescimo As Decimal, FormaPagto As Integer, Cobranca As Integer)
        Dim sql = "INSERT INTO tbContasPagar          (CodLocacao,
                                                               Entidade,
                                                               DtVencimento,
                                                               Parcelas,
                                                               DtPgto,
                                                               ValorParcela,
                                                               ValorPago,
                                                               Quitar,
                                                               Complemento,
                                                               Desconto,
                                                               Multa,
                                                               Acrescimo,
                                                               FormaPagto,
                                                               Cobranca) 
                                        VALUES                 (@CodLocacao,
                                                               @Entidade,
                                                               @DtVencimento,
                                                               @Parcelas,
                                                               @DtPgto,
                                                               @ValorParcela,
                                                               @ValorPago,
                                                               1,
                                                               @Complemento,
                                                               @Desconto,
                                                               @Multa,
                                                               @Acrescimo,
                                                               @FormaPagto,
                                                               @Cobranca)"
        Dim parameters As SqlParameter() = {
                     New SqlParameter("@CODLOCACAO", CodLocacao),
                    New SqlParameter("@DtVencimento", DtVencimento),
                    New SqlParameter("@PARCELAS", Parcelas),
                    New SqlParameter("@DtPgto", DtPgto),
                    New SqlParameter("@ValorParcela", ValorParcela),
                    New SqlParameter("@VALORPAGO", ValorPago),
                    New SqlParameter("@COMPLEMENTO", Complemento),
                    New SqlParameter("@DESCONTO", Desconto),
                    New SqlParameter("@ENTIDADE", Entidade),
                    New SqlParameter("@COBRANCA", Cobranca),
                    New SqlParameter("@FORMAPAGTO", FormaPagto),
                    New SqlParameter("@MULTA", Multa),
                    New SqlParameter("@ACRESCIMO", Acrescimo)
                      }
        ClasseConexao.Operar(sql, parameters)
    End Sub
#End Region
#Region "FUNCOES"
    Public Function ConsultaFormaPagto(sql As String, CodFormaPagto As Integer)

        Dim parameters As SqlParameter() = {
                   New SqlParameter("@CodFormaPagto", CodFormaPagto)
                      }
        Return ClasseConexao.Consultar(sql, parameters)

    End Function
    Public Function ConsultaTaxas(sql As String, CodTaxas As Integer)

        Dim parameters As SqlParameter() = {
                   New SqlParameter("@CodTaxas", CodTaxas)
                      }
        Return ClasseConexao.Consultar(sql, parameters)

    End Function
#End Region
End Class
