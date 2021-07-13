Imports MySql.Data.MySqlClient

Public Class frmBuscarFornecedor
    Private Sub frmBuscarFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
    End Sub

    Private Sub listar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from fornecedores where status = 'Ativo' order by id_fornecedor asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgBuscaFornecedor.DataSource = dt

            formatarDG()
            'contarLinhas()

        Catch ex As Exception

            MsgBox("Erro ao Listar!! " + ex.Message)

        End Try
    End Sub
    Private Sub formatarDG()

        dgBuscaFornecedor.Columns(0).Visible = False
        dgBuscaFornecedor.Columns(3).Visible = False
        dgBuscaFornecedor.Columns(4).Visible = False
        dgBuscaFornecedor.Columns(5).Visible = False
        dgBuscaFornecedor.Columns(7).Visible = False
        dgBuscaFornecedor.Columns(8).Visible = False
        dgBuscaFornecedor.Columns(9).Visible = False
        dgBuscaFornecedor.Columns(12).Visible = False
        dgBuscaFornecedor.Columns(15).Visible = False
        dgBuscaFornecedor.Columns(16).Visible = False

        dgBuscaFornecedor.Columns(0).HeaderText = "Codigo Fornecedor"
        dgBuscaFornecedor.Columns(1).HeaderText = "Razão Social"
        dgBuscaFornecedor.Columns(2).HeaderText = "Nome Fantasia"
        dgBuscaFornecedor.Columns(3).HeaderText = "Endereço"
        dgBuscaFornecedor.Columns(4).HeaderText = "Numero"
        dgBuscaFornecedor.Columns(5).HeaderText = "Complemento"
        dgBuscaFornecedor.Columns(6).HeaderText = "Cidade"
        dgBuscaFornecedor.Columns(7).HeaderText = "Estado"
        dgBuscaFornecedor.Columns(8).HeaderText = "Bairro"
        dgBuscaFornecedor.Columns(9).HeaderText = "Cep"
        dgBuscaFornecedor.Columns(10).HeaderText = "UF"
        dgBuscaFornecedor.Columns(11).HeaderText = "Data Cadastro"
        dgBuscaFornecedor.Columns(12).HeaderText = "Status"
        dgBuscaFornecedor.Columns(13).HeaderText = "CNPJ"
        dgBuscaFornecedor.Columns(14).HeaderText = "Telefone"
        dgBuscaFornecedor.Columns(15).HeaderText = "Telefone2"
        dgBuscaFornecedor.Columns(16).HeaderText = "Celular"
        dgBuscaFornecedor.Columns(17).HeaderText = "E-mail"

    End Sub

    Private Sub Buscar()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from fornecedores where nomefantasia LIKE '" & txtBuscar.Text & "%' order by nomefantasia asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgBuscaFornecedor.DataSource = dt

            formatarDG()
            ' contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
        End Try
    End Sub
    Private Sub BuscarCpf()
        Try
            abrir()
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim sql As String
            sql = "select * from fornecedores where cnpj = '" & txtBuscarCpf.Text & "' order by nomefantasia asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgBuscaFornecedor.DataSource = dt

            formatarDG()
            'contarLinhas()

        Catch ex As Exception
            'MsgBox("Erro ao Listar!! " + ex.Message)
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

    Private Sub dgBuscaFornecedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBuscaFornecedor.CellDoubleClick

        Dim codFonrn As Integer
        Dim nomeForn As String



        codFonrn = dgBuscaFornecedor.CurrentRow.Cells(0).Value
        nomeForn = dgBuscaFornecedor.CurrentRow.Cells(2).Value

        If codFonrn <> 0 And nomeForn <> "" Then

            Dim form = New frmAnimais()
            codFornecedor = codFonrn
            nomeFornecedor = nomeForn
            Me.Hide()

        Else

            MsgBox("Necessário selecionar um cliente")

        End If
    End Sub
End Class