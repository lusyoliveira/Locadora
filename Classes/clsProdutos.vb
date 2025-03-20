Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Text
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class clsProdutos
    Dim ClasseConexao As New clsConexao, tbProdutos As New DataTable()

#Region "PROPRIEDADES"
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
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Sub SalvarProduto(Produto As String, Titulo As String, Autor As String, Genero As String, Censura As String, Duracao As String, Valor As Decimal, dtcad As Date, Legenda As String)
        Dim sql As String = "INSERT INTO tbProdutos (produto, titulo, autor, genero, censura, duracao, valor, dtcad, legenda) VALUES (@produto, @titulo, @autor, @genero, @censura, @duracao, @valor, @dtcad, @legenda)"
        Dim parameters As SqlParameter() = {
            New SqlParameter("@produto", Produto),
            New SqlParameter("@titulo", Titulo),
            New SqlParameter("@autor", Autor),
            New SqlParameter("@genero", Genero),
            New SqlParameter("@censura", Censura),
            New SqlParameter("@duracao", Duracao),
            New SqlParameter("@valor", Valor),
            New SqlParameter("@dtcad", dtcad),
            New SqlParameter("@legenda", Legenda)
            }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Produto salvo com sucesso!")
    End Sub
    Public Sub AlterarProduto(Codigo As Integer, Produto As String, Titulo As String, Autor As String, Genero As String, Censura As String, Duracao As String, Valor As Decimal, dtcad As Date, Legenda As String)
        Dim sql As String = "UPDATE tbProdutos SET titulo = @titulo, autor = @autor, genero = @genero, censura = @censura, duracao = @duracao, valor = @valor, dtcad = @dtcad, legenda = @legenda WHERE Codigo = @Codigo"
        Dim parameters As SqlParameter() = {
                    New SqlParameter("@Codigo", Codigo),
                    New SqlParameter("@produto", Produto),
                    New SqlParameter("@titulo", Titulo),
                    New SqlParameter("@autor", Autor),
                    New SqlParameter("@genero", Genero),
                    New SqlParameter("@censura", Censura),
                    New SqlParameter("@duracao", Duracao),
                    New SqlParameter("@valor", Valor),
                    New SqlParameter("@dtcad", dtcad),
                    New SqlParameter("@legenda", Legenda)
}
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Produto alterado com sucesso!")
    End Sub
    Public Sub ExcluirProduto(Codigo As Integer)
        Dim sql As String = "DELETE FROM tbProdutos WHERE Codigo = @Codigo"
        Dim parameters As SqlParameter() = {
                    New SqlParameter("@Codigo", Codigo)
                    }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Produto excluído com sucesso!")
    End Sub
#End Region
#Region "FUNCOES"
    Public Function PesquisaProduto(Codigo As Integer, Produto As String) As DataTable
        Dim sql As New StringBuilder("SELECT * FROM tbProdutos WHERE 1=1 ")
        Dim parameters As New List(Of SqlParameter)()

        Try
            If Codigo <> 0 Then
                sql.AppendLine("AND Codigo = @Codigo")
                parameters.Add(New SqlParameter("@Codigo", Codigo))
            End If

            If Not String.IsNullOrEmpty(Produto) Then
                sql.AppendLine("AND Produto LIKE @Produto")
                parameters.Add(New SqlParameter("@Produto", "%" & Produto & "%"))
            End If

            sql.AppendLine("ORDER BY Produto")

            Return ClasseConexao.Consultar(sql.ToString(), parameters.ToArray())
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
    End Function
    Public Function ConsultaProduto(sql As String, Optional Codigo As Integer = 0, Optional Produto As String = "")

        If Codigo <> 0 Then
            Dim parameters As SqlParameter() = {
                       New SqlParameter("@Codigo", Codigo)
                          }
            Return ClasseConexao.Consultar(sql, parameters)
        ElseIf Produto IsNot Nothing Then
            Dim parameters As SqlParameter() = {
           New SqlParameter("@Produto", Produto)
              }
            Return ClasseConexao.Consultar(sql, parameters)
        Else
            Return ClasseConexao.Consultar(sql, Nothing)
        End If
    End Function
#End Region
End Class
