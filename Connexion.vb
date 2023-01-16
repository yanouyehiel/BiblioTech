Imports MySql.Data.MySqlClient
Public Class connexion_admin
    Private Sub btn_connexion_Click(sender As Object, e As EventArgs) Handles btn_connexion.Click
        Try
            If txtbox_pseudo.Text = "" And txtbox_password.Text = "" Then
                MsgBox("Veuillez remplir d'abord tous les champs.")
            Else
                Dim connection = BaseDeDonnee.Connect()
                Dim cmd As MySqlCommand = connection.CreateCommand
                cmd.CommandText = "SELECT * FROM users WHERE pseudo=@pseudo AND password=@pass And admin=1"
                cmd.Parameters.Add("@pseudo", MySqlDbType.VarChar).Value = txtbox_pseudo.Text
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtbox_password.Text

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                If table.Rows.Count() <= 0 Then
                    MsgBox("Pseudo ou Password incorrect !")
                Else
                    My.Settings.Pseudo = txtbox_pseudo.Text
                    My.Settings.Password = txtbox_password.Text
                    My.Settings.Save()
                    MsgBox("Connexion réussie ! Ravie de vous revoir " & txtbox_pseudo.Text & "")
                    connection.Close()
                    Me.Hide()
                    Principale.Show()
                End If
            End If
        Catch ex As Exception
            ErrorMessage.ManageError(ex)
        End Try
    End Sub

    Private Sub btn_categorie_quitter_Click(sender As Object, e As EventArgs) Handles btn_categorie_quitter.Click
        Me.Hide()
        Principale.Show()
    End Sub
End Class