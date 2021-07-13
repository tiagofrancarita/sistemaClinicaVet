<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelAnimaisEspecies
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
        Me.AnimaisFiltroDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sistema_clinicaDataSet = New SistemaClinica.sistema_clinicaDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AnimaisFiltroDataTableAdapter = New SistemaClinica.sistema_clinicaDataSetTableAdapters.AnimaisFiltroDataTableAdapter()
        CType(Me.AnimaisFiltroDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sistema_clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnimaisFiltroDataBindingSource
        '
        Me.AnimaisFiltroDataBindingSource.DataMember = "AnimaisFiltroData"
        Me.AnimaisFiltroDataBindingSource.DataSource = Me.sistema_clinicaDataSet
        '
        'sistema_clinicaDataSet
        '
        Me.sistema_clinicaDataSet.DataSetName = "sistema_clinicaDataSet"
        Me.sistema_clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Inicio"
        '
        'dtInicio
        '
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(260, 12)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(96, 20)
        Me.dtInicio.TabIndex = 6
        '
        'dtFinal
        '
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(434, 12)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(96, 20)
        Me.dtFinal.TabIndex = 5
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSAnimaisEspecies"
        ReportDataSource1.Value = Me.AnimaisFiltroDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelAnimaisEspecies.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 55)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(934, 520)
        Me.ReportViewer1.TabIndex = 9
        '
        'AnimaisFiltroDataTableAdapter
        '
        Me.AnimaisFiltroDataTableAdapter.ClearBeforeFill = True
        '
        'frmRelAnimaisEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 589)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtInicio)
        Me.Controls.Add(Me.dtFinal)
        Me.Name = "frmRelAnimaisEspecies"
        Me.Text = "frmRelAnimaisEspecies"
        CType(Me.AnimaisFiltroDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sistema_clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents dtFinal As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AnimaisFiltroDataBindingSource As BindingSource
    Friend WithEvents sistema_clinicaDataSet As sistema_clinicaDataSet
    Friend WithEvents AnimaisFiltroDataTableAdapter As sistema_clinicaDataSetTableAdapters.AnimaisFiltroDataTableAdapter
End Class
