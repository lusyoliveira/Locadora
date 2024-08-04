Public Class frmCadProdutos
    Dim tbProdutos As DataTable, ClasseProdutos As New clsProdutos, ClasseCombo As New clsCombo
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
        txtoriginal.Text = ""
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
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
        ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.SalvarProduto(cboProduto.Text, txtTitulo.Text, txtAutor.Text, cboGenero.Text, txtCensura.Text, txtDuracao.Text, txtvalor.Text, mskDcad.Text, cbolegenda.Text)
            ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.ExcluirProduto(Val(lblCodigo.Text))
            ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFilmes.SelectedIndexChanged
        If lstFilmes.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstFilmes.SelectedItems(0).SubItems(0).Text)
            cboProduto.Text = lstFilmes.SelectedItems(0).SubItems(1).Text
            txtTitulo.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
            txtAutor.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
            cboGenero.Text = lstFilmes.SelectedItems(0).SubItems(3).Text
            txtCensura.Text = lstFilmes.SelectedItems(0).SubItems(4).Text
            ' txtDuracao.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
            '  txtQuantidade.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
            ' txtoriginal.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
            ' txtvalor.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
            mskDcad.Text = lstFilmes.SelectedItems(0).SubItems(5).Text
            'cbolegenda.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub cboGenero_Enter(sender As Object, e As EventArgs) Handles cboGenero.Enter
        Dim ListaGenero = ClasseCombo.PreencherComboBox("SELECT * FROM tbGenero ORDER BY Genero", "Codigo", "Genero")
        With Me.cboGenero
            .DataSource = ListaGenero
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboProduto_Enter(sender As Object, e As EventArgs) Handles cboProduto.Enter

    End Sub

    Private Sub cbolegenda_Enter(sender As Object, e As EventArgs) Handles cbolegenda.Enter
        Dim ListaLegenda = ClasseCombo.PreencherComboBox("SELECT * FROM tbLegenda ORDER BY Legenda", "Codigo", "Legenda")
        With Me.cbolegenda
            .DataSource = ListaLegenda
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub AtualizaBancoDados(ByVal dt As DataTable)
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.AlterarProduto(Val(lblCodigo.Text), cboProduto.Text, txtTitulo.Text, txtAutor.Text, cboGenero.Text, txtCensura.Text, txtDuracao.Text, txtvalor.Text, mskDcad.Text, cbolegenda.Text)

            ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
        Else
            Exit Sub
        End If
    End Sub
End Class
