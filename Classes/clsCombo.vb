Public Class clsCombo
    Public Valor As Object
    Public Descricao As String

    Public Sub New(ByVal NovoValor As Object, ByVal NovaDescricao As String)
        Valor = NovoValor
        Descricao = NovaDescricao
    End Sub

    Public Overrides Function ToString() As String
        Return Descricao
    End Function

End Class
