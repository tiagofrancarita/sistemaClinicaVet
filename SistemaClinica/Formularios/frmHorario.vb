Imports MySql.Data.MySqlClient

Public Class frmHorario
    Private Sub frmHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()

        btnNovo.Enabled = True
        btnNovo.BackgroundImage = My.Resources.btn_novo

        btnEditar.Enabled = False
        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

        btnExcluir.Enabled = False
        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo

        btnSalvar.Enabled = False
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

    End Sub

    Private Sub listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from horarios order by horario asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgHorario.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try

    End Sub

    Private Sub formatarDG()


        dgHorario.Columns(0).Visible = False


        dgHorario.Columns(0).HeaderText = "Id do Horário"
        dgHorario.Columns(1).HeaderText = "Horário"

    End Sub
    Private Sub dgHorario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHorario.CellDoubleClick

        btnNovo.Enabled = False
        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo

        btnSalvar.Enabled = False
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

        btnEditar.Enabled = True
        btnEditar.BackgroundImage = My.Resources.bt_editar_menor

        btnExcluir.Enabled = True
        btnExcluir.BackgroundImage = My.Resources.bt_excluir_menor

        dtHora.Enabled = True

        txtCodigo.Text = dgHorario.CurrentRow.Cells(0).Value
        dtHora.Text = dgHorario.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub contarLinhas()

        Dim total As Integer = dgHorario.Rows.Count
        lblTotal.Text = total - 1

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        dtHora.Enabled = True
        btnSalvar.Enabled = True
        btnSalvar.BackgroundImage = My.Resources.bt_salvar

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try

            'Verifica usuario existente
            abrir()
            Dim cmdUser As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sqlUser
            sqlUser = "select * from horarios  where horario = '" & dtHora.Text & "'"
            cmdUser = New MySqlCommand(sqlUser, con)
            reader = cmdUser.ExecuteReader

            If reader.Read = True Then

                MsgBox("Horário já cadastrado.")
                fechar()

            Else
                fechar()

                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "Insert into horarios 
                      (horario)
                      values ('" & dtHora.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados salvos com sucesso.")


                btnSalvar.Enabled = False
                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

                btnNovo.Enabled = True
                btnNovo.BackgroundImage = My.Resources.btn_novo

                listar()
                contarLinhas()

            End If

        Catch ex As Exception
            MsgBox("Erro ao cadastrar horário." + ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            abrir()
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "UPDATE horarios SET horario = '" & dtHora.Text & "' where id_horario = '" & txtCodigo.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Dados Editado com Sucesso!!")
        Catch ex As Exception
            MsgBox("Erro ao Editar!! " + ex.Message)
        End Try


        btnSalvar.Enabled = False
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

        btnEditar.Enabled = False
        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

        btnExcluir.Enabled = False
        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo

        btnNovo.Enabled = True
        btnNovo.BackgroundImage = My.Resources.btn_novo

        listar()
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Confirmar Exclusão?", "Excluir Registro", MessageBoxButtons.YesNo)
            If result = vbYes Then
                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM horarios where id_horario = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dado Excluido com Sucesso!!")
                Catch ex As Exception
                    MsgBox("Erro ao Excluir!! " + ex.Message)
                End Try

                btnSalvar.Enabled = False
                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

                btnEditar.Enabled = False
                btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

                btnExcluir.Enabled = False
                btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo

                btnNovo.Enabled = True
                btnNovo.BackgroundImage = My.Resources.btn_novo

                listar()


            End If

        Else
            MsgBox("Selecione um registro para excluir")
        End If
    End Sub

End Class