<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGerarFinanceiro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnGerarParcelas = New System.Windows.Forms.Button()
        Me.lblNrFicha2 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblDescEntidade = New System.Windows.Forms.Label()
        Me.dgvParcelas = New System.Windows.Forms.DataGridView()
        Me.Parcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vencimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vlrParcela = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotalFinal2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblNrPacelas = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboFormaPgto = New System.Windows.Forms.ComboBox()
        Me.cboCobranca = New System.Windows.Forms.ComboBox()
        Me.txtAcrescimo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTaxas = New System.Windows.Forms.TextBox()
        Me.txtMulta = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboEntidade = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAtraso = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(58, 15)
        Me.Label21.TabIndex = 132
        Me.Label21.Text = "Cobrança"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(332, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 15)
        Me.Label20.TabIndex = 131
        Me.Label20.Text = "Forma de Pagamento"
        '
        'btnGerarParcelas
        '
        Me.btnGerarParcelas.Location = New System.Drawing.Point(505, 154)
        Me.btnGerarParcelas.Name = "btnGerarParcelas"
        Me.btnGerarParcelas.Size = New System.Drawing.Size(86, 23)
        Me.btnGerarParcelas.TabIndex = 133
        Me.btnGerarParcelas.Text = "Gerar Parcela"
        Me.btnGerarParcelas.UseVisualStyleBackColor = True
        '
        'lblNrFicha2
        '
        Me.lblNrFicha2.AutoSize = True
        Me.lblNrFicha2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrFicha2.Location = New System.Drawing.Point(9, 37)
        Me.lblNrFicha2.Name = "lblNrFicha2"
        Me.lblNrFicha2.Size = New System.Drawing.Size(68, 15)
        Me.lblNrFicha2.TabIndex = 136
        Me.lblNrFicha2.Text = "Nº Locação"
        '
        'lblCodigo
        '
        Me.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodigo.Location = New System.Drawing.Point(12, 58)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(76, 20)
        Me.lblCodigo.TabIndex = 139
        Me.lblCodigo.Text = "0"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescEntidade
        '
        Me.lblDescEntidade.AutoSize = True
        Me.lblDescEntidade.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescEntidade.Location = New System.Drawing.Point(91, 39)
        Me.lblDescEntidade.Name = "lblDescEntidade"
        Me.lblDescEntidade.Size = New System.Drawing.Size(53, 15)
        Me.lblDescEntidade.TabIndex = 137
        Me.lblDescEntidade.Text = "Entidade"
        '
        'dgvParcelas
        '
        Me.dgvParcelas.AllowUserToAddRows = False
        Me.dgvParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvParcelas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvParcelas.ColumnHeadersHeight = 29
        Me.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvParcelas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parcela, Me.Vencimento, Me.vlrParcela})
        Me.dgvParcelas.Location = New System.Drawing.Point(12, 183)
        Me.dgvParcelas.Name = "dgvParcelas"
        Me.dgvParcelas.RowHeadersWidth = 51
        Me.dgvParcelas.Size = New System.Drawing.Size(664, 192)
        Me.dgvParcelas.TabIndex = 141
        '
        'Parcela
        '
        Me.Parcela.HeaderText = "Parcela"
        Me.Parcela.MinimumWidth = 6
        Me.Parcela.Name = "Parcela"
        Me.Parcela.Width = 68
        '
        'Vencimento
        '
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Vencimento.DefaultCellStyle = DataGridViewCellStyle5
        Me.Vencimento.HeaderText = "Vencimento"
        Me.Vencimento.MinimumWidth = 6
        Me.Vencimento.Name = "Vencimento"
        Me.Vencimento.Width = 88
        '
        'vlrParcela
        '
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.vlrParcela.DefaultCellStyle = DataGridViewCellStyle6
        Me.vlrParcela.HeaderText = "Valor da Parcela"
        Me.vlrParcela.MinimumWidth = 6
        Me.vlrParcela.Name = "vlrParcela"
        Me.vlrParcela.Width = 110
        '
        'lblTotalFinal2
        '
        Me.lblTotalFinal2.AutoSize = True
        Me.lblTotalFinal2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFinal2.Location = New System.Drawing.Point(332, 135)
        Me.lblTotalFinal2.Name = "lblTotalFinal2"
        Me.lblTotalFinal2.Size = New System.Drawing.Size(89, 15)
        Me.lblTotalFinal2.TabIndex = 143
        Me.lblTotalFinal2.Text = "Total do Pedido"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(335, 154)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 20)
        Me.lblTotal.TabIndex = 142
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(596, 154)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(80, 23)
        Me.btnConfirmar.TabIndex = 144
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'lblNrPacelas
        '
        Me.lblNrPacelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNrPacelas.Location = New System.Drawing.Point(423, 154)
        Me.lblNrPacelas.Name = "lblNrPacelas"
        Me.lblNrPacelas.Size = New System.Drawing.Size(75, 20)
        Me.lblNrPacelas.TabIndex = 147
        Me.lblNrPacelas.Text = "0"
        Me.lblNrPacelas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Nº de Parcelas"
        '
        'cboFormaPgto
        '
        Me.cboFormaPgto.DisplayMember = "Cod_Pgto"
        Me.cboFormaPgto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaPgto.FormattingEnabled = True
        Me.cboFormaPgto.Location = New System.Drawing.Point(335, 106)
        Me.cboFormaPgto.Name = "cboFormaPgto"
        Me.cboFormaPgto.Size = New System.Drawing.Size(342, 21)
        Me.cboFormaPgto.TabIndex = 151
        Me.cboFormaPgto.ValueMember = "Cod_Pgto"
        '
        'cboCobranca
        '
        Me.cboCobranca.DisplayMember = "Codigo"
        Me.cboCobranca.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCobranca.FormattingEnabled = True
        Me.cboCobranca.Location = New System.Drawing.Point(12, 106)
        Me.cboCobranca.Name = "cboCobranca"
        Me.cboCobranca.Size = New System.Drawing.Size(318, 21)
        Me.cboCobranca.TabIndex = 152
        Me.cboCobranca.ValueMember = "Codigo"
        '
        'txtAcrescimo
        '
        Me.txtAcrescimo.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAcrescimo.Location = New System.Drawing.Point(254, 153)
        Me.txtAcrescimo.Name = "txtAcrescimo"
        Me.txtAcrescimo.Size = New System.Drawing.Size(76, 21)
        Me.txtAcrescimo.TabIndex = 210
        Me.txtAcrescimo.Text = "0,00"
        Me.txtAcrescimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(252, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 15)
        Me.Label16.TabIndex = 214
        Me.Label16.Text = "Acréscimo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 211
        Me.Label1.Text = "Desconto"
        '
        'txtTaxas
        '
        Me.txtTaxas.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxas.Location = New System.Drawing.Point(174, 153)
        Me.txtTaxas.Name = "txtTaxas"
        Me.txtTaxas.Size = New System.Drawing.Size(76, 22)
        Me.txtTaxas.TabIndex = 209
        Me.txtTaxas.Text = "0,00"
        Me.txtTaxas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMulta
        '
        Me.txtMulta.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMulta.Location = New System.Drawing.Point(93, 153)
        Me.txtMulta.Name = "txtMulta"
        Me.txtMulta.Size = New System.Drawing.Size(76, 22)
        Me.txtMulta.TabIndex = 208
        Me.txtMulta.Text = "0,00"
        Me.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesconto
        '
        Me.txtDesconto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesconto.Location = New System.Drawing.Point(12, 153)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(76, 22)
        Me.txtDesconto.TabIndex = 207
        Me.txtDesconto.Text = "0,00"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(90, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 15)
        Me.Label19.TabIndex = 212
        Me.Label19.Text = "Multa"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(171, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 15)
        Me.Label22.TabIndex = 213
        Me.Label22.Text = "Taxas"
        '
        'cboEntidade
        '
        Me.cboEntidade.DisplayMember = "Codigo"
        Me.cboEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEntidade.FormattingEnabled = True
        Me.cboEntidade.Location = New System.Drawing.Point(94, 57)
        Me.cboEntidade.Name = "cboEntidade"
        Me.cboEntidade.Size = New System.Drawing.Size(494, 21)
        Me.cboEntidade.TabIndex = 215
        Me.cboEntidade.ValueMember = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(591, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Dias de Atraso"
        '
        'lblAtraso
        '
        Me.lblAtraso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAtraso.Location = New System.Drawing.Point(594, 58)
        Me.lblAtraso.Name = "lblAtraso"
        Me.lblAtraso.Size = New System.Drawing.Size(82, 20)
        Me.lblAtraso.TabIndex = 216
        Me.lblAtraso.Text = "0"
        Me.lblAtraso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.DarkRed
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 28)
        Me.Panel1.TabIndex = 218
        '
        'frmGerarFinanceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAtraso)
        Me.Controls.Add(Me.cboEntidade)
        Me.Controls.Add(Me.txtAcrescimo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTaxas)
        Me.Controls.Add(Me.txtMulta)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cboCobranca)
        Me.Controls.Add(Me.cboFormaPgto)
        Me.Controls.Add(Me.lblNrPacelas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.lblTotalFinal2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvParcelas)
        Me.Controls.Add(Me.lblNrFicha2)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblDescEntidade)
        Me.Controls.Add(Me.btnGerarParcelas)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGerarFinanceiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geração do Financeiro"
        CType(Me.dgvParcelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btnGerarParcelas As Button
    Friend WithEvents lblNrFicha2 As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblDescEntidade As Label
    Friend WithEvents dgvParcelas As DataGridView
    Friend WithEvents lblTotalFinal2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents lblNrPacelas As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Parcela As DataGridViewTextBoxColumn
    Friend WithEvents Vencimento As DataGridViewTextBoxColumn
    Friend WithEvents vlrParcela As DataGridViewTextBoxColumn
    Friend WithEvents cboFormaPgto As ComboBox
    Friend WithEvents cboCobranca As ComboBox
    Friend WithEvents txtAcrescimo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTaxas As TextBox
    Friend WithEvents txtMulta As TextBox
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cboEntidade As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAtraso As Label
    Friend WithEvents Panel1 As Panel
End Class
