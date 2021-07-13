Imports MySql.Data.MySqlClient

Public Class frmBuscarCliente
    Private Sub frmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listar()

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
            'contarLinhas()

        Catch ex As Exception
            MsgBox("Erro ao Listar!! " + ex.Message)
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
            sql = "select * from clientes where cpf = '" & txtBuscarCpf.Text & "' order by nome asc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            dgCliente.DataSource = dt

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

    Private Sub dgCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCliente.CellDoubleClick

        Dim codigo As Integer
        Dim nome As String

        codigo = dgCliente.CurrentRow.Cells(0).Value
        nome = dgCliente.CurrentRow.Cells(1).Value

        If codigo <> 0 And nome <> "" Then

            Dim form = New frmAnimais()
            codCliente = codigo
            nomeCliente = nome
            Me.Hide()

        Else
            MsgBox("Necessário selecionar um cliente")
        End If




    End Sub
End Class