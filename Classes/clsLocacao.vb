Imports System.Data.SqlClient
Imports System.Text
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
    Public Function PesquisaLocacao(Codigo As Integer, Devolvido As String, DevolucaoIni As String, DevolucaoFim As String) As DataTable
        tbLocacao.Clear()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM CS_Locacao WHERE 1=1")
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
                End If

                'Pesquisa pela data de cadastro
                If Not String.IsNullOrEmpty(DevolucaoIni) And Not String.IsNullOrEmpty(DevolucaoFim) Then
                    sql.AppendLine("AND Dt_Devolucao BETWEEN @DevolucaoIni AND @DevolucaoFim")
                ElseIf Not String.IsNullOrEmpty(DevolucaoIni) And String.IsNullOrEmpty(DevolucaoFim) Then
                    sql.AppendLine("AND Dt_Devolucao >= @DevolucaoIni")
                ElseIf String.IsNullOrEmpty(DevolucaoIni) And Not String.IsNullOrEmpty(DevolucaoFim) Then
                    sql.AppendLine("AND Dt_Devolucao <= @DevolucaoFim")
                End If

                sql.AppendLine("ORDER BY Codigo")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(DevolucaoIni) Then
                        command.Parameters.AddWithValue("@DevolucaoIni", DevolucaoIni)
                    End If

                    If Not String.IsNullOrEmpty(DevolucaoFim) Then
                        command.Parameters.AddWithValue("@DevolucaoFim", DevolucaoFim)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbLocacao)

                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a locação: " & ex.Message)
        End Try
        Return tbLocacao
    End Function
    Public Function ObterLocacaoProd(lstgrade As ListView, CodLocacao As Integer) As DataTable
        tbLocacaoProd.Clear()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM CS_LocacaoProd WHERE CodLocacao = @CodLocacao"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodLocacao", CodLocacao)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbLocacaoProd)
                    Dim x As Integer = 0

                    If tbLocacaoProd.Rows.Count > 0 Then
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
                        MessageBox.Show("Essa locação não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a locação: " & ex.Message)
        End Try
        Return tbLocacaoProd
    End Function
    Public Sub ObterCodigo(ByRef DadosLocacao As clsLocacao, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)

                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosLocacao._Codigo = RDR.Item("Codigo")
                        End While
                        RDR.Close()
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar obter dados da locação!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
    Public Sub ObterLocacao(ByRef DadosLocacao As clsLocacao, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)

                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosLocacao._CodLocacao = RDR.Item("Codigo")
                            'DadosLocacao._Cliente = RDR.Item("Cliente")
                            'DadosLocacao._Total = RDR.Item("Total")
                            'DadosLocacao._Dias = RDR.Item("Atraso")
                        End While
                        RDR.Close()
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar obter dados da locação!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
    Public Sub SalvarLocacao(Funcionario As Integer, Quantidade As Integer, Cliente As Integer, Total As Decimal, DataLocacao As String, DataDevolucao As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbLocacao (Funcionario,Cliente,Quantidade,Total,DT_Locacao,DT_Devolucao) VALUES (@Funcionario,@Cliente, @Quantidade, @Total, @DataLocacao,@DataDevolucao)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@Funcionario", Funcionario)
                    cmd.Parameters.AddWithValue("@DataLocacao", DataLocacao)
                    cmd.Parameters.AddWithValue("@DataDevolucao", DataDevolucao)
                    cmd.Parameters.AddWithValue("@Quantidade", Quantidade)
                    cmd.Parameters.AddWithValue("@Cliente", Cliente)
                    cmd.Parameters.AddWithValue("@Total", Total)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a locação: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarDetLocacao(CodLocacao As Integer, CodProd As Integer, ValorUnitario As Decimal, Total As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbLocacaoProd (CodLocacao,CodProd, Valor,Total) VALUES (@CodLocacao,@CodProd, @ValorUnitario,@Total)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodLocacao", CodLocacao)
                    cmd.Parameters.AddWithValue("@CodProd", CodProd)
                    cmd.Parameters.AddWithValue("@ValorUnitario", ValorUnitario)
                    cmd.Parameters.AddWithValue("@Total", Total)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a locação: " & ex.Message)
        End Try
    End Sub
    Public Sub DevolverLocacao(CodLocacao As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE	tbLocacao SET Dt_Devolucao = GETDATE() WHERE Codigo = @CodLocacao"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodLocacao", CodLocacao)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Locação atualizada com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar a locação: " & ex.Message)
        End Try
    End Sub
    Public Function PesquisaReserva(Codigo As Integer, ReservaIni As String, ReservaFim As String) As DataTable
        tbReservas.Clear()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM CS_Reservas WHERE 1=1")

                'Pesquisa por código da reserva
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                Else
                    sql.AppendLine("AND Codigo IS NOT NULL")
                End If

                'Pesquisa pela data de reserva
                If Not String.IsNullOrEmpty(ReservaIni) And Not String.IsNullOrEmpty(ReservaFim) Then
                    sql.AppendLine("AND DataInicial BETWEEN @ReservaIni AND @ReservaFim")
                ElseIf Not String.IsNullOrEmpty(ReservaIni) And String.IsNullOrEmpty(ReservaFim) Then
                    sql.AppendLine("AND DataInicial >= @ReservaIni")
                ElseIf String.IsNullOrEmpty(ReservaIni) And Not String.IsNullOrEmpty(ReservaFim) Then
                    sql.AppendLine("AND DataFinal <= @ReservaFim")
                End If

                sql.AppendLine("ORDER BY Codigo")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(ReservaIni) Then
                        command.Parameters.AddWithValue("@ReservaIni", ReservaIni)
                    End If

                    If Not String.IsNullOrEmpty(ReservaFim) Then
                        command.Parameters.AddWithValue("@ReservaFim", ReservaFim)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbReservas)

                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a locação: " & ex.Message)
        End Try
        Return tbReservas
    End Function
    Public Sub ObterReserva(ByRef DadosLocacao As clsLocacao, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)
                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosLocacao._CodReserva = RDR.Item("Codigo")
                            DadosLocacao._Cliente = RDR.Item("Cliente")
                            DadosLocacao._DataInicial = RDR.Item("Datainicial")
                            DadosLocacao._DataFinal = RDR.Item("Datafinal")
                            DadosLocacao._CodProd = RDR.Item("CodProd")
                        End While
                        RDR.Close()
                    End Using
                End Using
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar obter orçamento!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub
    Public Function ObterReservaProd(lstgrade As ListView, CodReserva As Integer) As DataTable
        tbReservaProd.Clear()
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "SELECT * FROM CS_ReservasProd WHERE Codigo = @CodReserva"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodReserva", CodReserva)
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbReservaProd)
                    Dim x As Integer = 0

                    If tbReservaProd.Rows.Count > 0 Then
                        For Each row As DataRow In tbReservaProd.Rows
                            ' Adiciona o código (assumindo que nunca é nulo)
                            lstgrade.Items.Add(row("CodProd").ToString())

                            ' Adiciona os subitens, verificando se cada valor é nulo
                            lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Titulo")), String.Empty, row("Titulo").ToString()))
                            x += 1
                        Next
                    Else
                        MessageBox.Show("Essa locação não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a locação: " & ex.Message)
        End Try
        Return tbReservaProd
    End Function
    Public Sub IncluirReserva(Cliente As String, DataInicial As String, DataFinal As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbReservas (Cliente, DataInicial,DataFinal,DataReserva) VALUES (@Cliente, @DataInicial,@DataFinal,GETDATE())"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Cliente", Cliente)
                    command.Parameters.AddWithValue("@DataInicial", DataInicial)
                    command.Parameters.AddWithValue("@DataFinal", DataFinal)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Reserva incluída com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao incluir a reserva: " & ex.Message)
        End Try
    End Sub
    Public Sub IncluirReservaProd(CodReserva As Integer, Produto As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbReservaProd (CodReserva, CodProd) VALUES (@CodReserva, @Produto)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@CodReserva", CodReserva)
                    command.Parameters.AddWithValue("@Produto", Produto)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Reserva incluída com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao incluir a reserva: " & ex.Message)
        End Try
    End Sub

#End Region
End Class
