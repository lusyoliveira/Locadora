Public Class frmPrincipal
   
    Private Sub Funcion�riosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Funcion�riosToolStripMenuItem.Click
        frmCadFuncionarios.Show()
    End Sub
    Private Sub ProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosToolStripMenuItem.Click
        frmCadProdutos.Show()
    End Sub
    Private Sub Loca��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loca��oToolStripMenuItem.Click
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
    Private Sub NovoUsu�rioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsu�rioToolStripMenuItem.Click
        frmCadUsuarios.Show()
    End Sub
    Private Sub ReservaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservaToolStripMenuItem.Click
        frmReserva.Show()
    End Sub
    Private Sub Devolu��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Devolu��oToolStripMenuItem.Click
        frmDevolucao.Show()
    End Sub
   
    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        Dim tbLogin As ADODB.Recordset, sql As String

        sql = "Select * from tbLogin where nome <> '' order by nome"
        tbLogin = RecebeTabela(sql)
        If tbLogin.RecordCount = 0 Then
            MsgBox("N�o existem usu�rio !")
            Exit Sub
        End If


    End Sub

   
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        frmCadClientes.Show()
    End Sub

    
End Class