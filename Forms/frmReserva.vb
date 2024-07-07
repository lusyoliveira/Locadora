Imports System.Data.SqlClient

Public Class frmReserva
    Dim tbClientes, tbProdutos, TBRESERVA As DataTable
    Dim SQL As String
    Private Sub LIMPAR()
        CBO_CLIENTE.Text = ""
        CBO_PRODUTO.Text = ""
        lbltotal.Text = ""
        lblValorTotal.Text = ""
        lstgrade.Clear()
    End Sub
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
    End Sub
    Private Sub CBO_PORDUTO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBO_PRODUTO.GotFocus

        CarregaCombo(CBO_PRODUTO, "Select codigo ,titulo from tbProdutos order by titulo")
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

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If lblvalunit.Tag = "" Then Exit Sub

        Dim tbProdutos As DataTable = RecebeTabela("SELECT * FROM tbProdutos WHERE codigo = " & lblvalunit.Tag)
        If tbProdutos.Rows.Count = 0 Then Exit Sub

        Dim row As DataRow = tbProdutos.Rows(0)
        lstgrade.Items.Add(row("Titulo").ToString())
        lstgrade.Items(lstgrade.Items.Count - 1).SubItems.Add(FormatCurrency(row("valor").ToString()))
        lstgrade.Items(lstgrade.Items.Count - 1).Tag = row("codigo").ToString()

        atualizaValor()
    End Sub

    Private Sub CBO_PRODUTO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_PRODUTO.SelectedIndexChanged
        Dim tbProdutos As DataTable = RecebeTabela("SELECT * FROM tbProdutos WHERE titulo LIKE '" & CBO_PRODUTO.Text & "'")
        lblvalunit.Text = FormatCurrency(0)
        If tbProdutos.Rows.Count = 0 Then Exit Sub

        Dim row As DataRow = tbProdutos.Rows(0)
        lblvalunit.Text = FormatCurrency(row("valor").ToString())
        lblvalunit.Tag = row("codigo").ToString()
    End Sub

    Private Sub frmReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReservar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservar.Click
        On Error Resume Next
        CAMPOZERO()

        Dim TBRESERVA As DataTable = RecebeTabela("SELECT * FROM TBRESERVA")
        Dim newRow As DataRow = TBRESERVA.NewRow()
        newRow("CLIENTE").Value = LerCombo(CBO_CLIENTE)
        newRow("PRODUTO").Value = LerCombo(CBO_PRODUTO)
        newRow("DT_RESERVA").Value = DTP_RESERVA.Text
        newRow("DT_DEVOLUCAO").Value = DTP_DEVOLUCAO.Text
        newRow("VALOR").Value = lbltotal.Text

        TBRESERVA.Rows.Add(newRow)
        AtualizaBancoDados(TBRESERVA) ' Este método deve ser responsável por enviar as mudanças para o banco de dados.

        LIMPAR()
    End Sub
    Public Sub AtualizaBancoDados(ByVal tabela As DataTable)
        Dim connectionString As String = "sua_string_de_conexao_aqui" ' Substitua pela sua string de conexão
        Using connection As New SqlConnection(connectionString)
            Dim sql As String = "SELECT * FROM " & tabela.TableName
            Dim adapter As New SqlDataAdapter(sql, connection)
            Dim commandBuilder As New SqlCommandBuilder(adapter)

            Try
                connection.Open()
                adapter.Update(tabela)
            Catch ex As Exception
                MsgBox("Erro ao atualizar o banco de dados: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Class