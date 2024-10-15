
Public Class frmReserva
    Dim ClasseLocacao As New clsLocacao, ClasseCombo As New clsCombo, ClasseProdutos As New clsProdutos,
        tbClientes, tbProdutos, tbReserva As DataTable
    Dim sql As String
    Private Sub Limpar()
        cboCliente.Text = ""
        cboProduto.Text = ""
        txtCodReserva.Text = ""
        lstgrade.Items.Clear()
    End Sub
    Private Sub Habilitar()
        cboCliente.Enabled = True
        cboProduto.Enabled = True
        txtCodReserva.Enabled = True
    End Sub
    Private Sub Desabilitar()
        cboCliente.Enabled = False
        cboProduto.Enabled = False
        txtCodReserva.Enabled = False
    End Sub
    Private Sub CampoZero()
        If cboCliente.Text = "" Then
            cboCliente.Text = 0
        End If
        If cboProduto.Text = "" Then
            cboProduto.Text = 0
        End If
    End Sub
    Private Sub ConsultaReserva()
        Dim ReservaIni As String = "", ReservaFim As String = ""

        'Valida data de cadastro
        If dtpReservaIni.Checked = True And dtpReservaFim.Checked = True Then
            ReservaIni = dtpReservaIni.Value.ToString("yyyy-MM-dd")
            ReservaFim = dtpReservaFim.Value.ToString("yyyy-MM-dd")
        ElseIf dtpReservaIni.Checked = True And dtpReservaFim.Checked = False Then
            ReservaIni = dtpReservaIni.Value.ToString("yyyy-MM-dd")
        ElseIf dtpReservaIni.Checked = False And dtpReservaFim.Checked = True Then
            ReservaFim = dtpReservaFim.Value.ToString("yyyy-MM-dd")
        Else
            ReservaIni = ""
            ReservaFim = ""
        End If

        tbReserva = ClasseLocacao.PesquisaReserva(Val(lblCodigo.Text), ReservaIni, ReservaFim)
        ' Limpar ListView
        lstConsulta.Items.Clear()

        ' Verificar se tbPreco contém linhas
        If tbReserva.Rows.Count > 0 Then
            For Each row As DataRow In tbReserva.Rows
                ' Criar um novo item do ListView
                Dim listViewItem As New ListViewItem(If(IsDBNull(row("Codigo")), String.Empty, row("Codigo").ToString()))
                ' Adicionar subitens
                listViewItem.SubItems.Add(If(IsDBNull(row("Cliente")), String.Empty, row("Cliente").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("DataInicial")), String.Empty, row("DataInicial").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("DataFinal")), String.Empty, row("DataFinal").ToString()))
                listViewItem.SubItems.Add(If(IsDBNull(row("DataReserva")), String.Empty, row("DataReserva").ToString()))
                ' Adicionar o item ao ListView
                lstConsulta.Items.Add(listViewItem)
            Next
        Else
            MessageBox.Show("Essa reserva não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub cboCliente_Enter(sender As Object, e As EventArgs) Handles cboCliente.Enter
        Dim ListaCLientes = ClasseCombo.PreencherComboBox("SELECT * FROM tbEntidades WHERE Tipo = 'C' ORDER BY NomeFantasia", "Codigo", "NomeFantasia")
        With Me.cboCliente
            .DataSource = ListaCLientes
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub cboProduto_Enter(sender As Object, e As EventArgs) Handles cboProduto.Enter
        Dim ListaProdutos = ClasseCombo.PreencherComboBox("SELECT * FROM tbProdutos ORDER BY Titulo", "Codigo", "Titulo")
        With Me.cboProduto
            .DataSource = ListaProdutos
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub lstConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConsulta.SelectedIndexChanged
        If lstConsulta.SelectedItems.Count > 0 Then
            txtCodReserva.Text = Val(lstConsulta.SelectedItems(0).SubItems(0).Text)
            cboCliente.Text = lstConsulta.SelectedItems(0).SubItems(1).Text
            dtpInicio.Text = lstConsulta.SelectedItems(0).SubItems(2).Text
            dtpFim.Text = lstConsulta.SelectedItems(0).SubItems(3).Text
        End If
        lstgrade.Items.Clear()
        Dim tbReservaDet As DataTable = ClasseLocacao.ConsultaReserva("SELECT * FROM CS_ReservasProd WHERE Codigo = @CodReserva", Val(txtCodReserva.Text))
        Dim x As Integer = 0

        If tbReservaDet.Rows.Count > 0 Then
            For Each row As DataRow In tbReservaDet.Rows
                ' Adiciona o código (assumindo que nunca é nulo)
                lstgrade.Items.Add(row("CodProd").ToString())

                ' Adiciona os subitens, verificando se cada valor é nulo
                lstgrade.Items(x).SubItems.Add(If(IsDBNull(row("Titulo")), String.Empty, row("Titulo").ToString()))
                x += 1
            Next
        Else
            MessageBox.Show("Essa locação não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        tcReserva.SelectTab(1)
        AlterarToolStripButton.Enabled = True
        ExcluirToolStripButton.Enabled = True
        Habilitar()
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        ConsultaReserva()
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão da reserva?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseLocacao.IncluirReserva(cboCliente.SelectedValue, dtpInicio.Value, dtpFim.Value)
            For Each item As ListViewItem In lstgrade.Items
                ClasseLocacao.IncluirReservaProd(Val(txtCodReserva.Text), item.SubItems(0).Text)
            Next
            Limpar()
            Desabilitar()
            SalvarToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
        Else
            Exit Sub
        End If
    End Sub
    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        Dim tbLocacao As DataTable = ClasseLocacao.ConsultaLocacao("SELECT CASE WHEN IDENT_CURRENT('tbReservas') IS NULL THEN 1 ELSE IDENT_CURRENT('tbReservas')+1 END AS Codigo")
        txtCodReserva.Text = tbLocacao.Rows(0)("Codigo").ToString()
        Habilitar()
        SalvarToolStripButton.Enabled = True
        NovoToolStripButton.Enabled = False
        tcReserva.SelectTab(1)
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        If cboProduto.SelectedValue = 0 Then
            MessageBox.Show("Por favor, preencha todos os campos.")
            Exit Sub
            'fazer if para verificar se o título já foi reservado pelo mesmo cliente ou por outro cliente
        Else
            ' Cria um novo item para o ListView com o código do produto.
            Dim item As New ListViewItem(cboProduto.SelectedValue.ToString())

            ' Adiciona o nome do produto como subitem na segunda coluna.
            item.SubItems.Add(cboProduto.Text)

            ' Adiciona o item ao ListView.
            lstgrade.Items.Add(item)
        End If
        cboProduto.Text = ""
    End Sub
    Private Sub frmReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If lstgrade.SelectedItems.Count = 0 Then Exit Sub
        lstgrade.SelectedItems(0).Remove()
    End Sub
End Class