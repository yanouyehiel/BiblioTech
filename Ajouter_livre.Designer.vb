<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ajout_livre
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combox_genre = New System.Windows.Forms.ComboBox()
        Me.btn_livre_quitter = New System.Windows.Forms.Button()
        Me.btn_ajout_livre = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbox_description = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbox_page = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbox_maison_edition = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox_auteur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_nom = New System.Windows.Forms.TextBox()
        Me.label_nom = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nouveau Livre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combox_genre)
        Me.GroupBox1.Controls.Add(Me.btn_livre_quitter)
        Me.GroupBox1.Controls.Add(Me.btn_ajout_livre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtbox_description)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtbox_page)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbox_maison_edition)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbox_auteur)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbox_nom)
        Me.GroupBox1.Controls.Add(Me.label_nom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(120, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 470)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter"
        '
        'combox_genre
        '
        Me.combox_genre.FormattingEnabled = True
        Me.combox_genre.Items.AddRange(New Object() {"Drame", "Fiction", "Triller & Policier", "Roman", "Réalisme", "Philosophique", "Crime", "Drame & Fiction", "Autobiographie"})
        Me.combox_genre.Location = New System.Drawing.Point(183, 328)
        Me.combox_genre.Name = "combox_genre"
        Me.combox_genre.Size = New System.Drawing.Size(313, 24)
        Me.combox_genre.TabIndex = 6
        '
        'btn_livre_quitter
        '
        Me.btn_livre_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_livre_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_livre_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_livre_quitter.Location = New System.Drawing.Point(268, 416)
        Me.btn_livre_quitter.Name = "btn_livre_quitter"
        Me.btn_livre_quitter.Size = New System.Drawing.Size(100, 30)
        Me.btn_livre_quitter.TabIndex = 8
        Me.btn_livre_quitter.Text = "Quitter"
        Me.btn_livre_quitter.UseVisualStyleBackColor = False
        '
        'btn_ajout_livre
        '
        Me.btn_ajout_livre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ajout_livre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajout_livre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout_livre.Location = New System.Drawing.Point(147, 416)
        Me.btn_ajout_livre.Name = "btn_ajout_livre"
        Me.btn_ajout_livre.Size = New System.Drawing.Size(100, 30)
        Me.btn_ajout_livre.TabIndex = 7
        Me.btn_ajout_livre.Text = "Ajouter"
        Me.btn_ajout_livre.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(44, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Genre littéraire :"
        '
        'txtbox_description
        '
        Me.txtbox_description.Location = New System.Drawing.Point(183, 240)
        Me.txtbox_description.Multiline = True
        Me.txtbox_description.Name = "txtbox_description"
        Me.txtbox_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbox_description.Size = New System.Drawing.Size(313, 63)
        Me.txtbox_description.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Description :"
        '
        'txtbox_page
        '
        Me.txtbox_page.Location = New System.Drawing.Point(183, 191)
        Me.txtbox_page.Name = "txtbox_page"
        Me.txtbox_page.Size = New System.Drawing.Size(313, 22)
        Me.txtbox_page.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre de pages :"
        '
        'txtbox_maison_edition
        '
        Me.txtbox_maison_edition.Location = New System.Drawing.Point(183, 135)
        Me.txtbox_maison_edition.Name = "txtbox_maison_edition"
        Me.txtbox_maison_edition.Size = New System.Drawing.Size(313, 22)
        Me.txtbox_maison_edition.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Maison d'édition :"
        '
        'txtbox_auteur
        '
        Me.txtbox_auteur.Location = New System.Drawing.Point(183, 78)
        Me.txtbox_auteur.Name = "txtbox_auteur"
        Me.txtbox_auteur.Size = New System.Drawing.Size(313, 22)
        Me.txtbox_auteur.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Auteur du livre :"
        '
        'txtbox_nom
        '
        Me.txtbox_nom.Location = New System.Drawing.Point(183, 32)
        Me.txtbox_nom.Name = "txtbox_nom"
        Me.txtbox_nom.Size = New System.Drawing.Size(313, 22)
        Me.txtbox_nom.TabIndex = 1
        '
        'label_nom
        '
        Me.label_nom.AutoSize = True
        Me.label_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nom.Location = New System.Drawing.Point(51, 30)
        Me.label_nom.Name = "label_nom"
        Me.label_nom.Size = New System.Drawing.Size(103, 20)
        Me.label_nom.TabIndex = 0
        Me.label_nom.Text = "Nom du livre :"
        '
        'ajout_livre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(771, 542)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(579, 0)
        Me.Name = "ajout_livre"
        Me.Text = "Ajouter un livre"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbox_description As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbox_page As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbox_maison_edition As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbox_auteur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_nom As TextBox
    Friend WithEvents label_nom As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_ajout_livre As Button
    Friend WithEvents btn_livre_quitter As Button
    Friend WithEvents combox_genre As ComboBox
End Class
