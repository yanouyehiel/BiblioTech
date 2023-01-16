Imports MySql.Data.MySqlClient

Public Class Liste_Livres

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim formAjout = New ajout_livre
        formAjout.ShowDialog()
    End Sub


    Dim indice As Integer = -1
    Private Sub btn_modifier_Click(sender As Object, e As EventArgs) Handles btn_modifier.Click
        If Table.SelectedItems.Count > 0 Then
            Dim element As ListViewItem = Table.SelectedItems(0)
            element.SubItems(6).Text = txt_stock.Text
            'Table.Items.Add(element)
            'element.Text = txt_nom.Text
            'element.SubItems(1).Text = txt_auteur.Text
            'element.SubItems(2).Text = txt_edition.Text
            'element.SubItems(3).Text = txt_pages.Text
            'element.SubItems(4).Text = txt_description.Text
            'element.SubItems(5).Text = txt_genre.Text

            Dim sql = "UPDATE livres SET stock=@stock WHERE nom=" & element.Text & ""
            Dim cmd As MySqlCommand = BaseDeDonnee.GetCommande(sql)
            cmd.Parameters.AddWithValue("@stock", txt_stock.Text)
        End If
        'If (indice = -1) Then
        'Lorsque aucune ligne n'est sélectionnée
        'indice = Table.CurrentCell.RowIndex 
        'txt_nom.Text = Table.Rows(indice).Cells(0).Value.ToString()
        'txt_auteur.Text = Table.Rows(indice).Cells(1).Value.ToString()
        'txt_edition.Text = Table.Rows(indice).Cells(2).Value.ToString()
        'txt_pages.Text = Table.Rows(indice).Cells(3).Value.ToString()
        'txt_genre.Text = Table.Rows(indice).Cells(4).Value.ToString()

        btn_ajouter.Enabled = False
        btn_supprimer.Enabled = False
        btn_trier.Enabled = False
        btn_raffraichir.Enabled = False
        btn_modifier.Text = "Valider"
        'Else
        'Une ligne est sélectionnée

        'Table.Rows(indice).Cells(0).Value = txt_nom.Text
        'Table.Rows(indice).Cells(1).Value = txt_auteur.Text
        'Table.Rows(indice).Cells(2).Value = txt_edition.Text
        'Table.Rows(indice).Cells(3).Value = txt_pages.Text
        'Table.Rows(indice).Cells(4).Value = txt_genre.Text
        btn_ajouter.Enabled = True
        btn_supprimer.Enabled = True
        btn_trier.Enabled = True
        btn_raffraichir.Enabled = True
        btn_modifier.Text = "Modifier"
        'End If
    End Sub

    Private Sub btn_supprimer_Click(sender As Object, e As EventArgs) Handles btn_supprimer.Click
        If Table.SelectedItems.Count = 1 Then
            Dim element As ListViewItem = Table.SelectedItems(0)
            Table.Items.Remove(element)

            'Dim connection = BaseDeDonnee.Connect()
            'Dim cmd As MySqlCommand = connection.CreateCommand
            'cmd.CommandText = "DELETE FROM livres WHERE id=" & element & ""
            'cmd.ExecuteScalar()
        Else
            MsgBox("Veuillez sélectionner une ligne.")
        End If
    End Sub

    Private Sub btn_trier_Click(sender As Object, e As EventArgs) Handles btn_trier.Click

    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
        Principale.Show()
    End Sub

    Private Sub btn_vider_Click(sender As Object, e As EventArgs) Handles btn_raffraichir.Click
        Table.SelectedItems.Clear()
        chargerLivre()
    End Sub

    Private Sub chargerLivre()
        Table.Items.Clear()
        Try
            Dim connection = BaseDeDonnee.Connect()
            Dim cmd As MySqlCommand = connection.CreateCommand
            cmd.CommandText = "SELECT * FROM livres"
            Dim resultat = cmd.ExecuteReader()

            While resultat.Read
                Dim item As ListViewItem = New ListViewItem(resultat.GetString("nom"))
                item.SubItems.Add(resultat.GetString("auteur"))
                item.SubItems.Add(resultat.GetString("maison_edition"))
                item.SubItems.Add(resultat.GetString("nb_pages"))
                item.SubItems.Add(resultat.GetString("description"))
                item.SubItems.Add(resultat.GetString("genre_litteraire"))
                item.SubItems.Add(resultat.GetString("stock"))
                Table.Items.Add(item)
            End While
            resultat.Close()
            connection.Close()
        Catch ex As Exception
            ErrorMessage.ManageError(ex)
        End Try
    End Sub
    Private Sub Liste_livre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargerLivre()
    End Sub

    Private Sub Table_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Table.SelectedIndexChanged
        If Table.SelectedItems.Count > 0 Then
            Dim element As ListViewItem = Table.SelectedItems(0)
            txt_stock.Text = element.SubItems(6).Text
            'txt_nom.Text = element.Text
            'txt_auteur.Text = element.SubItems(1).Text
            'txt_edition.Text = element.SubItems(2).Text
            'txt_pages.Text = element.SubItems(3).Text
            'txt_description.Text = element.SubItems(4).Text
            'txt_genre.Text = element.SubItems(5).Text
        Else
            txt_stock.Text = ""
            'txt_nom.Text = ""
            'txt_auteur.Text = ""
            'txt_edition.Text = ""
            'txt_pages.Text = ""
            'txt_description.Text = ""
            'txt_genre.Text = ""
        End If
    End Sub
End Class