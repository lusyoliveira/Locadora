Public Class frmLocalizar
    Dim tbClientes, tbProdutos As DataTable, sql As String, x As Integer



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub grpLocalizar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MdiParent = frmPrincipal
        txtLocalizar.Focus()
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Dim sql As String = ""
        Dim x As Integer = 0

        Select Case cboItens.Text
            Case "Clientes"
                lstLocalizar.Items.Clear()
                sql = "SELECT * FROM tbClientes WHERE nome LIKE '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "SELECT * FROM tbClientes WHERE codigo = " & txtLocalizar.Text
                End If
                tbClientes = RecebeTabela(sql)
                If tbClientes.Rows.Count > 0 Then
                    For Each row As DataRow In tbClientes.Rows
                        lstLocalizar.Items.Add(row("codigo").ToString())
                        lstLocalizar.Items(x).SubItems.Add(row("nome").ToString())
                        x += 1
                    Next
                End If

            Case "Produtos"
                lstLocalizar.Items.Clear()
                sql = "SELECT * FROM tbProdutos WHERE titulo LIKE '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "SELECT * FROM tbProdutos WHERE codigo = " & txtLocalizar.Text
                End If
                tbProdutos = RecebeTabela(sql)
                If tbProdutos.Rows.Count > 0 Then
                    For Each row As DataRow In tbProdutos.Rows
                        lstLocalizar.Items.Add(row("codigo").ToString())
                        lstLocalizar.Items(x).SubItems.Add(row("titulo").ToString())
                        x += 1
                    Next
                End If
        End Select
    End Sub

    Private Sub frmLocalizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Select Case cboItens.Text
            Case Is = "Clientes"
                frmCadClientes.Show()
                frmCadClientes.btnExcluir.Enabled = False
            Case Is = "Produtos"
                frmCadProdutos.Show()
                frmCadProdutos.btnExcluir.Enabled = False
        End Select
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Select Case cboItens.Text
            Case Is = "Clientes"
                frmCadClientes.Show()
                frmCadClientes.btnSalvar.Enabled = False
                frmCadClientes.btnExcluir.Enabled = False
            Case Is = "Produtos"
                frmCadProdutos.Show()
                frmCadProdutos.btnSalvar.Enabled = False
                frmCadProdutos.btnExcluir.Enabled = False
        End Select
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Select Case cboItens.Text
            Case Is = "Clientes"
                frmCadClientes.Show()
                frmCadClientes.btnSalvar.Enabled = False
            Case Is = "Produtos"
                frmCadProdutos.Show()
                frmCadProdutos.btnSalvar.Enabled = False

        End Select
    End Sub
End Class