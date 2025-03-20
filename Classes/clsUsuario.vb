Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Text
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class clsUsuario
    Dim ClasseConexao As New clsConexao
#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function PesquisaUsuario(Codigo As Integer, Nome As String) As DataTable
        Dim sql As New StringBuilder("SELECT * FROM tbUsuarios WHERE 1=1 ")
        Dim parameters As New List(Of SqlParameter)()

        Try
            If Codigo <> 0 Then
                sql.AppendLine("AND Codigo = @Codigo")
                parameters.Add(New SqlParameter("@Codigo", Codigo))
            End If

            If Not String.IsNullOrEmpty(Nome) Then
                sql.AppendLine("AND Nome LIKE @Nome")
                parameters.Add(New SqlParameter("@Nome", "%" & Nome & "%"))
            End If

            sql.AppendLine("ORDER BY Nome")

            Return ClasseConexao.Consultar(sql.ToString(), parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o usuário: " & ex.Message)
        End Try
    End Function
    Public Sub SalvarUsuario(Nome As String, Permissao As String, Senha As String, ConfSenha As String)
        Dim sql As String = "INSERT INTO tbUsuarios (Nome, Permissao, Senha, ConfSenha) VALUES (@Nome, @Permissao, @Senha, @ConfSenha)"
        Dim parameters As SqlParameter() = {
             New SqlParameter("@Nome", Nome),
            New SqlParameter("@Permissao", Permissao),
            New SqlParameter("@Senha", Senha),
            New SqlParameter("@ConfSenha", ConfSenha)
              }
        ClasseConexao.Operar(sql, parameters)
    End Sub
    Public Sub AlterarUsuario(codigo As Integer, Nome As String, Permissao As String, Senha As String, ConfSenha As String)

        Dim sql As String = "UPDATE tbUsuarios SET Nome = @Nome, Permissao = @Permissao, Senha = @Senha, ConfSenha = @ConfSenha WHERE Codigo = @Codigo"
        Dim parameters As SqlParameter() = {
                   New SqlParameter("@Codigo", codigo),
                   New SqlParameter("@Nome", Nome),
                  New SqlParameter("@Permissao", Permissao),
                  New SqlParameter("@Senha", Senha),
                  New SqlParameter("@ConfSenha", ConfSenha)
                    }
        ClasseConexao.Operar(sql, parameters)
    End Sub
    Public Sub ExcluirUsuario(codigo As Integer)
        Dim sql As String = "DELETE FROM tbUsuarios WHERE Codigo = @Codigo"
        Dim parameters As SqlParameter() = {
                   New SqlParameter("@Codigo", codigo)
                    }
    End Sub

#End Region
End Class
