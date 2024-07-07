Imports System.Data.Common
Imports System.Configuration
Imports System.ServiceProcess
Imports System.Data.SqlClient
Imports System.Text
Module mdlConexao
    Const database = "dbLocadora"
    Const user = "sa"
    Const password = "123456"
    Private server = GetNomeSQLServer()
    Public connectionString As String = $"Data Source={server};Initial Catalog=dbLocadora;User ID=sa;Password=123456"

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
    Public Function RecebeTabela(ByVal Sql As String)

        Dim dt As New DataTable()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(Sql, connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function
    Public Function ConsultaTabelaFiltros(ByVal Sql As StringBuilder)

        Dim dt As New DataTable()
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand(Sql.ToString(), connection)
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using
            End Using
        End Using
        Return dt
    End Function


    Public Sub CarregaLista(ByVal tabela As String, ByRef list As ListView, ByVal nome As String, ByVal codigo As String, Optional ByVal filtro As String = "", Optional ByVal Campos As String = "*")
        list.Visible = False

        Dim variavel As ADODB.Recordset, X As Integer, Y As Integer

        variavel = RecebeTabela("select " & Campos & " from " & tabela & " where " & IIf(IsNumeric(filtro), codigo & "=" & filtro, nome & " like'" & filtro & "%'"))

        list.Clear()
        list.FullRowSelect = True
        list.MultiSelect = True
        list.View = View.Details
        If Not variavel.EOF Then
            For Y = 0 To variavel.Fields.Count - 1
                list.Columns.Add(variavel(Y).Name)
            Next
            list.Items.Clear()
        End If

        Do Until variavel.EOF
            list.Items.Add(variavel(0).Value.ToString)
            For Y = 1 To list.Columns.Count - 1
                list.Items(X).SubItems.Add(variavel(Y).Value.ToString)
            Next
            variavel.MoveNext()
            X += 1
        Loop
        variavel.Close()
        list.Visible = True
    End Sub
End Module
