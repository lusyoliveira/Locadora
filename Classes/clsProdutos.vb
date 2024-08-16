﻿Imports System.Data.SqlClient
Imports System.Text
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
    Public Function ConsultaProduto(lstgrade As ListView, Codigo As Integer, Produto As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbProdutos WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Produto) Then
                    sql.AppendLine("AND Produto LIKE @Produto")
                End If

                sql.AppendLine("ORDER BY Produto")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Produto) Then
                        command.Parameters.AddWithValue("@Produto", "%" & Produto & "%")
                    End If
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbProdutos)
                    Dim x As Integer = 0
                    If tbProdutos.Rows.Count > 0 Then
                        For Each row As DataRow In tbProdutos.Rows
                            lstgrade.Items.Add(row("codigo").ToString())
                            lstgrade.Items(x).SubItems.Add(row("produto").ToString())
                            lstgrade.Items(x).SubItems.Add(row("titulo").ToString())
                            lstgrade.Items(x).SubItems.Add(row("genero").ToString())
                            lstgrade.Items(x).SubItems.Add(row("censura").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Legenda").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Autor").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Duracao").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Quantidade").ToString())
                            lstgrade.Items(x).SubItems.Add(row("Valor").ToString())
                            lstgrade.Items(x).SubItems.Add(row("dtcad").ToString())
                            x += 1
                        Next
                    Else
                        MessageBox.Show("Esse produto não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
        Return tbProdutos
    End Function
    Public Sub ObterProduto(ByRef DadosProd As clsProdutos, Optional Codigo As Integer = 0, Optional Produto As String = "")

        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbProdutos WHERE 1=1 ")
                If Codigo <> 0 Then
                    sql.AppendLine("AND Codigo = @Codigo")
                End If

                If Not String.IsNullOrEmpty(Produto) Then
                    sql.AppendLine("AND Titulo LIKE @Produto")
                End If

                sql.AppendLine("ORDER BY Produto")

                Using command As New SqlCommand(sql.ToString(), connection)

                    If Codigo <> 0 Then
                        command.Parameters.AddWithValue("@Codigo", Codigo)
                    End If

                    If Not String.IsNullOrEmpty(Produto) Then
                        command.Parameters.AddWithValue("@Produto", "%" & Produto & "%")
                    End If

                    Using RDR As SqlDataReader = command.ExecuteReader()

                        If RDR.HasRows() Then
                            While RDR.Read()
                                DadosProd._CodProd = If(Not RDR.IsDBNull(RDR.GetOrdinal("Codigo")), RDR.GetInt32(RDR.GetOrdinal("Codigo")), String.Empty)
                                DadosProd._Descricao = If(Not RDR.IsDBNull(RDR.GetOrdinal("Titulo")), RDR.GetString(RDR.GetOrdinal("Titulo")), String.Empty)
                                DadosProd._ValorUnit = If(Not RDR.IsDBNull(RDR.GetOrdinal("Valor")), RDR.GetDecimal(RDR.GetOrdinal("Valor")), String.Empty)
                            End While
                        End If

                        RDR.Close()
                    End Using
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o produto: " & ex.Message)
        End Try
    End Sub
    Public Sub SalvarProduto(Produto As String, Titulo As String, Autor As String, Genero As String, Censura As String, Duracao As String, Valor As Decimal, dtcad As Date, Legenda As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "INSERT INTO tbProdutos (produto, titulo, autor, genero, censura, duracao, valor, dtcad, legenda) VALUES (@produto, @titulo, @autor, @genero, @censura, @duracao, @valor, @dtcad, @legenda)"

                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@produto", Produto)
                    command.Parameters.AddWithValue("@titulo", Titulo)
                    command.Parameters.AddWithValue("@autor", Autor)
                    command.Parameters.AddWithValue("@genero", Genero)
                    command.Parameters.AddWithValue("@censura", Censura)
                    command.Parameters.AddWithValue("@duracao", Duracao)
                    command.Parameters.AddWithValue("@valor", Valor)
                    command.Parameters.AddWithValue("@dtcad", dtcad)
                    command.Parameters.AddWithValue("@legenda", Legenda)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Produto salvo com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar produto: " & ex.Message)
        End Try
    End Sub
    Public Sub AlterarProduto(Codigo As Integer, Produto As String, Titulo As String, Autor As String, Genero As String, Censura As String, Duracao As String, Valor As Decimal, dtcad As Date, Legenda As String)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "UPDATE tbProdutos SET titulo = @titulo, autor = @autor, genero = @genero, censura = @censura, duracao = @duracao, valor = @valor, dtcad = @dtcad, legenda = @legenda WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    command.Parameters.AddWithValue("@produto", Produto)
                    command.Parameters.AddWithValue("@titulo", Titulo)
                    command.Parameters.AddWithValue("@autor", Autor)
                    command.Parameters.AddWithValue("@genero", Genero)
                    command.Parameters.AddWithValue("@censura", Censura)
                    command.Parameters.AddWithValue("@duracao", Duracao)
                    command.Parameters.AddWithValue("@valor", Valor)
                    command.Parameters.AddWithValue("@dtcad", dtcad)
                    command.Parameters.AddWithValue("@legenda", Legenda)

                    command.ExecuteNonQuery()
                    MessageBox.Show("Produto alterado com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao alterar produto: " & ex.Message)

        End Try
    End Sub
    Public Sub ExcluirProduto(Codigo As Integer)
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As String = "DELETE FROM tbProdutos WHERE Codigo = @Codigo"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Codigo", Codigo)
                    command.ExecuteNonQuery()
                    MessageBox.Show("Produto excluído com sucesso!")
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir produto: " & ex.Message)
        End Try
    End Sub


#End Region
End Class
