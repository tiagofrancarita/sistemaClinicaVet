Imports MySql.Data.MySqlClient

Public Class frmListaConsulta

    Private Sub frmListaConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listar()
        cboStatus.Text = "Finalizado"


    End Sub

    Private Sub contarLinhas()
        Dim total As Integer = dgConsultaMarcacao.Rows.Count
        lblTotal.Text = total - 1
    End Sub

    Private Sub listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "SELECT c.id_consulta, c.id_animal, c.id_veterinario, a.nome, v.nome,
                    cl.nome,c.data_consulta, c.hora, c.hora_inicio, c.hora_fim, c.obs, 
                    c.status
                    FROM consultas AS c
                    INNER JOIN animal AS a on c.id_animal = a.id_animal 
                    INNER JOIN veterinarios AS v on c.id_veterinario = v.id_veterinario 
                    INNER JOIN clientes AS cl on a.id_cliente = cl.id_cliente
                    ORDER BY c.data_consulta asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgConsultaMarcacao.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try

    End Sub

    Private Sub formatarDG()

        dgConsultaMarcacao.Columns(0).Visible = False
        dgConsultaMarcacao.Columns(1).Visible = False
        dgConsultaMarcacao.Columns(2).Visible = False
        dgConsultaMarcacao.Columns(10).Visible = False

        dgConsultaMarcacao.Columns(0).HeaderText = "Código Consulta"
        dgConsultaMarcacao.Columns(1).HeaderText = "Código Animal"
        dgConsultaMarcacao.Columns(2).HeaderText = "Código Veterinario"
        dgConsultaMarcacao.Columns(3).HeaderText = "Nome Animal"
        dgConsultaMarcacao.Columns(4).HeaderText = "Nome Veterinario(a)"
        dgConsultaMarcacao.Columns(5).HeaderText = "Cliente"
        dgConsultaMarcacao.Columns(6).HeaderText = "Data Consulta"
        dgConsultaMarcacao.Columns(7).HeaderText = "Hora Marcada"
        dgConsultaMarcacao.Columns(8).HeaderText = "Hora Inicio"
        dgConsultaMarcacao.Columns(9).HeaderText = "Hora Fim"
        dgConsultaMarcacao.Columns(10).HeaderText = "Observação"
        dgConsultaMarcacao.Columns(11).HeaderText = "Status"

    End Sub
    Private Sub Buscar()

        Dim dataBuscar As String
        dataBuscar = dtBuscar.Value.ToString("yyyy-MM-dd")

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "SELECT c.id_consulta, c.id_animal, c.id_veterinario, a.nome, v.nome,
                    cl.nome,c.data_consulta, c.hora, c.hora_inicio, c.hora_fim, c.obs, 
                    c.status
                    FROM consultas AS c
                    INNER JOIN animal AS a on c.id_animal = a.id_animal 
                    INNER JOIN veterinarios AS v on c.id_veterinario = v.id_veterinario 
                    INNER JOIN clientes AS cl on a.id_cliente = cl.id_cliente
                    WHERE data_consulta = '" & dataBuscar & "' AND status = '" & cboStatus.Text & "' 
                    ORDER BY data_consulta asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgConsultaMarcacao.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged
        Buscar()

    End Sub

    Private Sub dtBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscar.ValueChanged
        Buscar()

    End Sub

    Private Sub dgConsultaMarcacao_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgConsultaMarcacao.CellDoubleClick

        btnRelConsulta.Enabled = True
        btnRelReceita.Enabled = True

        txtCodigo.Text = dgConsultaMarcacao.CurrentRow.Cells(0).Value

    End Sub

    Private Sub btnRelConsulta_Click(sender As Object, e As EventArgs) Handles btnRelConsulta.Click
        Dim codigo As Integer
        codigo = txtCodigo.Text

        Dim frmRelConsulta = New frmRelConsulta(codigo)
        frmRelConsulta.ShowDialog()
    End Sub

    Private Sub btnRelReceita_Click(sender As Object, e As EventArgs) Handles btnRelReceita.Click
        Dim codigo As Integer
        codigo = txtCodigo.Text

        Dim frmRelReceita = New frmRelReceita(codigo)
        frmRelReceita.ShowDialog()
    End Sub
End Class

