Imports System.Data.Common
Imports System.Configuration
Imports System.ServiceProcess
Imports System.Data.SqlClient
Module mdlConexao
    Private aConexao As New ADODB.Connection
    Const database = "dbLocadora"
    Const user = "sa"
    Const password = "123456"
    Private server = "(local)"
    Public Enum tpServidor
        Access = 0
        SqlServer = 1
        MySQL = 2
        PostgreSQL = 3
        Oracle = 4
        SQLite = 5
    End Enum
    Private Function GetConnectionString(ByVal servidor As tpServidor) As String
        Select Case servidor
            Case tpServidor.SqlServer
                Return $"Server={server};Database={database};User Id={user};Password={password};"
            Case tpServidor.MySQL
                Return $"Server={server};Database={database};User={user};Password={password};"
            Case tpServidor.PostgreSQL
                Return $"Host={server};Database={database};Username={user};Password={password};"
            Case tpServidor.Oracle
                Return $"Data Source={server};User Id={user};Password={password};"
            Case tpServidor.SQLite
                Dim dbPath As String = My.Computer.FileSystem.CurrentDirectory & If(Right(My.Computer.FileSystem.CurrentDirectory, 1) = "\", "", "\") & database & ".sqlite"
                Return $"Data Source={dbPath};Version=3;"
            Case Else ' Access
                Dim acess_db2 As String = My.Computer.FileSystem.CurrentDirectory
                acess_db2 &= If(Right(acess_db2, 1) = "\", "", "\")
                acess_db2 &= database & ".mdb"
                Return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={database};Persist Security Info=False"
        End Select
    End Function
    Private Function GetProviderInvariantName(ByVal servidor As tpServidor) As String
        Select Case servidor
            Case tpServidor.SqlServer
                server = GetNomeSQLServer()
                Return "System.Data.SqlClient"
            Case tpServidor.MySQL
                Return "MySql.Data.MySqlClient"
            Case tpServidor.PostgreSQL
                Return "Npgsql"
            Case tpServidor.Oracle
                Return "Oracle.ManagedDataAccess.Client"
            Case tpServidor.SQLite
                Return "System.Data.SQLite"
            Case Else ' Access
                Return "System.Data.OleDb"
        End Select
    End Function
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

        Dim connectionString As String = "Data Source=VAR223\SQLEXPRESS;Initial Catalog=dbLocadora;User ID=sa;Password=123456"
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
        '        Dim aResultado As New ADODB.Recordset
        '        Dim acess_db2 As String
        '        acess_db2 = My.Computer.FileSystem.CurrentDirectory
        '        acess_db2 &= IIf(Right(acess_db2, 1) = "\", "", "\")
        '        acess_db2 &= database & ".mdb"
        '        'MsgBox(acess_db2)
        '        If aConexao.State = 1 Then aConexao.Close()

        '        If servidor = tpServidor.SqlServer Then

        '            aConexao.ConnectionString = "driver={sql server};" &
        '                                            "server=" + server + ";" &
        '                                            "Database=" + database + ";" &
        '                                            "PWD=" + password + ";" &
        '                                            "UID=" + user + ";"
        '        Else
        '            aConexao.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & acess_db2 & ";Persist Security Info=False"
        '        End If
        '        Try
        '            aConexao.Open()

        '        Catch ex As Exception
        '            aResultado = Nothing
        '            MsgBox("Banco de Dados não encontrado!")
        '            GoTo fim
        '        End Try

        '        aResultado.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '        aResultado.Open(Sql, aConexao, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        'fim:
        '        RecebeTabela = aResultado
        '        aResultado = Nothing
    End Function

    Public Sub CarregarList(ByVal tabela As String, ByRef list As ListView, ByVal nome As String, ByVal codigo As String, Optional ByVal filtro As String = "", Optional ByVal Campos As String = "*")
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
