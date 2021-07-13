Imports MySql.Data.MySqlClient

Public Class frmFornecedor


    Private Sub frmFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRazao.Focus()

        listar()
        LimparCampos()

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
            sql = "select * from fornecedores order by id_fornecedor asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgFornecedor.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro na listagem de dados " + ex.Message)
        End Try
    End Sub

    Private Sub HabilitarCampos()

        txtNomeFantasia.Enabled = True
        txtRazao.Enabled = True
        txtEndereco.Enabled = True
        txtNumero.Enabled = True
        txtComplemento.Enabled = True
        txtCidade.Enabled = True
        txtEstado.Enabled = True
        txtBairro.Enabled = True
        txtCep.Enabled = True
        txtUf.Enabled = True
        cboStatus.Enabled = True
        txtCnpj.Enabled = True
        txtTelefone1.Enabled = True
        txtTelefone2.Enabled = True
        txtCelular.Enabled = True
        txtEmail.Enabled = True


    End Sub

    Private Sub LimparCampos()

        txtCodigo.Text = ""
        txtNomeFantasia.Text = ""
        txtRazao.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtComplemento.Text = ""
        txtCidade.Text = ""
        txtEstado.Text = ""
        txtBairro.Text = ""
        txtCep.Text = ""
        txtUf.Text = ""
        cboStatus.Text = ""
        txtCnpj.Text = ""
        txtTelefone1.Text = ""
        txtTelefone2.Text = ""
        txtCelular.Text = ""
        txtEmail.Text = ""

    End Sub

    Private Sub contarLinhas()

        Dim total As Integer = dgFornecedor.Rows.Count
        lblTotal.Text = total - 1

    End Sub

    Private Sub formatarDG()

        dgFornecedor.Columns(0).Visible = False
        dgFornecedor.Columns(5).Visible = False
        dgFornecedor.Columns(8).Visible = False
        dgFornecedor.Columns(9).Visible = False


        dgFornecedor.Columns(0).HeaderText = "Codigo Fornecedor"
        dgFornecedor.Columns(1).HeaderText = "Razão Social"
        dgFornecedor.Columns(2).HeaderText = "Nome Fantasia"
        dgFornecedor.Columns(3).HeaderText = "Endereço"
        dgFornecedor.Columns(4).HeaderText = "Número"
        dgFornecedor.Columns(5).HeaderText = "Complemento"
        dgFornecedor.Columns(6).HeaderText = "Cidade"
        dgFornecedor.Columns(7).HeaderText = "Estado"
        dgFornecedor.Columns(8).HeaderText = "Bairro"
        dgFornecedor.Columns(9).HeaderText = "CEP"
        dgFornecedor.Columns(10).HeaderText = "UF"
        dgFornecedor.Columns(11).HeaderText = "Data Cadastro"
        dgFornecedor.Columns(12).HeaderText = "Status"
        dgFornecedor.Columns(13).HeaderText = "CNPJ"
        dgFornecedor.Columns(14).HeaderText = "Telefone (1)"
        dgFornecedor.Columns(15).HeaderText = "Telefone (2)"
        dgFornecedor.Columns(16).HeaderText = "Celular"
        dgFornecedor.Columns(17).HeaderText = "E-mail"

        'dgFornecedor.Columns(4).Width = 80
        'dgFornecedor.Columns(2).Width = 80

    End Sub

    Private Sub Buscar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from fornecedores where status LIKE '" & cboStatusBuscar.Text & "%' order by id_fornecedor asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgFornecedor.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception

            MsgBox("Erro ao pesquisar nome !" + ex.Message)

        End Try

    End Sub

    Private Sub cboStatusBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusBuscar.SelectedIndexChanged
        Buscar()
    End Sub

    Private Sub BuscarCnpj()

        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from fornecedores where cnpj = '" & txtBuscarCNPJ.Text & "' order by id_fornecedor asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgFornecedor.DataSource = dt

            'formatarDG()
            'contarLinhas()

        Catch ex As Exception

            'MsgBox("Erro ao buscar cpf " + ex.Message)

        End Try
    End Sub

    Private Sub txtBuscarCNPJ_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCNPJ.TextChanged
        BuscarCnpj()
    End Sub

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
    Private Sub dgFornecedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgFornecedor.CellDoubleClick
        HabilitarCampos()


        'dgFornecedor.Columns(0).HeaderText = "Codigo Fornecedor"
        'dgFornecedor.Columns(1).HeaderText = "Razão Social"
        'dgFornecedor.Columns(2).HeaderText = "Nome Fantasia"
        'dgFornecedor.Columns(3).HeaderText = "Endereço"
        'dgFornecedor.Columns(4).HeaderText = "Número"
        'dgFornecedor.Columns(5).HeaderText = "Complemento"
        'dgFornecedor.Columns(6).HeaderText = "Cidade"
        'dgFornecedor.Columns(7).HeaderText = "Estado"
        'dgFornecedor.Columns(8).HeaderText = "Bairro"
        'dgFornecedor.Columns(9).HeaderText = "CEP"
        'dgFornecedor.Columns(10).HeaderText = "UF"
        'dgFornecedor.Columns(11).HeaderText = "Data Cadastro"
        'dgFornecedor.Columns(12).HeaderText = "Status"
        'dgFornecedor.Columns(13).HeaderText = "CNPJ"
        'dgFornecedor.Columns(14).HeaderText = "Telefone (1)"
        'dgFornecedor.Columns(15).HeaderText = "Telefone (2)"
        'dgFornecedor.Columns(16).HeaderText = "Celular"
        'dgFornecedor.Columns(17).HeaderText = "E-mail"

        txtCodigo.Text = dgFornecedor.CurrentRow.Cells(0).Value
        txtRazao.Text = dgFornecedor.CurrentRow.Cells(1).Value
        txtNomeFantasia.Text = dgFornecedor.CurrentRow.Cells(2).Value
        txtEndereco.Text = dgFornecedor.CurrentRow.Cells(3).Value
        txtNumero.Text = dgFornecedor.CurrentRow.Cells(4).Value
        txtComplemento.Text = dgFornecedor.CurrentRow.Cells(5).Value
        txtCidade.Text = dgFornecedor.CurrentRow.Cells(6).Value
        txtEstado.Text = dgFornecedor.CurrentRow.Cells(7).Value
        txtBairro.Text = dgFornecedor.CurrentRow.Cells(8).Value
        txtCep.Text = dgFornecedor.CurrentRow.Cells(9).Value
        txtUf.Text = dgFornecedor.CurrentRow.Cells(10).Value
        cboStatus.Text = dgFornecedor.CurrentRow.Cells(12).Value
        txtCnpj.Text = dgFornecedor.CurrentRow.Cells(13).Value
        txtTelefone1.Text = dgFornecedor.CurrentRow.Cells(14).Value
        txtTelefone2.Text = dgFornecedor.CurrentRow.Cells(15).Value
        txtCelular.Text = dgFornecedor.CurrentRow.Cells(16).Value
        txtEmail.Text = dgFornecedor.CurrentRow.Cells(17).Value


        btnEditar.BackgroundImage = My.Resources.bt_editar
        btnEditar.Enabled = True

        btnExcluir.BackgroundImage = My.Resources.bt_excluir
        btnExcluir.Enabled = True

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim verifica As String
        verifica = "@"

        If (txtEmail.Text.Contains(verifica)) Then

            If txtCnpj.Text <> "" Or txtTelefone1.Text <> "" Or txtEmail.Text <> "" Or txtEndereco.Text <> "" Or txtCidade.Text <> "" Then

                Dim data As String
                data = Now.ToString("yyyy-MM-dd")

                Try

                    'Verifica usuario existente
                    abrir()
                    Dim cmdUser As MySqlCommand
                    Dim reader As MySqlDataReader
                    Dim sqlUser
                    sqlUser = "select * from fornecedores  where cnpj = '" & txtCnpj.Text & "'"
                    cmdUser = New MySqlCommand(sqlUser, con)
                    reader = cmdUser.ExecuteReader

                    If reader.Read = True Then

                        MsgBox("Fornecedor já cadastrado, verifique os dados")
                        fechar()

                    Else
                        fechar()

                        abrir()
                        Dim cmd As MySqlCommand
                        Dim sql As String
                        sql = "INSERT INTO fornecedores(razaosocial,nomefantasia,endereco,numero,complemento,
                                cidade,estado,bairro,cep,uf,datacadastro,status,cnpj,telefone,telefone2,
                                celular,email)
                                VALUES ('" & txtRazao.Text & "','" & txtNomeFantasia.Text & "', '" & txtEndereco.Text & "',
                                        '" & txtNumero.Text & "','" & txtComplemento.Text & "','" & txtCidade.Text & "',
                                        '" & txtEstado.Text & "','" & txtBairro.Text & "','" & txtCep.Text & "','" & txtUf.Text & "',
                                        '" & data & "','" & cboStatus.Text & "','" & txtCnpj.Text & "','" & txtTelefone1.Text & "',
                                        '" & txtTelefone2.Text & "','" & txtCelular.Text & "','" & txtEmail.Text & "')"
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Fornecedor cadastrado com sucesso !")

                        LimparCampos()
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

                    End If

                Catch ex As Exception

                    MsgBox("Erro ao cadastra fornecedor." + ex.Message)

                End Try

            Else

                MsgBox("Campos obrigatórios não foram preenchidos, favor preencher")

            End If

        Else

            MsgBox("E-mail digitado é inválido, verifique.")

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtCnpj.Text <> "" Or txtTelefone1.Text <> "" Or txtEmail.Text <> "" Or txtEndereco.Text <> "" Or txtCidade.Text <> "" Then

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE fornecedores 
                        SET
                        razaosocial  =  '" & txtRazao.Text & "',
                        nomefantasia  =  '" & txtNomeFantasia.Text & "',
                        endereco  =  '" & txtEndereco.Text & "',
                        numero  =  '" & txtNumero.Text & "',
                        complemento  =  '" & txtComplemento.Text & "',
                        cidade  =  '" & txtCidade.Text & "',
                        estado  =  '" & txtEstado.Text & "',
                        bairro  =  '" & txtBairro.Text & "',
                        cep  =  '" & txtCep.Text & "',
                        uf  =  '" & txtUf.Text & "',
                        status  =  '" & cboStatus.Text & "',
                        cnpj  =  '" & txtCnpj.Text & "',
                        telefone  =  '" & txtTelefone1.Text & "',
                        telefone2  =  '" & txtTelefone2.Text & "',
                        celular  =  '" & txtCelular.Text & "',
                        email  =  '" & txtEmail.Text & "'
                        where id_fornecedor = '" & txtCodigo.Text & "'  "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados alterados com sucesso.")
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
                MsgBox("Erro ao alterar." + ex.Message)
            End Try

        Else

            MsgBox("Favor preencher os campos")

        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If txtCodigo.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Deseja mesmo excluir o fornecedor selecionado?", "Excluir registro", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Try
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE from fornecedores where id_fornecedor = '" & txtCodigo.Text & "'  "
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