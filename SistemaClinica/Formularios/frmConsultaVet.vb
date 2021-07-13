Imports MySql.Data.MySqlClient

Public Class frmConsultaVet
    Private Sub frmConsultaVet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()

        btnNovo.Enabled = False
        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo

        btnSalvar.Enabled = False
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

        dtHora.Value = Now.ToString("yyyy-MM-dd HH:mm")

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
                    WHERE data_consulta = CurDate() AND (status = 'Marcado' OR status = 'Em Andamento') and v.nome = '" & nomeUsuario & "' 
                    ORDER BY c.data_consulta asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgIniciaConsulta.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception

            MsgBox("Erro ao listar consultas " + ex.Message)

        End Try

    End Sub

    Private Sub formatarDG()

        dgIniciaConsulta.Columns(0).Visible = False
        dgIniciaConsulta.Columns(1).Visible = False
        dgIniciaConsulta.Columns(2).Visible = False
        dgIniciaConsulta.Columns(4).Visible = False
        dgIniciaConsulta.Columns(6).Visible = False

        dgIniciaConsulta.Columns(0).HeaderText = "Código Consulta"
        dgIniciaConsulta.Columns(1).HeaderText = "Código Animal"
        dgIniciaConsulta.Columns(2).HeaderText = "Código Veterinario"
        dgIniciaConsulta.Columns(3).HeaderText = "Nome Animal"
        dgIniciaConsulta.Columns(4).HeaderText = "Nome Veterinario(a)"
        dgIniciaConsulta.Columns(5).HeaderText = "Cliente"
        dgIniciaConsulta.Columns(6).HeaderText = "Data Consulta"
        dgIniciaConsulta.Columns(7).HeaderText = "Hora Marcada"
        dgIniciaConsulta.Columns(8).HeaderText = "Hora Inicio"
        dgIniciaConsulta.Columns(9).HeaderText = "Hora Fim"
        dgIniciaConsulta.Columns(10).HeaderText = "Observação"
        dgIniciaConsulta.Columns(11).HeaderText = "Status"

    End Sub

    Private Sub contarLinhas()
        Dim total As Integer = dgIniciaConsulta.Rows.Count
        lblTotal.Text = total - 1
    End Sub

    Private Sub dgIniciaConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgIniciaConsulta.CellDoubleClick

        btnNovo.Enabled = True
        btnNovo.BackgroundImage = My.Resources.btn_novo

        txtCodigo.Text = dgIniciaConsulta.CurrentRow.Cells(0).Value
        txtStatus.Text = dgIniciaConsulta.CurrentRow.Cells(11).Value


    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtObs.Enabled = True
        txtObs.Text = ""
        txtObs.Focus()

        btnSalvar.Enabled = True
        btnSalvar.BackgroundImage = My.Resources.bt_salvar

        Try

            abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            If txtStatus.Text <> "Em Andamento" Then
                Dim cmdH As MySqlCommand
                Dim sqlH As String
                sqlH = "UPDATE consultas 
                   SET hora_inicio = curTime()
                   where id_consulta = '" & txtCodigo.Text & "'"
                cmdH = New MySqlCommand(sqlH, con)
                cmdH.ExecuteNonQuery()
            End If

            sql = "UPDATE consultas 
                   SET status = 'Em Andamento'
                   where id_consulta = '" & txtCodigo.Text & "'"
            cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
            'MsgBox("Consulta iniciada com sucesso.")


        Catch ex As Exception
            MsgBox("Erro ao iniciar consulta." + ex.Message)
                End Try

                btnNovo.Enabled = False
                btnNovo.BackgroundImage = My.Resources.bt_novo_inativo

                btnSalvar.Enabled = True
                btnSalvar.BackgroundImage = My.Resources.bt_salvar

                listar()
                txtObs.Text = ""




    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtObs.Text <> "" Then

            Try

                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE consultas 
                   SET status = 'Finalizado',
                        hora_fim = curTime(),
                       obs = '" & txtObs.Text & "'   
                   where id_consulta = '" & txtCodigo.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Consulta finalizada com sucesso.")

                Dim codigo As Integer
                codigo = txtCodigo.Text

                Dim frmRelConsulta = New frmRelConsulta(codigo)
                frmRelConsulta.ShowDialog()


            Catch ex As Exception

            End Try

            btnNovo.Enabled = False
            btnNovo.BackgroundImage = My.Resources.bt_novo_inativo

            btnSalvar.Enabled = False
            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

            listar()
            txtObs.Text = ""

        Else

            MsgBox("Preencha o campo observação!")

        End If
    End Sub
End Class