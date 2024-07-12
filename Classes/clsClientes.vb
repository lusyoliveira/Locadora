Imports System.Data.SqlClient
Imports System.Text
Public Class clsClientes
    Dim ClasseConexao As New clsConexao, tbClientes, TbDependentes As New DataTable()
#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaCliente(Codigo As Integer, Nome As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbClientes WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Nome) Then
                    sql.AppendLine("AND Nome LIKE @Nome")
                End If

                sql.AppendLine("ORDER BY Nome")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Nome) Then
                        command.Parameters.AddWithValue("@Nome", "%" & Nome & "%")
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbClientes)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
        Return tbClientes
    End Function
    Public Sub SalvarCliente(nome As String, dtnasc As Date, telefone As String, email As String, rg As String, cpf As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()

            Dim sql As String = "INSERT INTO tbClientes (Nome, DtNasc, Telefone1, Email, RG, CPF) VALUES (@Nome, @DtNasc, @Telefone, @Email, @RG, @CPF)"

            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@DtNasc", dtnasc)
                command.Parameters.AddWithValue("@Telefone", telefone)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@RG", rg)
                command.Parameters.AddWithValue("@CPF", cpf)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AlterarCliente(codigo As Integer, nome As String, dtnasc As Date, telefone As String, email As String, rg As String, cpf As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()

            Dim sql As String = "UPDATE tbClientes SET Nome = @Nome, DtNasc = @DtNasc,Telefone1 = @Telefone, Email = @Email, RG = @RG, CPF = @CPF WHERE Codigo = @Codigo"

            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Codigo", codigo)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@DtNasc", dtnasc)
                command.Parameters.AddWithValue("@Telefone", telefone)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@RG", rg)
                command.Parameters.AddWithValue("@CPF", cpf)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirCliente(codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbClientes WHERE Codigo = @Codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Codigo", codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ConsultaDependente(Matricula As String, Nome As String)
        Dim sql As String = "SELECT * FROM tbdependentes WHERE matricula = @Matricula ORDER BY nrseq"

        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Matricula", Matricula)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(TbDependentes)
                    If TbDependentes.Rows.Count = 0 Then
                        MessageBox.Show("Dependente não encontrado!", "Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        If Nome.ToUpper.Trim = TbDependentes.Rows(0)("Nome").ToString().ToUpper() Then
                            Exit Sub
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub
#End Region
End Class
