<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelEspecies
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EspeciesDataSet = New SistemaClinica.EspeciesDataSet()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New SistemaClinica.EspeciesDataSetTableAdapters.categoriasTableAdapter()
        CType(Me.EspeciesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsEspecies"
        ReportDataSource1.Value = Me.CategoriasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaClinica.RelEspecies.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(866, 538)
        Me.ReportViewer1.TabIndex = 0
        '
        'EspeciesDataSet
        '
        Me.EspeciesDataSet.DataSetName = "EspeciesDataSet"
        Me.EspeciesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "categorias"
        Me.CategoriasBindingSource.DataSource = Me.EspeciesDataSet
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'frmRelEspecies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 562)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRelEspecies"
        Me.Text = "Relatório de Especies"
        CType(Me.EspeciesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents EspeciesDataSet As EspeciesDataSet
    Friend WithEvents CategoriasBindingSource As BindingSource
    Friend WithEvents CategoriasTableAdapter As EspeciesDataSetTableAdapters.categoriasTableAdapter
End Class
