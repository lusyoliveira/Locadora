Public Class frmCadClientes
    Dim ClasseClientes As New clsClientes, tbClientes As DataTable

    Private Sub limpar()
        txtNome.Text = ""
        mskDnascimento.Text = ""
        cboEstadoCivil.Text = ""
        txtEndereco.Text = ""
        txtComplemento.Text = ""
        txtBairro.Text = ""
        rbdFeminino.Checked = False
        rbdMasculino.Checked = False
        txtCidade.Text = ""
        cboUf.Text = ""
        mskCep.Text = ""
        mskTel1.Text = ""
        mskTel2.Text = ""
        mskCel.Text = ""
        txtEmail.Text = ""
        mskrg.Text = ""
        mskcpf.Text = ""
        txtnome_dep.Text = ""
        mskDnasc.Text = ""
        txtnome_dep.Text = ""
        mskcpf_dep.Text = ""
        cbopzrentesco.Text = ""
        mskdtdatadep.Text = ""
        txtObs.Text = ""
        txtextra.Text = ""
        txtEmail.Text = ""
        lstgrade.Items.Clear()
    End Sub
    Private Sub PreencheListaClientes()
        Dim x As Integer = 0

        For Each row As DataRow In tbClientes.Rows
            lstgrade.Items.Add(row("codigo").ToString())
            lstgrade.Items(x).SubItems.Add(row("nome").ToString())
            lstgrade.Items(x).SubItems.Add(row("dtnasc").ToString())
            lstgrade.Items(x).SubItems.Add(row("telefone1").ToString())
            lstgrade.Items(x).SubItems.Add(row("email").ToString())
            lstgrade.Items(x).SubItems.Add(row("rg").ToString())
            lstgrade.Items(x).SubItems.Add(row("cpf").ToString())
            x += 1
        Next
    End Sub
    Private Sub frmCadClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbClientes = ClasseClientes.ConsultaCliente(Val(lblCodigo.Text), txtNome.Text)
        PreencheListaClientes()
    End Sub
    Private Sub txtNome_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            tbClientes = ClasseClientes.ConsultaCliente(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaClientes()
        End If
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        tbClientes = ClasseClientes.ConsultaCliente(Val(lblCodigo.Text), txtNome.Text)
        PreencheListaClientes()
    End Sub
    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        limpar()
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtNome.Focus()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.SalvarCliente(txtNome.Text, mskDnascimento.Text, mskTel1.Text, txtEmail.Text, mskrg.Text, mskcpf.Text)
            tbClientes = ClasseClientes.ConsultaCliente(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaClientes()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub lstgrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstgrade.SelectedIndexChanged
        If lstgrade.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstgrade.SelectedItems(0).SubItems(0).Text)
            lblCodigo.Text = lstgrade.SelectedItems(0).SubItems(1).Text
            txtNome.Text = lstgrade.SelectedItems(0).SubItems(2).Text
            mskDnascimento.Text = Format(CDate(lstgrade.SelectedItems(0).SubItems(0).Text), "dd/MM/yyyy")
            cboEstadoCivil.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtEndereco.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtComplemento.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtBairro.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtCidade.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            cboUf.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            mskCep.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            If lstgrade.SelectedItems(0).SubItems(0).Text Then
                rbdMasculino.Checked = True
            Else
                rbdFeminino.Checked = True
            End If
            mskTel1.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            mskTel2.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            mskCel.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtEmail.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            mskrg.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            mskcpf.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtnome_dep.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            mskdtdatadep.Text = Format(CDate(lstgrade.SelectedItems(0).SubItems(0).Text), "dd/MM/yyyy")
            mskcpf_dep.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            cbopzrentesco.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtObs.Text = lstgrade.SelectedItems(0).SubItems(0).Text
            txtextra.Text = lstgrade.SelectedItems(0).SubItems(0).Text
        End If
    End Sub
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.ExcluirCliente(Val(lblCodigo.Text))
            tbClientes = ClasseClientes.ConsultaCliente(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaClientes()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cboUf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUf.SelectedIndexChanged

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a alteração do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.AlterarCliente(Val(lblCodigo.Text), txtNome.Text, mskDnascimento.Text, mskTel1.Text, txtEmail.Text, mskrg.Text, mskcpf.Text)
            tbClientes = ClasseClientes.ConsultaCliente(Val(lblCodigo.Text), txtNome.Text)
            PreencheListaClientes()
        Else
            Exit Sub
        End If
    End Sub
End Class