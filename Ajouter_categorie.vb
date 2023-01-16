Imports MySql.Data.MySqlClient
Public Class ajouter_categorie
    Private Sub btn_categorie_quitter_Click(sender As Object, e As EventArgs) Handles btn_categorie_quitter.Click
        Principale.Show()
        Me.Close()
    End Sub

    Private Sub btn_ajout_categorie_Click(sender As Object, e As EventArgs) Handles btn_ajout_categorie.Click
        Try
            If (txtbox_nom.Text = "") Then
                MsgBox("Veuillez remplir d'abord le champ vide")
            Else
                Dim sql = "INSERT INTO categories (nom) VALUES (@nom)"
                Dim cmd As MySqlCommand = BaseDeDonnee.GetCommande(sql)
                cmd.Parameters.AddWithValue("@nom", txtbox_nom.Text)

                Dim rowAffected = cmd.ExecuteNonQuery
                If rowAffected > 0 Then
                    MsgBox("Catégorie ajoutée avec succès !")
                    Close()
                    Principale.Show()
                Else
                    MsgBox("Une erreur est survenue.")
                End If
            End If
        Catch ex As Exception
            ErrorMessage.ManageError(ex)
        End Try
    End Sub

End Class