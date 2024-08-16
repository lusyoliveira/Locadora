Public Class frmCadProdutos
    Dim tbProdutos As DataTable, ClasseProdutos As New clsProdutos, ClasseCombo As New clsCombo
    Private Sub Limpar()
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
        lstFilmes.Items.Clear()
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
    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstFilmes.SelectedIndexChanged
        If lstFilmes.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstFilmes.SelectedItems(0).SubItems(0).Text)
            cboProduto.Text = lstFilmes.SelectedItems(0).SubItems(1).Text
            txtTitulo.Text = lstFilmes.SelectedItems(0).SubItems(2).Text
            cboGenero.Text = lstFilmes.SelectedItems(0).SubItems(3).Text
            txtCensura.Text = lstFilmes.SelectedItems(0).SubItems(4).Text
            cbolegenda.Text = lstFilmes.SelectedItems(0).SubItems(5).Text
            txtAutor.Text = lstFilmes.SelectedItems(0).SubItems(6).Text
            txtDuracao.Text = lstFilmes.SelectedItems(0).SubItems(7).Text
            txtQuantidade.Text = lstFilmes.SelectedItems(0).SubItems(8).Text
            txtvalor.Text = lstFilmes.SelectedItems(0).SubItems(9).Text
            mskDcad.Text = lstFilmes.SelectedItems(0).SubItems(10).Text
        End If
    End Sub
    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        SalvarToolStripButton.Enabled = True
        AlterarToolStripButton.Enabled = False
        ExcluirToolStripButton.Enabled = False
        NovoToolStripButton.Enabled = False
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.SalvarProduto(cboProduto.Text, txtTitulo.Text, txtAutor.Text, cboGenero.Text, txtCensura.Text, txtDuracao.Text, txtvalor.Text, mskDcad.Text, cbolegenda.Text)
            Limpar()
            ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
            SalvarToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub AlterarToolStripButton_Click(sender As Object, e As EventArgs) Handles AlterarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.AlterarProduto(Val(lblCodigo.Text), cboProduto.Text, txtTitulo.Text, txtAutor.Text, cboGenero.Text, txtCensura.Text, txtDuracao.Text, txtvalor.Text, mskDcad.Text, cbolegenda.Text)
            Limpar()
            ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
            SalvarToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ExcluirToolStripButton_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseProdutos.ExcluirProduto(Val(lblCodigo.Text))
            Limpar()
            ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
            SalvarToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        ClasseProdutos.ConsultaProduto(lstFilmes, Val(lblCodigo.Text), cboProduto.Text)
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
    Private Sub cbolegenda_Enter(sender As Object, e As EventArgs) Handles cbolegenda.Enter
        Dim ListaLegenda = ClasseCombo.PreencherComboBox("SELECT * FROM tbLegenda ORDER BY Legenda", "Codigo", "Legenda")
        With Me.cbolegenda
            .DataSource = ListaLegenda
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub


End Class
