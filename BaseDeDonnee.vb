Imports MySql.Data.MySqlClient
Module BaseDeDonnee
    Public Function Connect()
        Dim chaineConnection As String = "DataSource=localhost;Initial Catalog=bibliotheque;User Id=root;Password=;"
        Dim Connection = New MySqlConnection(chaineConnection)
        Try
            If Connection.State <> ConnectionState.Open Then
                Connection.Open()
            End If
        Catch ex As Exception
            ErrorMessage.ManageError(ex)
        End Try
        Return Connection
    End Function

    ''' <summary>
    ''' Permet d'initialiser une commande pour exécuter une requete sql
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCommande(ByVal sql As String) As MySqlCommand
        'Dim connection = Connect()
        'Dim cmd = connection.CreateCommand
        Dim cmd = Connect().CreateCommand
        cmd.CommandText = sql
        Return cmd
    End Function
End Module
