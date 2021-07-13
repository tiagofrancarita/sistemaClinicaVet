<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrocaSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTrocaSenha))
        Me.btnTrocaSenha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtConfirma = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTrocaSenha
        '
        Me.btnTrocaSenha.Location = New System.Drawing.Point(96, 92)
        Me.btnTrocaSenha.Name = "btnTrocaSenha"
        Me.btnTrocaSenha.Size = New System.Drawing.Size(75, 23)
        Me.btnTrocaSenha.TabIndex = 0
        Me.btnTrocaSenha.Text = "Trocar"
        Me.btnTrocaSenha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Senha"
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(96, 30)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 2
        '
        'txtConfirma
        '
        Me.txtConfirma.Location = New System.Drawing.Point(96, 56)
        Me.txtConfirma.Name = "txtConfirma"
        Me.txtConfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirma.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirma.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Confirma Senha"
        '
        'frmTrocaSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 137)
        Me.Controls.Add(Me.txtConfirma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTrocaSenha)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTrocaSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Troca Senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTrocaSenha As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtConfirma As TextBox
    Friend WithEvents Label2 As Label
End Class
