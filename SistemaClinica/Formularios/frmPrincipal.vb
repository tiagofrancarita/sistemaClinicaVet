Imports MySql.Data.MySqlClient

Public Class frmPrincipal


    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblAndamento.Visible = False
        lblTotalAndamento.Visible = False
        lblTotalCanceladas.Visible = False
        lblTotalFinalizado.Visible = False
        Label3.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False


        listarConsultaEmAndamento()
        listaProximasConsultas()

        lblUsuario.Text = nomeUsuario
        lblCargo.Text = cargoUsuario




        MenuCadastro.Enabled = False
        MenuCadCli.Enabled = False
        MenuCadFun.Enabled = False
        CadHorarioAtendimento.Enabled = False


        MenuAnimais.Enabled = False
        MenuCadAnimal.Enabled = False
        MenuCadEspecie.Enabled = False


        MenuRelatorio.Enabled = False
        MenuRelAniEsp.Enabled = False
        MenuRelatorioAnimais.Enabled = False
        MenuRelatorioEspecies.Enabled = False


        MenuAtendimento.Enabled = False
        MenuMarcaConsulta.Enabled = False
        MenuConsultaAgendada.Enabled = False
        MenuListaConsulta.Enabled = False
        MenuQuadroHorario.Enabled = False

        BtCadastroAnimais.Enabled = False
        btCadastroCliente.Enabled = False
        BtMarcacaoConsulta.Enabled = False
        btRelatorioConsulta.Enabled = False

        MenuFinanceiro.Enabled = False
        SubContasPagar.Enabled = False
        SubContasReceber.Enabled = False



        restricao()

    End Sub

    Private Sub restricao()
        If cargoUsuario = "Veterinário" Then

            MenuAtendimento.Enabled = True
            MenuConsultaAgendada.Enabled = True
            MenuListaConsulta.Enabled = True
            MenuQuadroHorario.Enabled = True
            BtMarcacaoConsulta.Enabled = True
            btRelatorioConsulta.Enabled = True

        End If

        If cargoUsuario = "Atendente" Then

            MenuCadastro.Enabled = True
            MenuCadCli.Enabled = True

            MenuAnimais.Enabled = True
            MenuCadAnimal.Enabled = True
            MenuCadEspecie.Enabled = True

            MenuAtendimento.Enabled = True
            MenuMarcaConsulta.Enabled = True
            MenuQuadroHorario.Enabled = True

            BtCadastroAnimais.Enabled = True
            btCadastroCliente.Enabled = True
            BtMarcacaoConsulta.Enabled = True

        End If

        If cargoUsuario = "Gerente" Then

            MenuCadastro.Enabled = True
            MenuCadCli.Enabled = True
            MenuCadFun.Enabled = True
            CadHorarioAtendimento.Enabled = True
            MenuAnimais.Enabled = True
            MenuCadAnimal.Enabled = True
            MenuCadEspecie.Enabled = True
            MenuRelatorio.Enabled = True
            MenuRelAniEsp.Enabled = True
            MenuRelatorioAnimais.Enabled = True
            MenuRelatorioEspecies.Enabled = True
            MenuAtendimento.Enabled = True
            MenuListaConsulta.Enabled = True
            MenuQuadroHorario.Enabled = True
            BtCadastroAnimais.Enabled = True
            btCadastroCliente.Enabled = True
            BtMarcacaoConsulta.Enabled = True
            MenuFinanceiro.Enabled = True
            SubContasPagar.Enabled = True
            SubContasReceber.Enabled = True


        End If

        If cargoUsuario = "Administrador" Then


            MenuCadastro.Enabled = True
            MenuCadCli.Enabled = True
            MenuCadFun.Enabled = True
            CadHorarioAtendimento.Enabled = True


            MenuAnimais.Enabled = True
            MenuCadAnimal.Enabled = True
            MenuCadEspecie.Enabled = True


            MenuRelatorio.Enabled = True
            MenuRelAniEsp.Enabled = True
            MenuRelatorioAnimais.Enabled = True
            MenuRelatorioEspecies.Enabled = True


            MenuAtendimento.Enabled = True
            MenuMarcaConsulta.Enabled = True
            MenuConsultaAgendada.Enabled = True
            MenuListaConsulta.Enabled = True
            MenuQuadroHorario.Enabled = True

            BtCadastroAnimais.Enabled = True
            btCadastroCliente.Enabled = True
            BtMarcacaoConsulta.Enabled = True
            btRelatorioConsulta.Enabled = True

            MenuFinanceiro.Enabled = True
            SubContasPagar.Enabled = True
            SubContasReceber.Enabled = True

        End If

    End Sub

    Private Sub frmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Application.Exit()

    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles MenuCadEspecie.Click
        Dim frmcategoria = New frmCategoria
        frmcategoria.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles MenuCadAnimal.Click
        Dim frmanimais = New frmAnimais()
        frmanimais.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MenuCadFun.Click
        Dim frmfuncionario = New frmFuncionarios
        frmfuncionario.ShowDialog()
    End Sub

    Private Sub DsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BtCadastroAnimais.Click
        Dim frmanimais = New frmAnimais()
        frmanimais.ShowDialog()
    End Sub

    Private Sub DdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btCadastroCliente.Click
        Dim frmcliente = New frmCliente
        frmcliente.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MenuCadCli.Click
        Dim frmcliente = New frmCliente
        frmcliente.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click

        Dim frmLogin = New frmLogin
        frmLogin.ShowDialog()

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles MenuRelatorioAnimais.Click
        Dim frmRelAnimais = New frmRelAnimais
        frmRelAnimais.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles MenuRelatorioEspecies.Click
        Dim frmRelEspecies = New frmRelEspecies
        frmRelEspecies.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles MenuRelAniEsp.Click
        Dim frmRelAnimaisEspecies = New frmRelAnimaisEspecies
        frmRelAnimaisEspecies.ShowDialog()
    End Sub

    Private Sub MarcaçãoDeConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuMarcaConsulta.Click
        Dim frmMarcacaoConsulta = New frmConsultaMarcacao
        frmMarcacaoConsulta.ShowDialog()
    End Sub

    Private Sub ConsultasAgendadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuConsultaAgendada.Click
        Dim frmConsultasAgendadas = New frmConsultaVet
        frmConsultasAgendadas.ShowDialog()
    End Sub

    Private Sub ListagemDeConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuListaConsulta.Click
        Dim frmListaConsulta = New frmListaConsulta
        frmListaConsulta.ShowDialog()
    End Sub

    Private Sub HorariosDeAtendimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadHorarioAtendimento.Click
        Dim frmHorario = New frmHorario
        frmHorario.ShowDialog()
    End Sub

    Private Sub QuadroDeHoráriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuQuadroHorario.Click
        Dim frmQuadroHorario = New frmQuadroHorario
        frmQuadroHorario.ShowDialog()
    End Sub

    Private Sub DddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BtMarcacaoConsulta.Click
        Dim form = New frmConsultaMarcacao
        form.ShowDialog()
    End Sub

    Private Sub DddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles btQuadroHorario.Click
        Dim form = New frmQuadroHorario
        form.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles btRelatorioConsulta.Click
        Dim codigo As Integer


        Dim frmRelConsulta = New frmRelConsulta(codigo)
        frmRelConsulta.ShowDialog()
    End Sub
    Private Sub RelatoriodeConsulta_Click(sender As Object, e As EventArgs) Handles RelatoriodeConsulta.Click
        Dim frmConsultaData = New frmRelConsultaData
        frmConsultaData.ShowDialog()
    End Sub

    Private Sub lblUsuario_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click

        Dim frmTrocaSenha = New frmTrocaSenha
        frmTrocaSenha.ShowDialog()

    End Sub

    Private Sub CadFornecedor_Click(sender As Object, e As EventArgs) Handles CadFornecedor.Click

        Dim frmFornecedor = New frmFornecedor
        frmFornecedor.ShowDialog()

    End Sub

    Private Sub ContasAPagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubContasPagar.Click
        Dim frmContasPagar = New frmContasPagar
        frmContasPagar.ShowDialog()
    End Sub

    Private Sub listaProximasConsultas()

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
                    ORDER BY c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgProximasConsultas.DataSource = dt

            formatarDGProximaConsulta()


        Catch ex As Exception
            MsgBox("Erro ao Listar proximas consultas " + ex.Message)
        End Try
    End Sub

    Private Sub listarConsultaEmAndamento()


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
                    WHERE data_consulta = CurDate() AND status = 'Em Andamento'
                    ORDER BY c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgListaAndamento.DataSource = dt

            formatarDGlistarConsultaEmAndamento()


        Catch ex As Exception
            MsgBox("Erro ao listar consultas em andamento " + ex.Message)
        End Try

    End Sub
    Private Sub listaProximasConsultasVet()

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
                    WHERE data_consulta = CurDate() AND status = 'Marcado' and v.nome = '" & nomeUsuario & "'
                    ORDER BY c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgProximasConsultasVet.DataSource = dt

            formatarDGProximaConsultaVet()


        Catch ex As Exception
            MsgBox("Erro ao listar consulta do vet " + ex.Message)
        End Try
    End Sub

    Private Sub listaProximasConsultasAtd()


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
                    WHERE data_consulta = CurDate() AND (status = 'Marcado' or status ='Em Andamento')
                    ORDER BY c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            dgProximasConsultasAtd.DataSource = dt

            formatarDGProximaConsultaAtd()


        Catch ex As Exception
            MsgBox("Erro ao Listar proximas consultas do atendimento " + ex.Message)
        End Try
    End Sub

    Private Sub listaConsultasFinalizadas()

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
                    WHERE data_consulta = CurDate() AND status = 'Finalizado'
                    ORDER BY c.hora asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            dgConsultaFinalizada.DataSource = dt

            formatarConsultaFinalizada()


        Catch ex As Exception
            MsgBox("Erro ao Listar consultas finalizadas " + ex.Message)
        End Try
    End Sub



    Private Sub formatarDGlistarConsultaEmAndamento()

        dgListaAndamento.Columns(0).Visible = False
        dgListaAndamento.Columns(1).Visible = False
        dgListaAndamento.Columns(2).Visible = False
        dgListaAndamento.Columns(6).Visible = False
        dgListaAndamento.Columns(9).Visible = False
        dgListaAndamento.Columns(10).Visible = False
        'dgListaAndamento.Columns(11).Visible = False

        dgListaAndamento.Columns(0).HeaderText = "Código Consulta"
        dgListaAndamento.Columns(1).HeaderText = "Código Animal"
        dgListaAndamento.Columns(2).HeaderText = "Código Veterinario"
        dgListaAndamento.Columns(3).HeaderText = "Nome Animal"
        dgListaAndamento.Columns(4).HeaderText = "Nome Veterinario(a)"
        dgListaAndamento.Columns(5).HeaderText = "Cliente"
        dgListaAndamento.Columns(6).HeaderText = "Data Consulta"
        dgListaAndamento.Columns(7).HeaderText = "Hora Marcada"
        dgListaAndamento.Columns(8).HeaderText = "Hora Inicio"
        dgListaAndamento.Columns(9).HeaderText = "Hora Fim"
        dgListaAndamento.Columns(10).HeaderText = "Observação"
        dgListaAndamento.Columns(11).HeaderText = "Status"


    End Sub


    Private Sub formatarDGProximaConsulta()

        dgProximasConsultas.Columns(0).Visible = False
        dgProximasConsultas.Columns(1).Visible = False
        dgProximasConsultas.Columns(2).Visible = False
        dgProximasConsultas.Columns(6).Visible = False
        dgProximasConsultas.Columns(9).Visible = False
        dgProximasConsultas.Columns(10).Visible = False
        'dgProximasConsultas.Columns(11).Visible = False

        dgProximasConsultas.Columns(0).HeaderText = "Código Consulta"
        dgProximasConsultas.Columns(1).HeaderText = "Código Animal"
        dgProximasConsultas.Columns(2).HeaderText = "Código Veterinario"
        dgProximasConsultas.Columns(3).HeaderText = "Nome Animal"
        dgProximasConsultas.Columns(4).HeaderText = "Nome Veterinario(a)"
        dgProximasConsultas.Columns(5).HeaderText = "Cliente"
        dgProximasConsultas.Columns(6).HeaderText = "Data Consulta"
        dgProximasConsultas.Columns(7).HeaderText = "Hora Marcada"
        dgProximasConsultas.Columns(8).HeaderText = "Hora Inicio"
        dgProximasConsultas.Columns(9).HeaderText = "Hora Fim"
        dgProximasConsultas.Columns(10).HeaderText = "Observação"
        dgProximasConsultas.Columns(11).HeaderText = "Status"
    End Sub

    Private Sub formatarDGProximaConsultaVet()

        dgProximasConsultasVet.Columns(0).Visible = False
        dgProximasConsultasVet.Columns(1).Visible = False
        dgProximasConsultasVet.Columns(2).Visible = False
        dgProximasConsultasVet.Columns(4).Visible = False
        dgProximasConsultasVet.Columns(6).Visible = False
        dgProximasConsultasVet.Columns(8).Visible = False
        dgProximasConsultasVet.Columns(9).Visible = False
        dgProximasConsultasVet.Columns(10).Visible = False
        dgProximasConsultasVet.Columns(11).Visible = False



        dgProximasConsultasVet.Columns(0).HeaderText = "Código Consulta" 'invisivel
        dgProximasConsultasVet.Columns(1).HeaderText = "Código Animal" 'invisivel
        dgProximasConsultasVet.Columns(2).HeaderText = "Código Veterinario" 'invisivel
        dgProximasConsultasVet.Columns(3).HeaderText = "Nome Animal"
        dgProximasConsultasVet.Columns(4).HeaderText = "Nome Veterinario(a)" 'invisivel
        dgProximasConsultasVet.Columns(5).HeaderText = "Cliente"
        dgProximasConsultasVet.Columns(6).HeaderText = "Data Consulta" 'invisivel
        dgProximasConsultasVet.Columns(7).HeaderText = "Hora Marcada"
        dgProximasConsultasVet.Columns(8).HeaderText = "Hora Inicio" 'invisivel
        dgProximasConsultasVet.Columns(9).HeaderText = "Hora Fim" 'invisivel
        dgProximasConsultasVet.Columns(10).HeaderText = "Observação" 'invisivel
        dgProximasConsultasVet.Columns(11).HeaderText = "Status" 'invisivel
    End Sub

    Private Sub formatarDGProximaConsultaAtd()

        dgProximasConsultasAtd.Columns(0).Visible = False
        dgProximasConsultasAtd.Columns(1).Visible = False
        dgProximasConsultasAtd.Columns(2).Visible = False
        dgProximasConsultasAtd.Columns(6).Visible = False
        dgProximasConsultasAtd.Columns(9).Visible = False
        dgProximasConsultasAtd.Columns(10).Visible = False
        'dgProximasConsultasAtd.Columns(11).Visible = False

        dgProximasConsultasAtd.Columns(0).HeaderText = "Código Consulta"
        dgProximasConsultasAtd.Columns(1).HeaderText = "Código Animal"
        dgProximasConsultasAtd.Columns(2).HeaderText = "Código Veterinario"
        dgProximasConsultasAtd.Columns(3).HeaderText = "Nome Animal"
        dgProximasConsultasAtd.Columns(4).HeaderText = "Nome Veterinario(a)"
        dgProximasConsultasAtd.Columns(5).HeaderText = "Cliente"
        dgProximasConsultasAtd.Columns(6).HeaderText = "Data Consulta"
        dgProximasConsultasAtd.Columns(7).HeaderText = "Hora Marcada"
        dgProximasConsultasAtd.Columns(8).HeaderText = "Hora Inicio"
        dgProximasConsultasAtd.Columns(9).HeaderText = "Hora Fim"
        dgProximasConsultasAtd.Columns(10).HeaderText = "Observação"
        dgProximasConsultasAtd.Columns(11).HeaderText = "Status"
    End Sub

    Private Sub formatarConsultaFinalizada()

        dgConsultaFinalizada.Columns(0).Visible = False
        dgConsultaFinalizada.Columns(1).Visible = False
        dgConsultaFinalizada.Columns(2).Visible = False
        dgConsultaFinalizada.Columns(6).Visible = False
        'dgConsultaFinalizada.Columns(9).Visible = False
        dgConsultaFinalizada.Columns(10).Visible = False
        'dgProximasConsultasAtd.Columns(11).Visible = False

        dgConsultaFinalizada.Columns(0).HeaderText = "Código Consulta"
        dgConsultaFinalizada.Columns(1).HeaderText = "Código Animal"
        dgConsultaFinalizada.Columns(2).HeaderText = "Código Veterinario"
        dgConsultaFinalizada.Columns(3).HeaderText = "Nome Animal"
        dgConsultaFinalizada.Columns(4).HeaderText = "Nome Veterinario(a)"
        dgConsultaFinalizada.Columns(5).HeaderText = "Cliente"
        dgConsultaFinalizada.Columns(6).HeaderText = "Data Consulta"
        dgConsultaFinalizada.Columns(7).HeaderText = "Hora Marcada"
        dgConsultaFinalizada.Columns(8).HeaderText = "Hora Inicio"
        dgConsultaFinalizada.Columns(9).HeaderText = "Hora Fim"
        dgConsultaFinalizada.Columns(10).HeaderText = "Observação"
        dgConsultaFinalizada.Columns(11).HeaderText = "Status"
    End Sub

    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        dgListaAndamento.Visible = False
        dgProximasConsultas.Visible = False
        dgProximasConsultasVet.Visible = False
        dgProximasConsultasAtd.Visible = False
        dgConsultaFinalizada.Visible = False


        lblAndamento.Visible = False
        lblProxima.Visible = False


        If cargoUsuario = "Administrador" Or cargoUsuario = "Gerente" Then
            TotaisAdm()

            lblAndamento.Visible = True
            lblTotalAndamento.Visible = True
            lblTotalCanceladas.Visible = True
            lblTotalFinalizado.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label8.Visible = True

            listarConsultaEmAndamento()
            listaProximasConsultas()

            dgProximasConsultas.Visible = True
            dgListaAndamento.Visible = True

            lblAndamento.Visible = True
            lblProxima.Visible = True

        End If

        If cargoUsuario = "Atendente" Then


            listaConsultasFinalizadas()
            dgConsultaFinalizada.Visible = True
            lblAndamento.Visible = True
            lblAndamento.Text = "Consultas Finalizadas."

            listaProximasConsultasAtd()
            dgProximasConsultasAtd.Visible = True
            lblProxima.Visible = True

        End If


        If cargoUsuario = "Veterinário" Then

            listaProximasConsultasVet()
            dgProximasConsultasVet.Visible = True

            lblProxima.Visible = True
            lblProxima.Text = "Próximas consultas Dr(a). " + nomeUsuario

        End If

    End Sub

    Sub TotaisAdm()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "Select * from Consultas where status = 'Marcado' and data_consulta = curDate()"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lblTotalMarcado.Text = dt.Rows.Count
            dt.Clear()


            sql = "Select * from Consultas where status = 'Em Andamento' and data_consulta = curDate()"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lblTotalAndamento.Text = dt.Rows.Count
            dt.Clear()

            sql = "SELECT * FROM consultas WHERE status='Cancelado'  and data_consulta = curDate()"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lblTotalCanceladas.Text = dt.Rows.Count
            dt.Clear()

            sql = "Select * from Consultas where status = 'Finalizado'  and data_consulta = curDate()"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            lblTotalFinalizado.Text = dt.Rows.Count
            dt.Clear()

        Catch ex As Exception

            MsgBox("Erro ao realizar contagem." + ex.Message)


        End Try


    End Sub


End Class