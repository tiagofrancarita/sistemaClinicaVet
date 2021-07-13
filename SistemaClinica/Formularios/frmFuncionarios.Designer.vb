<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionarios))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dgFuncionario = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCargoBuscar = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblcrmv = New System.Windows.Forms.Label()
        Me.txtCrmv = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dgFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Telefone"
        '
        'cboCargo
        '
        Me.cboCargo.Enabled = False
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Items.AddRange(New Object() {"Administrador", "Gerente", "Atendente", "Veterinário"})
        Me.cboCargo.Location = New System.Drawing.Point(314, 62)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(217, 21)
        Me.cboCargo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Endereço"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Cargo"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(521, 342)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 43
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 342)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 42
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
        Me.btnExcluir.Location = New System.Drawing.Point(341, 345)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluir.TabIndex = 41
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
        Me.btnEditar.Location = New System.Drawing.Point(275, 345)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 60)
        Me.btnEditar.TabIndex = 40
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
        Me.btnSalvar.Location = New System.Drawing.Point(209, 345)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 39
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
        Me.btnNovo.Location = New System.Drawing.Point(143, 345)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 38
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'dgFuncionario
        '
        Me.dgFuncionario.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFuncionario.Location = New System.Drawing.Point(6, 189)
        Me.dgFuncionario.Name = "dgFuncionario"
        Me.dgFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFuncionario.Size = New System.Drawing.Size(525, 150)
        Me.dgFuncionario.TabIndex = 37
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(68, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 36
        Me.txtCodigo.Visible = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(68, 62)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(191, 20)
        Me.txtNome.TabIndex = 1
        '
        'TxtEndereco
        '
        Me.TxtEndereco.Location = New System.Drawing.Point(68, 88)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(191, 20)
        Me.TxtEndereco.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(265, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Cpf"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Senha"
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(314, 92)
        Me.txtCpf.Mask = "000.000.000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(217, 20)
        Me.txtCpf.TabIndex = 6
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(68, 114)
        Me.txtTelefone.Mask = "(00) 00000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(191, 20)
        Me.txtTelefone.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Cargo"
        '
        'cboCargoBuscar
        '
        Me.cboCargoBuscar.FormattingEnabled = True
        Me.cboCargoBuscar.Items.AddRange(New Object() {"Administrador", "Gerente", "Atendente", "Veterinário"})
        Me.cboCargoBuscar.Location = New System.Drawing.Point(252, 12)
        Me.cboCargoBuscar.Name = "cboCargoBuscar"
        Me.cboCargoBuscar.Size = New System.Drawing.Size(130, 21)
        Me.cboCargoBuscar.TabIndex = 65
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(314, 147)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(217, 20)
        Me.txtEmail.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(265, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "E-mail"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(314, 118)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(217, 20)
        Me.txtUsuario.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(265, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Usuario"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(68, 140)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(191, 20)
        Me.txtSenha.TabIndex = 4
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(420, 12)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(111, 20)
        Me.txtBuscar.TabIndex = 71
        '
        'lblcrmv
        '
        Me.lblcrmv.AutoSize = True
        Me.lblcrmv.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcrmv.Location = New System.Drawing.Point(9, 173)
        Me.lblcrmv.Name = "lblcrmv"
        Me.lblcrmv.Size = New System.Drawing.Size(38, 13)
        Me.lblcrmv.TabIndex = 72
        Me.lblcrmv.Text = "CRMV"
        Me.lblcrmv.Visible = False
        '
        'txtCrmv
        '
        Me.txtCrmv.Location = New System.Drawing.Point(68, 166)
        Me.txtCrmv.Mask = "AA-00000"
        Me.txtCrmv.Name = "txtCrmv"
        Me.txtCrmv.Size = New System.Drawing.Size(191, 20)
        Me.txtCrmv.TabIndex = 9
        Me.txtCrmv.Visible = False
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(545, 419)
        Me.Controls.Add(Me.txtCrmv)
        Me.Controls.Add(Me.lblcrmv)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboCargoBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCargo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dgFuncionario)
        Me.Controls.Add(Me.txtCodigo)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionário"
        CType(Me.dgFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboCargo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dgFuncionario As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtTelefone As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboCargoBuscar As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblcrmv As Label
    Friend WithEvents txtCrmv As MaskedTextBox
End Class
