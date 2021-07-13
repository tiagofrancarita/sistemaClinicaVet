Imports Microsoft.Reporting.WinForms

Public Class frmRelConsultaData
    Private Sub frmRelConsultaData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtInicio.Value = Now.ToShortDateString
        dtFinal.Value = Now.ToShortDateString

        chamarRel()
        'TODO: This line of code loads data into the 'ConsultaDataSet.ConsultasPorData' table. You can move, or remove it, as needed.
        Me.ConsultasPorDataTableAdapter.Fill(Me.ConsultaDataSet.ConsultasPorData, dtInicio.Text, dtFinal.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub chamarRel()
        Me.ConsultasPorDataTableAdapter.Fill(Me.ConsultaDataSet.ConsultasPorData, dtInicio.Text, dtFinal.Text)

        'Chamar parametros

        'Dim dtIni As ReportParameter
        'Dim dtFim As ReportParameter

        'Me.ReportViewer1.LocalReport.SetParameters(dtIni)
        'Me.ReportViewer1.LocalReport.SetParameters(dtFim)

        Dim parametro(1) As ReportParameter


        parametro(0) = New ReportParameter("dataInicial", dtInicio.Text)
        parametro(1) = New ReportParameter("dataFinal", dtFinal.Text)

        Me.ReportViewer1.LocalReport.SetParameters(parametro)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtInicio.ValueChanged
        chamarRel()

    End Sub

    Private Sub dtFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtFinal.ValueChanged
        chamarRel()

    End Sub
End Class