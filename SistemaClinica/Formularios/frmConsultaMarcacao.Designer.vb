<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaMarcacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaMarcacao))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboAnimal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dgMarcaConsulta = New System.Windows.Forms.DataGridView()
        Me.cboVeterinario = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.dtHora = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtBuscar = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgMarcaConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, -46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Nome:"
        '
        'cboAnimal
        '
        Me.cboAnimal.FormattingEnabled = True
        Me.cboAnimal.Location = New System.Drawing.Point(73, 51)
        Me.cboAnimal.Name = "cboAnimal"
        Me.cboAnimal.Size = New System.Drawing.Size(183, 21)
        Me.cboAnimal.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(262, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Data:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Animal:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(492, 338)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 43
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(432, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Registros:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.bt_excluir_menor
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(339, 341)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 60)
        Me.btnCancelar.TabIndex = 41
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnEditar.Location = New System.Drawing.Point(273, 341)
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
        Me.btnSalvar.Location = New System.Drawing.Point(207, 341)
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
        Me.btnNovo.Location = New System.Drawing.Point(140, 341)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 38
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(73, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 37
        Me.txtCodigo.Visible = False
        '
        'dgMarcaConsulta
        '
        Me.dgMarcaConsulta.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgMarcaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMarcaConsulta.Location = New System.Drawing.Point(15, 131)
        Me.dgMarcaConsulta.Name = "dgMarcaConsulta"
        Me.dgMarcaConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMarcaConsulta.Size = New System.Drawing.Size(487, 204)
        Me.dgMarcaConsulta.TabIndex = 50
        '
        'cboVeterinario
        '
        Me.cboVeterinario.FormattingEnabled = True
        Me.cboVeterinario.Location = New System.Drawing.Point(73, 78)
        Me.cboVeterinario.Name = "cboVeterinario"
        Me.cboVeterinario.Size = New System.Drawing.Size(183, 21)
        Me.cboVeterinario.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Veterinário:"
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(302, 51)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(96, 20)
        Me.dtData.TabIndex = 3
        '
        'dtHora
        '
        Me.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtHora.Location = New System.Drawing.Point(302, 80)
        Me.dtHora.Name = "dtHora"
        Me.dtHora.ShowUpDown = True
        Me.dtHora.Size = New System.Drawing.Size(96, 20)
        Me.dtHora.TabIndex = 4
        Me.dtHora.Value = New Date(2020, 10, 26, 19, 39, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Hora:"
        '
        'dtBuscar
        '
        Me.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBuscar.Location = New System.Drawing.Point(395, 9)
        Me.dtBuscar.Name = "dtBuscar"
        Me.dtBuscar.Size = New System.Drawing.Size(96, 20)
        Me.dtBuscar.TabIndex = 56
        '
        'frmConsultaMarcacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(507, 408)
        Me.Controls.Add(Me.dtBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtHora)
        Me.Controls.Add(Me.dtData)
        Me.Controls.Add(Me.cboVeterinario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgMarcaConsulta)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboAnimal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsultaMarcacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marcação de Consultas"
        CType(Me.dgMarcaConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents cboAnimal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents dgMarcaConsulta As DataGridView
    Friend WithEvents cboVeterinario As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents dtHora As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents dtBuscar As DateTimePicker
End Class
