Public Class frmRelEspecies
    Private Sub frmRelEspecies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EspeciesDataSet.categorias' table. You can move, or remove it, as needed.
        Me.CategoriasTableAdapter.Fill(Me.EspeciesDataSet.categorias)
        'TODO: This line of code loads data into the 'EspeciesDataSet.categorias' table. You can move, or remove it, as needed.
        Me.categoriasTableAdapter.Fill(Me.EspeciesDataSet.categorias)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class