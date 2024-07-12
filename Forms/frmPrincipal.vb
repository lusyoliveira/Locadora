Public Class frmPrincipal
    Dim ClasseCombo As New clsCombo
    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        ''frmCadFuncionarios.Show()
        Dim frmPrincipal As New frmCadFuncionarios()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub
    Private Sub ProdutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdutosToolStripMenuItem.Click
        ''frmCadProdutos.Show()
        Dim frmPrincipal As New frmCadProdutos()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub
    Private Sub LocaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocaçãoToolStripMenuItem.Click
        '' frmLocacao.Show()
        Dim frmPrincipal As New frmLocacao()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub
    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        ''frmCadFornecedores.Show()
        Dim frmPrincipal As New frmCadFornecedores()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub
    Private Sub SairToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem1.Click
        If (MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub SairToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem2.Click
        If (MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub NovoUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsuárioToolStripMenuItem.Click
        ''frmCadUsuarios.Show()
        Dim frmPrincipal As New frmCadUsuarios()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub
    Private Sub ReservaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservaToolStripMenuItem.Click
        ''frmReserva.Show()
        Dim frmPrincipal As New frmReserva()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub
    Private Sub DevoluçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevoluçãoToolStripMenuItem.Click
        ''frmDevolucao.Show()
        Dim frmPrincipal As New frmDevolucao()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        ''frmCadClientes.Show()
        Dim frmPrincipal As New frmCadClientes()
        frmPrincipal.MdiParent = Me
        frmPrincipal.Show()
    End Sub

End Class