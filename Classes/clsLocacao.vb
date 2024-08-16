Imports System.Data.SqlClient
Imports System.Text
Public Class clsLocacao
    Dim ClasseConexao As New clsConexao, tbLocacao As New DataTable()
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
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function PesquisaLocacao(lstgrade As ListView, Codigo As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbLocacao WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                sql.AppendLine("ORDER BY Codigo")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbLocacao)
                    Dim x As Integer = 0

                    If tbLocacao.Rows.Count = 0 Then
                        For Each row As DataRow In tbLocacao.Rows
                            lstgrade.Items.Add(row("codigo").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Cliente").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Total").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Multa").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Dt_Locacao").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Dt_Devolucao").ToString())
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
        Return tbLocacao
    End Function
    Public Sub ObterLocacao(ByRef DadosLocacao As clsLocacao, sql As String)
        Try
            Using cn = New SqlConnection(ClasseConexao.connectionString)
                cn.Open()
                Using CMD = New SqlCommand(sql, cn)
                    Using RDR As SqlDataReader = CMD.ExecuteReader()
                        While RDR.Read()
                            DadosLocacao._CodLocacao = RDR.Item("Codigo")
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
    Public Sub SalvarLocacao(Funcionario As Integer, Quantidade As Integer, DataLocacao As String, Cliente As Integer, Total As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbLocacao (Funcionario,Cliente,Quantidade,Total,DT_Locacao) VALUES (@Funcionario, @Quantidade,@DataLocacao,@Cliente,@Total)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@Funcionario", Funcionario)
                    cmd.Parameters.AddWithValue("@DataLocacao", DataLocacao)
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
    Public Sub SalvarDetLocacao(CodLocacao As Integer, CodProd As Integer, ValorUnitario As Decimal)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbProduto_Locacao (CodLocacao,CodProd, Valor) VALUES (@CodLocacao,@CodProd, @ValorUnitario)"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@CodLocacao", CodLocacao)
                    cmd.Parameters.AddWithValue("@CodProd", CodProd)
                    cmd.Parameters.AddWithValue("@ValorUnitario", ValorUnitario)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a locação: " & ex.Message)
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
            MessageBox.Show("Erro ao salvar produto: " & ex.Message)
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
