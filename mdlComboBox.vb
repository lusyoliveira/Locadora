Module mdlComboBox

    Public Sub CarregaCombo(ByVal ComboRec As ComboBox, ByVal Sql As String)
        ' Carrega o combox
        Dim Lista As New ArrayList()
        Dim Tabela As ADODB.Recordset

        Lista.Clear()
        'ComboRec.Items.Clear()
        ComboRec.AutoCompleteCustomSource.Clear()
        Tabela = RecebeTabela(Sql)
        If Tabela.RecordCount <> 0 Then
            Tabela.MoveFirst()
            While Tabela.EOF = False
                Lista.Add(New clsConteudoCombo(Tabela.Fields(0).Value, Tabela.Fields(1).Value.ToString))
                ComboRec.AutoCompleteCustomSource.Add(Tabela.Fields(1).Value.ToString)
                Tabela.MoveNext()
            End While
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
            Selecionado = CType(ComboRec.SelectedItem, clsConteudoCombo).Valor.ToString
        Catch ex As Exception
            Selecionado = ""
        End Try
        Return Selecionado
    End Function

    Public Sub SelecionarCombo(ByRef ComboRec As ComboBox, ByVal Valor As String)
        Dim Selecionado As String, x As Integer
        Try
            For x = 0 To ComboRec.Items.Count - 1
                If CType(ComboRec.Items(x), clsConteudoCombo).Valor.ToString = Valor Then
                    ComboRec.SelectedIndex = x
                    Exit For
                End If
            Next
        Catch ex As Exception
            Selecionado = ""
        End Try
    End Sub
End Module
