
Imports System.Data
Imports Microsoft.Data.SqlClient
Imports System.Text
Imports System.Runtime.Versioning
<SupportedOSPlatform("windows")>
Public Class clsEntidades
    Dim ClasseConexao As New clsConexao
#Region "CONSTRUTORES"

#End Region
#Region "PROPRIEDADES"
    Private Property _CodEntidade As Integer
    Public Property CodEntidade As Integer
        Get
            Return _CodEntidade
        End Get
        Set(value As Integer)
            _CodEntidade = value
        End Set
    End Property
    Private Property _CodContato As Integer
    Public Property CodContato As Integer
        Get
            Return _CodContato
        End Get
        Set(value As Integer)
            _CodContato = value
        End Set
    End Property
    Private Property _CodCargo As Integer
    Public Property CodCargo As Integer
        Get
            Return _CodCargo
        End Get
        Set(value As Integer)
            _CodCargo = value
        End Set
    End Property
    Private Property _NumeroFicha As Integer
    Public Property NumeroFicha As Integer
        Get
            Return _NumeroFicha
        End Get
        Set(value As Integer)
            _NumeroFicha = value
        End Set
    End Property
    Private Property _NomeFantasia As String
    Public Property NomeFantasia As String
        Get
            Return _NomeFantasia
        End Get
        Set(value As String)
            _NomeFantasia = value
        End Set
    End Property
    Private Property _Telefone1 As String
    Public Property Telefone1 As String
        Get
            Return _Telefone1
        End Get
        Set(value As String)
            _Telefone1 = value
        End Set
    End Property
    Private Property _Telefone2 As String
    Public Property Telefone2 As String
        Get
            Return _Telefone2
        End Get
        Set(value As String)
            _Telefone2 = value
        End Set
    End Property
    Private Property _Celular As String
    Public Property Celular As String
        Get
            Return _Celular
        End Get
        Set(value As String)
            _Celular = value
        End Set
    End Property
    Private Property _Email As String
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property
    Private Property _Matricula As Integer
    Public Property Matricula As Integer
        Get
            Return _Matricula
        End Get
        Set(value As Integer)
            _Matricula = value
        End Set
    End Property
    Private Property _CarteiraProfissional As String
    Public Property CarteiraProfissional As String
        Get
            Return _CarteiraProfissional
        End Get
        Set(value As String)
            _CarteiraProfissional = value
        End Set
    End Property
    Private Property _Cargo As Integer
    Public Property Cargo As Integer
        Get
            Return _Cargo
        End Get
        Set(value As Integer)
            _Cargo = value
        End Set
    End Property
    Private Property _Salario As Decimal
    Public Property Salario As Decimal
        Get
            Return _Salario
        End Get
        Set(value As Decimal)
            _Salario = value
        End Set
    End Property
    Private Property _Expediente As String
    Public Property Expediente As String
        Get
            Return _Expediente
        End Get
        Set(value As String)
            _Expediente = value
        End Set
    End Property

#End Region
#Region "METODOS"
    Public Sub SalvarEntidade(NomeFantasia As String, RazaoSocial As String, Datanasc As String, Estadocivil As String, Endereco As String, Complemento As String, Bairro As String, Cidade As String, Uf As String, Cep As String, sexo As String, Rg As String, Documento As String, Obs As String, Tipo As String)

        Dim sql As String = "INSERT INTO tbEntidades   (NomeFantasia,
                                                           RazaoSocial,
                                                           Datanasc,
                                                           Estadocivil,
                                                           Endereco,
                                                           Complemento,
                                                           Bairro,
                                                           Cidade,
                                                           Uf,
                                                           Cep,
                                                           sexo,
                                                           Rg,
                                                           Documento,
                                                           Obs,
                                                           DataCadastro,
                                                           Tipo)
                                                VALUES     (@NomeFantasia,
                                                           @RazaoSocial,
                                                           @Datanasc,
                                                           @Estadocivil,
                                                           @Endereco,
                                                           @Complemento,
                                                           @Bairro,
                                                           @Cidade,
                                                           @Uf,
                                                           @Cep,
                                                           @sexo,
                                                           @Rg,
                                                           @Documento,
                                                           @Obs,
                                                           GETDATE(),
                                                           @Tipo)"
        Dim parameters As SqlParameter() = {
New SqlParameter("@NomeFantasia", NomeFantasia),
New SqlParameter("@RazaoSocial", RazaoSocial),
New SqlParameter("@Datanasc", Datanasc),
New SqlParameter("@Estadocivil", Estadocivil),
New SqlParameter("@Endereco", Endereco),
New SqlParameter("@Complemento", Complemento),
New SqlParameter("@Bairro", Bairro),
New SqlParameter("@Cidade", Cidade),
New SqlParameter("@Uf", Uf),
New SqlParameter("@Cep", Cep),
New SqlParameter("@sexo", sexo),
New SqlParameter("@Rg", Rg),
New SqlParameter("@Documento", Documento),
                        New SqlParameter("@Obs", Obs),
                        New SqlParameter("@Tipo", Tipo)
                      }
        ClasseConexao.Operar(sql, parameters)

                MessageBox.Show("Entidade salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub AlterarEntidade(codigo As Integer, NomeFantasia As String, RazaoSocial As String, Datanasc As String, Estadocivil As String, Endereco As String, Complemento As String, Bairro As String, Cidade As String, Uf As String, Cep As String, sexo As String, Rg As String, Documento As String, Obs As String)

        Dim sql As String = "UPDATE	tbEntidades
                               SET	NomeFantasia = @NomeFantasia,
		                            RazaoSocial = @RazaoSocial,
		                            Datanasc = @Datanasc,
		                            Estadocivil = @Estadocivil,
		                            Endereco = @Endereco,
		                            Complemento = @Complemento,
		                            Bairro = @Bairro,
		                            Cidade = @Cidade,
		                            Uf = @Uf,
		                            CEP = @Cep,
		                            sexo = @sexo,
		                            Rg = @Rg,
		                            Documento = @Documento,
		                            Obs = @Obs,
		                            DataAlteracao = GETDATE()
                             WHERE	Codigo = @Codigo"

        Dim parameters As SqlParameter() = {
                New SqlParameter("@Codigo", codigo),
                New SqlParameter("@NomeFantasia", NomeFantasia),
                New SqlParameter("@RazaoSocial", RazaoSocial),
                New SqlParameter("@Datanasc", Datanasc),
                New SqlParameter("@Estadocivil", Estadocivil),
                New SqlParameter("@Endereco", Endereco),
                New SqlParameter("@Complemento", Complemento),
                New SqlParameter("@Bairro", Bairro),
                New SqlParameter("@Cidade", Cidade),
                New SqlParameter("@Uf", Uf),
                New SqlParameter("@Cep", Cep),
                New SqlParameter("@sexo", sexo),
                New SqlParameter("@Rg", Rg),
                New SqlParameter("@Documento", Documento),
                New SqlParameter("@Obs", Obs)
              }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Entidade alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Public Sub ExcluirEntidade(codigo As Integer)

        Dim sql As String = "DELETE FROM tbEntidades WHERE Codigo = @Codigo"
        Dim parameters As SqlParameter() = {
                  New SqlParameter("@Codigo", codigo)
                  }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Entidade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub SalvarContato(CodEntidade As Integer, Telefone1 As String, Telefone2 As String, Celular As String, Email As String)

        Dim sql As String = "INSERT INTO    tbEntidadeContatos
                                                (CodEntidade,
                                                Telefone1,
                                                Telefone2,
                                                Celular,
                                                Email)
                                        VALUES
                                                (@CodEntidade,
                                                @Telefone1,
                                                @Telefone2,
                                                @Celular,
                                                @Email)"
        Dim parameters As SqlParameter() = {
                    New SqlParameter("@CodEntidade", CodEntidade),
                    New SqlParameter("@Telefone1", Telefone1),
                    New SqlParameter("@Telefone2", Telefone2),
                    New SqlParameter("@Celular", Celular),
                    New SqlParameter("@Email", Email)
                    }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Contato salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Public Sub AlterarContato(CodEntidade As Integer, Codigo As Integer, Telefone1 As String, Telefone2 As String, Celular As String, Email As String)

        Dim sql As String = "UPDATE	tbEntidadeContatos
                                SET     CodEntidade = @CodEntidade, 
                                        Telefone1 = @Telefone1,
                                        Telefone2 = @Telefone2,
                                        Celular = @Celular,
                                        Email = @Email
                                WHERE   Codigo = @Codigo AND CodEntidade = @CodEntidade"

        Dim parameters As SqlParameter() = {
                    New SqlParameter("@CodEntidade", CodEntidade),
                    New SqlParameter("@Codigo", Codigo),
                    New SqlParameter("@Telefone1", Telefone1),
                    New SqlParameter("@Telefone2", Telefone2),
                    New SqlParameter("@Celular", Celular),
                    New SqlParameter("@Email", Email)
                    }
        ClasseConexao.Operar(sql, parameters)
            MessageBox.Show("Contato alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Public Sub ExcluirContato(CodEntidade As Integer, Optional Codcontato As Integer = 0)

        If Codcontato <> 0 Then
            Dim sql As String = "DELETE FROM tbEntidadeContatos WHERE CodEntidade = @CodEntidade AND Codigo = @Codigo"
            Dim parameters As SqlParameter() = {
                    New SqlParameter("@CodEntidade", CodEntidade),
                    New SqlParameter("@Codigo", Codcontato)
                    }
            ClasseConexao.Operar(sql, parameters)
            MessageBox.Show("Contato excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim sql As String = "DELETE FROM tbEntidadeContatos WHERE CodEntidade = @CodEntidade"
            Dim parameters As SqlParameter() = {
                    New SqlParameter("@CodEntidade", CodEntidade),
                    New SqlParameter("@Codigo", Codcontato)
                    }
            ClasseConexao.Operar(sql, parameters)
            MessageBox.Show("Contato excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub SalvarCargo(CodEntidade As Integer, Matricula As Integer, CarteiraProfissional As String, Cargo As String, Salario As String, Expediente As String)

        Dim sql As String = "INSERT INTO tbEntidadeCargo   (CodEntidade,
                                                                   Matricula,
                                                                   CarteiraProfissional,
                                                                   Cargo,
                                                                   Salario,
                                                                   Expediente,
                                                                   GETDATE())
                                        VALUES                     (@CodEntidade,
                                                                   @Matricula,
                                                                   @CarteiraProfissional,
                                                                   @Cargo,
                                                                   @Salario,
                                                                   @Expediente,
                                                                   @DataCadastro)"
        Dim parameters As SqlParameter() = {
                    New SqlParameter("@CodEntidade", CodEntidade),
                    New SqlParameter("@Matricula", Matricula),
                    New SqlParameter("@CarteiraProfissional", CarteiraProfissional),
                    New SqlParameter("@Cargo", Cargo),
                    New SqlParameter("@Salario", Salario),
                    New SqlParameter("@Expediente", Expediente)
                    }
        ClasseConexao.Operar(sql, parameters)

        MessageBox.Show("Cargo salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub AlterarCargo(CodEntidade As Integer, Codigo As Integer, Matricula As Integer, CarteiraProfissional As String, Cargo As String, Salario As String, Expediente As String)

        Dim sql As String = "UPDATE	tbEntidadeCargo
                                    SET     CodEntidade = @CodEntidade, 
                                            Matricula = @Matricula,
                                            CarteiraProfissional = @CarteiraProfissional,
                                            Cargo = @Cargo,
                                            Salario = @Salario,
                                            Expediente = @Expediente,
                                            DataAlteracao = GETDATE()
                                WHERE   Codigo = @Codigo AND CodEntidade = @CodEntidade"
        Dim parameters As SqlParameter() = {
                  New SqlParameter("@CodEntidade", CodEntidade),
                  New SqlParameter("@Matricula", Matricula),
                  New SqlParameter("@CarteiraProfissional", CarteiraProfissional),
                  New SqlParameter("@Cargo", Cargo),
                  New SqlParameter("@Salario", Salario),
                  New SqlParameter("@Expediente", Expediente)
                  }
        ClasseConexao.Operar(sql, parameters)
        MessageBox.Show("Cargo alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Public Sub ExcluirCargo(CodEntidade As Integer, Optional CodCargo As Integer = 0)
        If CodCargo <> 0 Then
            Dim sql As String = "DELETE FROM tbEntidadeCargo WHERE CodEntidade = @CodEntidade AND Codigo = @CodCargo"

            Dim parameters As SqlParameter() = {
                      New SqlParameter("@CodEntidade", CodEntidade),
                      New SqlParameter("@CodCargo", CodCargo)
                      }
            ClasseConexao.Operar(sql, parameters)
            MessageBox.Show("Cargo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim sql As String = "DELETE FROM tbEntidadeCargo WHERE CodEntidade = @CodEntidade"

            Dim parameters As SqlParameter() = {
                  New SqlParameter("@CodEntidade", CodEntidade)
                  }
            ClasseConexao.Operar(sql, parameters)
            MessageBox.Show("Cargo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region
#Region "FUNCOES"
    Public Function PesquisaEntidade(Codigo As Integer, NomeFantasia As String, Tipo As String) As DataTable
        Dim sql As New StringBuilder("SELECT * FROM tbEntidades WHERE 1=1")
        Dim parameters As New List(Of SqlParameter)()

        Try
            If Codigo <> 0 Then
                sql.AppendLine("AND Codigo = @Codigo")
                parameters.Add(New SqlParameter("@Codigo", Codigo))
            End If

            If Not String.IsNullOrEmpty(NomeFantasia) Then
                sql.AppendLine("AND NomeFantasia LIKE @NomeFantasia")
                parameters.Add(New SqlParameter("@Nome", "%" & NomeFantasia & "%"))
            End If

            If Not String.IsNullOrEmpty(Tipo) Then
                sql.AppendLine("AND Tipo = @Tipo")
                parameters.Add(New SqlParameter("@Tipo", Tipo))
            End If

            sql.AppendLine("ORDER BY NomeFantasia")

            Return ClasseConexao.Consultar(sql.ToString(), parameters.ToArray())

        Catch ex As Exception
            MessageBox.Show("Erro ao consultar a entidades: " & ex.Message)
        End Try
    End Function
    Public Function ConsultaEntidade(sql As String, CodEntidade As Integer)
        Dim parameters As SqlParameter() = {
                   New SqlParameter("@CodEntidade", CodEntidade)
                      }
        Return ClasseConexao.Consultar(sql, parameters)
    End Function
#End Region
End Class
