Imports MySql.Data.MySqlClient

Public Class frmConsultaMarcacao
    Private Sub frmConsultaMarcacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        desabilitaBotao()
        CarregarAnimal()
        CarregarVet()
        listar()
        contarLinhas()
        dtBuscar.Value = Now

        If HorarioLivre <> "" Then
            dtHora.Text = HorarioLivre
        Else
            dtHora.Text = Now.ToString("yyyy-MM-dd 13:00")
        End If

        cboVeterinario.Text = Veterinario

    End Sub
    Private Sub limpar()

        txtCodigo.Text = ""
        dtData.Value = Now
        'dtHora.Value = Now.ToString("yyyy-MM-dd 13:00")
        'dtHora.Text = HorarioLivre


    End Sub

    Private Sub desabilitaBotao()

        btnEditar.Enabled = False
        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

        btnCancelar.Enabled = False
        btnCancelar.BackgroundImage = My.Resources.bt_excluir_inativo

        btnSalvar.Enabled = False
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

        cboAnimal.Enabled = False
        cboVeterinario.Enabled = False
        dtData.Enabled = False
        dtHora.Enabled = False

    End Sub

    Private Sub habilitaCampos()
        cboAnimal.Enabled = True
        cboVeterinario.Enabled = True
        dtData.Enabled = True
        dtHora.Enabled = True
    End Sub

    Private Sub habilitaNovo()
        cboAnimal.Enabled = True
        cboVeterinario.Enabled = True
        dtData.Enabled = True
        dtHora.Enabled = True

        btnEditar.Enabled = False
        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

        btnCancelar.Enabled = False
        btnCancelar.BackgroundImage = My.Resources.bt_excluir_inativo

        btnSalvar.Enabled = True
        btnSalvar.BackgroundImage = My.Resources.bt_salvar

    End Sub

    Private Sub CarregarVet()
        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from veterinarios order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            cboVeterinario.ValueMember = "id_veterinario"
            cboVeterinario.DisplayMember = "nome"
            cboVeterinario.DataSource = dt


        Catch ex As Exception
            MsgBox("Erro ao listar veterinário." + ex.Message)
        End Try
    End Sub
    Private Sub CarregarAnimal()
        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from animal order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            cboAnimal.ValueMember = "id_animal"
            cboAnimal.DisplayMember = "nome"
            cboAnimal.DataSource = dt


        Catch ex As Exception
            MsgBox("Erro ao listar animais." + ex.Message)
        End Try
    End Sub

    Private Sub contarLinhas()
        Dim total As Integer = dgMarcaConsulta.Rows.Count
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
                    WHERE data_consulta = CurDate() AND status = 'Marcado'
                    ORDER BY c.data_consulta asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgMarcaConsulta.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try

    End Sub

    Private Sub formatarDG()

        dgMarcaConsulta.Columns(0).Visible = False
        dgMarcaConsulta.Columns(1).Visible = False
        dgMarcaConsulta.Columns(2).Visible = False

        dgMarcaConsulta.Columns(0).HeaderText = "Código Consulta"
        dgMarcaConsulta.Columns(1).HeaderText = "Código Animal"
        dgMarcaConsulta.Columns(2).HeaderText = "Código Veterinario"
        dgMarcaConsulta.Columns(3).HeaderText = "Nome Animal"
        dgMarcaConsulta.Columns(4).HeaderText = "Nome Veterinario(a)"
        dgMarcaConsulta.Columns(5).HeaderText = "Cliente"
        dgMarcaConsulta.Columns(6).HeaderText = "Data Consulta"
        dgMarcaConsulta.Columns(7).HeaderText = "Hora Marcada"
        dgMarcaConsulta.Columns(8).HeaderText = "Hora Inicio"
        dgMarcaConsulta.Columns(9).HeaderText = "Hora Fim"
        dgMarcaConsulta.Columns(10).HeaderText = "Observação"
        dgMarcaConsulta.Columns(11).HeaderText = "Status"

    End Sub
    Private Sub dgMarcaConsulta_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgMarcaConsulta.CellDoubleClick

        btnEditar.Enabled = True
        btnEditar.BackgroundImage = My.Resources.bt_editar

        btnCancelar.Enabled = True
        btnCancelar.BackgroundImage = My.Resources.bt_excluir

        btnSalvar.Enabled = False
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

        btnNovo.Enabled = False
        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo

        txtCodigo.Text = dgMarcaConsulta.CurrentRow.Cells(0).Value
        cboAnimal.Text = dgMarcaConsulta.CurrentRow.Cells(3).Value
        cboVeterinario.Text = dgMarcaConsulta.CurrentRow.Cells(4).Value
        dtData.Value = dgMarcaConsulta.CurrentRow.Cells(6).Value
        dtHora.Text = dgMarcaConsulta.CurrentRow.Cells(7).Value.ToString

        habilitaCampos()
        cboAnimal.Enabled = False

        'dgMarcaConsulta.Columns(0).HeaderText = "Código Consulta"
        'dgMarcaConsulta.Columns(1).HeaderText = "Código Animal"
        'dgMarcaConsulta.Columns(2).HeaderText = "Código Veterinario"
        'dgMarcaConsulta.Columns(3).HeaderText = "Nome Animal"
        'dgMarcaConsulta.Columns(4).HeaderText = "Nome Veterinario(a)"
        'dgMarcaConsulta.Columns(5).HeaderText = "Cliente"
        'dgMarcaConsulta.Columns(6).HeaderText = "Data Consulta"
        'dgMarcaConsulta.Columns(7).HeaderText = "Hora Marcada"
        'dgMarcaConsulta.Columns(8).HeaderText = "Hora Inicio"
        'dgMarcaConsulta.Columns(9).HeaderText = "Hora Fim"
        'dgMarcaConsulta.Columns(10).HeaderText = "Observação"
        'dgMarcaConsulta.Columns(11).HeaderText = "Status"
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
                    WHERE data_consulta = '" & dataBuscar & "' AND status = 'Marcado'
                    ORDER BY data_consulta asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgMarcaConsulta.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        cboAnimal.Focus()
        habilitaNovo()
        btnNovo.Enabled = False
        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        limpar()


    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim data As String
        data = dtData.Value.ToString("yyyy-MM-dd")

        If cboVeterinario.Text = "" Or cboVeterinario.Text = "" Then
            MsgBox("Preencha os campos!")
        Else
            Try


                'VERIFICAR SE O HORÁRIO EXISTE NA TABELA DE HORÁRIOS
                abrir()
                Dim cmdHorario As MySqlCommand
                Dim readerHora As MySqlDataReader
                Dim sql2 As String
                sql2 = "select * from horarios where horario = '" & dtHora.Text & "' "
                cmdHorario = New MySqlCommand(sql2, con)
                readerHora = cmdHorario.ExecuteReader


                If readerHora.Read = True Then
                    'VERIFICAR SE O HORÁRIO DA CONSULTA ESTÁ LIBERADO
                    abrir()
                    readerHora.Close()
                    Dim cmdhora As MySqlCommand
                    Dim reader As MySqlDataReader
                    Dim sqlhora As String
                    sqlhora = "select * from consultas where hora = '" & dtHora.Text & "' and data_consulta = '" & data & "' and id_veterinario = '" & cboVeterinario.SelectedValue & "' and status = 'Marcado' "
                    cmdhora = New MySqlCommand(sqlhora, con)
                    reader = cmdhora.ExecuteReader

                    If reader.Read = True Then

                        MsgBox("Este horário não está disponível!")
                        reader.Close()
                        fechar()
                        Exit Sub
                    Else

                        reader.Close()
                        abrir()
                        Dim cmd As MySqlCommand
                        Dim sql As String
                        sql = "INSERT INTO consultas (id_animal, id_veterinario, data_consulta, hora, hora_inicio, hora_fim, obs, status) VALUES ('" & cboAnimal.SelectedValue & "', '" & cboVeterinario.SelectedValue & "', '" & data & "', '" & dtHora.Text & "',  '',  '', '', 'Marcado') "
                        cmd = New MySqlCommand(sql, con)

                        cmd.ExecuteNonQuery()
                        MsgBox("Dados Salvos com Sucesso!!")
                    End If
                Else
                    MsgBox("Este Horário não está cadastrado!")
                    fechar()
                End If

            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try

            listar()
            contarLinhas()
            limpar()

            btnNovo.Enabled = True
            btnNovo.BackgroundImage = My.Resources.btn_novo

            btnEditar.Enabled = False
            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

            btnCancelar.Enabled = False
            btnCancelar.BackgroundImage = My.Resources.bt_excluir_inativo

            btnSalvar.Enabled = False
            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim data As String
        data = dtData.Value.ToString("yyyy-MM-dd")

        If cboVeterinario.Text = "" Or cboAnimal.Text = "" Then
            MsgBox("Preencha os campos!")
        Else
            Try

                'VERIFICAR SE O HORÁRIO DA CONSULTA JÁ EXISTE
                abrir()
                Dim cmdhora As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sqlhora As String
                sqlhora = "select * from consultas where hora = '" & dtHora.Text & "' and data_consulta = '" & data & "' and id_veterinario = '" & cboVeterinario.SelectedValue & "' and status = 'Marcado' "
                cmdhora = New MySqlCommand(sqlhora, con)
                reader = cmdhora.ExecuteReader

                If reader.Read = True Then

                    MsgBox("Este horário não está disponível!")
                    reader.Close()
                    fechar()
                    Exit Sub
                Else
                    reader.Close()
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE consultas SET id_veterinario = '" & cboVeterinario.SelectedValue & "', data_consulta = '" & data & "', hora = '" & dtHora.Text & "' where id_consulta = '" & txtCodigo.Text & "' "
                    cmd = New MySqlCommand(sql, con)

                    cmd.ExecuteNonQuery()
                    MsgBox("Dados Salvos com Sucesso!!")
                End If


            Catch ex As Exception
                MsgBox("Erro ao editar!! " + ex.Message)
            End Try

            listar()
            contarLinhas()
            limpar()

            btnSalvar.Enabled = False
            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

            btnNovo.Enabled = True
            btnNovo.BackgroundImage = My.Resources.btn_novo

            btnEditar.Enabled = False
            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

            btnCancelar.Enabled = False
            btnCancelar.BackgroundImage = My.Resources.bt_excluir_inativo

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim data As String
        data = dtData.Value.ToString("yyyy-MM-dd")

        If txtCodigo.Text = "" Then

            MsgBox("Campos obrigatórios vazios, favor selecionar!")

        Else

            Dim result As DialogResult = MessageBox.Show("Deseja cancelar a consulta selecionada?", "Excluir registro", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                Try

                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE consultas 
                           SET 
                           status = 'Cancelado'
                           where id_consulta = '" & txtCodigo.Text & "'"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Consulta cancelada com sucesso.")

                Catch ex As Exception
                    MsgBox("Erro ao cancelar consulta." + ex.Message)
                End Try

                listar()
                contarLinhas()
                limpar()

                btnNovo.Enabled = True
                btnNovo.BackgroundImage = My.Resources.btn_novo

                btnSalvar.Enabled = False
                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

                btnEditar.Enabled = False
                btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

                btnCancelar.Enabled = False
                btnCancelar.BackgroundImage = My.Resources.bt_excluir_inativo
            End If

        End If
    End Sub

    Private Sub dtBuscar_ValueChanged(sender As Object, e As EventArgs) Handles dtBuscar.ValueChanged
        Buscar()

    End Sub
End Class