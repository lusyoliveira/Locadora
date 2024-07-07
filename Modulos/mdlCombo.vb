Module mdlCombo
    Public Sub CarregaCombo(ByVal ComboRec As ComboBox, ByVal Sql As String)
        ' Carrega o combobox
        Dim Lista As New ArrayList()
        Dim Tabela As DataTable

        Lista.Clear()
        ComboRec.AutoCompleteCustomSource.Clear()
        Tabela = RecebeTabela(Sql)

        If Tabela.Rows.Count <> 0 Then
            For Each row As DataRow In Tabela.Rows
                Lista.Add(New clsCombo(row(0), row(1).ToString()))
                ComboRec.AutoCompleteCustomSource.Add(row(1).ToString())
            Next
        End If

        ComboRec.DisplayMember = "Descricao"
        ComboRec.ValueMember = "Valor"
        ComboRec.DataSource = Lista
        ComboRec.Text = ""
        ComboRec.SelectedIndex = -1
    End Sub

    Public Function LerCombo(ByVal ComboRec As ComboBox) As String
        Dim Selecionado As String
        Try
            Selecionado = CType(ComboRec.SelectedItem, clsCombo).Valor.ToString
        Catch ex As Exception
            Selecionado = ""
        End Try
        Return Selecionado
    End Function

    Public Sub SelecionarCombo(ByRef ComboRec As ComboBox, ByVal Valor As String)
        Dim Selecionado As String, x As Integer
        Try
            For x = 0 To ComboRec.Items.Count - 1
                If CType(ComboRec.Items(x), clsCombo).Valor.ToString = Valor Then
                    ComboRec.SelectedIndex = x
                    Exit For
                End If
            Next
        Catch ex As Exception
            Selecionado = ""
        End Try
    End Sub

End Module


