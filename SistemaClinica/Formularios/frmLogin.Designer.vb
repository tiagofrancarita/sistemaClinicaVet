<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnLogar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(272, 275)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(353, 31)
        Me.txtUsuario.TabIndex = 1
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(272, 357)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(353, 31)
        Me.txtSenha.TabIndex = 2
        '
        'btnLogar
        '
        Me.btnLogar.BackColor = System.Drawing.Color.Transparent
        Me.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLogar.FlatAppearance.BorderSize = 0
        Me.btnLogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua
        Me.btnLogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnLogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogar.Location = New System.Drawing.Point(189, 448)
        Me.btnLogar.Name = "btnLogar"
        Me.btnLogar.Size = New System.Drawing.Size(436, 63)
        Me.btnLogar.TabIndex = 3
        Me.btnLogar.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.login
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.btnLogar)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents btnLogar As Button
End Class
