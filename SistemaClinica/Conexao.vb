Imports MySql.Data.MySqlClient

Module Conexao

    'Conexao local
    Public con As New MySqlConnection("server=localhost;userid=root;password=;database=sistema_clinica;")

    'CONEXÃO HOSPEDADA
    'Public con As New MySqlConnection("server=databases.000webhost.com;userid=id15277242_admclinica;password=up|WTMRC^4Yv$u+;database=id15277242_sistemaclinica;port=3306")


    Sub abrir()

        If con.State = 0 Then

            con.Open()


        End If


    End Sub

    Sub fechar()

        If con.State = 1 Then

            con.Close()

        End If


    End Sub

    'Variaveis para pegar login, cargo e nome do usuario logado passada como parametro

    Public usuario As String
    Public cargoUsuario As String
    Public nomeUsuario As String
    Public CodUsu As String

    Public nomeCliente As String
    Public codCliente As String

    Public nomeFornecedor As String
    Public codFornecedor As String


    Public HorarioLivre As String
    Public Veterinario As String





End Module
