Public Class frmRelConsulta

    Dim codigo As Integer

    Sub New(codigoP As Integer)

        InitializeComponent()
        codigo = codigoP

    End Sub
    Private Sub frmRelConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ConsultaDataSet.ConsultaID' table. You can move, or remove it, as needed.
        Me.ConsultaIDTableAdapter.Fill(Me.ConsultaDataSet.ConsultaID, codigo)

        Me.ReportViewer1.RefreshReport()
        'MsgBox(codigo)
    End Sub

    Private Sub btnReceita_Click(sender As Object, e As EventArgs) Handles btnReceita.Click

        Dim frmRelReceita = New frmRelReceita(codigo)
        frmRelReceita.ShowDialog()
    End Sub
End Class