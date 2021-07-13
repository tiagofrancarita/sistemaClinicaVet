Public Class frmRelReceita

    Dim codigo As Integer

    Sub New(codigoP As Integer)

        InitializeComponent()
        codigo = codigoP

    End Sub
    Private Sub frmRelReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultaDataSet.ConsultaID' table. You can move, or remove it, as needed.
        Me.ConsultaIDTableAdapter.Fill(Me.ConsultaDataSet.ConsultaID, codigo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class