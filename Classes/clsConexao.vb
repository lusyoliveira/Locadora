Imports System.ServiceProcess
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class clsConexao
#Region "PROPRIEDADES"
    Private pServidor = GetNomeSQLServer()
    Public Property Servidor() As String
        Get
            Return pServidor
        End Get
        Set(value As String)
            pServidor = value
        End Set
    End Property
    Private pDataBase = "dbLocadora"
    Public Property DataBase() As String
        Get
            Return pDataBase
        End Get
        Set(value As String)
            pDataBase = value
        End Set
    End Property
    Private pUser = "sa"
    Public Property user() As String
        Get
            Return pUser
        End Get
        Set(value As String)
            pUser = value
        End Set
    End Property

    Private pPassword = "123456"
    Public Property password() As String
        Get
            Return pPassword
        End Get
        Set(value As String)
            pPassword = value
        End Set
    End Property
    Private _connectionString As String = $"Data Source={pServidor};Initial Catalog={pDataBase};User ID={pUser};Password={pPassword};TrustServerCertificate=True"
    Public Property connectionString As String
        Get
            Return _connectionString
        End Get
        Set(value As String)
            _connectionString = value
        End Set
    End Property
#End Region
#Region "METODOS"
    ''' <summary>
    ''' Este método realiza operações de inserção, alteração e exclusão numa tabela do banco de dados.
    ''' </summary>
    ''' <param name="sql">Representa a string sql para realizar uma inserção, alteração ou exclusão numa tabela do banco de dados.</param>
    Public Sub Operar(ByVal sql As String, ByVal parameters As SqlParameter())
        Try
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand(sql, cn)
                    ' Adiciona parâmetros ao comando, se houver
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception '
            MessageBox.Show("Não foi possível realizar a operação" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub

#End Region
#Region "FUNCOES"
    ''' <summary>
    ''' Esta função realiza uma consulta no banco de dados e retorna a lista dos dados.
    ''' </summary>
    ''' <param name="sql">Representa a string sql para realizar a consulta.</param>
    ''' <returns>Retorna a tabela consultada.</returns>
    Public Function Consultar(ByVal sql As String, ByVal parameters As SqlParameter()) As DataTable
        Dim dt As New DataTable()

        Try
            Using cn As New SqlConnection(_connectionString)
                Using cmd As New SqlCommand(sql, cn)
                    ' Adiciona parâmetros ao comando, se houver
                    If parameters IsNot Nothing Then
                        cmd.Parameters.AddRange(parameters)
                    End If

                    Using adpt As New SqlDataAdapter(cmd)
                        adpt.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Throw
            MessageBox.Show("Não foi possível consultar os dados!" & vbCrLf & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Opcional: log do erro ou tratamento adicional
        End Try
        Return dt
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
#End Region
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
