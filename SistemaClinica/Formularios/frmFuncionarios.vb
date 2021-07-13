Imports MySql.Data.MySqlClient

Public Class frmFuncionarios

    Public id_func As String

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        LimparCampos()
        HabilitarCampos()

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
        btnExcluir.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar
        btnSalvar.Enabled = True

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub frmFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from funcionarios order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgFuncionario.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub HabilitarCampos()

        txtNome.Enabled = True
        txtBuscar.Enabled = True
        txtCpf.Enabled = True
        TxtEndereco.Enabled = True
        txtSenha.Enabled = True
        txtTelefone.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        cboCargo.Enabled = True
        txtSenha.Enabled = True
        txtUsuario.Enabled = True
        txtEmail.Enabled = True


    End Sub

    Private Sub LimparCampos()

        txtCodigo.Text = ""
        txtNome.Text = ""
        txtBuscar.Text = ""
        txtCpf.Text = ""
        TxtEndereco.Text = ""
        txtSenha.Text = ""
        txtTelefone.Text = ""
        btnEditar.Text = ""
        btnExcluir.Text = ""
        btnSalvar.Text = ""
        txtSenha.Text = ""
        txtUsuario.Text = ""
        txtEmail.Text = ""
        cboCargo.Text = ""
        lblcrmv.Visible = False
        txtCrmv.Visible = False



    End Sub

    Private Sub DesabilitarCampos()

        txtNome.Enabled = False
        txtCpf.Enabled = False
        TxtEndereco.Enabled = False
        txtSenha.Enabled = False
        txtTelefone.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnSalvar.Enabled = False
        txtSenha.Enabled = False
        txtUsuario.Enabled = False
        txtEmail.Enabled = False

    End Sub

    Private Sub contarLinhas()

        Dim total As Integer = dgFuncionario.Rows.Count
        lblTotal.Text = total - 1

    End Sub

    Private Sub formatarDG()

        dgFuncionario.Columns(0).Visible = False
        dgFuncionario.Columns(6).Visible = False

        dgFuncionario.Columns(0).HeaderText = "Codigo Funcionário"
        dgFuncionario.Columns(1).HeaderText = "Nome"
        dgFuncionario.Columns(2).HeaderText = "Cargo"
        dgFuncionario.Columns(3).HeaderText = "Endereço"
        dgFuncionario.Columns(4).HeaderText = "Telefone"
        dgFuncionario.Columns(5).HeaderText = "CPF"
        dgFuncionario.Columns(7).HeaderText = "Usuário"
        dgFuncionario.Columns(8).HeaderText = "E-mail"

        dgFuncionario.Columns(4).Width = 80
        dgFuncionario.Columns(2).Width = 80


    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim verifica As String
        verifica = "@"

        If (txtEmail.Text.Contains(verifica)) Then

            If txtNome.Text <> "" Or txtCpf.Text <> "" Or txtSenha.Text <> "" Then

                Try

                    'Verifica usuario existente
                    abrir()
                    Dim cmdUser As MySqlCommand
                    Dim reader As MySqlDataReader
                    Dim sqlUser
                    sqlUser = "select * from funcionarios  
                           where usuario = '" & txtUsuario.Text & "' or cpf = '" & txtCpf.Text & "' "
                    cmdUser = New MySqlCommand(sqlUser, con)
                    reader = cmdUser.ExecuteReader

                    If reader.Read = True Then

                        MsgBox("Usuário já cadastrado.")
                        fechar()

                    Else
                        fechar()

                        abrir()
                        Dim cmd As MySqlCommand
                        Dim sql As String
                        sql = "Insert into funcionarios 
                            (nome, cargo, endereco, telefone, cpf, senha,usuario,email) 
                            values ('" & txtNome.Text & "', '" & cboCargo.Text & "', 
                             '" & TxtEndereco.Text & "','" & txtTelefone.Text & "', 
                             '" & txtCpf.Text & "','" & txtSenha.Text & "',
                             '" & txtUsuario.Text & "','" & txtEmail.Text & "')"
                        cmd = New MySqlCommand(sql, con)

                        If cboCargo.Text = "Veterinário" And txtCrmv.Text = "  -" Then
                            MsgBox("O campo CRMV é obrigatório, favor preencher.")
                            txtCrmv.Focus()
                            Exit Sub

                        Else
                            cmd.ExecuteNonQuery()
                        End If

                        'recupera id_funcionario
                        abrir()
                        Dim cmdFunc As MySqlCommand
                        Dim readerFunc As MySqlDataReader
                        Dim sqlFunc As String
                        sqlFunc = "select MAX(id_funcionario) from funcionarios "
                        cmdFunc = New MySqlCommand(sqlFunc, con)
                        readerFunc = cmdFunc.ExecuteReader

                        If readerFunc.Read = True Then

                            id_func = readerFunc(0)
                            'MsgBox(id_func)
                            readerFunc.Close()

                        End If

                        'Salvando dados na tab veterinarios
                        If cboCargo.Text = "Veterinário" Then
                            Dim cmdVet As MySqlCommand
                            Dim sqlVet As String
                            sqlVet = "Insert into veterinarios 
                               (id_funcionario, nome, crmv) 
                        values ('" & id_func & "', '" & txtNome.Text & "', 
                        '" & txtCrmv.Text & "')"
                            cmdVet = New MySqlCommand(sqlVet, con)
                            cmdVet.ExecuteNonQuery()

                        Else

                        End If
                        MsgBox("Dados salvos com sucesso.")
                    End If
                Catch ex As Exception
                    MsgBox("Erro ao salvar." + ex.Message)
                End Try

                listar()
                LimparCampos()
                contarLinhas()

                btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
                btnEditar.Enabled = False

                btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
                btnExcluir.Enabled = False

                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
                btnSalvar.Enabled = False

                btnNovo.BackgroundImage = My.Resources.btn_novo
                btnNovo.Enabled = True

            Else

                MsgBox("O campo Nome, CPF e Senha são obrigatórios, favor preencher")

            End If

        Else

            MsgBox("E-mail digitado é inválid, verifique.")

        End If

    End Sub

    Private Sub dgFuncionario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFuncionario.CellDoubleClick

        HabilitarCampos()

        btnEditar.BackgroundImage = My.Resources.bt_editar
        btnEditar.Enabled = True

        btnExcluir.BackgroundImage = My.Resources.bt_excluir
        btnExcluir.Enabled = True

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False


        txtCodigo.Text = dgFuncionario.CurrentRow.Cells(0).Value
        txtNome.Text = dgFuncionario.CurrentRow.Cells(1).Value
        cboCargo.Text = dgFuncionario.CurrentRow.Cells(2).Value
        TxtEndereco.Text = dgFuncionario.CurrentRow.Cells(3).Value
        txtTelefone.Text = dgFuncionario.CurrentRow.Cells(4).Value
        txtCpf.Text = dgFuncionario.CurrentRow.Cells(5).Value
        txtSenha.Text = dgFuncionario.CurrentRow.Cells(6).Value
        txtUsuario.Text = dgFuncionario.CurrentRow.Cells(7).Value
        txtEmail.Text = dgFuncionario.CurrentRow.Cells(8).Value

        cboCargo.Enabled = False
        lblcrmv.Visible = False
        txtCrmv.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Or txtCpf.Text <> "" Or txtSenha.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE funcionarios 
                        SET 
                        nome = '" & txtNome.Text & "',
                        cargo = '" & cboCargo.Text & "',
                        endereco = '" & TxtEndereco.Text & "',
                        telefone = '" & txtTelefone.Text & "',
                        cpf = '" & txtCpf.Text & "',
                        senha = '" & txtSenha.Text & "',
                        usuario = '" & txtUsuario.Text & "',
                        email = '" & txtEmail.Text & "'
                        where id_funcionario = '" & txtCodigo.Text & "'  "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

                'Editando dados na tab veterinarios
                If cboCargo.Text = "Veterinário" Then
                    Dim cmdVet As MySqlCommand
                    Dim sqlVet As String
                    sqlVet = "Update veterinarios 
                              set
                              nome = '" & txtNome.Text & "'
                              Where  id_funcionario = '" & txtCodigo.Text & "'"

                    cmdVet = New MySqlCommand(sqlVet, con)
                    cmdVet.ExecuteNonQuery()

                Else
                End If

                MsgBox("Dados alterados com sucesso.")


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

            listar()
            LimparCampos()

        Else

            MsgBox("Favor preencher os campos")

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
                    sql = "DELETE from funcionarios where id_funcionario = '" & txtCodigo.Text & "'  "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    'Editando dados na tab veterinarios
                    If cboCargo.Text = "Veterinário" Then
                        Dim cmdVet As MySqlCommand
                        Dim sqlVet As String
                        sqlVet = "Delete from veterinarios 
                              Where  id_funcionario = '" & txtCodigo.Text & "'"

                        cmdVet = New MySqlCommand(sqlVet, con)
                        cmdVet.ExecuteNonQuery()

                    Else

                    End If

                    MsgBox("Dado excluído com sucesso.")

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

                listar()
                LimparCampos()

            End If

        End If
    End Sub
    Private Sub Buscar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from funcionarios
                    where cargo = '" & cboCargoBuscar.Text & "' or
                    nome LIKE '" & txtBuscar.Text & "%' 
                     order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgFuncionario.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        Buscar()

    End Sub

    Private Sub cboCargoBuscar_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCargoBuscar.SelectedValueChanged
        Buscar()

    End Sub

    Private Sub cboCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCargo.SelectedIndexChanged

        If cboCargo.Text = "Veterinário" Then

            lblcrmv.Visible = True
            txtCrmv.Visible = True
            txtCrmv.Text = ""

        Else

            lblcrmv.Visible = False
            txtCrmv.Visible = False
            txtCrmv.Text = ""

        End If
    End Sub
End Class