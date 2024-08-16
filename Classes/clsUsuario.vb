Imports System.Data.SqlClient
Imports System.Text
Public Class clsUsuario
    Dim ClasseConexao As New clsConexao, tbUsuarios As New DataTable()
#Region "PROPRIEDADES"
#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Function PesquisaUsuario(lstGrade As ListView, Codigo As Integer, Nome As String) As DataTable
        Try
            Using connection As New SqlConnection(ClasseConexao.connectionString)
                connection.Open()
                Dim sql As New StringBuilder("SELECT * FROM tbUsuarios WHERE 1=1 ")

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
                    Dim adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbUsuarios)
                    Dim x As Integer = 0
                    If tbUsuarios.Rows.Count > 0 Then
                        For Each row As DataRow In tbUsuarios.Rows
                            Dim item As New ListViewItem(row("codigo").ToString())
                            item.SubItems.Add(row("nome").ToString())
                            item.SubItems.Add(row("permissao").ToString())
                            item.SubItems.Add(row("senha").ToString())
                            item.SubItems.Add(row("confsenha").ToString())

                            lstGrade.Items.Add(item)
                            x += 1
                        Next
                    Else
                        MessageBox.Show("Essa entidade não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar o usuário: " & ex.Message)
        End Try
        Return tbUsuarios
    End Function
    Public Sub SalvarUsuario(Nome As String, Permissao As String, Senha As String, ConfSenha As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()

            Dim sql As String = "INSERT INTO tbUsuarios (Nome, Permissao, Senha, ConfSenha) VALUES (@Nome, @Permissao, @Senha, @ConfSenha)"

            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Nome", Nome)
                command.Parameters.AddWithValue("@Permissao", Permissao)
                command.Parameters.AddWithValue("@Senha", Senha)
                command.Parameters.AddWithValue("@ConfSenha", ConfSenha)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub AlterarUsuario(codigo As Integer, Nome As String, Permissao As String, Senha As String, ConfSenha As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "UPDATE tbUsuarios SET Nome = @Nome, Permissao = @Permissao, Senha = @Senha, ConfSenha = @ConfSenha WHERE Codigo = @Codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Codigo", codigo)
                command.Parameters.AddWithValue("@Nome", Nome)
                command.Parameters.AddWithValue("@Permissao", Permissao)
                command.Parameters.AddWithValue("@Senha", Senha)
                command.Parameters.AddWithValue("@ConfSenha", ConfSenha)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub ExcluirUsuario(codigo As Integer)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            connection.Open()
            Dim sql As String = "DELETE FROM tbUsuarios WHERE Codigo = @Codigo"
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Codigo", codigo)
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub Autenticar(Login As String, Senha As String)
        Using connection As New SqlConnection(ClasseConexao.connectionString)
            Dim sql As String = "SELECT * FROM tbUsuarios WHERE nome = @Login"
            connection.Open()
            Using command As New SqlCommand(sql, connection)
                command.Parameters.AddWithValue("@Login", Login)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(tbUsuarios)
                    If tbUsuarios.Rows.Count = 0 Then
                        MessageBox.Show("Usuário não existe!!", "Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    If Senha.ToUpper = tbUsuarios.Rows(0)("senha").ToString().ToUpper() Then
                        frmPrincipal.Show()
                        MessageBox.Show("Seja Bem-Vindo a Loctech Sistema!", "Bem Vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MsgBox("Senha inválida!")
                        Beep()
                    End If
                    'Using reader As SqlDataReader = command.ExecuteReader()
                    '    dt.Load(reader)
                End Using
            End Using
        End Using
    End Sub

    Public Function CtrlMenuSubmenu(ByVal menu As System.Windows.Forms.ToolStripMenuItem, ByVal permissao As String, Optional ByVal esconder As Boolean = False) As Boolean
        Dim z As Integer

        For z = 0 To menu.DropDownItems.Count - 1
            If menu.DropDownItems(z).Text <> "" Then
                Dim sql As String = "SELECT ativo FROM tbpermissoes WHERE permissao = @permissao AND menu = @menu"

                Using connection As New SqlConnection(ClasseConexao.connectionString)
                    connection.Open()
                    Using command As New SqlCommand(sql, connection)
                        command.Parameters.AddWithValue("@permissao", permissao)
                        command.Parameters.AddWithValue("@menu", menu.DropDownItems(z).Text)

                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                reader.Read()
                                Dim ativo As Boolean = reader.GetBoolean(reader.GetOrdinal("ativo"))

                                If ativo Then
                                    If Not esconder Then
                                        menu.DropDownItems(z).Enabled = True
                                    Else
                                        menu.DropDownItems(z).Visible = True
                                    End If
                                Else
                                    If Not esconder Then
                                        menu.DropDownItems(z).Enabled = False
                                    Else
                                        menu.DropDownItems(z).Visible = False
                                    End If
                                End If
                            Else
                                If Not esconder Then
                                    menu.DropDownItems(z).Enabled = True
                                Else
                                    menu.DropDownItems(z).Visible = True
                                End If
                            End If
                        End Using
                    End Using
                End Using
                ' Recursivamente chama a função para os submenus
                CtrlMenuSubmenu(menu.DropDownItems(z), permissao, esconder)
            End If
        Next

        Return True
    End Function
#End Region
End Class
