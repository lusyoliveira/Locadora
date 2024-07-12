Imports System.ServiceProcess
Imports System.Data.SqlClient
Imports System.Text
Public Class clsConexao
    Private database = "dbLocadora"
    Private user = "sa"
    Private password = "123456"
    Private server = GetNomeSQLServer()
    Public connectionString As String = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password}"

    Public Function GetNomeSQLServer() As String
        'Nome do PC local
        Dim strPCname As String = Environment.MachineName
        ' nome do serviço do SQL Server Express
        Dim strInstancia As String = "MSSQL$SQLEXPRESS"
        Dim strNomeSQLServer As String = String.Empty

        ' Inclua uma referência a : System.ServiceProcess;
        Dim servicos As ServiceController() = ServiceController.GetServices()
        ' percorre os serviços 
        For Each servico As ServiceController In servicos
            If servico Is Nothing Then
                Continue For
            End If
            Dim strNomeDoServico As String = servico.ServiceName
            If strNomeDoServico.Contains(strInstancia) Then
                strNomeSQLServer = strNomeDoServico
            End If
        Next
        Dim IndiceInicio As Integer = strNomeSQLServer.IndexOf("$")
        If IndiceInicio > -1 Then
            'strSqlServerName=NomeDoSeuPC\SQLEXPRESS;
            strNomeSQLServer = strPCname + "\" + strNomeSQLServer.Substring(IndiceInicio + 1)
        End If
        Return strNomeSQLServer
    End Function
    Public Sub CarregaLista(ByVal tabela As String, ByRef lstGrade As ListView, ByVal nome As String, ByVal codigo As String, Optional ByVal filtro As String = "", Optional ByVal Campos As String = "*")
        lstGrade.Visible = False
        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim sql As String = "SELECT " & Campos & " FROM " & tabela & " WHERE " & IIf(IsNumeric(filtro), codigo & " = " & filtro, nome & " LIKE '" & filtro & "%'")

            Dim adapter As New SqlDataAdapter(sql, conn)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            lstGrade.Clear()
            lstGrade.Columns.Clear()

            ' Adiciona colunas ao ListView
            For Each column As DataColumn In dataTable.Columns
                lstGrade.Columns.Add(column.ColumnName)
            Next

            ' Adiciona itens ao ListView
            For Each row As DataRow In dataTable.Rows
                Dim listItem As New ListViewItem(row(0).ToString())
                For i As Integer = 1 To dataTable.Columns.Count - 1
                    listItem.SubItems.Add(row(i).ToString())
                Next
                lstGrade.Items.Add(listItem)
            Next

            conn.Close()
        End Using

        lstGrade.Visible = True
    End Sub
End Class
