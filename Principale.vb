Public Class Principale
    Private Sub btn_ajout_abonne_Click(sender As Object, e As EventArgs) Handles btn_ajout_abonne.Click
        ajout_user.Show()
        Close()
    End Sub

    Private Sub btn_deconnexion_Click(sender As Object, e As EventArgs) Handles btn_deconnexion.Click
        Accueil.Show()
        Close()
    End Sub

    Private Sub btn_ajouter_livre_Click(sender As Object, e As EventArgs) Handles btn_ajouter_livre.Click
        ajout_livre.Show()
        Close()
    End Sub

    Private Sub btn_ajout_categorie_Click(sender As Object, e As EventArgs) Handles btn_ajout_categorie.Click
        ajouter_categorie.Show()
        Close()
    End Sub

    Private Sub btn_principale_quitter_Click(sender As Object, e As EventArgs) Handles btn_principale_quitter.Click
        Accueil.Show()
        Close()
    End Sub

    Private Sub liste_livre_Click(sender As Object, e As EventArgs) Handles liste_livre.Click
        Liste_Livres.Show()
        Close()
    End Sub

    Private Sub btn_liste_admin_Click(sender As Object, e As EventArgs) Handles btn_liste_admin.Click
        liste_admin.Show()
        Close()
    End Sub

    Private Sub btn_liste_abonne_Click(sender As Object, e As EventArgs) Handles btn_liste_abonne.Click
        liste_abonne.Show()
        Close()
    End Sub

    Private Sub btn_emprunt_Click(sender As Object, e As EventArgs) Handles btn_emprunt.Click
        gestion_emprunt.Show()
        Close()
    End Sub

    Private Sub btn_liste_emprunt_Click(sender As Object, e As EventArgs) Handles btn_liste_emprunt.Click
        liste_emprunts.Show()
        Close()
    End Sub
End Class