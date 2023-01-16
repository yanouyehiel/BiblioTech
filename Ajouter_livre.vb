Imports MySql.Data.MySqlClient
Public Class ajout_livre
    Private Sub btn_livre_quitter_Click(sender As Object, e As EventArgs) Handles btn_livre_quitter.Click
        Principale.Show()
        Me.Close()
    End Sub

    Private Sub btn_ajout_livre_Click(sender As Object, e As EventArgs) Handles btn_ajout_livre.Click
        If (txtbox_nom.Text = "" And txtbox_auteur.Text = "" And txtbox_description.Text = "" And combox_genre.Text = "" And txtbox_page.Text = "" And txtbox_maison_edition.Text = "") Then
            MsgBox("Veuillez remplir d'abord tous les champs")
        Else
            Try
                Dim sql = "INSERT INTO livres (nom, auteur, maison_edition, nb_pages, description, genre_litteraire) VALUES (@nom, @auteur, @maison_edition, @nb_pages, @description, @genre_litteraire)"
                Dim cmd As MySqlCommand = BaseDeDonnee.GetCommande(sql)
                cmd.Parameters.AddWithValue("@nom", txtbox_nom.Text)
                cmd.Parameters.AddWithValue("@auteur", txtbox_auteur.Text)
                cmd.Parameters.AddWithValue("@maison_edition", txtbox_maison_edition.Text)
                cmd.Parameters.AddWithValue("@nb_pages", txtbox_page.Text)
                cmd.Parameters.AddWithValue("@description", txtbox_description.Text)
                cmd.Parameters.AddWithValue("@genre_litteraire", combox_genre.Text)

                Dim rowAffected = cmd.ExecuteNonQuery
                If rowAffected > 0 Then
                    MsgBox("Nouveau livre ajouté avec succès !")
                    Close()
                    Principale.Show()
                Else
                    MsgBox("Une erreur est survenue")
                End If
            Catch ex As Exception
                ErrorMessage.ManageError(ex)
            End Try
        End If
    End Sub
End Class