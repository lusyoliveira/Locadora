Public Class frmDevolucao
    Dim TBLOCACAO As DataTable


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        carregalocacao()
    End Sub
    Private Sub carregalocacao()

        lstgrade.Items.Clear()

        Dim sql As String = "Select * from TBLOCACAO where CODIGO = " & TXT_CODIGO.Text
        ' Recebe o DataTable preenchido com os dados das locações
        TBLOCACAO = RecebeTabela(sql)

        If TBLOCACAO.Rows.Count = 0 Then Exit Sub

        For Each row As DataRow In TBLOCACAO.Rows
            Dim item As New ListViewItem(row("CODIGO").ToString())
            item.SubItems.Add(row("CLIENTE").ToString())
            item.SubItems.Add(row("TOTAL").ToString())
            item.SubItems.Add(row("MULTA").ToString())
            item.SubItems.Add(row("DT_LOCACAO").ToString())
            item.SubItems.Add(row("DT_DEVOLUCAO").ToString())
            lstgrade.Items.Add(item)
        Next
    End Sub


End Class