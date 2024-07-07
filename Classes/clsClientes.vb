Imports System.Data.SqlClient
Imports System.Text

Public Class clsClientes
    Dim tbClientes As New DataTable()

#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Sub CarregaClientes(lstgrade As ListView, Nome As String, Codigo As Integer)
        Dim x As Integer = 0

        Using connection As New SqlConnection(connectionString)
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
                Using reader As SqlDataReader = command.ExecuteReader()
                    tbClientes.Load(reader)
                    For Each row As DataRow In tbClientes.Rows
                        lstgrade.Items.Add(row("codigo").ToString())
                        lstgrade.Items(x).SubItems.Add(row("nome").ToString())
                        lstgrade.Items(x).SubItems.Add(row("dtnasc").ToString())
                        lstgrade.Items(x).SubItems.Add(row("telefone1").ToString())
                        lstgrade.Items(x).SubItems.Add(row("email").ToString())
                        lstgrade.Items(x).SubItems.Add(row("rg").ToString())
                        lstgrade.Items(x).SubItems.Add(row("cpf").ToString())
                        x += 1
                    Next
                End Using
            End Using
        End Using
    End Sub
    Public Sub SalvarCliente(nome As String, dtnasc As Date, telefone As String, email As String, rg As String, cpf As String)
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim sql As String = "INSERT INTO tbClientes (Nome, DtNasc, Telefone1, Email, RG, CPF) " &
                            "VALUES (@Nome, @DtNasc, @Telefone, @Email, @RG, @CPF)"

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
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim sql As String = "UPDATE tbClientes SET Nome = @Nome, DtNasc = @DtNasc, " &
                            "Telefone1 = @Telefone, Email = @Email, RG = @RG, CPF = @CPF " &
                            "WHERE Codigo = @Codigo"

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
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim sql As String = "DELETE FROM tbClientes WHERE Codigo = @Codigo"

            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Codigo", codigo)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

#End Region
End Class
