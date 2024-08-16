Imports System.Data.SqlClient

Public Class clsFinanceiro
    Dim ClasseConexao As New clsConexao
#Region "PROPRIEDADES"
    Public Property CodReceber As Integer
    Public Property CodPagar As Integer
    Public Property CodFormaPagto As Integer
    Public Property CodCobranca As Integer
    Public Property CodConta As Integer
    Public Property FormaPagto As String
    Public Property Cobranca As String
    Public Property NomeConta As String
    Public Property NomeBanco As String
    Public Property Dias As Integer
    Public Property NParcelas As Integer
    Public Property DataVencto As Date
    Public Property DataPagto As Date
    Public Property ValorPago As Decimal
    Public Property ValorParcela As Decimal

#End Region
#Region "METODOS"
    Public Sub CalculaParcelas(ValorTotal As Decimal, Data As DateTime, NumeroParcelas As Integer, ByRef DadosParcela As clsFinanceiro)
        Dim valorParcela As Decimal = FormatCurrency(ValorTotal / NumeroParcelas)
        Dim ListaParcela = New List(Of clsFinanceiro)
        Dim i As Integer
        Try
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
    Public Sub ListaNParcelas(FormaPagto As String, ByRef DadosMov As clsFinanceiro)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Dim sql = "SELECT NParcelas  FROM Tbl_FormaPgto  WHERE Forma_Pgto = @FORMAPAGTO"
                Using CMD = New SqlCommand(sql, cn)
                    CMD.Parameters.AddWithValue("@FORMAPAGTO", FormaPagto)
                    Dim RDR As SqlClient.SqlDataReader
                    RDR = CMD.ExecuteReader()
                    While RDR.Read()
                        DadosMov.NParcelas = RDR.GetInt32(RDR.GetOrdinal("NParcelas"))
                    End While
                    RDR.Close()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar a consulta!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
    ''' <summary>
    ''' Este metódo realiza a gravação do pagamento no banco de dados.
    ''' </summary>
    ''' <param name="CodCompra">Representa o código do lançamento da nota fiscal relacionada ao pagamento do tipo integer.</param>
    ''' <param name="CodDevolucao">Representa o código da devolução relacionada ao pagamento do tipo integer.</param>
    ''' <param name="DtVencimento">Representa a data em que o pagamento irá vencer do tipo date.</param>
    ''' <param name="Parcelas">Represente o número do parcelas do tipo integer.</param>
    ''' <param name="DtPgto">Representa a data na qual o pagamento foi realizado do tipo date.</param>
    ''' <param name="ValorParcela">Representa o valor da parcelas a ser pago do tipo decimal.</param>
    ''' <param name="ValorPago">Representa o valor pago do pagamento do tipo decimal.</param>
    ''' <param name="Complemento">Representa a descrição do pagamento do tipo string.</param>
    ''' <param name="Desconto">Representa o valor de desconto aplicado no pagamento do tipo decimal.</param>
    ''' <param name="Frete">Representa o valor de frete aplicado no pagamento do tipo decimal.</param>
    ''' <param name="Taxa">Representa o valor de taxa aplicado no pagamento do tipo decimal.</param>
    ''' <param name="Acrescimo">Representa o valor de acréscimo aplicado no pagamento do tipo decimal.</param>
    ''' <param name="Entidade">Representa o código da entidade para qual o pagamento foi realizado do tipo integer.</param>
    ''' <param name="Cobranca">Representa o código da  cobrança do pagamento do tipo integer.</param>
    ''' <param name="FormaPagto">Representa o código do da forma de pagamento do tipo integer.</param>
    Public Sub GerarPagamento(CodCompra As String, CodDevolucao As String, DtVencimento As Date, Parcelas As Integer, DtPgto As Date, ValorParcela As Decimal, ValorPago As Decimal, Complemento As String, Desconto As Integer, Frete As Integer, Taxa As Decimal, Acrescimo As Decimal, Entidade As Integer, Cobranca As Integer, FormaPagto As Integer)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Dim sql = "INSERT INTO Tbl_ContasPagar         (CodCompra,
                                                                Dt_Vencimento,
                                                                Parcelas,
                                                                Dt_Pgto,
                                                                Valor_Parcela,
                                                                Valor_Pago,
                                                                Quitar,
                                                                Complemento,
                                                                CodDevolucao,
                                                                Desconto,
                                                                Frete,
                                                                Entidade,
                                                                FormaPagto,
                                                                Cobranca,
                                                                Taxa,
                                                                Acrescimo,
                                                                TipoEntidade) 
                                        VALUES                  (@CODCOMPRA, 
                                                                @DATAVENCTO, 
                                                                @PARCELAS,
                                                                @DATAPAGTO,
                                                                @VALORPARC,
                                                                @VALORPAGO,
                                                                0,
                                                                @COMPLEMENTO,
                                                                @CodDevolucao,
                                                                @DESCONTO,
                                                                @FRETE,
                                                                @ENTIDADE,
                                                                @FORMAPAGTO,
                                                                @COBRANCA,
                                                                @TAXA,
                                                                @ACRESCIMO, 
                                                                @TipoEntidade)"
                Using CMD = New SqlCommand(sql, cn)
                    If CodCompra = 0 Then
                        Dim CompraNulo As Object = DBNull.Value
                        CMD.Parameters.AddWithValue("@CODCOMPRA", CompraNulo)
                    Else
                        CMD.Parameters.AddWithValue("@CODCOMPRA", CodCompra)
                    End If
                    CMD.Parameters.AddWithValue("@DATAVENCTO", DtVencimento)
                    CMD.Parameters.AddWithValue("@PARCELAS", Parcelas)
                    CMD.Parameters.AddWithValue("@DATAPAGTO", DtPgto)
                    CMD.Parameters.AddWithValue("@VALORPARC", ValorParcela)
                    CMD.Parameters.AddWithValue("@VALORPAGO", ValorPago)
                    CMD.Parameters.AddWithValue("@COMPLEMENTO", Complemento)
                    CMD.Parameters.AddWithValue("@DESCONTO", Desconto)
                    CMD.Parameters.AddWithValue("@FRETE", Frete)
                    CMD.Parameters.AddWithValue("@ENTIDADE", Entidade)
                    CMD.Parameters.AddWithValue("@COBRANCA", Cobranca)
                    CMD.Parameters.AddWithValue("@FORMAPAGTO", FormaPagto)
                    CMD.Parameters.AddWithValue("@TAXA", Taxa)
                    CMD.Parameters.AddWithValue("@ACRESCIMO", Acrescimo)
                    If CodDevolucao = 0 Then
                        CMD.Parameters.AddWithValue("@CodDevolucao", DBNull.Value)
                    Else
                        CMD.Parameters.AddWithValue("@CodDevolucao", CodDevolucao)
                    End If
                    CMD.ExecuteNonQuery()
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não é possível salvar o pagamento!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
#End Region
#Region "FUNÇÕES"

#End Region
End Class
