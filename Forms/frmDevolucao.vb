Public Class frmDevolucao
    Dim ClasseLocacao As New clsLocacao, tbLocacao As DataTable

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs)
        ClasseLocacao.PesquisaLocacao(lstgrade, Val(txtCodigo.Text))
    End Sub

    Private Sub frmDevolucao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class