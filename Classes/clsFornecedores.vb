Imports System.Data.SqlClient
Imports System.Text

Public Class clsFornecedores
    Dim ClasseConexao As New clsConexao, tbFornecedores As New DataTable()
#Region "PROPRIEDADES"

#End Region
#Region "METODOS"
    Public Function ConsultaFornecedor(Codigo As Integer, Fornecedor As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbFornecedores WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Fornecedor) Then
                    sql.AppendLine("AND Fornecedor LIKE @Fornecedor")
                End If

                sql.AppendLine("ORDER BY Fornecedor")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Fornecedor) Then
                        command.Parameters.AddWithValue("@Fornecedor", "%" & Fornecedor & "%")
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbFornecedores)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o fornecedor: " & ex.Message)
        End Try
        Return tbFornecedores
    End Function
    Public Sub SalvarFornecedor(Fornecedor As String, Empresa As String, CNPJ As String, UF As String, CEP As String, Telefone As String, Celular As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO tbFornecedores (Codigo, Fornecedor, Empresa, CNPJ, UF, CEP, Telefone, Celular) VALUES (@Codigo, @Fornecedor, @Empresa, @CNPJ, @UF, @CEP, @Telefone, @Celular)"

            Using command As New SqlCommand(sql.ToString(), connection)
                command.Parameters.AddWithValue("@Fornecedor", Fornecedor)
                command.Parameters.AddWithValue("@Empresa", Empresa)
                command.Parameters.AddWithValue("@CNPJ", CNPJ)
                command.Parameters.AddWithValue("@UF", UF)
                command.Parameters.AddWithValue("@CEP", CEP)
                command.Parameters.AddWithValue("@Telefone", Telefone)
                command.Parameters.AddWithValue("@Celular", Celular)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AlterarFornecedor(Codigo As Integer, Fornecedor As String, Empresa As String, CNPJ As String, UF As String, CEP As String, Telefone As String, Celular As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "UPDATE tbFornecedores SET Fornecedor = @Fornecedor, Empresa = @Empresa, CNPJ = @CNPJ, UF = @UF, CEP = @CEP, Telefone = @Telefone, Celular = @Celular WHERE Codigo = @Codigo"

            Using command As New SqlCommand(sql.ToString(), connection)
                command.Parameters.AddWithValue("@Codigo", Codigo)
                command.Parameters.AddWithValue("@Fornecedor", Fornecedor)
                command.Parameters.AddWithValue("@Empresa", Empresa)
                command.Parameters.AddWithValue("@CNPJ", CNPJ)
                command.Parameters.AddWithValue("@UF", UF)
                command.Parameters.AddWithValue("@CEP", CEP)
                command.Parameters.AddWithValue("@Telefone", Telefone)
                command.Parameters.AddWithValue("@Celular", Celular)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirFornecedor(Codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbFornecedores WHERE Codigo = @Codigo"

            Using command As New SqlCommand(sql.ToString(), connection)
                command.Parameters.AddWithValue("@Codigo", Codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

#End Region
End Class
