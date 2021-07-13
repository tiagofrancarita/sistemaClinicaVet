Imports MySql.Data.MySqlClient

Public Class frmCategoria
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click



        LimpaCampo()
        txtDescricao.Enabled = True

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
        btnExcluir.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar
        btnSalvar.Enabled = True

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub LimpaCampo()

        txtDescricao.Text = ""

    End Sub



    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtDescricao.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "Insert into categorias (descricao) 
                values ('" & txtDescricao.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados salvos com sucesso.")
                LimpaCampo()

            Catch ex As Exception
                MsgBox("Erro ao salvar." + ex.Message)
            End Try


            listar()

            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
            btnEditar.Enabled = False

            btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
            btnExcluir.Enabled = False

            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
            btnSalvar.Enabled = False

            btnNovo.BackgroundImage = My.Resources.btn_novo
            btnNovo.Enabled = True

        Else

            MsgBox("O campo descrição é obrigatório, favor preencher")

        End If

    End Sub

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listar()
        contarLinhas()

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
        btnExcluir.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.btn_novo
        btnNovo.Enabled = True


    End Sub

    Private Sub contarLinhas()

        Dim total As Integer = dgCategoria.Rows.Count
        lblTotal.Text = total

    End Sub

    Private Sub listar()

        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias order by id_categoria asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgCategoria.DataSource = dt



            formatarDG()
            contarLinhas()


        Catch ex As Exception
            MsgBox("Erro ao listar dados." + ex.Message)
        End Try

    End Sub

    Private Sub formatarDG()

        dgCategoria.Columns(0).HeaderText = "Codigo Categoria"
        dgCategoria.Columns(1).HeaderText = "Descrição"
        dgCategoria.Columns(1).Width = 140
        dgCategoria.Columns(0).Width = 140

    End Sub

    Private Sub dgCategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCategoria.CellDoubleClick

        txtCodigo.Text = dgCategoria.CurrentRow.Cells(0).Value
        txtDescricao.Text = dgCategoria.CurrentRow.Cells(1).Value

        txtDescricao.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        btnEditar.BackgroundImage = My.Resources.bt_editar
        btnEditar.Enabled = True

        btnExcluir.BackgroundImage = My.Resources.bt_excluir
        btnExcluir.Enabled = True

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtDescricao.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE categorias SET descricao = '" & txtDescricao.Text & "' where id_categoria = '" & txtCodigo.Text & "'  "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados alterados com sucesso.")
                LimpaCampo()

            Catch ex As Exception
                MsgBox("Erro ao alterar." + ex.Message)
            End Try


            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
            btnEditar.Enabled = False

            btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
            btnExcluir.Enabled = False

            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
            btnSalvar.Enabled = False

            btnNovo.BackgroundImage = My.Resources.btn_novo
            btnNovo.Enabled = True

            LimpaCampo()
            listar()

        Else

            MsgBox("O campo descrição é obrigatório, favor preencher")

        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        If txtCodigo.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Deseja mesmo excluir os dados selecionados?", "Excluir registro", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE from categorias where id_categoria = '" & txtCodigo.Text & "'  "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dado excluído com sucesso.")
                    LimpaCampo()

                Catch ex As Exception
                    MsgBox("Erro ao excluir." + ex.Message)
                End Try


                btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
                btnEditar.Enabled = False

                btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
                btnExcluir.Enabled = False

                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
                btnSalvar.Enabled = False

                btnNovo.BackgroundImage = My.Resources.btn_novo
                btnNovo.Enabled = True

                LimpaCampo()
                listar()
            End If
        End If

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Buscar()

    End Sub

    Private Sub Buscar()

        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias where descricao LIKE '" & txtBuscar.Text & "%' order by id_categoria asc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgCategoria.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception

            MsgBox("Erro ao listar dados." + ex.Message)

        End Try

    End Sub
End Class