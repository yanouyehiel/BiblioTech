<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principale))
        Me.btn_ajouter_livre = New System.Windows.Forms.Button()
        Me.btn_ajout_categorie = New System.Windows.Forms.Button()
        Me.btn_ajout_abonne = New System.Windows.Forms.Button()
        Me.liste_livre = New System.Windows.Forms.Button()
        Me.btn_deconnexion = New System.Windows.Forms.Button()
        Me.btn_principale_quitter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_liste_admin = New System.Windows.Forms.Button()
        Me.btn_liste_abonne = New System.Windows.Forms.Button()
        Me.btn_liste_emprunt = New System.Windows.Forms.Button()
        Me.btn_emprunt = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ajouter_livre
        '
        Me.btn_ajouter_livre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ajouter_livre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajouter_livre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter_livre.Location = New System.Drawing.Point(69, 171)
        Me.btn_ajouter_livre.Name = "btn_ajouter_livre"
        Me.btn_ajouter_livre.Size = New System.Drawing.Size(154, 30)
        Me.btn_ajouter_livre.TabIndex = 0
        Me.btn_ajouter_livre.Text = "Ajouter un livre"
        Me.btn_ajouter_livre.UseVisualStyleBackColor = False
        '
        'btn_ajout_categorie
        '
        Me.btn_ajout_categorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ajout_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajout_categorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout_categorie.Location = New System.Drawing.Point(307, 171)
        Me.btn_ajout_categorie.Name = "btn_ajout_categorie"
        Me.btn_ajout_categorie.Size = New System.Drawing.Size(167, 30)
        Me.btn_ajout_categorie.TabIndex = 1
        Me.btn_ajout_categorie.Text = "Ajouter une catégorie"
        Me.btn_ajout_categorie.UseVisualStyleBackColor = False
        '
        'btn_ajout_abonne
        '
        Me.btn_ajout_abonne.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ajout_abonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajout_abonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout_abonne.Location = New System.Drawing.Point(570, 171)
        Me.btn_ajout_abonne.Name = "btn_ajout_abonne"
        Me.btn_ajout_abonne.Size = New System.Drawing.Size(169, 30)
        Me.btn_ajout_abonne.TabIndex = 2
        Me.btn_ajout_abonne.Text = "Ajouter un abonné"
        Me.btn_ajout_abonne.UseVisualStyleBackColor = False
        '
        'liste_livre
        '
        Me.liste_livre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.liste_livre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.liste_livre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.liste_livre.Location = New System.Drawing.Point(69, 247)
        Me.liste_livre.Name = "liste_livre"
        Me.liste_livre.Size = New System.Drawing.Size(154, 30)
        Me.liste_livre.TabIndex = 6
        Me.liste_livre.Text = "Liste des livres"
        Me.liste_livre.UseVisualStyleBackColor = False
        '
        'btn_deconnexion
        '
        Me.btn_deconnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deconnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deconnexion.Location = New System.Drawing.Point(214, 412)
        Me.btn_deconnexion.Name = "btn_deconnexion"
        Me.btn_deconnexion.Size = New System.Drawing.Size(130, 30)
        Me.btn_deconnexion.TabIndex = 9
        Me.btn_deconnexion.Text = "Déconnexion"
        Me.btn_deconnexion.UseVisualStyleBackColor = False
        '
        'btn_principale_quitter
        '
        Me.btn_principale_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_principale_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_principale_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_principale_quitter.Location = New System.Drawing.Point(434, 412)
        Me.btn_principale_quitter.Name = "btn_principale_quitter"
        Me.btn_principale_quitter.Size = New System.Drawing.Size(134, 30)
        Me.btn_principale_quitter.TabIndex = 12
        Me.btn_principale_quitter.Text = "Quitter"
        Me.btn_principale_quitter.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(303, 35)
        Me.Label1.MaximumSize = New System.Drawing.Size(300, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bienvenu(e) sur votre interface"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(240, 93)
        Me.Label2.MaximumSize = New System.Drawing.Size(300, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 30)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Que voulez-vous faire ?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_liste_admin
        '
        Me.btn_liste_admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_liste_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_liste_admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_liste_admin.Location = New System.Drawing.Point(307, 247)
        Me.btn_liste_admin.Name = "btn_liste_admin"
        Me.btn_liste_admin.Size = New System.Drawing.Size(167, 30)
        Me.btn_liste_admin.TabIndex = 16
        Me.btn_liste_admin.Text = "Liste des admins"
        Me.btn_liste_admin.UseVisualStyleBackColor = False
        '
        'btn_liste_abonne
        '
        Me.btn_liste_abonne.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_liste_abonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_liste_abonne.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_liste_abonne.Location = New System.Drawing.Point(570, 247)
        Me.btn_liste_abonne.Name = "btn_liste_abonne"
        Me.btn_liste_abonne.Size = New System.Drawing.Size(169, 30)
        Me.btn_liste_abonne.TabIndex = 17
        Me.btn_liste_abonne.Text = "Liste des abonnés"
        Me.btn_liste_abonne.UseVisualStyleBackColor = False
        '
        'btn_liste_emprunt
        '
        Me.btn_liste_emprunt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_liste_emprunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_liste_emprunt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_liste_emprunt.Location = New System.Drawing.Point(307, 320)
        Me.btn_liste_emprunt.Name = "btn_liste_emprunt"
        Me.btn_liste_emprunt.Size = New System.Drawing.Size(167, 30)
        Me.btn_liste_emprunt.TabIndex = 19
        Me.btn_liste_emprunt.Text = "Liste des emprunts"
        Me.btn_liste_emprunt.UseVisualStyleBackColor = False
        '
        'btn_emprunt
        '
        Me.btn_emprunt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_emprunt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_emprunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_emprunt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emprunt.Location = New System.Drawing.Point(69, 320)
        Me.btn_emprunt.Name = "btn_emprunt"
        Me.btn_emprunt.Size = New System.Drawing.Size(154, 30)
        Me.btn_emprunt.TabIndex = 18
        Me.btn_emprunt.Text = "Gérer un emprunt"
        Me.btn_emprunt.UseVisualStyleBackColor = False
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 516)
        Me.Controls.Add(Me.btn_liste_emprunt)
        Me.Controls.Add(Me.btn_emprunt)
        Me.Controls.Add(Me.btn_liste_abonne)
        Me.Controls.Add(Me.btn_liste_admin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_principale_quitter)
        Me.Controls.Add(Me.btn_deconnexion)
        Me.Controls.Add(Me.liste_livre)
        Me.Controls.Add(Me.btn_ajout_abonne)
        Me.Controls.Add(Me.btn_ajout_categorie)
        Me.Controls.Add(Me.btn_ajouter_livre)
        Me.Location = New System.Drawing.Point(550, 0)
        Me.Name = "Principale"
        Me.Text = "Interface Principale"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ajouter_livre As Button
    Friend WithEvents btn_ajout_categorie As Button
    Friend WithEvents btn_ajout_abonne As Button
    Friend WithEvents liste_livre As Button
    Friend WithEvents btn_deconnexion As Button
    Friend WithEvents btn_principale_quitter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_liste_admin As Button
    Friend WithEvents btn_liste_abonne As Button
    Friend WithEvents btn_liste_emprunt As Button
    Friend WithEvents btn_emprunt As Button
End Class
