Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogar_Click(sender As Object, e As EventArgs) Handles btnLogar.Click

        Try
            'VERIFICAR SE O USUARIO JÁ EXISTE
            abrir()
            Dim cmdUser As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql2 As String
            sql2 = "select * from funcionarios where (usuario = '" & txtUsuario.Text & "' or email = '" & txtUsuario.Text & "')  and senha = '" & txtSenha.Text & "'"
            cmdUser = New MySqlCommand(sql2, con)
            reader = cmdUser.ExecuteReader

            If reader.Read = True Then

                'RECUPERAÇÃO DO CARGO E NOME DO FUNCIONÁRIO
                Dim cargo As String
                cargo = reader(2)
                Dim nome As String
                nome = reader(1)

                Dim form = New frmPrincipal
                usuario = txtUsuario.Text
                cargoUsuario = cargo
                nomeUsuario = nome
                MsgBox("Bem Vindo " + nomeUsuario)
                reader.Close()
                Me.Hide()
                form.ShowDialog()

            Else
                MsgBox("Usuário ou senha incorretos! ")
                fechar()
                txtUsuario.Text = ""
                txtSenha.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Erro ao relizar login: " + ex.Message)
            txtUsuario.Text = ""
            txtSenha.Text = ""
        End Try
    End Sub
End Class
