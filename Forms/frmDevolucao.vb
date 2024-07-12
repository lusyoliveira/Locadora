Public Class frmDevolucao
    Dim ClasseLocacao As New clsLocacao, tbLocacao As DataTable
    Private Sub PreencheListaLocacao()
        Dim x As Integer = 0
        lstgrade.Items.Clear()

        If tbLocacao.Rows.Count = 0 Then Exit Sub
        For Each row As DataRow In tbLocacao.Rows
            lstgrade.Items.Add(row("codigo").ToString())
            lstgrade.Items(x).SubItems.Add(row("Cliente").ToString())
            lstgrade.Items(x).SubItems.Add(row("Total").ToString())
            lstgrade.Items(x).SubItems.Add(row("Multa").ToString())
            lstgrade.Items(x).SubItems.Add(row("Dt_Locacao").ToString())
            lstgrade.Items(x).SubItems.Add(row("Dt_Devolucao").ToString())
            x += 1
        Next
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        tbLocacao = ClasseLocacao.ConsultaLocacao(Val(txtCodigo.Text))
        PreencheListaLocacao()
    End Sub

    Private Sub frmDevolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class