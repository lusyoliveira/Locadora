Public Class frmDevolucao
    Dim TBLOCACAO As ADODB.Recordset

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If lblvalunit.Tag = "" Then Exit Sub
        'Dim tbProdutos As ADODB.Recordset
        TBLOCACAO = RecebeTabela("Select * from TBLOCACAO where CODIGO = " & TXT_CODIGO.Text)
        If TBLOCACAO.RecordCount = 0 Then Exit Sub
        TBLOCACAO.MoveFirst()
        'lstgrade.Items(lstgrade.Items.Count - 1).Tag = tbProdutos("codigo").Value.ToString
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(TBLOCACAO("CODIGO").Value.ToString)
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(TBLOCACAO("CLIENTE").Value.ToString)
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(TBLOCACAO("TOTAL").Value.ToString)
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(TBLOCACAO("MULTA").Value.ToString)
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(TBLOCACAO("DT_LOCACAO").Value.ToString)
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(TBLOCACAO("DT_DEVOLUCAO").Value.ToString)


        ''atualizaValor()
    End Sub
End Class