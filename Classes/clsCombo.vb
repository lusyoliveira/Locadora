Imports Microsoft.Data.SqlClient
Imports System.Data
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class clsCombo
    Dim ClasseConexao As New clsConexao

#Region "PROPRIEDADES"
    Public Property Codigo As Integer
    Public Property Descricao As String
#End Region
#Region "CONSTRUTORES"
    Public Sub New()

    End Sub
#End Region
#Region "METODOS"
    Public Function PreencherComboBox(query As String, campoId As String, campoNome As String) As List(Of clsCombo)
        Dim lista = New List(Of clsCombo)

        Dim Tabela As DataTable = ClasseConexao.Consultar(query, Nothing)
        For Each Row As DataRow In Tabela.Rows
            Dim item As New clsCombo With {
                    .Codigo = Row(campoId),
                    .Descricao = Row(campoNome)
                }
            lista.Add(item)
        Next

        Return lista
    End Function

    Public Sub Localizar(Tabela As String, lstGrade As ListView, Localizar As String)
        Dim sql As String = ""
        Dim x As Integer = 0

        Select Case Tabela
            Case "Clientes"
                lstGrade.Items.Clear()
                sql = "SELECT * FROM tbClientes WHERE nome LIKE @Localizar"
                If IsNumeric(Localizar) Then
                    sql = "SELECT * FROM tbClientes WHERE codigo = @Localizar"
                End If
                Dim parameters As SqlParameter() = {
                     New SqlParameter("@Localizar", Localizar)
                    }

                Dim tbClientes As DataTable = ClasseConexao.Consultar(sql, parameters)
                If tbClientes.Rows.Count > 0 Then
                    For Each row As DataRow In tbClientes.Rows
                        lstGrade.Items.Add(row("codigo").ToString())
                        lstGrade.Items(x).SubItems.Add(row("nome").ToString())
                        x += 1
                    Next
                End If

            Case "Produtos"
                lstGrade.Items.Clear()
                sql = "SELECT * FROM tbProdutos WHERE titulo LIKE @Localizar"
                If IsNumeric(Localizar) Then
                    sql = "SELECT * FROM tbProdutos WHERE codigo = @Localizar"
                End If
                Dim parameters As SqlParameter() = {
                     New SqlParameter("@Localizar", Localizar)
                    }
                Dim tbProdutos As DataTable = ClasseConexao.Consultar(sql, parameters)
                If tbProdutos.Rows.Count > 0 Then
                    For Each row As DataRow In tbProdutos.Rows
                        lstGrade.Items.Add(row("codigo").ToString())
                        lstGrade.Items(x).SubItems.Add(row("titulo").ToString())
                        x += 1
                    Next
                End If
        End Select
    End Sub
#End Region
End Class
