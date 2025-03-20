Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Text
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class clsLocacao
    Dim ClasseConexao As New clsConexao, tbLocacao, tbLocacaoProd, tbReservas, tbReservaProd As New DataTable()
#Region "PROPRIEDADES"
    Private Property _Codigo As Integer
    Public Property Codigo As Integer
        Get
            Return _Codigo
        End Get
        Set(value As Integer)
            _Codigo = value
        End Set
    End Property
    Private Property _CodLocacao As Integer
    Public Property CodLocacao As Integer
        Get
            Return _CodLocacao
        End Get
        Set(value As Integer)
            _CodLocacao = value
        End Set
    End Property
    Private Property _CodReserva As Integer
    Public Property CodReserva As Integer
        Get
            Return _CodReserva
        End Get
        Set(value As Integer)
            _CodReserva = value
        End Set
    End Property
    Private Property _CodProd As Integer
    Public Property CodProd As Integer
        Get
            Return _CodProd
        End Get
        Set(value As Integer)
            _CodProd = value
        End Set
    End Property
    Private Property _Descricao As String
    Public Property Descricao As String
        Get
            Return _Descricao
        End Get
        Set(value As String)
            _Descricao = value
        End Set
    End Property
    Private Property _ValorUnit As Decimal
    Public Property ValorUnit As Decimal
        Get
            Return _ValorUnit
        End Get
        Set(value As Decimal)
            _ValorUnit = value
        End Set
    End Property
    Private Property _Total As Decimal
    Public Property Total As Decimal
        Get
            Return _Total
        End Get
        Set(value As Decimal)
            _Total = value
        End Set
    End Property
    Private Property _Cliente As String
    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
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
    Private Property _DataInicial As String
    Public Property DataInicial As String
        Get
            Return _DataInicial
        End Get
        Set(value As String)
            _DataInicial = value
        End Set
    End Property
    Private Property _DataFinal As String
    Public Property DataFinal As String
        Get
            Return _DataFinal
        End Get
        Set(value As String)
            _DataFinal = value
        End Set
    End Property
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Sub SalvarLocacao(Funcionario As Integer, Quantidade As Integer, Cliente As Integer, Total As Decimal, DataLocacao As String, DataDevolucao As String)

        Dim sql As String = "INSERT INTO tbLocacao (Funcionario,Cliente,Quantidade,Total,DT_Locacao,DT_Devolucao) VALUES (@Funcionario,@Cliente, @Quantidade, @Total, @DataLocacao,@DataDevolucao)"
        Dim parameters As SqlParameter() = {
                New SqlParameter("@DataLocacao", DataLocacao),
                New SqlParameter("@DataDevolucao", DataDevolucao),
                New SqlParameter("@Quantidade", Quantidade),
                New SqlParameter("@Cliente", Cliente),
                New SqlParameter("@Total", Total)
                      }

        ClasseConexao.Operar(sql, parameters)
    End Sub
    Public Sub SalvarDetLocacao(CodLocacao As Integer, CodProd As Integer, ValorUnitario As Decimal, Total As Decimal)
        Dim sql As String = "INSERT INTO tbLocacaoProd (CodLocacao,CodProd, Valor,Total) VALUES (@CodLocacao,@CodProd, @ValorUnitario,@Total)"

        Dim parameters As SqlParameter() = {
            New SqlParameter("@CodLocacao", CodLocacao),
            New SqlParameter("@CodProd", CodProd),
            New SqlParameter("@ValorUnitario", ValorUnitario),
            New SqlParameter("@Total", Total)
        }
        ClasseConexao.Operar(sql, parameters)
    End Sub
    Public Sub DevolverLocacao(CodLocacao As Integer)

        Dim sql As String = "UPDATE	tbLocacao SET Dt_Devolucao = GETDATE(), Devolvido = 1 WHERE Codigo = @CodLocacao"
        Dim parameters As SqlParameter() = {
                    New SqlParameter("@CodLocacao", CodLocacao)
                }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Locação atualizada com sucesso!")
    End Sub
    Public Function PesquisaReserva(Codigo As Integer, ReservaIni As String, ReservaFim As String) As DataTable
        Dim sql As New StringBuilder("SELECT * FROM CS_Reservas WHERE 1=1")
        Dim parameters As New List(Of SqlParameter)()

        Try
            'Pesquisa por código da reserva
            If Codigo <> 0 Then
                sql.AppendLine("AND Codigo = @Codigo")
                parameters.Add(New SqlParameter("@Codigo", Codigo))
            Else
                sql.AppendLine("AND Codigo IS NOT NULL")
            End If
            'Pesquisa pela data de reserva
            If Not String.IsNullOrEmpty(ReservaIni) And Not String.IsNullOrEmpty(ReservaFim) Then
                sql.AppendLine("AND DataInicial BETWEEN @ReservaIni AND @ReservaFim")
                parameters.Add(New SqlParameter("@ReservaIni", ReservaIni))
                parameters.Add(New SqlParameter("@ReservaFim", ReservaFim))
            ElseIf Not String.IsNullOrEmpty(ReservaIni) And String.IsNullOrEmpty(ReservaFim) Then
                sql.AppendLine("AND DataInicial >= @ReservaIni")
            ElseIf String.IsNullOrEmpty(ReservaIni) And Not String.IsNullOrEmpty(ReservaFim) Then
                sql.AppendLine("AND DataFinal <= @ReservaFim")
            End If

            sql.AppendLine("ORDER BY Codigo")

            Return ClasseConexao.Consultar(sql.ToString(), parameters.ToArray())
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a locação: " & ex.Message)
        End Try
    End Function
    Public Function ConsultaReserva(sql As String, Optional CodReserva As Integer = 0, Optional CodProd As Integer = 0)
        If CodReserva <> 0 Then
            Dim parameters As SqlParameter() = {
                     New SqlParameter("@CodReserva", CodReserva)
               }
            Return ClasseConexao.Consultar(sql, parameters)
        ElseIf CodProd <> 0 Then
            Dim parameters As SqlParameter() = {
                     New SqlParameter("@CodProd", CodProd)
               }
            Return ClasseConexao.Consultar(sql, parameters)
        Else
            Return ClasseConexao.Consultar(sql, Nothing)
        End If
    End Function
    Public Sub IncluirReserva(Cliente As String, DataInicial As String, DataFinal As String)
        Dim sql As String = "INSERT INTO tbReservas (Cliente, DataInicial,DataFinal,DataReserva) VALUES (@Cliente, @DataInicial,@DataFinal,GETDATE())"

        Dim parameters As SqlParameter() = {
                    New SqlParameter("@Cliente", Cliente),
                    New SqlParameter("@DataInicial", DataInicial),
                    New SqlParameter("@DataFinal", DataFinal)
                }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Reserva incluída com sucesso!")
    End Sub
    Public Sub IncluirReservaProd(CodReserva As Integer, Produto As Integer)
        Dim sql As String = "INSERT INTO tbReservaProd (CodReserva, CodProd) VALUES (@CodReserva, @Produto)"

        Dim parameters As SqlParameter() = {
            New SqlParameter("@CodReserva", CodReserva),
            New SqlParameter("@Produto", Produto)
                }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Reserva incluída com sucesso!")
    End Sub

#End Region
#Region "FUNCOES"
    Public Function PesquisaLocacao(Codigo As Integer, Devolvido As String, DevolucaoIni As String, DevolucaoFim As String) As DataTable
        Dim sql As New StringBuilder("SELECT * FROM CS_Locacao WHERE 1=1")
        Dim parameters As New List(Of SqlParameter)()

        Try
            Select Case Devolvido
                Case "NÃO"
                    sql.AppendLine("AND Devolvido = 0")
                Case "SIM"
                    sql.AppendLine("AND Devolvido = 1")
                Case "TODOS"
                    sql.AppendLine("AND Devolvido IS NOT NULL")
            End Select

            'Pesquisa por código da locação
            If Codigo <> 0 Then
                sql.AppendLine("AND Codigo = @Codigo")
                parameters.Add(New SqlParameter("@Codigo", Codigo))
            End If

            'Pesquisa pela data de cadastro
            If Not String.IsNullOrEmpty(DevolucaoIni) And Not String.IsNullOrEmpty(DevolucaoFim) Then
                sql.AppendLine("AND Dt_Devolucao BETWEEN @DevolucaoIni AND @DevolucaoFim")
                parameters.Add(New SqlParameter("@DevolucaoIni", DevolucaoIni))
                parameters.Add(New SqlParameter("@DevolucaoFim", DevolucaoFim))
            ElseIf Not String.IsNullOrEmpty(DevolucaoIni) And String.IsNullOrEmpty(DevolucaoFim) Then
                sql.AppendLine("AND Dt_Devolucao >= @DevolucaoIni")
                parameters.Add(New SqlParameter("@DevolucaoIni", DevolucaoIni))
            ElseIf String.IsNullOrEmpty(DevolucaoIni) And Not String.IsNullOrEmpty(DevolucaoFim) Then
                sql.AppendLine("AND Dt_Devolucao <= @DevolucaoFim")
                parameters.Add(New SqlParameter("@DevolucaoFim", DevolucaoFim))
            End If

            sql.AppendLine("ORDER BY Codigo")

            Return ClasseConexao.Consultar(sql.ToString(), parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a locação: " & ex.Message)
        End Try
    End Function
    Public Function ConsultaLocacao(sql As String, Optional CodLocacao As Integer = 0)
        If CodLocacao <> 0 Then
            Dim parameters As SqlParameter() = {
                        New SqlParameter("@CodLocacao", CodLocacao)
              }
            Return ClasseConexao.Consultar(sql, parameters)
        Else
            Return ClasseConexao.Consultar(sql, Nothing)
        End If
    End Function
#End Region
End Class
