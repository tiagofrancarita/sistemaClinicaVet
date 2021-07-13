Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAnimais

    Public imgNome As String
    Dim abriu As Boolean





    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        LimparCampos()
        VerificaCombo()
        habilitaCamposBtNovo()


        btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
        btnEditar.Enabled = False

        btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
        btnExcluir.Enabled = False

        btnSalvar.BackgroundImage = My.Resources.bt_salvar
        btnSalvar.Enabled = True

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

    End Sub

    Private Sub habilitaCamposBtNovo()

        txtNome.Enabled = True
        txtBuscar.Enabled = True
        txtRaca.Enabled = True
        txtIdade.Enabled = True
        cboCategoria.Enabled = True
        btnImg.Enabled = True
        btnBuscaCliente.Enabled = True

    End Sub

    Private Sub VerificaCombo()
        abrir()
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select * from categorias order by id_categoria asc"

        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then

            LimparCampos()
            btnSalvar.Enabled = True

        Else

            MsgBox("Não há nenhuma categoria cadastrada, favor cadastrar antes de cadastrar um animal.")

        End If
    End Sub

    Private Sub LimparCampos()

        txtCodigo.Text = ""
        txtNome.Text = ""
        txtBuscar.Text = ""
        txtRaca.Text = ""
        txtIdade.Text = ""
        cboCategoria.Text = ""
        txtCodCliente.Text = ""
        txtCliente.Text = ""

        imagem.Image = My.Resources.sem_foto
        imgNome = "sem-foto.jpg"

    End Sub

    Private Sub DesabilitarCampos()

        txtNome.Enabled = False
        txtBuscar.Enabled = False
        txtRaca.Enabled = False
        txtIdade.Enabled = False
        cboCategoria.Enabled = False
        btnSalvar.Enabled = False
        btnImg.Enabled = True
        btnBuscaCliente.Enabled = True

    End Sub

    Private Sub frmAnimais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        imagem.Image = My.Resources.sem_foto
        botaoInativo()
        CarregarCategoria()
        CarregarCategoriaBuscar()
        listar()
        contarLinhas()


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

    Private Sub CarregarCategoria()
        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias order by id_categoria asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)

            cboCategoria.ValueMember = "id_categoria"
            cboCategoria.DisplayMember = "descricao"
            cboCategoria.DataSource = dt


        Catch ex As Exception
            MsgBox("Erro ao listar categoria." + ex.Message)
        End Try
    End Sub

    Private Sub CarregarCategoriaBuscar()
        Try

            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from categorias order by id_categoria asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)


            cbCategoriaBuscar.ValueMember = "id_categoria"
            cbCategoriaBuscar.DisplayMember = "descricao"
            cbCategoriaBuscar.DataSource = dt

        Catch ex As Exception
            MsgBox("Erro ao listar categoria busca." + ex.Message)
        End Try
    End Sub



    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtNome.Text <> "" Or txtRaca.Text <> "" Or txtIdade.Text <> "" Or txtCodCliente.Text <> "" Then

            Dim data As String
            data = Now.ToString("yyyy-MM-dd")

            'Tratamento de img para salvar no banco
            Dim fs As FileStream
            fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
            Dim picByte As Byte() = New Byte(fs.Length - 1) {}
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
            fs.Close()

            Try
                abrir()
                Dim cmd As MySqlCommand
                Dim sql As String
                sql = "  Insert into animal 
                         (id_categoria,nome,raca,idade,data_cadastro,id_cliente,imagem) 
                         values 
                         ('" & cboCategoria.SelectedValue & "','" & txtNome.Text & "',
                         '" & txtRaca.Text & "','" & txtIdade.Text & "','" & data & "',
                         '" & txtCodCliente.Text & "'," & " @img)"

                'Declaracao de parametros
                Dim param As New MySqlParameter
                param.MySqlDbType = MySqlDbType.Binary
                param.ParameterName = "img"
                param.Value = picByte

                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.Add(param)
                cmd.ExecuteNonQuery()
                MsgBox("Dados salvos com sucesso.")
                LimparCampos()
                botaoInativo()

            Catch ex As Exception
                MsgBox("Erro ao salvar." + ex.Message)
            End Try

            listar()
            contarLinhas()
            DesabilitarCampos()


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

    Private Sub listar()

        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select a.id_animal, c.descricao, a.nome, a.raca, a.idade, 
                    a.data_cadastro, a.id_categoria, a.id_cliente, cl.nome, a.imagem 
                    from animal as a 
                    INNER JOIN categorias as c on a.id_categoria = c.id_categoria 
                    INNER JOIN clientes as cl on a.id_cliente = cl.id_cliente 
                    order by a.nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgAnimal.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub contarLinhas()

        Dim total As Integer = dgAnimal.Rows.Count
        lblTotal.Text = total

    End Sub

    Private Sub formatarDG()
        'id_categoria,nome,raca,idade,data_cadastro


        dgAnimal.Columns(0).Visible = False
        dgAnimal.Columns(6).Visible = False
        dgAnimal.Columns(7).Visible = False
        dgAnimal.Columns(9).Visible = False

        dgAnimal.Columns(0).HeaderText = "Id do Animal"
        dgAnimal.Columns(1).HeaderText = "Categoria"
        dgAnimal.Columns(2).HeaderText = "Nome"
        dgAnimal.Columns(3).HeaderText = "Raça"
        dgAnimal.Columns(4).HeaderText = "Idade"
        dgAnimal.Columns(5).HeaderText = "Data_Cadastro"
        dgAnimal.Columns(8).HeaderText = "Dono"


    End Sub



    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtNome.Text <> "" Or txtRaca.Text <> "" Or txtIdade.Text <> "" Then

            Try
                Dim dlgImage As FileDialog = New OpenFileDialog
                dlgImage.Filter = "Image File(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png"

                If abriu = True Then
                    'Tratamento de img para salvar no banco
                    Dim fs As FileStream
                    fs = New FileStream(imgNome, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}
                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                    fs.Close()

                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE animal 
                        SET 
                        id_categoria = '" & cboCategoria.SelectedValue & "',
                        nome = '" & txtNome.Text & "',
                        raca = '" & txtRaca.Text & "',
                        idade = '" & txtIdade.Text & "',
                        id_cliente = '" & txtCodCliente.Text & "',
                        imagem = " & " @img
                        where id_animal = '" & txtCodigo.Text & "'  "


                    'Declaracao de parametros
                    Dim param As New MySqlParameter
                    param.MySqlDbType = MySqlDbType.Binary
                    param.ParameterName = "img"
                    param.Value = picByte

                    cmd = New MySqlCommand(sql, con)
                    cmd.Parameters.Add(param)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados alterados com sucesso.")
                Else
                    abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "UPDATE animal 
                        SET 
                        id_categoria = '" & cboCategoria.SelectedValue & "',
                        nome = '" & txtNome.Text & "',
                        raca = '" & txtRaca.Text & "',
                        idade = '" & txtIdade.Text & "',
                        id_cliente = '" & txtCodCliente.Text & "'
                        where id_animal = '" & txtCodigo.Text & "'  "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dados alterados com sucesso.")

                End If

            Catch ex As Exception
                MsgBox("Erro ao alterar." + ex.Message)
            End Try

            listar()
            contarLinhas()
            DesabilitarCampos()
            LimparCampos()


            btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
            btnEditar.Enabled = False

            btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
            btnExcluir.Enabled = False

            btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
            btnSalvar.Enabled = False

            btnNovo.BackgroundImage = My.Resources.btn_novo
            btnNovo.Enabled = True

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
                    sql = "DELETE from animal where id_animal = '" & txtCodigo.Text & "'  "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Dado excluído com sucesso.")
                    LimparCampos()
                    botaoInativo()

                Catch ex As Exception
                    MsgBox("Erro ao excluir." + ex.Message)
                End Try

                listar()
                contarLinhas()
                DesabilitarCampos()
                LimparCampos()

                btnEditar.BackgroundImage = My.Resources.bt_editar_inativo
                btnEditar.Enabled = False

                btnExcluir.BackgroundImage = My.Resources.bt_excluir_inativo
                btnExcluir.Enabled = False

                btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
                btnSalvar.Enabled = False

                btnNovo.BackgroundImage = My.Resources.btn_novo
                btnNovo.Enabled = True

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
            sql = "select a.id_animal, c.descricao, a.nome, a.raca, a.idade, 
                    a.data_cadastro, a.id_categoria, a.id_cliente, cl.nome, a.imagem 
                    from animal as a 
                    INNER JOIN categorias as c on a.id_categoria = c.id_categoria 
                    INNER JOIN clientes as cl on a.id_cliente = cl.id_cliente 
                    where a.nome LIKE '" & txtBuscar.Text & "%' 
                    and a.id_categoria = '" & cbCategoriaBuscar.SelectedValue & "'  
                    order by a.nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgAnimal.DataSource = dt

            formatarDG()
            contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub

    Private Sub cbCategoriaBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategoriaBuscar.SelectedIndexChanged

        Buscar()

    End Sub

    Private Sub btnBuscaCliente_Click(sender As Object, e As EventArgs) Handles btnBuscaCliente.Click

        Dim frmBuscaCliente = New frmBuscarCliente
        'Me.Hide()
        frmBuscaCliente.ShowDialog()

    End Sub

    Private Sub frmAnimais_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        txtCodCliente.Text = codCliente
        txtCliente.Text = nomeCliente

    End Sub

    Private Sub btnImg_Click(sender As Object, e As EventArgs) Handles btnImg.Click
        Try
            Dim dlgImage As FileDialog = New OpenFileDialog
            dlgImage.Filter = "Image File(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png"
            If (dlgImage.ShowDialog) = DialogResult.OK Then
                imgNome = dlgImage.FileName
                abriu = True

                Dim novaImg As New Bitmap(imgNome)
                imagem.SizeMode = PictureBoxSizeMode.StretchImage
                imagem.Image = DirectCast(novaImg, Image)

                'MsgBox(imgNome)
            Else
                dlgImage = Nothing
            End If
        Catch ex As Exception
            imgNome = ""
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub dgAnimal_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAnimal.CellDoubleClick

        habilitaCamposBtNovo()

        btnEditar.BackgroundImage = My.Resources.bt_editar
        btnEditar.Enabled = True

        btnExcluir.BackgroundImage = My.Resources.bt_excluir
        btnExcluir.Enabled = True

        btnSalvar.BackgroundImage = My.Resources.bt_salvar_inativo
        btnSalvar.Enabled = False

        btnNovo.BackgroundImage = My.Resources.bt_novo_inativo
        btnNovo.Enabled = False

        txtCodigo.Text = dgAnimal.CurrentRow.Cells(0).Value
        cboCategoria.Text = dgAnimal.CurrentRow.Cells(1).Value
        txtNome.Text = dgAnimal.CurrentRow.Cells(2).Value
        txtRaca.Text = dgAnimal.CurrentRow.Cells(3).Value
        txtIdade.Text = dgAnimal.CurrentRow.Cells(4).Value
        txtCodCliente.Text = dgAnimal.CurrentRow.Cells(7).Value
        txtCliente.Text = dgAnimal.CurrentRow.Cells(8).Value

        'CONVERTENDO BYTE EM PICKTURE BOX

        Dim img As Byte() = dgAnimal.CurrentRow.Cells(9).Value
        Dim ms As MemoryStream = New MemoryStream(img)
        imagem.Image = System.Drawing.Image.FromStream(ms)
    End Sub

    Private Sub frmAnimais_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate

        codCliente = txtCodCliente.Text
        nomeCliente = txtCliente.Text

    End Sub
End Class