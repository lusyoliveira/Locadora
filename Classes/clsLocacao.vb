Imports System.Data.SqlClient
Imports System.Text
Public Class clsLocacao
    Dim ClasseConexao As New clsConexao, tbProdutos As New DataTable()
#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaLocacao(Codigo As Integer) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbProdutos WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                sql.AppendLine("ORDER BY Codigo")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbProdutos)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a locação: " & ex.Message)
        End Try
        Return tbProdutos
    End Function
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

#End Region
End Class
