Imports System.Runtime.Versioning

<SupportedOSPlatform("windows")>
Public Class frmPrincipal
    Dim ClasseCombo As New clsCombo
    Private Sub Funcion�riosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Funcion�riosToolStripMenuItem.Click
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
    Private Sub Loca��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loca��oToolStripMenuItem.Click
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
    Private Sub NovoUsu�rioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsu�rioToolStripMenuItem.Click
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
    Private Sub Devolu��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Devolu��oToolStripMenuItem.Click
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