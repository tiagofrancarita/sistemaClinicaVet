<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCliente
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
        Me.txtBuscarCpf = New System.Windows.Forms.MaskedTextBox()
        Me.rbNome = New System.Windows.Forms.RadioButton()
        Me.rbCpf = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgCliente = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarCpf
        '
        Me.txtBuscarCpf.Location = New System.Drawing.Point(491, 10)
        Me.txtBuscarCpf.Mask = "000.000.000-00"
        Me.txtBuscarCpf.Name = "txtBuscarCpf"
        Me.txtBuscarCpf.Size = New System.Drawing.Size(111, 20)
        Me.txtBuscarCpf.TabIndex = 101
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.Location = New System.Drawing.Point(375, 12)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(56, 17)
        Me.rbNome.TabIndex = 100
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome:"
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbCpf
        '
        Me.rbCpf.AutoSize = True
        Me.rbCpf.Location = New System.Drawing.Point(437, 12)
        Me.rbCpf.Name = "rbCpf"
        Me.rbCpf.Size = New System.Drawing.Size(48, 17)
        Me.rbCpf.TabIndex = 99
        Me.rbCpf.TabStop = True
        Me.rbCpf.Text = "CPF:"
        Me.rbCpf.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(327, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Buscar"
        '
        'dgCliente
        '
        Me.dgCliente.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCliente.Location = New System.Drawing.Point(12, 35)
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCliente.Size = New System.Drawing.Size(590, 150)
        Me.dgCliente.TabIndex = 97
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(491, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(111, 20)
        Me.txtBuscar.TabIndex = 102
        '
        'frmBuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(616, 198)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtBuscarCpf)
        Me.Controls.Add(Me.rbNome)
        Me.Controls.Add(Me.rbCpf)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgCliente)
        Me.Name = "frmBuscarCliente"
        Me.Text = "Buscar Cliente"
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuscarCpf As MaskedTextBox
    Friend WithEvents rbNome As RadioButton
    Friend WithEvents rbCpf As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents dgCliente As DataGridView
    Friend WithEvents txtBuscar As TextBox
End Class
