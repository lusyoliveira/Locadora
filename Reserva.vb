Public Class frmReserva
    Dim tbClientes As ADODB.Recordset
    Dim tbProdutos As ADODB.Recordset
    Dim TBRESERVA As ADODB.Recordset
    Dim SQL As String
    Private Sub CAMPOZERO()
        If CBO_CLIENTE.Text = "" Then
            CBO_CLIENTE.Text = 0
        End If
        If CBO_PRODUTO.Text = "" Then
            CBO_PRODUTO.Text = 0
        End If
    End Sub
    Private Sub cboCliente_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBO_CLIENTE.GotFocus
        CarregaCombo(CBO_CLIENTE, "Select codigo ,nome from tbClientes order by nome")
        'Dim tbClientes As ADODB.Recordset
        'cboCliente.Items.Clear()
        'tbClientes = RecebeTabela("Select * from tbClientes order by nome")
        'If tbClientes.RecordCount <> 0 Then
        '    tbClientes.MoveFirst()
        '    While tbClientes.EOF = False
        '        cboCliente.Items.Add(tbClientes.Fields("nome").Value.ToString)
        '        tbClientes.MoveNext()
        '    End While
        'End If
    End Sub
    Private Sub CBO_PORDUTO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBO_PRODUTO.GotFocus

        CarregaCombo(CBO_PRODUTO, "Select codigo ,titulo from tbProdutos order by titulo")
        'Dim tbProdutos As ADODB.Recordset
        'CBO_PRODUTO.Items.Clear()
        'tbProdutos = RecebeTabela("Select * from tbProdutos order by titulo")
        'If tbProdutos.RecordCount <> 0 Then
        '    tbProdutos.MoveFirst()
        '    Do Until tbProdutos.EOF
        '        CBO_PRODUTO.Items.Add(tbProdutos.Fields("titulo").Value.ToString)
        '        tbProdutos.MoveNext()
        '    Loop
        'End If
    End Sub
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        '' Dim tbReserva As ADODB.Record
        If lblvalunit.Tag = "" Then Exit Sub
        Dim tbProdutos As ADODB.Recordset
        tbProdutos = RecebeTabela("Select * from tbProdutos where codigo = " & lblvalunit.Tag)
        If tbProdutos.RecordCount = 0 Then Exit Sub
        tbProdutos.MoveFirst()
        lstgrade.Items.Add(tbProdutos("Titulo").Value.ToString)
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(FormatCurrency(tbProdutos("valor").Value.ToString))
        lstgrade.Items(lstgrade.Items.Count - 1).Tag = tbProdutos("codigo").Value.ToString


        atualizaValor()
    End Sub
    Private Sub atualizaValor()
        Dim x As Integer, total As Decimal = 0
        If lstgrade.Items.Count > 0 Then
            For x = 0 To lstgrade.Items.Count - 1
                total += lstgrade.Items(x).SubItems(1).Text
            Next
            lbltotal.Text = FormatCurrency(total)
        Else
            lbltotal.Text = 0
        End If
    End Sub
    Private Sub CBO_PRODUTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_PRODUTO.SelectedIndexChanged

        Dim tbProdutos As ADODB.Recordset
        tbProdutos = RecebeTabela("Select * from tbProdutos where titulo like '" & CBO_PRODUTO.Text & "'")
        lblvalunit.Text = FormatCurrency(0)
        If tbProdutos.RecordCount = 0 Then Exit Sub
        tbProdutos.MoveFirst()
        lblvalunit.Text = FormatCurrency(tbProdutos("valor").Value.ToString)
        lblvalunit.Tag = tbProdutos("codigo").Value.ToString
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If lstgrade.SelectedItems.Count = 0 Then Exit Sub
        lstgrade.SelectedItems(0).Remove()
        atualizaValor()
        CBO_PRODUTO.Text = ""
        lblvalunit.Text = ""
    End Sub
    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservar.Click
        On Error Resume Next
        CAMPOZERO()
        SQL = "select * from TBRESERVA "
        TBRESERVA = RecebeTabela(Sql)
        TBRESERVA.AddNew()
        TBRESERVA("CLIENTE").Value = LerCombo(CBO_CLIENTE)
        TBRESERVA("PRODUTO").Value = LerCombo(CBO_PRODUTO)
        TBRESERVA("DT_RESERVA").Value = DTP_RESERVA.Text
        TBRESERVA("DT_DEVOLUCAO").Value = DTP_DEVOLUCAO.Text
        TBRESERVA("VALOR").Value = lbltotal.Text
        TBRESERVA.Update()
        LIMPAR()
    End Sub
    Private Sub LIMPAR()
        CBO_CLIENTE.Text = ""
        CBO_PRODUTO.Text = ""
        lbltotal.Text = ""
        lblValorTotal.Text = ""
        lstgrade.Clear()


    End Sub
    Private Sub cboCliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_CLIENTE.SelectedIndexChanged

    End Sub

    Private Sub frmReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblvalunit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvalunit.Click

    End Sub
End Class