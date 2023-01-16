Imports MySql.Data.MySqlClient
Public Class Accueil
    Dim Connect As New MySqlConnection("DataSource=localhost;Initial Catalog=bibliotheque;User Id=root;Password=root;")
    Dim cmd As MySqlCommand
    Dim dataReader As MySqlDataReader
    Dim db As DataTable

    Private Sub button_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        'Principale.Show()
        connexion_admin.Show()
        'Me.Close()
    End Sub

    Private Sub btn_accueil_quitter_Click(sender As Object, e As EventArgs) Handles btn_accueil_quitter.Click
        If MsgBox("Souhaitez-vous vraiment quitter ?", 36, "Confirmation sortie") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
End Class