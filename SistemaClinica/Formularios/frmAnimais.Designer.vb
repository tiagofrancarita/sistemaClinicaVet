<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnimais
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimais))
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgAnimal = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRaca = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.cbCategoriaBuscar = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscaCliente = New System.Windows.Forms.Button()
        Me.btnImg = New System.Windows.Forms.Button()
        Me.imagem = New System.Windows.Forms.PictureBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        CType(Me.dgAnimal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(444, 363)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(384, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Registros:"
        '
        'dgAnimal
        '
        Me.dgAnimal.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAnimal.Location = New System.Drawing.Point(10, 156)
        Me.dgAnimal.Name = "dgAnimal"
        Me.dgAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAnimal.Size = New System.Drawing.Size(444, 204)
        Me.dgAnimal.TabIndex = 15
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(65, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 14
        Me.txtCodigo.Visible = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(457, 10)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(133, 20)
        Me.txtBuscar.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(159, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Buscar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Raça"
        '
        'txtRaca
        '
        Me.txtRaca.Enabled = False
        Me.txtRaca.Location = New System.Drawing.Point(65, 104)
        Me.txtRaca.Name = "txtRaca"
        Me.txtRaca.Size = New System.Drawing.Size(121, 20)
        Me.txtRaca.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(192, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(233, 78)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(151, 20)
        Me.txtNome.TabIndex = 4
        '
        'cboCategoria
        '
        Me.cboCategoria.Enabled = False
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(65, 78)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cboCategoria.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(192, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Idade"
        '
        'txtIdade
        '
        Me.txtIdade.Enabled = False
        Me.txtIdade.Location = New System.Drawing.Point(233, 104)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(70, 20)
        Me.txtIdade.TabIndex = 5
        '
        'cbCategoriaBuscar
        '
        Me.cbCategoriaBuscar.FormattingEnabled = True
        Me.cbCategoriaBuscar.Location = New System.Drawing.Point(263, 9)
        Me.cbCategoriaBuscar.Name = "cbCategoriaBuscar"
        Me.cbCategoriaBuscar.Size = New System.Drawing.Size(121, 21)
        Me.cbCategoriaBuscar.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(205, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Categoria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Nome:"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(65, 130)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(121, 20)
        Me.txtCliente.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Cliente"
        '
        'btnBuscaCliente
        '
        Me.btnBuscaCliente.Enabled = False
        Me.btnBuscaCliente.Location = New System.Drawing.Point(195, 130)
        Me.btnBuscaCliente.Name = "btnBuscaCliente"
        Me.btnBuscaCliente.Size = New System.Drawing.Size(70, 20)
        Me.btnBuscaCliente.TabIndex = 36
        Me.btnBuscaCliente.Text = "Buscar"
        Me.btnBuscaCliente.UseVisualStyleBackColor = True
        '
        'btnImg
        '
        Me.btnImg.Enabled = False
        Me.btnImg.Location = New System.Drawing.Point(460, 187)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.Size = New System.Drawing.Size(130, 27)
        Me.btnImg.TabIndex = 38
        Me.btnImg.Text = "Buscar imagem"
        Me.btnImg.UseVisualStyleBackColor = True
        '
        'imagem
        '
        Me.imagem.Location = New System.Drawing.Point(460, 51)
        Me.imagem.Name = "imagem"
        Me.imagem.Size = New System.Drawing.Size(130, 130)
        Me.imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagem.TabIndex = 37
        Me.imagem.TabStop = False
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
        Me.btnExcluir.Location = New System.Drawing.Point(303, 366)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluir.TabIndex = 19
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
        Me.btnEditar.Location = New System.Drawing.Point(237, 366)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(60, 60)
        Me.btnEditar.TabIndex = 18
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
        Me.btnSalvar.Location = New System.Drawing.Point(171, 366)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 17
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
        Me.btnNovo.Location = New System.Drawing.Point(104, 366)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 16
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Enabled = False
        Me.txtCodCliente.Location = New System.Drawing.Point(65, 51)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(28, 20)
        Me.txtCodCliente.TabIndex = 39
        Me.txtCodCliente.Visible = False
        '
        'frmAnimais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(594, 434)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.btnImg)
        Me.Controls.Add(Me.imagem)
        Me.Controls.Add(Me.btnBuscaCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbCategoriaBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRaca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.dgAnimal)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtBuscar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnimais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Animais"
        CType(Me.dgAnimal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dgAnimal As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRaca As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents cbCategoriaBuscar As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBuscaCliente As Button
    Friend WithEvents imagem As PictureBox
    Friend WithEvents btnImg As Button
    Friend WithEvents txtCodCliente As TextBox
End Class
