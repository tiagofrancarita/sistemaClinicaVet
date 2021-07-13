Imports MySql.Data.MySqlClient

Public Class frmContasPagar


    Private Sub habilitaCamposBtNovo()

        txtCodFornecedor.Enabled = True
        txtCodigo.Enabled = True
        txtDescricao.Enabled = True
        txtFornecedor.Enabled = False
        txtNumDoc.Enabled = True
        txtValor.Enabled = True
        cbStatus.Enabled = True

    End Sub

    Private Sub LimparCampos()

        txtCodFornecedor.Text = ""
        txtCodigo.Text = ""
        txtDescricao.Text = ""
        txtFornecedor.Text = ""
        txtNumDoc.Text = ""
        txtValor.Text = ""
        cbStatus.Text = ""

    End Sub
    Private Sub contarLinhas()

        Dim total As Integer = dgContasPagar.Rows.Count
        lblTotal.Text = total

    End Sub


    Private Sub listar()
        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "SELECT cp.id_contaspagar,cp.id_fornecedor,f.nomefantasia,cp.descricao,cp.numdoc,cp.datacadastro,cp.status,
                    cp.valor,cp.datavencimento
                    FROM contasapagar AS cp
                    INNER JOIN fornecedores AS f on cp.id_fornecedor = f.id_fornecedor 
                    
                    WHERE cp.datacadastro = CurDate() AND cp.status = 'A Pagar'

                    ORDER BY cp.datavencimento asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgContasPagar.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception

            MsgBox("Erro ao Listar!! " + ex.Message)

        End Try
    End Sub

    Private Sub formatarDG()
        'cp.id_contaspagar, cp.id_fornecedor, f.nomefantasia, cp.descricao, cp.numdoc, cp.datacadastro,
        'cp.status,'cp.valor, cp.databaixa, cp.datavencimento

        dgContasPagar.Columns(0).Visible = False
        dgContasPagar.Columns(1).Visible = False
        'dgContasPagar.Columns(2).Visible = False

        dgContasPagar.Columns(0).HeaderText = "Código Contas"
        dgContasPagar.Columns(1).HeaderText = "Código Fornecedor"
        dgContasPagar.Columns(2).HeaderText = "Nome Fantasia"
        dgContasPagar.Columns(3).HeaderText = "Descrição"
        dgContasPagar.Columns(4).HeaderText = "Número Documento"
        dgContasPagar.Columns(5).HeaderText = "Data Cadastro"
        dgContasPagar.Columns(6).HeaderText = "Status"
        dgContasPagar.Columns(7).HeaderText = "Valor R$"
        dgContasPagar.Columns(8).HeaderText = "Data da Vencimento"

    End Sub

    Private Sub frmContasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnBaixa.BackgroundImage = My.Resources.bt_excluir_inativo
        btnBaixa.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.btn_novo
        btnNovo.Enabled = True

        listar()
        contarLinhas()

        dtVencimento.Value = Now
        cbBuscarStatus.Text = "A Pagar"

    End Sub
    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        LimparCampos()

        habilitaCamposBtNovo()
        btnBuscaCliente.Enabled = True
        dtVencimento.Enabled = True

        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnBaixa.BackgroundImage = My.Resources.bt_excluir_inativo
        btnBaixa.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar
        btnSalvar.Enabled = True

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub btnBuscaCliente_Click(sender As Object, e As EventArgs) Handles btnBuscaCliente.Click
        Dim frmBuscaFornecedor = New frmBuscarFornecedor
        'Me.Hide()
        frmBuscaFornecedor.ShowDialog()
    End Sub

    Private Sub frmContasPagar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        txtCodFornecedor.Text = codFornecedor
        txtFornecedor.Text = nomeFornecedor
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim datav As String
        datav = dtVencimento.Value.ToString("yyyy-MM-dd")

        Dim datac As String
        datac = Now.ToString("yyyy-MM-dd")

        If txtFornecedor.Text = "" Or txtDescricao.Text = "" Or txtValor.Text = "" Or txtNumDoc.Text = "" Then
            MsgBox("Preencha os campos!")
        Else

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "INSERT INTO contasapagar 
                      (id_fornecedor, descricao, numdoc, datacadastro, status, valor,databaixa,datavencimento) 
                      VALUES ('" & txtCodFornecedor.Text & "', '" & txtDescricao.Text & "', 
                              '" & txtNumDoc.Text & "', '" & datac & "','" & cbStatus.Text & "','" & txtValor.Text & "',
                              '','" & datav & "'          ) "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados Salvos com Sucesso!!")

            Catch ex As Exception

                MsgBox("Erro ao Salvar!! " + ex.Message)

            End Try

            listar()
            contarLinhas()
            LimparCampos()

            btnNovo.Enabled = True
            btnNovo.BackgroundImage = My.Resources.btn_novo

            btnEditar.Enabled = False
            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

            btnBaixa.Enabled = False
            btnBaixa.BackgroundImage = My.Resources.bt_excluir_inativo

            btnSalvar.Enabled = False
            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo


        End If

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim data As String
        data = dtVencimento.Value.ToString("yyyy-MM-dd")


        If txtCodFornecedor.Text = "" Or txtCodigo.Text = "" Then
            MsgBox("Selecione uma conta para editar.!")
        Else

            Try

                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE contasapagar SET 
                      id_fornecedor = '" & txtCodFornecedor.Text & "',
                      descricao = '" & txtDescricao.Text & "', 
                      numdoc = '" & txtNumDoc.Text & "',
                      valor = '" & txtValor.Text & "',
                      datavencimento = '" & data & "'
                      where id_contaspagar = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados editados com Sucesso!!")


            Catch ex As Exception
                MsgBox("Erro ao editar!! " + ex.Message)
            End Try

            listar()
            contarLinhas()
            LimparCampos()


            btnSalvar.Enabled = False
            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

            btnNovo.Enabled = True
            btnNovo.BackgroundImage = My.Resources.btn_novo

            btnEditar.Enabled = False
            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

            btnBaixa.Enabled = False
            btnBaixa.BackgroundImage = My.Resources.bt_excluir_inativo
        End If

    End Sub

    Private Sub dgContasPagar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgContasPagar.CellDoubleClick

        btnEditar.Enabled = True
        btnEditar.BackgroundImage = My.Resources.bt_editar

        btnBaixa.Enabled = True
        btnBaixa.BackgroundImage = My.Resources.bt_excluir

        btnSalvar.Enabled = False
        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

        btnNovo.Enabled = False
        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo

        cbStatus.Enabled = False

        txtCodigo.Text = dgContasPagar.CurrentRow.Cells(0).Value
        txtCodFornecedor.Text = dgContasPagar.CurrentRow.Cells(1).Value
        txtFornecedor.Text = dgContasPagar.CurrentRow.Cells(2).Value
        txtDescricao.Text = dgContasPagar.CurrentRow.Cells(3).Value
        txtNumDoc.Text = dgContasPagar.CurrentRow.Cells(4).Value
        txtValor.Text = dgContasPagar.CurrentRow.Cells(7).Value
        dtVencimento.Value = dgContasPagar.CurrentRow.Cells(8).Value
        cbStatus.Text = dgContasPagar.CurrentRow.Cells(6).Value

        habilitaCamposBtNovo()
        cbStatus.Enabled = False
        dtVencimento.Enabled = True

    End Sub

    Private Sub btnBaixa_Click(sender As Object, e As EventArgs) Handles btnBaixa.Click

        Dim data As String
        data = Now.ToString("yyyy-MM-dd")

        If txtCodFornecedor.Text = "" Or txtCodigo.Text = "" Then
            MsgBox("Selecione uma conta para dar baixa.!")
        Else

            Try

                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "UPDATE contasapagar SET 
                      databaixa = '" & data & "',
                      status ='Pago'
                      where id_contaspagar = '" & txtCodigo.Text & "' "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Dados editados com Sucesso!!")

            Catch ex As Exception

                MsgBox("Erro ao editar!! " + ex.Message)

            End Try

            listar()
            contarLinhas()
            LimparCampos()


            btnSalvar.Enabled = False
            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo

            btnNovo.Enabled = True
            btnNovo.BackgroundImage = My.Resources.btn_novo

            btnEditar.Enabled = False
            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo

            btnBaixa.Enabled = False
            btnBaixa.BackgroundImage = My.Resources.bt_excluir_inativo

        End If
    End Sub
End Class