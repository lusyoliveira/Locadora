Imports System.Data.SqlClient
Imports System.Text
Public Class clsLocacao
    Dim ClasseConexao As New clsConexao, tbLocacao, tbLocacaoProd As New DataTable()
#Region "PROPRIEDADES"
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
    Public Sub ObterLocacao(ByRef DadosLocacao As clsLocacao, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)

                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosLocacao._CodLocacao = RDR.Item("Codigo")
                            DadosLocacao._Cliente = RDR.Item("Cliente")
                            DadosLocacao._Total = RDR.Item("Total")
                            DadosLocacao._Dias = RDR.Item("Atraso")
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
    Public Sub IncluirReserva(Cliente As String, Produto As String, dtReserva As String, dtDevolucao As String, valor As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbReserva (Cliente, Produto, Dt_Reserva, Dt_Devolucao, Valor) VALUES (@Cliente, @Produto, @DtReserva, @DtDevolucao, @Valor)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Cliente", Cliente)
                    command.Parameters.AddWithValue("@Produto", Produto)
                    command.Parameters.AddWithValue("@DtReserva", dtReserva)
                    command.Parameters.AddWithValue("@DtDevolucao", dtDevolucao)
                    command.Parameters.AddWithValue("@Valor", valor)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Reserva incluída com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao incluir a reserva: " & ex.Message)
        End Try
    End Sub
    Public Sub ObterReserva(ByRef DadosLocacao As clsLocacao, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)
                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosLocacao._CodReserva = RDR.Item("Codigo")
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
#End Region
End Class
