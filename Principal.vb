Public Class frmPrincipal
   
    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        frmCadFuncionarios.Show()
    End Sub
    Private Sub ProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosToolStripMenuItem.Click
        frmCadProdutos.Show()
    End Sub
    Private Sub LocaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocaçãoToolStripMenuItem.Click
        frmLocacao.Show()
    End Sub
    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        frmCadFornecedores.Show()
    End Sub
    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        If (MsgBox("Deseja realmente sair do sistema ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub SairToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem2.Click
        If (MsgBox("Deseja realmente sair do sistema ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub NovoUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsuárioToolStripMenuItem.Click
        frmCadUsuarios.Show()
    End Sub
    Private Sub ReservaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservaToolStripMenuItem.Click
        frmReserva.Show()
    End Sub
    Private Sub DevoluçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluçãoToolStripMenuItem.Click
        frmDevolucao.Show()
    End Sub
   
    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Dim tbLogin As ADODB.Recordset, sql As String

        sql = "Select * from tbLogin where nome <> '' order by nome"
        tbLogin = RecebeTabela(sql)
        If tbLogin.RecordCount = 0 Then
            MsgBox("Não existem usuário !")
            Exit Sub
        End If


    End Sub

   
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmCadClientes.Show()
    End Sub

    
End Class