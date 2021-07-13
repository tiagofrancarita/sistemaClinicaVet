<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVet
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtHora = New System.Windows.Forms.DateTimePicker()
        Me.dgIniciaConsulta = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        CType(Me.dgIniciaConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Hora Inicio:"
        '
        'dtHora
        '
        Me.dtHora.Enabled = False
        Me.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtHora.Location = New System.Drawing.Point(90, 21)
        Me.dtHora.Name = "dtHora"
        Me.dtHora.ShowUpDown = True
        Me.dtHora.Size = New System.Drawing.Size(96, 20)
        Me.dtHora.TabIndex = 72
        Me.dtHora.Value = New Date(2020, 10, 26, 19, 39, 0, 0)
        '
        'dgIniciaConsulta
        '
        Me.dgIniciaConsulta.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgIniciaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIniciaConsulta.Location = New System.Drawing.Point(15, 141)
        Me.dgIniciaConsulta.Name = "dgIniciaConsulta"
        Me.dgIniciaConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgIniciaConsulta.Size = New System.Drawing.Size(509, 167)
        Me.dgIniciaConsulta.TabIndex = 68
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(514, 314)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 64
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Registros:"
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
        Me.btnSalvar.Location = New System.Drawing.Point(276, 314)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvar.TabIndex = 60
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
        Me.btnNovo.Location = New System.Drawing.Point(209, 314)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovo.TabIndex = 59
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(506, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 58
        Me.txtCodigo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Observações:"
        '
        'txtObs
        '
        Me.txtObs.Enabled = False
        Me.txtObs.Location = New System.Drawing.Point(90, 53)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(434, 82)
        Me.txtObs.TabIndex = 76
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(400, 12)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtStatus.TabIndex = 77
        Me.txtStatus.Visible = False
        '
        'frmConsultaVet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(546, 382)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtHora)
        Me.Controls.Add(Me.dgIniciaConsulta)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmConsultaVet"
        Me.Text = "Consulta"
        CType(Me.dgIniciaConsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents dtHora As DateTimePicker
    Friend WithEvents dgIniciaConsulta As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents txtStatus As TextBox
End Class
