<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dgCliente = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbCpf = New System.Windows.Forms.RadioButton()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.txtBuscarCpf = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(455, 7)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(111, 20)
        Me.txtBuscar.TabIndex = 87
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(71, 111)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(217, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(71, 137)
        Me.txtTelefone.Mask = "(00) 00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(217, 20)
        Me.txtTelefone.TabIndex = 3
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(349, 86)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(217, 20)
        Me.txtCpf.TabIndex = 4
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(71, 86)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(217, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(291, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Buscar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Endereço"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(556, 328)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 83
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Registros:"
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
        Me.btnExcluir.Location = New System.Drawing.Point(383, 331)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluir.TabIndex = 81
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
        Me.btnEditar.Location = New System.Drawing.Point(317, 331)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 60)
        Me.btnEditar.TabIndex = 80
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
        Me.btnSalvar.Location = New System.Drawing.Point(251, 331)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 79
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
        Me.btnNovo.Location = New System.Drawing.Point(185, 331)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 78
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'dgCliente
        '
        Me.dgCliente.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCliente.Location = New System.Drawing.Point(71, 175)
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCliente.Size = New System.Drawing.Size(495, 150)
        Me.dgCliente.TabIndex = 77
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(71, 60)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Telefone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(349, 111)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(217, 20)
        Me.txtEmail.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Cpf"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(308, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "E-mail"
        '
        'rbCpf
        '
        Me.rbCpf.AutoSize = True
        Me.rbCpf.Location = New System.Drawing.Point(401, 8)
        Me.rbCpf.Name = "rbCpf"
        Me.rbCpf.Size = New System.Drawing.Size(48, 17)
        Me.rbCpf.TabIndex = 93
        Me.rbCpf.TabStop = True
        Me.rbCpf.Text = "CPF:"
        Me.rbCpf.UseVisualStyleBackColor = True
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(339, 8)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(56, 17)
        Me.rbNome.TabIndex = 95
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome:"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'txtBuscarCpf
        '
        Me.txtBuscarCpf.Location = New System.Drawing.Point(455, 7)
        Me.txtBuscarCpf.Mask = "000.000.000-00"
        Me.txtBuscarCpf.Name = "txtBuscarCpf"
        Me.txtBuscarCpf.Size = New System.Drawing.Size(111, 20)
        Me.txtBuscarCpf.TabIndex = 96
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(591, 404)
        Me.Controls.Add(Me.txtBuscarCpf)
        Me.Controls.Add(Me.rbNome)
        Me.Controls.Add(Me.rbCpf)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dgCliente)
        Me.Controls.Add(Me.txtCodigo)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dgCliente As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbCpf As RadioButton
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents txtBuscarCpf As MaskedTextBox
End Class
