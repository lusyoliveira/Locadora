Imports System.Data
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class frmCadClientes
    Dim ClasseClientes As New clsEntidades, ClasseDependentes As New clsDependente, ClasseCombo As New clsCombo, tbClientes As DataTable

    Private Sub Limpar()
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
        txtRazaoSocial.Text = ""
        txtEmail.Text = ""
        lstEntidade.Items.Clear()
        lstDependente.Items.Clear()
    End Sub
    Private Sub PreencherGridClientes()
        Dim tbClientes As DataTable = ClasseClientes.PesquisaEntidade(Val(lblCodigo.Text), txtNome.Text, "C")
        Dim x As Integer = 0
        If tbClientes.Rows.Count > 0 Then
            For Each row As DataRow In tbClientes.Rows
                lstEntidade.Items.Add(row("Codigo").ToString())
                lstEntidade.Items(x).SubItems.Add(row("NomeFantasia").ToString())
                lstEntidade.Items(x).SubItems.Add(row("RazaoSocial").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataNasc").ToString())
                lstEntidade.Items(x).SubItems.Add(row("EstadoCivil").ToString())
                lstEntidade.Items(x).SubItems.Add(row("endereco").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Complemento").ToString())
                lstEntidade.Items(x).SubItems.Add(row("bairro").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Cidade").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Uf").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Cep").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Sexo").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Rg").ToString())
                lstEntidade.Items(x).SubItems.Add(row("Documento").ToString())
                lstEntidade.Items(x).SubItems.Add(row("obs").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataCadastro").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataAlteracao").ToString())
                lstEntidade.Items(x).SubItems.Add(row("DataInativacao").ToString())
                x += 1
            Next
        Else
            MessageBox.Show("Essa entidade não Existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub frmCadClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstEntidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEntidade.SelectedIndexChanged
        If lstEntidade.SelectedItems.Count > 0 Then
            lblCodigo.Text = Val(lstEntidade.SelectedItems(0).SubItems(0).Text)
            txtNome.Text = lstEntidade.SelectedItems(0).SubItems(1).Text
            mskDnascimento.Text = Format(CDate(lstEntidade.SelectedItems(0).SubItems(3).Text), "dd/MM/yyyy")
            cboEstadoCivil.Text = lstEntidade.SelectedItems(0).SubItems(4).Text
            txtEndereco.Text = lstEntidade.SelectedItems(0).SubItems(5).Text
            txtComplemento.Text = lstEntidade.SelectedItems(0).SubItems(6).Text
            txtBairro.Text = lstEntidade.SelectedItems(0).SubItems(7).Text
            txtCidade.Text = lstEntidade.SelectedItems(0).SubItems(8).Text
            cboUf.Text = lstEntidade.SelectedItems(0).SubItems(9).Text
            mskCep.Text = lstEntidade.SelectedItems(0).SubItems(10).Text
            'If lstEntidade.SelectedItems(0).SubItems(11).Text = False Then
            '    rbdMasculino.Checked = True
            'Else
            '    rbdFeminino.Checked = True
            'End If
        End If
        Dim tbDependentes As DataTable = ClasseDependentes.ConsultaDependente("SELECT * FROM tbEntidadeDependente WHERE CodEntidade = @CodEntidade", Val(lblCodigo.Text))

        Dim x As Integer = 0
        For Each row As DataRow In tbDependentes.Rows
            lstDependente.Items.Add(row("Codigo").ToString())
            lstDependente.Items(x).SubItems.Add(row("NomeDependente").ToString())
            lstDependente.Items(x).SubItems.Add(row("DataNasc").ToString())
            lstDependente.Items(x).SubItems.Add(row("Documento").ToString())
            lstDependente.Items(x).SubItems.Add(row("Parentesco").ToString())

            If x Mod 2 = 0 Then
                lstDependente.Items(x).ForeColor = Color.Black
                lstDependente.Items(x).BackColor = Color.LightGray
            Else
                lstDependente.Items(x).ForeColor = Color.Black
                lstDependente.Items(x).BackColor = Color.White
            End If
            x += 1
        Next
        Dim tbContato As DataTable = ClasseClientes.ConsultaEntidade("SELECT * FROM tbEntidadeContatos WHERE CodEntidade = @CodEntidade", Val(lblCodigo.Text))
        mskTel1.Text = tbContato.Rows(0)("Telefone1").ToString()
        mskTel2.Text = tbContato.Rows(0)("Telefone2").ToString()
        mskCel.Text = tbContato.Rows(0)("Celular").ToString()
        txtEmail.Text = tbContato.Rows(0)("Email").ToString()
        SalvarToolStripButton.Enabled = False
        AlterarToolStripButton.Enabled = True
        ExcluirToolStripButton.Enabled = True
        NovoToolStripButton.Enabled = False
        tcCliente.SelectTab(1)
    End Sub

    Private Sub cboEstadoCivil_Enter(sender As Object, e As EventArgs) Handles cboEstadoCivil.Enter
        Dim ListaCivil = ClasseCombo.PreencherComboBox("SELECT * FROM tbEstadoCivil ORDER BY Descricao", "Codigo", "Descricao")
        With Me.cboEstadoCivil
            .DataSource = ListaCivil
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        rbdFeminino.Visible = True
        rbdMasculino.Visible = True
        txtNome.Focus()
        SalvarToolStripButton.Enabled = True
        AlterarToolStripButton.Enabled = False
        ExcluirToolStripButton.Enabled = False
        NovoToolStripButton.Enabled = False
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a inclusão do cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.SalvarEntidade(txtNome.Text, txtRazaoSocial.Text, mskDnascimento.Text, cboEstadoCivil.Text, txtEndereco.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, mskCep.Text, "", mskrg.Text, mskcpf.Text, txtObs.Text, "C")
            ClasseClientes.SalvarContato(Val(lblCodigo.Text), mskTel1.Text, mskTel2.Text, mskCel.Text, txtEmail.Text)
            Limpar()
            PreencherGridClientes()
            SalvarToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ConsultarToolStripButton_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripButton.Click
        PreencherGridClientes()
    End Sub

    Private Sub ExcluirToolStripButton_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripButton.Click
        Dim MsgResult As DialogResult = MessageBox.Show("Confirma a Exclusão?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MsgResult = DialogResult.Yes Then
            ClasseClientes.ExcluirContato(Val(lblCodigo.Text))
            ClasseClientes.ExcluirEntidade(Val(lblCodigo.Text))
            Limpar()
            PreencherGridClientes()
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
            ClasseClientes.AlterarEntidade(Val(lblCodigo.Text), txtNome.Text, txtRazaoSocial.Text, DateTime.Parse(mskDnascimento.Value).ToString("dd-MM-yyyy HH:mm:ss"), cboEstadoCivil.Text, txtEndereco.Text,
                                           txtComplemento.Text, txtBairro.Text, txtCidade.Text, cboUf.Text,
                                           mskCep.Text, "", mskrg.Text, mskcpf.Text, txtObs.Text)
            ClasseClientes.AlterarContato(Val(lblCodigo.Text), ClasseClientes.CodContato, mskTel1.Text, mskTel2.Text, mskCel.Text, txtEmail.Text)
            Limpar()
            PreencherGridClientes()
            SalvarToolStripButton.Enabled = False
            AlterarToolStripButton.Enabled = False
            ExcluirToolStripButton.Enabled = False
            NovoToolStripButton.Enabled = True
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cbopzrentesco_Enter(sender As Object, e As EventArgs) Handles cbopzrentesco.Enter
        Dim ListaParentesco = ClasseCombo.PreencherComboBox("SELECT * FROM tbParentesco ORDER BY Parentesco", "Codigo", "Parentesco")
        With Me.cbopzrentesco
            .DataSource = ListaParentesco
            .ValueMember = "Codigo"
            .DisplayMember = "Descricao"
            .SelectedIndex = "0"
        End With
    End Sub
End Class