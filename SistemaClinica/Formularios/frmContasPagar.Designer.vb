<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContasPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContasPagar))
        Me.txtCodFornecedor = New System.Windows.Forms.TextBox()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.dgContasPagar = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbBuscarStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBaixa = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtVencimento = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodFornecedor
        '
        Me.txtCodFornecedor.Enabled = False
        Me.txtCodFornecedor.Location = New System.Drawing.Point(82, 36)
        Me.txtCodFornecedor.Name = "txtCodFornecedor"
        Me.txtCodFornecedor.Size = New System.Drawing.Size(28, 20)
        Me.txtCodFornecedor.TabIndex = 56
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Enabled = False
        Me.btnBuscaCliente.Location = New System.Drawing.Point(282, 62)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(70, 20)
        Me.btnBuscaCliente.TabIndex = 55
        Me.btnBuscaCliente.Text = "Buscar"
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(378, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Status:"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Enabled = False
        Me.txtNumDoc.Location = New System.Drawing.Point(504, 63)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(137, 20)
        Me.txtNumDoc.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Número do Documento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Descrição:"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Enabled = False
        Me.txtFornecedor.Location = New System.Drawing.Point(82, 62)
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(193, 20)
        Me.txtFornecedor.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Fornecedor:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Location = New System.Drawing.Point(82, 89)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(193, 20)
        Me.txtDescricao.TabIndex = 41
        '
        'dgContasPagar
        '
        Me.dgContasPagar.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgContasPagar.Location = New System.Drawing.Point(15, 141)
        Me.dgContasPagar.Name = "dgContasPagar"
        Me.dgContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgContasPagar.Size = New System.Drawing.Size(626, 156)
        Me.dgContasPagar.TabIndex = 46
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(116, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 45
        Me.txtCodigo.Visible = False
        '
        'cbStatus
        '
        Me.cbStatus.Enabled = False
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"A Pagar", "Pago"})
        Me.cbStatus.Location = New System.Drawing.Point(504, 89)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(137, 21)
        Me.cbStatus.TabIndex = 57
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(110, 115)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(165, 20)
        Me.txtValor.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Valor Documento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(462, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Nome:"
        '
        'cbBuscarStatus
        '
        Me.cbBuscarStatus.FormattingEnabled = True
        Me.cbBuscarStatus.Items.AddRange(New Object() {"A Pagar", "Pago"})
        Me.cbBuscarStatus.Location = New System.Drawing.Point(314, 11)
        Me.cbBuscarStatus.Name = "cbBuscarStatus"
        Me.cbBuscarStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbBuscarStatus.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(256, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(508, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(133, 20)
        Me.txtBuscar.TabIndex = 60
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(631, 303)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 70
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Registros:"
        '
        'btnBaixa
        '
        Me.btnBaixa.BackColor = System.Drawing.Color.Transparent
        Me.btnBaixa.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.bt_excluir_menor
        Me.btnBaixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBaixa.Enabled = False
        Me.btnBaixa.FlatAppearance.BorderSize = 0
        Me.btnBaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaixa.Location = New System.Drawing.Point(390, 303)
        Me.btnBaixa.Name = "btnBaixa"
        Me.btnBaixa.Size = New System.Drawing.Size(60, 60)
        Me.btnBaixa.TabIndex = 68
        Me.btnBaixa.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(324, 303)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 60)
        Me.btnEditar.TabIndex = 67
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
        Me.btnSalvar.Location = New System.Drawing.Point(258, 303)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 66
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.btn_novo
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Location = New System.Drawing.Point(191, 303)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 65
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(378, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Data Vencimento:"
        '
        'dtVencimento
        '
        Me.dtVencimento.Enabled = False
        Me.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtVencimento.Location = New System.Drawing.Point(504, 115)
        Me.dtVencimento.Name = "dtVencimento"
        Me.dtVencimento.Size = New System.Drawing.Size(137, 20)
        Me.dtVencimento.TabIndex = 72
        '
        'frmContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(657, 371)
        Me.Controls.Add(Me.dtVencimento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBaixa)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbBuscarStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.txtCodFornecedor)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFornecedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.dgContasPagar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Pagar"
        CType(Me.dgContasPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodFornecedor As TextBox
    Friend WithEvents btnBuscaCliente As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFornecedor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents dgContasPagar As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbBuscarStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBaixa As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents dtVencimento As DateTimePicker
End Class
