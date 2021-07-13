Imports MySql.Data.MySqlClient

Public Class frmCliente

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listar()
        DesabilitarCampos()

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
        btnExcluir.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.btn_novo
        btnNovo.Enabled = True

    End Sub
    Private Sub HabilitarCampos()

        txtNome.Enabled = True
        txtBuscar.Enabled = True
        txtCpf.Enabled = True
        txtEndereco.Enabled = True
        txtTelefone.Enabled = True
        txtEmail.Enabled = True


    End Sub
    Private Sub LimparCampos()

        txtCodigo.Text = ""
        txtNome.Text = ""
        txtBuscar.Text = ""
        txtCpf.Text = ""
        txtEndereco.Text = ""
        txtTelefone.Text = ""
        btnEditar.Text = ""
        btnExcluir.Text = ""
        btnSalvar.Text = ""
        txtEmail.Text = ""

    End Sub
    Private Sub DesabilitarCampos()

        txtNome.Enabled = False
        txtBuscar.Enabled = False
        txtCpf.Enabled = False
        txtEndereco.Enabled = False
        txtTelefone.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnSalvar.Enabled = False
        txtEmail.Enabled = False

    End Sub

    Private Sub contarLinhas()

        Dim total As Integer = dgCliente.Rows.Count
        lblTotal.Text = total - 1

    End Sub

    Private Sub listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from clientes order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgCliente.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro na listagem " + ex.Message)
        End Try
    End Sub

    Private Sub formatarDG()

        dgCliente.Columns(0).Visible = False


        dgCliente.Columns(0).HeaderText = "Codigo Cliente"
        dgCliente.Columns(1).HeaderText = "Nome"
        dgCliente.Columns(2).HeaderText = "Telefone"
        dgCliente.Columns(3).HeaderText = "CPF"
        dgCliente.Columns(4).HeaderText = "Endereço"
        dgCliente.Columns(5).HeaderText = "E-mail"

    End Sub

    Private Sub botaoInativo()

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
        btnExcluir.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.btn_novo
        btnNovo.Enabled = True

    End Sub

    Private Sub dgCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCliente.CellDoubleClick
        HabilitarCampos()

        txtCodigo.Text = dgCliente.CurrentRow.Cells(0).Value
        txtNome.Text = dgCliente.CurrentRow.Cells(1).Value
        txtTelefone.Text = dgCliente.CurrentRow.Cells(2).Value
        txtCpf.Text = dgCliente.CurrentRow.Cells(3).Value
        txtEndereco.Text = dgCliente.CurrentRow.Cells(4).Value
        txtEmail.Text = dgCliente.CurrentRow.Cells(5).Value

        btnEditar.BackgroundImage = My.Resources.bt_editar
        btnEditar.Enabled = True

        btnExcluir.BackgroundImage = My.Resources.bt_excluir
        btnExcluir.Enabled = True

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub Buscar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from clientes where nome LIKE '" & txtBuscar.Text & "%' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgCliente.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception

            MsgBox("Erro ao pesquisar nome !" + ex.Message)

        End Try

    End Sub
    Private Sub BuscarCpf()

        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from clientes where cpf = '" & txtBuscarCpf.Text & "' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgCliente.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception

            'MsgBox("Erro ao buscar cpf " + ex.Message)

        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

        Buscar()

    End Sub

    Private Sub rbNome_CheckedChanged(sender As Object, e As EventArgs) Handles rbNome.CheckedChanged

        txtBuscar.Text = ""
        txtBuscarCpf.Text = ""
        txtBuscar.Visible = True
        txtBuscarCpf.Visible = False
        Buscar()

    End Sub

    Private Sub rbCpf_CheckedChanged(sender As Object, e As EventArgs) Handles rbCpf.CheckedChanged

        txtBuscar.Text = ""
        txtBuscarCpf.Text = ""
        txtBuscar.Visible = False
        txtBuscarCpf.Visible = True
        Buscar()

    End Sub

    Private Sub txtBuscarCpf_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCpf.TextChanged

        BuscarCpf()

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        LimparCampos()
        HabilitarCampos()

        rbNome.Checked = True

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
        btnExcluir.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar
        btnSalvar.Enabled = True

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim verifica As String
        verifica = "@"

        If (txtEmail.Text.Contains(verifica)) Then

                If txtNome.Text <> "" Or txtCpf.Text <> "" Or txtEmail.Text <> "" Then

                    Try

                        'Verifica usuario existente
                        abrir()
                        Dim cmdUser As MySqlCommand
                        Dim reader As MySqlDataReader
                        Dim sqlUser
                        sqlUser = "select * from clientes  where cpf = '" & txtCpf.Text & "'"
                        cmdUser = New MySqlCommand(sqlUser, con)
                        reader = cmdUser.ExecuteReader

                        If reader.Read = True Then

                            MsgBox("Usuário já cadastrado, ou e-mail inválido, verifique")
                            fechar()

                        Else
                            fechar()

                            abrir()
                            Dim cmd As MySqlCommand
                            Dim sql As String
                            sql = "Insert into clientes 
                      (nome, 
                       telefone, 
                       cpf, 
                       endereco, email)
                      values (
                        '" & txtNome.Text & "', 
                        '" & txtTelefone.Text & "',
                        '" & txtCpf.Text & "',
                        '" & txtEndereco.Text & "',
                        '" & txtEmail.Text & "')"
                            cmd = New MySqlCommand(sql, con)
                            cmd.ExecuteNonQuery()
                            MsgBox("Dados salvos com sucesso.")

                            LimparCampos()

                            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
                            btnEditar.Enabled = False

                            btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
                            btnExcluir.Enabled = False

                            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
                            btnSalvar.Enabled = False

                            btnNovo.BackgroundImage = My.Resources.btn_novo
                            btnNovo.Enabled = True

                            listar()
                            contarLinhas()

                        End If

                    Catch ex As Exception
                        MsgBox("Erro ao salvar." + ex.Message)
                    End Try

                Else

                    MsgBox("O campo Nome e CPF são obrigatórios, favor preencher")

                End If


            Else

                MsgBox("E-mail digitado é inválid, verifique.")


            End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Or txtCpf.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE clientes 
                        SET 
                        nome = '" & txtNome.Text & "',
                        telefone = '" & txtTelefone.Text & "',
                        cpf = '" & txtCpf.Text & "',
                        endereco = '" & txtEndereco.Text & "',
                        email = '" & txtEmail.Text & "'
                        where id_cliente = '" & txtCodigo.Text & "'  "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados alterados com sucesso.")
                LimparCampos()

                btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
                btnEditar.Enabled = False

                btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
                btnExcluir.Enabled = False

                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
                btnSalvar.Enabled = False

                btnNovo.BackgroundImage = My.Resources.btn_novo
                btnNovo.Enabled = True

                listar()


            Catch ex As Exception
                MsgBox("Erro ao alterar." + ex.Message)
            End Try

        Else

            MsgBox("Favor preencher os campos")

        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Deseja mesmo excluir o cliente selecionados?", "Excluir registro", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE from clientes where id_cliente = '" & txtCodigo.Text & "'  "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dado excluído com sucesso.")
                    LimparCampos()
                    listar()

                    btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
                    btnEditar.Enabled = False

                    btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
                    btnExcluir.Enabled = False

                    btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
                    btnSalvar.Enabled = False

                    btnNovo.BackgroundImage = My.Resources.btn_novo
                    btnNovo.Enabled = True

                Catch ex As Exception
                    MsgBox("Erro ao excluir." + ex.Message)
                End Try

            End If
        End If
    End Sub

End Class