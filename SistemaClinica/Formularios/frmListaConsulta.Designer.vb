<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaConsulta
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
        Me.dgConsultaMarcacao = New System.Windows.Forms.DataGridView()
        Me.dtBuscar = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRelReceita = New System.Windows.Forms.Button()
        Me.btnRelConsulta = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        CType(Me.dgConsultaMarcacao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgConsultaMarcacao
        '
        Me.dgConsultaMarcacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaMarcacao.Location = New System.Drawing.Point(12, 38)
        Me.dgConsultaMarcacao.Name = "dgConsultaMarcacao"
        Me.dgConsultaMarcacao.Size = New System.Drawing.Size(520, 150)
        Me.dgConsultaMarcacao.TabIndex = 0
        '
        'dtBuscar
        '
        Me.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBuscar.Location = New System.Drawing.Point(436, 6)
        Me.dtBuscar.Name = "dtBuscar"
        Me.dtBuscar.Size = New System.Drawing.Size(96, 20)
        Me.dtBuscar.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Buscar"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(522, 191)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(10, 13)
        Me.lblTotal.TabIndex = 63
        Me.lblTotal.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(462, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Registros:"
        '
        'btnRelReceita
        '
        Me.btnRelReceita.BackColor = System.Drawing.Color.Transparent
        Me.btnRelReceita.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.Relatório
        Me.btnRelReceita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRelReceita.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelReceita.Enabled = False
        Me.btnRelReceita.FlatAppearance.BorderSize = 0
        Me.btnRelReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnRelReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelReceita.Location = New System.Drawing.Point(286, 194)
        Me.btnRelReceita.Name = "btnRelReceita"
        Me.btnRelReceita.Size = New System.Drawing.Size(68, 60)
        Me.btnRelReceita.TabIndex = 59
        Me.btnRelReceita.UseVisualStyleBackColor = False
        '
        'btnRelConsulta
        '
        Me.btnRelConsulta.BackColor = System.Drawing.Color.Transparent
        Me.btnRelConsulta.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.consultas1
        Me.btnRelConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRelConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelConsulta.Enabled = False
        Me.btnRelConsulta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRelConsulta.FlatAppearance.BorderSize = 0
        Me.btnRelConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnRelConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelConsulta.Location = New System.Drawing.Point(212, 194)
        Me.btnRelConsulta.Name = "btnRelConsulta"
        Me.btnRelConsulta.Size = New System.Drawing.Size(68, 68)
        Me.btnRelConsulta.TabIndex = 58
        Me.btnRelConsulta.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(12, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(28, 20)
        Me.txtCodigo.TabIndex = 57
        Me.txtCodigo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Status:"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Marcado", "Cancelado", "Finalizado", "Em Andamento"})
        Me.cboStatus.Location = New System.Drawing.Point(278, 5)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboStatus.TabIndex = 68
        '
        'frmListaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 262)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRelReceita)
        Me.Controls.Add(Me.btnRelConsulta)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.dgConsultaMarcacao)
        Me.Name = "frmListaConsulta"
        Me.Text = "Listagem de Consultas"
        CType(Me.dgConsultaMarcacao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgConsultaMarcacao As DataGridView
    Friend WithEvents dtBuscar As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRelReceita As Button
    Friend WithEvents btnRelConsulta As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboStatus As ComboBox
End Class
