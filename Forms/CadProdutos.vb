Public Class frmCadProdutos
    Dim tbProdutos As DataTable, ClasseProdutos As New clsProdutos
    Private Sub limpar()
        cboProduto.Text = ""
        txtTitulo.Text = ""
        txtAutor.Text = ""
        cboGenero.Text = ""
        txtCensura.Text = ""
        txtDuracao.Text = ""
        txtQuantidade.Text = ""
        txtvalor.Text = ""
        mskDcad.Text = ""
        cbolegenda.Text = ""
        'txtoriginal.Text = ""
        lstgrade.Tag = 0
    End Sub
    Private Sub PreencheListaProdutos()
        Dim x As Integer = 0

        For Each row As DataRow In tbProdutos.Rows
            lstgrade.Items.Add(row("codigo").ToString())
            lstgrade.Items(x).SubItems.Add(row("produto").ToString())
            lstgrade.Items(x).SubItems.Add(row("titulo").ToString())
            lstgrade.Items(x).SubItems.Add(row("genero").ToString())
            lstgrade.Items(x).SubItems.Add(row("censura").ToString())
            lstgrade.Items(x).SubItems.Add(row("dtcad").ToString())
            x += 1
        Next
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Close()
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        tbProdutos = ClasseProdutos.ConsultaProduto(Val(lblCodigo.Text), cboProduto.Text)
        PreencheListaProdutos()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        cboProduto.Focus()
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
        tbProdutos = ClasseProdutos.ConsultaProduto(Val(lblCodigo.Text), cboProduto.Text)
        PreencheListaProdutos()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.SalvarProduto(cboProduto.Text, txtTitulo.Text, txtAutor.Text, cboGenero.Text, txtCensura.Text, txtDuracao.Text, txtvalor.Text, mskDcad.Text, cbolegenda.Text)
            tbProdutos = ClasseProdutos.ConsultaProduto(Val(lblCodigo.Text), cboProduto.Text)
            PreencheListaProdutos()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.ExcluirProduto(Val(lblCodigo.Text))
            tbProdutos = ClasseProdutos.ConsultaProduto(Val(lblCodigo.Text), cboProduto.Text)
            PreencheListaProdutos()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count = 0 Then
            limpar()
            Exit Sub
        End If

        ' Obtém o código do produto selecionado na lstgrade
        Dim Codigo As Integer = CInt(lstgrade.SelectedItems(0).Text)

        ' Chama o método para obter os dados do produto por código
        tbProdutos = ClasseProdutos.ConsultaProduto(Codigo, cboProduto.Text)

        ' Verifica se encontrou algum registro
        If tbProdutos.Rows.Count = 0 Then
            limpar()
            MessageBox.Show("Produto não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Preenche os controles da interface com os dados do produto encontrado
        Dim row As DataRow = tbProdutos.Rows(0) ' Assumindo que há apenas um registro retornado
        cboProduto.Text = row("produto").ToString()
        txtTitulo.Text = row("titulo").ToString()
        txtAutor.Text = row("autor").ToString()
        cboGenero.Text = row("genero").ToString()
        txtCensura.Text = row("censura").ToString()
        txtDuracao.Text = row("duracao").ToString()
        txtQuantidade.Text = row("quantidade").ToString()
        ' txtoriginal.Text = row("original").ToString()
        txtvalor.Text = row("valor").ToString()
        mskDcad.Text = row("dtcad").ToString()
        cbolegenda.Text = row("legenda").ToString()
        btnExcluir.Visible = True
    End Sub
    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.AlterarProduto(Val(lblCodigo.Text), cboProduto.Text, txtTitulo.Text, txtAutor.Text, cboGenero.Text, txtCensura.Text, txtDuracao.Text, txtvalor.Text, mskDcad.Text, cbolegenda.Text)

            tbProdutos = ClasseProdutos.ConsultaProduto(Val(lblCodigo.Text), cboProduto.Text)
            PreencheListaProdutos()
        Else
            Exit Sub
        End If
    End Sub
End Class
