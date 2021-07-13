<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelConsulta
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelConsulta))
        Me.ConsultaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaDataSet = New SistemaClinica.ConsultaDataSet()
        Me.btnReceita = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsultaIDTableAdapter = New SistemaClinica.ConsultaDataSetTableAdapters.ConsultaIDTableAdapter()
        CType(Me.ConsultaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultaIDBindingSource
        '
        Me.ConsultaIDBindingSource.DataMember = "ConsultaID"
        Me.ConsultaIDBindingSource.DataSource = Me.ConsultaDataSet
        '
        'ConsultaDataSet
        '
        Me.ConsultaDataSet.DataSetName = "ConsultaDataSet"
        Me.ConsultaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnReceita
        '
        Me.btnReceita.BackColor = System.Drawing.Color.Transparent
        Me.btnReceita.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnReceita.FlatAppearance.BorderSize = 0
        Me.btnReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceita.Image = Global.SistemaClinica.My.Resources.Resources.receita
        Me.btnReceita.Location = New System.Drawing.Point(12, 12)
        Me.btnReceita.Name = "btnReceita"
        Me.btnReceita.Size = New System.Drawing.Size(89, 72)
        Me.btnReceita.TabIndex = 0
        Me.btnReceita.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSConsulta"
        ReportDataSource1.Value = Me.ConsultaIDBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelConsulta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 90)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(690, 414)
        Me.ReportViewer1.TabIndex = 1
        '
        'ConsultaIDTableAdapter
        '
        Me.ConsultaIDTableAdapter.ClearBeforeFill = True
        '
        'frmRelConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(707, 516)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnReceita)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Consulta"
        CType(Me.ConsultaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReceita As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsultaIDBindingSource As BindingSource
    Friend WithEvents ConsultaDataSet As ConsultaDataSet
    Friend WithEvents ConsultaIDTableAdapter As ConsultaDataSetTableAdapters.ConsultaIDTableAdapter
End Class
