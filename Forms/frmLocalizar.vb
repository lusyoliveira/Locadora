Imports System.Data
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class frmLocalizar
    Dim ClasseCombos As New clsCombo, tbClientes, tbProdutos As DataTable, sql As String, x As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub grpLocalizar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtLocalizar.Focus()
    End Sub
    Private Sub frmLocalizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        ClasseCombos.Localizar(cboItens.Text, lstLocalizar, txtLocalizar.Text)
    End Sub

    'Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
    '    Select Case cboItens.Text
    '        Case Is = "Clientes"
    '            frmCadClientes.Show()
    '            frmCadClientes.btnAlterar.Enabled = False
    '        Case Is = "Produtos"
    '            frmCadProdutos.Show()
    '            frmCadProdutos.btnExcluir.Enabled = False
    '    End Select
    'End Sub

    'Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
    '    Select Case cboItens.Text
    '        Case Is = "Clientes"
    '            frmCadClientes.Show()
    '            frmCadClientes.btnSalvar.Enabled = False
    '            frmCadClientes.btnAlterar.Enabled = False
    '        Case Is = "Produtos"
    '            frmCadProdutos.Show()
    '            frmCadProdutos.btnSalvar.Enabled = False
    '            frmCadProdutos.btnExcluir.Enabled = False
    '    End Select
    'End Sub

    'Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
    '    Select Case cboItens.Text
    '        Case Is = "Clientes"
    '            frmCadClientes.Show()
    '            frmCadClientes.btnSalvar.Enabled = False
    '        Case Is = "Produtos"
    '            frmCadProdutos.Show()
    '            frmCadProdutos.btnSalvar.Enabled = False

    '    End Select
    'End Sub
End Class