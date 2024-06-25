Public Class frmLocalizar
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocalizar.Click
        Dim tbClientes, tbProdutos As ADODB.Recordset, sql As String, x As Integer

        Select Case cboItens.Text
            Case Is = "Clientes"
                lstLocalizar.Items.Clear()
                sql = "select * from tbClientes where nome like '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "select * from tbClientes where codigo = " & txtLocalizar.Text
                End If
                tbClientes = RecebeTabela(sql)
                If tbClientes.RecordCount > 0 Then
                    tbClientes.MoveFirst()
                    Do Until tbClientes.EOF
                        lstLocalizar.Items.Add(tbClientes("codigo").Value)
                        lstLocalizar.Items(x).SubItems.Add(tbClientes("nome").Value)
                        x += 1
                        tbClientes.MoveNext()
                    Loop
                End If
            Case Is = "Produtos"
                lstLocalizar.Items.Clear()
                sql = "select * from tbProdutos where titulo like '%" & txtLocalizar.Text & "%'"
                If IsNumeric(txtLocalizar.Text) Then
                    sql = "select * from tbProdutos where codigo = " & txtLocalizar.Text
                End If
                tbProdutos = RecebeTabela(sql)
                If tbProdutos.RecordCount > 0 Then
                    tbProdutos.MoveFirst()
                    Do Until tbProdutos.EOF
                        lstLocalizar.Items.Add(tbProdutos("codigo").Value)
                        lstLocalizar.Items(x).SubItems.Add(tbProdutos("titulo").Value)
                        x += 1
                        tbProdutos.MoveNext()
                    Loop
                End If


        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub grpLocalizar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MdiParent = frmPrincipal
        txtLocalizar.Focus()
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