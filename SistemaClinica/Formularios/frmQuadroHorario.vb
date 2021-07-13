Imports MySql.Data.MySqlClient

Public Class frmQuadroHorario
    Private Sub frmQuadroHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()

        CarregarVeterinarios()
        dtData.Value = Now()
    End Sub

    Private Sub CarregarVeterinarios()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from veterinarios order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                cbVeterinario.ValueMember = "id_veterinario"
                cbVeterinario.DisplayMember = "nome"
                cbVeterinario.DataSource = dt


            Else
                'MsgBox("É preciso cadastrar antes as categorias!")
            End If
        Catch ex As Exception
            MsgBox("Erro ao carregar veterinário!! " + ex.Message)
        End Try
    End Sub


    Private Sub Listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data_consulta, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animal as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data_consulta = curDate() and status = 'Marcado' and v.nome = '" & nomeUsuario & "' order by c.hora asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            VerificarHorario()

        Catch ex As Exception
            MsgBox("Erro na listagem de dados! " + ex.Message)
        End Try
    End Sub

    Private Sub FormatarDG()

        dg.Columns(0).Visible = False
        dg.Columns(1).Visible = False
        dg.Columns(2).Visible = False
        dg.Columns(5).Visible = False
        dg.Columns(6).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False

        dg.Columns(0).HeaderText = "Id da Consulta"
        dg.Columns(1).HeaderText = "Id do Animal"
        dg.Columns(2).HeaderText = "Id do Veterinário"
        dg.Columns(3).HeaderText = "Data da Consulta"
        dg.Columns(4).HeaderText = "Hora Marcada"
        dg.Columns(5).HeaderText = "Hora Início"
        dg.Columns(6).HeaderText = "Hora Fim"
        dg.Columns(7).HeaderText = "Observações"
        dg.Columns(8).HeaderText = "Status"
        dg.Columns(9).HeaderText = "Animal"
        dg.Columns(10).HeaderText = "Veterinário"

        'dg.Columns(0).Width = 140
        'dg.Columns(1).Width = 140

    End Sub


    Sub VerificarHorario()

        RedefinirHorarios()

        For Each linha As DataGridViewRow In dg.Rows
            If lbl8.Text = linha.Cells(4).Value.ToString Then
                Panel8.BackColor = Color.Tomato
                Panel8.Enabled = False
            End If

            If lbl9.Text = linha.Cells(4).Value.ToString Then
                Panel9.BackColor = Color.Tomato
                Panel9.Enabled = False
            End If

            If lbl10.Text = linha.Cells(4).Value.ToString Then
                Panel10.BackColor = Color.Tomato
                Panel10.Enabled = False
            End If

            If lbl11.Text = linha.Cells(4).Value.ToString Then
                Panel11.BackColor = Color.Tomato
                Panel11.Enabled = False
            End If

            If lbl13.Text = linha.Cells(4).Value.ToString Then
                Panel13.BackColor = Color.Tomato
                Panel13.Enabled = False
            End If

            If lbl14.Text = linha.Cells(4).Value.ToString Then
                Panel14.BackColor = Color.Tomato
                Panel14.Enabled = False
            End If


            If lbl15.Text = linha.Cells(4).Value.ToString Then
                Panel15.BackColor = Color.Tomato
                Panel15.Enabled = False
            End If


            If lbl16.Text = linha.Cells(4).Value.ToString Then
                Panel16.BackColor = Color.Tomato
                Panel16.Enabled = False
            End If


            If lbl17.Text = linha.Cells(4).Value.ToString Then
                Panel17.BackColor = Color.Tomato
                Panel17.Enabled = False
            End If

            If lbl18.Text = linha.Cells(4).Value.ToString Then
                Panel18.BackColor = Color.Tomato
                Panel18.Enabled = False
            End If


        Next
    End Sub



    Private Sub Buscar()

        Dim data As String
        data = dtData.Value.ToString("yyyy-MM-dd")

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select c.id_consulta, c.id_animal, c.id_veterinario, c.data_consulta, c.hora, c.hora_inicio, c.hora_fim, c.obs, c.status, a.nome, v.nome from consultas as c INNER JOIN animal as a on c.id_animal = a.id_animal INNER JOIN veterinarios as v on c.id_veterinario = v.id_veterinario where data_consulta = '" & data & "' and v.nome = '" & cbVeterinario.Text & "' order by c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dg.DataSource = dt

            FormatarDG()
            VerificarHorario()

        Catch ex As Exception
            MsgBox("Erro na busca ! " + ex.Message)
        End Try
    End Sub

    Private Sub cbVeterinario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVeterinario.SelectedIndexChanged
        Buscar()
    End Sub

    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged
        Buscar()
    End Sub


    Sub RedefinirHorarios()
        Panel8.BackColor = Color.LightGreen
        Panel9.BackColor = Color.LightGreen
        Panel10.BackColor = Color.LightGreen
        Panel11.BackColor = Color.LightGreen
        Panel13.BackColor = Color.LightGreen
        Panel14.BackColor = Color.LightGreen
        Panel15.BackColor = Color.LightGreen
        Panel16.BackColor = Color.LightGreen
        Panel17.BackColor = Color.LightGreen
        Panel18.BackColor = Color.LightGreen

        Panel8.Enabled = True
        Panel9.Enabled = True
        Panel10.Enabled = True
        Panel11.Enabled = True
        Panel13.Enabled = True
        Panel14.Enabled = True
        Panel15.Enabled = True
        Panel16.Enabled = True
        Panel17.Enabled = True
        Panel18.Enabled = True

    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click

        HorarioLivre = lbl8.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click

        HorarioLivre = lbl9.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs) Handles Panel10.Click

        HorarioLivre = lbl10.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub Panel11_Click(sender As Object, e As EventArgs) Handles Panel11.Click

        HorarioLivre = lbl11.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub Panel13_Click(sender As Object, e As EventArgs) Handles Panel13.Click

        HorarioLivre = lbl13.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub


    Private Sub Panel14_Click(sender As Object, e As EventArgs) Handles Panel14.Click

        HorarioLivre = lbl14.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub


    Private Sub Panel15_Click(sender As Object, e As EventArgs) Handles Panel15.Click

        HorarioLivre = lbl15.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub Panel16_Click(sender As Object, e As EventArgs) Handles Panel16.Click

        HorarioLivre = lbl16.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub


    Private Sub Panel17_Click(sender As Object, e As EventArgs) Handles Panel17.Click

        HorarioLivre = lbl17.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub Panel18_Click(sender As Object, e As EventArgs) Handles Panel18.Click

        HorarioLivre = lbl18.Text
        Veterinario = cbVeterinario.Text
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub frmQuadroHorario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Listar()
        CarregarVeterinarios()
        If cargoUsuario = "Veterinario" Then
            cbVeterinario.Text = nomeUsuario
        End If

    End Sub
End Class