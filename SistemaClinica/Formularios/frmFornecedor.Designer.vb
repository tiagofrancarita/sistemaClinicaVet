<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedor))
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.lblcrmv = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboStatusBuscar = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTelefone1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
        Me.txtRazao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgFornecedor = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefone2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtBuscarCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCep
        '
        Me.txtCep.Enabled = False
        Me.txtCep.Location = New System.Drawing.Point(655, 97)
        Me.txtCep.Mask = "00.000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(61, 20)
        Me.txtCep.TabIndex = 15
        '
        'lblcrmv
        '
        Me.lblcrmv.AutoSize = True
        Me.lblcrmv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcrmv.Location = New System.Drawing.Point(602, 100)
        Me.lblcrmv.Name = "lblcrmv"
        Me.lblcrmv.Size = New System.Drawing.Size(31, 13)
        Me.lblcrmv.TabIndex = 96
        Me.lblcrmv.Text = "CEP:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(368, 45)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(228, 20)
        Me.txtEndereco.TabIndex = 8
        '
        'txtComplemento
        '
        Me.txtComplemento.Enabled = False
        Me.txtComplemento.Location = New System.Drawing.Point(368, 71)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(228, 20)
        Me.txtComplemento.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(288, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 94
        Me.Label11.Text = "Complemento:"
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(368, 97)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(162, 20)
        Me.txtCidade.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(288, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Cidade:"
        '
        'cboStatusBuscar
        '
        Me.cboStatusBuscar.FormattingEnabled = True
        Me.cboStatusBuscar.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cboStatusBuscar.Location = New System.Drawing.Point(483, 11)
        Me.cboStatusBuscar.Name = "cboStatusBuscar"
        Me.cboStatusBuscar.Size = New System.Drawing.Size(130, 21)
        Me.cboStatusBuscar.TabIndex = 92
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Status:"
        '
        'txtTelefone1
        '
        Me.txtTelefone1.Enabled = False
        Me.txtTelefone1.Location = New System.Drawing.Point(91, 123)
        Me.txtTelefone1.Mask = "(00) 00000-0000"
        Me.txtTelefone1.Name = "txtTelefone1"
        Me.txtTelefone1.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefone1.TabIndex = 4
        '
        'txtCnpj
        '
        Me.txtCnpj.Enabled = False
        Me.txtCnpj.Location = New System.Drawing.Point(91, 97)
        Me.txtCnpj.Mask = "00.000.000/0000-00"
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(108, 20)
        Me.txtCnpj.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(288, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Endereço:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "CNPJ:"
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.Enabled = False
        Me.txtNomeFantasia.Location = New System.Drawing.Point(91, 71)
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.Size = New System.Drawing.Size(191, 20)
        Me.txtNomeFantasia.TabIndex = 2
        '
        'txtRazao
        '
        Me.txtRazao.Enabled = False
        Me.txtRazao.Location = New System.Drawing.Point(91, 45)
        Me.txtRazao.Name = "txtRazao"
        Me.txtRazao.Size = New System.Drawing.Size(191, 20)
        Me.txtRazao.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Telefone"
        '
        'cboStatus
        '
        Me.cboStatus.Enabled = False
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Ativo", "Inativo"})
        Me.cboStatus.Location = New System.Drawing.Point(368, 148)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(95, 21)
        Me.cboStatus.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Razão Social:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Nome Fantasia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Status:"
        '
        'dgFornecedor
        '
        Me.dgFornecedor.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFornecedor.Location = New System.Drawing.Point(7, 238)
        Me.dgFornecedor.Name = "dgFornecedor"
        Me.dgFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFornecedor.Size = New System.Drawing.Size(763, 206)
        Me.dgFornecedor.TabIndex = 83
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(91, 15)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 82
        Me.txtCodigo.Visible = False
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(655, 45)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(61, 20)
        Me.txtNumero.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(602, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Número:"
        '
        'txtTelefone2
        '
        Me.txtTelefone2.Enabled = False
        Me.txtTelefone2.Location = New System.Drawing.Point(91, 149)
        Me.txtTelefone2.Mask = "(00) 00000-0000"
        Me.txtTelefone2.Name = "txtTelefone2"
        Me.txtTelefone2.Size = New System.Drawing.Size(108, 20)
        Me.txtTelefone2.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Telefone2"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Location = New System.Drawing.Point(368, 123)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(162, 20)
        Me.txtEstado.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(288, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 102
        Me.Label13.Text = "Estado:"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(655, 71)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(115, 20)
        Me.txtBairro.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(602, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 104
        Me.Label14.Text = "Bairro:"
        '
        'txtUf
        '
        Me.txtUf.Enabled = False
        Me.txtUf.Location = New System.Drawing.Point(655, 123)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(32, 20)
        Me.txtUf.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(602, 126)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 13)
        Me.Label15.TabIndex = 106
        Me.Label15.Text = "UF:"
        '
        'txtCelular
        '
        Me.txtCelular.Enabled = False
        Me.txtCelular.Location = New System.Drawing.Point(91, 175)
        Me.txtCelular.Mask = "(00) 00000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(108, 20)
        Me.txtCelular.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 178)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 108
        Me.Label16.Text = "Celular:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(91, 201)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(191, 20)
        Me.txtEmail.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 204)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 110
        Me.Label17.Text = "E-mail"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(760, 447)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 116
        Me.lblTotal.Text = "-"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(700, 447)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 115
        Me.Label18.Text = "Registros:"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.bt_excluir_menor
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(470, 450)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluir.TabIndex = 114
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.bt_editar_menor
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(404, 450)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 60)
        Me.btnEditar.TabIndex = 113
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.bt_salvar
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(338, 450)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 112
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.btn_novo
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Enabled = False
        Me.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Location = New System.Drawing.Point(272, 450)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 111
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'txtBuscarCNPJ
        '
        Me.txtBuscarCNPJ.Location = New System.Drawing.Point(662, 12)
        Me.txtBuscarCNPJ.Mask = "00.000.000/0000-00"
        Me.txtBuscarCNPJ.Name = "txtBuscarCNPJ"
        Me.txtBuscarCNPJ.Size = New System.Drawing.Size(108, 20)
        Me.txtBuscarCNPJ.TabIndex = 117
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(619, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "CNPJ:"
        '
        'frmFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(782, 517)
        Me.Controls.Add(Me.txtBuscarCNPJ)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtTelefone2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.lblcrmv)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboStatusBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTelefone1)
        Me.Controls.Add(Me.txtCnpj)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomeFantasia)
        Me.Controls.Add(Me.txtRazao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgFornecedor)
        Me.Controls.Add(Me.txtCodigo)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fornecedor"
        CType(Me.dgFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents lblcrmv As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboStatusBuscar As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTelefone1 As MaskedTextBox
    Friend WithEvents txtCnpj As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeFantasia As TextBox
    Friend WithEvents txtRazao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgFornecedor As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefone2 As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtUf As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCelular As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtBuscarCNPJ As MaskedTextBox
    Friend WithEvents Label7 As Label
End Class
