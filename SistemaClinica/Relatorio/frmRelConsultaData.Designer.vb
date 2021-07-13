<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelConsultaData
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
        Me.ConsultasPorDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaDataSet = New SistemaClinica.ConsultaDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ConsultasPorDataTableAdapter = New SistemaClinica.ConsultaDataSetTableAdapters.ConsultasPorDataTableAdapter()
        CType(Me.ConsultasPorDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultasPorDataBindingSource
        '
        Me.ConsultasPorDataBindingSource.DataMember = "ConsultasPorData"
        Me.ConsultasPorDataBindingSource.DataSource = Me.ConsultaDataSet
        '
        'ConsultaDataSet
        '
        Me.ConsultaDataSet.DataSetName = "ConsultaDataSet"
        Me.ConsultaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(502, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Inicio"
        '
        'dtInicio
        '
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(373, 12)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(96, 20)
        Me.dtInicio.TabIndex = 10
        '
        'dtFinal
        '
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(547, 12)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(96, 20)
        Me.dtFinal.TabIndex = 9
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DsConsultaData"
        ReportDataSource1.Value = Me.ConsultasPorDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelConsultaData.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(651, 458)
        Me.ReportViewer1.TabIndex = 13
        '
        'ConsultasPorDataTableAdapter
        '
        Me.ConsultasPorDataTableAdapter.ClearBeforeFill = True
        '
        'frmRelConsultaData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 502)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtInicio)
        Me.Controls.Add(Me.dtFinal)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRelConsultaData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relátorio de Consultas"
        CType(Me.ConsultasPorDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents dtFinal As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ConsultasPorDataBindingSource As BindingSource
    Friend WithEvents ConsultaDataSet As ConsultaDataSet
    Friend WithEvents ConsultasPorDataTableAdapter As ConsultaDataSetTableAdapters.ConsultasPorDataTableAdapter
End Class
