Public Class frmCadProdutos
    Private Sub limpar()
        txtCodigo.Text = ""
        cboProduto.Text = ""
        txtTitulo.Text = ""
        txtAutor.Text = ""
        cboGenero.Text = ""
        cboGenerojogo.Text = ""
        txtCensura.Text = ""
        txtDuracao.Text = ""
        txtQuantidade.Text = ""
        txtvalor.Text = ""
        mskDcad.Text = ""
        cbolegenda.Text = ""
        'txtoriginal.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub carregaproduto()
        limpar()
        lstgrade.Items.Clear()
        Dim frmCadProdutos As ADODB.Recordset, x As Integer, sql As String
        lstgrade.Items.Clear()
        sql = "select * from tbProdutos where codigo=" & txtCodigo.Text
        If Not IsNumeric(cboProduto.Text) Then
            sql = "select * from tbProdutos where produto like '" & txtCodigo.Text & "%'"
        End If
        frmCadProdutos = RecebeTabela(sql)
        If frmCadProdutos.RecordCount > 0 Then
            frmCadProdutos.MoveFirst()
            Do Until frmCadProdutos.EOF
                lstgrade.Items.Add(frmCadProdutos("codigo").Value)
                lstgrade.Items(x).SubItems.Add(frmCadProdutos("produto").Value)
                lstgrade.Items(x).SubItems.Add(frmCadProdutos("titulo").Value)
                lstgrade.Items(x).SubItems.Add(frmCadProdutos("genero").Value)
                lstgrade.Items(x).SubItems.Add(frmCadProdutos("censura").Value)
                lstgrade.Items(x).SubItems.Add(frmCadProdutos("dtcad").Value)

                x += 1
                frmCadProdutos.MoveNext()

            Loop
            frmCadProdutos.Close()

        End If
    End Sub
    Private Sub cboProduto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProduto.SelectedIndexChanged
        If cboProduto.Text = "JOGO" Then
            cboGenerojogo.Visible = True
            txtDuracao.Enabled = False
            lblDuracao.Enabled = False
        Else
            cboGenerojogo.Visible = False
            txtDuracao.Enabled = True
            lblDuracao.Enabled = True
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        carregaproduto()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        cboProduto.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim frmCadProdutos As ADODB.Recordset
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text
        frmCadProdutos = RecebeTabela("select * from tbProdutos where codigo=" & codigo)
        If frmCadProdutos.EOF Then frmCadProdutos.AddNew()
        frmCadProdutos("produto").Value = cboProduto.Text
        frmCadProdutos("titulo").Value = txtTitulo.Text
        frmCadProdutos("autor").Value = txtAutor.Text
        If cboProduto.Text = "JOGO" Then
            frmCadProdutos("genero").Value = cboGenerojogo.Text
        Else
            frmCadProdutos("genero").Value = cboGenero.Text
        End If
        frmCadProdutos("censura").Value = txtCensura.Text
        frmCadProdutos("duracao").Value = txtDuracao.Text
        'frmCadProdutos("original").Value = txtoriginal.Text
        frmCadProdutos("valor").Value = txtvalor.Text
        frmCadProdutos("dtcad").Value = mskDcad.Text
        frmCadProdutos("legenda").Value = cbolegenda.Text
        frmCadProdutos.Update()
        carregaproduto()
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim frmCadProdutos As ADODB.Recordset
        Dim codigo As Integer = 0
        If lstgrade.SelectedItems.Count > 0 Then codigo = lstgrade.SelectedItems(0).Text
        If (MsgBox("Confirma a Exclusão ? ", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
            frmCadProdutos = RecebeTabela("select * from tbProdutos where codigo=" & codigo)
            If frmCadProdutos.EOF = False Then frmCadProdutos.Delete()
            carregaproduto()
        End If
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        Dim frmCadProdutos As ADODB.Recordset
        frmCadProdutos = RecebeTabela("select * from tbprodutos where codigo=" & lstgrade.SelectedItems(0).Text)
        If frmCadProdutos.RecordCount = 0 Then
            limpar()
            MsgBox("Registro não localizado!")
            Exit Sub
        End If

        cboProduto.Text = frmCadProdutos("produto").Value.ToString
        txtTitulo.Text = frmCadProdutos("titulo").Value.ToString
        txtAutor.Text = frmCadProdutos("autor").Value.ToString
        If cboProduto.Text = "JOGO" Then
            cboGenerojogo.Text = frmCadProdutos("genero").Value.ToString
        Else
            cboGenero.Text = frmCadProdutos("genero").Value.ToString
        End If

        txtCensura.Text = frmCadProdutos("censura").Value.ToString
        txtDuracao.Text = frmCadProdutos("duracao").Value.ToString
        txtQuantidade.Text = frmCadProdutos("quantidade").Value.ToString
        ' txtoriginal.Text = frmCadProdutos("original").Value.ToString
        txtvalor.Text = frmCadProdutos("valor").Value.ToString
        mskDcad.Text = frmCadProdutos("dtcad").Value.ToString
        cbolegenda.Text = frmCadProdutos("legenda").Value.ToString
        btnExcluir.Visible = True
    End Sub
    Private Sub cboGereno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGenero.SelectedIndexChanged
        If cboGenero.Text = "Adulto" Then
            txtCensura.Text = "18"
        Else
            txtCensura.Text = ""
            If cboGenero.Text = "Desenho" Then
                txtCensura.Text = "Livre"
            Else
                txtCensura.Text = ""
            End If
        End If
    End Sub
    Private Sub frmCadProdutos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaproduto()
    End Sub
    'Private Sub txtQuantidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantidade.TextChanged
    '    If txtQuantidade.Text >= 1 Then
    '        txtoriginal.Text = txtCodigo.Text
    '    End If
    'End Sub

   
End Class
