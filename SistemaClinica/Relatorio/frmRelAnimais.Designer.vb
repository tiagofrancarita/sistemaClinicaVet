<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelAnimais
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
        Me.AnimaisConsultaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sistema_clinicaDataSet = New SistemaClinica.sistema_clinicaDataSet()
        Me.AnimaisConsultaTableAdapter = New SistemaClinica.sistema_clinicaDataSetTableAdapters.AnimaisConsultaTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnimaisFiltroDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimaisFiltroDataTableAdapter = New SistemaClinica.sistema_clinicaDataSetTableAdapters.AnimaisFiltroDataTableAdapter()
        CType(Me.AnimaisConsultaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sistema_clinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimaisFiltroDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnimaisConsultaBindingSource
        '
        Me.AnimaisConsultaBindingSource.DataMember = "AnimaisConsulta"
        Me.AnimaisConsultaBindingSource.DataSource = Me.sistema_clinicaDataSet
        '
        'sistema_clinicaDataSet
        '
        Me.sistema_clinicaDataSet.DataSetName = "sistema_clinicaDataSet"
        Me.sistema_clinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnimaisConsultaTableAdapter
        '
        Me.AnimaisConsultaTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DSAnimais"
        ReportDataSource1.Value = Me.AnimaisFiltroDataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelAnimais.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 61)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 701)
        Me.ReportViewer1.TabIndex = 0
        '
        'dtFinal
        '
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(716, 12)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(96, 20)
        Me.dtFinal.TabIndex = 1
        '
        'dtInicio
        '
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(542, 12)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(96, 20)
        Me.dtInicio.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(497, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(671, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Final"
        '
        'AnimaisFiltroDataBindingSource
        '
        Me.AnimaisFiltroDataBindingSource.DataMember = "AnimaisFiltroData"
        Me.AnimaisFiltroDataBindingSource.DataSource = Me.sistema_clinicaDataSet
        '
        'AnimaisFiltroDataTableAdapter
        '
        Me.AnimaisFiltroDataTableAdapter.ClearBeforeFill = True
        '
        'frmRelAnimais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 768)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtInicio)
        Me.Controls.Add(Me.dtFinal)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRelAnimais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Animais"
        CType(Me.AnimaisConsultaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sistema_clinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimaisFiltroDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sistema_clinicaDataSet As sistema_clinicaDataSet
    Friend WithEvents AnimaisConsultaBindingSource As BindingSource
    Friend WithEvents AnimaisConsultaTableAdapter As sistema_clinicaDataSetTableAdapters.AnimaisConsultaTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtFinal As DateTimePicker
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AnimaisFiltroDataBindingSource As BindingSource
    Friend WithEvents AnimaisFiltroDataTableAdapter As sistema_clinicaDataSetTableAdapters.AnimaisFiltroDataTableAdapter
End Class
