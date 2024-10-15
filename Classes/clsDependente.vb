Imports System.Data.SqlClient

Public Class clsDependente
    Dim ClasseConexao As New clsConexao
#Region "PROPRIEDADES"

#End Region
#Region "CONSTRUTORES"

#End Region
#Region "METODOS"
    Public Sub SalvarDependente(CodEntidade As Integer, NomeDependente As String, DataNasc As String, Documento As String, Parentesco As Integer)

        Dim sql As String = "INSERT INTO tbEntidadeDependente   (CodEntidade,
                                                                        NomeDependente,
                                                                        DataNasc,
                                                                        Documento,
                                                                        Parentesco,
                                                                        DataCadastro)
                                            VALUES                      (@CodEntidade, 
                                                                        @NomeDependente, 
                                                                        @DataNasc, 
                                                                        @Documento, 
                                                                        @Parentesco, 
                                                                        GETDATE())"
        Dim parameters As SqlParameter() = {
                    New SqlParameter("@CodEntidade", CodEntidade),
                    New SqlParameter("@NomeDependente", NomeDependente),
                    New SqlParameter("@DataNasc", DataNasc),
                    New SqlParameter("@Documento", Documento),
                    New SqlParameter("@Parentesco", Parentesco)
                      }
        ClasseConexao.Operar(sql, parameters)
    End Sub
    Public Sub AlterarDependente(CodEntidade As Integer, CodDependente As Integer, NomeDependente As String, DataNasc As String, Documento As String, Parentesco As Integer)

        Dim sql As String = "UPDATE tbEntidadeDependente 
                                    SET  
                                            CodEntidade = @CodEntidade,
                                            NomeDependente = @NomeDependente,
                                            DataNasc = @DataNasc,
                                            Documento = @Documento,
                                            Parentesco = @Parentesco,
                                            DataAlteracao = GETDATE()
                                   WHERE   CodEntidade = @CodEntidade 
                                    AND     Codigo = @CodDependente"

        Dim parameters As SqlParameter() = {
    New SqlParameter("@CodEntidade", CodEntidade),
    New SqlParameter("@CodDependente", CodDependente),
    New SqlParameter("@NomeDependente", NomeDependente),
    New SqlParameter("@DataNasc", DataNasc),
    New SqlParameter("@Documento", Documento),
    New SqlParameter("@Parentesco", Parentesco)
      }
        ClasseConexao.Operar(sql, parameters)
    End Sub
    Public Sub ExcluirDependente(CodEntidade As Integer, CodDependente As Integer)
        If CodDependente <> 0 Then
            Dim sql As String = "DELETE FROM tbEntidadeDependente WHERE CodEntidade = @CodEntidade"
            Dim parameters As SqlParameter() = {
                New SqlParameter("@CodEntidade", CodEntidade)
                  }
            ClasseConexao.Operar(sql, parameters)
        Else
            Dim sql As String = "DELETE FROM tbEntidadeDependente WHERE CodEntidade = @CodEntidade AND Codigo = @CodDependente"
            Dim parameters As SqlParameter() = {
                New SqlParameter("@CodEntidade", CodEntidade),
                New SqlParameter("@CodDependente", CodDependente)
                  }
            ClasseConexao.Operar(sql, parameters)
        End If

    End Sub
#End Region
#Region "FUNCOES"
    Public Function ConsultaDependente(sql As String, CodEntidade As Integer)
        Dim Tabela As New DataTable

        Dim parameters As SqlParameter() = {
                   New SqlParameter("@CodEntidade", CodEntidade)
                      }
        Return ClasseConexao.Consultar(sql, parameters)

    End Function
#End Region
End Class
