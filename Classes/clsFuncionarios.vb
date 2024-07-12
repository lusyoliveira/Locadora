Imports System.Data.SqlClient
Imports System.Text
Public Class clsFuncionarios
    Dim ClasseConexao As New clsConexao, tbFuncionarios As New DataTable()

#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function ConsultaFuncionario(Codigo As Integer, Matricula As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbFuncionarios WHERE 1=1 ")

                If Codigo <> 0 Then
                    sql.AppendLine("AND codfunc = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Matricula) Then
                    sql.AppendLine("AND Matricula LIKE @Matricula")
                End If

                sql.AppendLine("ORDER BY Matricula")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Matricula) Then
                        command.Parameters.AddWithValue("@Matricula", "%" & Matricula & "%")
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbFuncionarios)
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar Funcionarios: " & ex.Message)
        End Try
        Return tbFuncionarios
    End Function
    Public Sub SalvarFuncionario(matricula As String, nome As String, estadoCivil As String, endereco As String, complemento As String, bairro As String, cidade As String, uf As String, cep As String, sexo As Boolean, telefone1 As String, telefone2 As String, celular As String, email As String, rg As String, cpf As String, carteiraProfissional As String, cargo As String, salario As Decimal, expediente As String, obs As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "INSERT INTO tbFuncionarios (matricula, nome, estadocivil, endereco, complemento, bairro, cidade, uf, cep, sexo, telefone1, telefone2, celular, email, rg, cpf, carteiraprofissional, cargo, salario, expediente, obs) " &
                            "VALUES (@matricula, @nome, @estadoCivil, @endereco, @complemento, @bairro, @cidade, @uf, @cep, @sexo, @telefone1, @telefone2, @celular, @email, @rg, @cpf, @carteiraProfissional, @cargo, @salario, @expediente, @obs)"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@matricula", matricula)
                command.Parameters.AddWithValue("@nome", nome)
                command.Parameters.AddWithValue("@estadoCivil", estadoCivil)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@complemento", complemento)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@cidade", cidade)
                command.Parameters.AddWithValue("@uf", uf)
                command.Parameters.AddWithValue("@cep", cep)
                command.Parameters.AddWithValue("@sexo", sexo)
                command.Parameters.AddWithValue("@telefone1", telefone1)
                command.Parameters.AddWithValue("@telefone2", telefone2)
                command.Parameters.AddWithValue("@celular", celular)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@rg", rg)
                command.Parameters.AddWithValue("@cpf", cpf)
                command.Parameters.AddWithValue("@carteiraProfissional", carteiraProfissional)
                command.Parameters.AddWithValue("@cargo", cargo)
                command.Parameters.AddWithValue("@salario", salario)
                command.Parameters.AddWithValue("@expediente", expediente)
                command.Parameters.AddWithValue("@obs", obs)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AlterarFuncionario(codigo As Integer, matricula As String, nome As String, estadoCivil As String, endereco As String, complemento As String, bairro As String, cidade As String, uf As String, cep As String, sexo As Boolean, telefone1 As String, telefone2 As String, celular As String, email As String, rg As String, cpf As String, carteiraProfissional As String, cargo As String, salario As Decimal, expediente As String, obs As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "UPDATE tbFuncionarios SET matricula = @matricula, nome = @nome, estadocivil = @estadoCivil, endereco = @endereco, complemento = @complemento, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep, sexo = @sexo, telefone1 = @telefone1, telefone2 = @telefone2, celular = @celular, email = @email, rg = @rg, cpf = @cpf, carteiraprofissional = @carteiraProfissional, cargo = @cargo, salario = @salario, expediente = @expediente, obs = @obs WHERE codfunc = @codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@codigo", codigo)
                command.Parameters.AddWithValue("@matricula", matricula)
                command.Parameters.AddWithValue("@nome", nome)
                command.Parameters.AddWithValue("@estadoCivil", estadoCivil)
                command.Parameters.AddWithValue("@endereco", endereco)
                command.Parameters.AddWithValue("@complemento", complemento)
                command.Parameters.AddWithValue("@bairro", bairro)
                command.Parameters.AddWithValue("@cidade", cidade)
                command.Parameters.AddWithValue("@uf", uf)
                command.Parameters.AddWithValue("@cep", cep)
                command.Parameters.AddWithValue("@sexo", sexo)
                command.Parameters.AddWithValue("@telefone1", telefone1)
                command.Parameters.AddWithValue("@telefone2", telefone2)
                command.Parameters.AddWithValue("@celular", celular)
                command.Parameters.AddWithValue("@email", email)
                command.Parameters.AddWithValue("@rg", rg)
                command.Parameters.AddWithValue("@cpf", cpf)
                command.Parameters.AddWithValue("@carteiraProfissional", carteiraProfissional)
                command.Parameters.AddWithValue("@cargo", cargo)
                command.Parameters.AddWithValue("@salario", salario)
                command.Parameters.AddWithValue("@expediente", expediente)
                command.Parameters.AddWithValue("@obs", obs)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirFuncionario(codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbFuncionarios WHERE codfunc = @codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@codigo", codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

#End Region
End Class
