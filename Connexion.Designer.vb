<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class connexion_admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(connexion_admin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_categorie_quitter = New System.Windows.Forms.Button()
        Me.btn_connexion = New System.Windows.Forms.Button()
        Me.txtbox_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_pseudo = New System.Windows.Forms.TextBox()
        Me.label_nom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entrer vos identifiants"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_categorie_quitter)
        Me.GroupBox1.Controls.Add(Me.btn_connexion)
        Me.GroupBox1.Controls.Add(Me.txtbox_password)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbox_pseudo)
        Me.GroupBox1.Controls.Add(Me.label_nom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 173)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connexion"
        '
        'btn_categorie_quitter
        '
        Me.btn_categorie_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_categorie_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categorie_quitter.Location = New System.Drawing.Point(269, 126)
        Me.btn_categorie_quitter.Name = "btn_categorie_quitter"
        Me.btn_categorie_quitter.Size = New System.Drawing.Size(100, 30)
        Me.btn_categorie_quitter.TabIndex = 5
        Me.btn_categorie_quitter.Text = "Quitter"
        Me.btn_categorie_quitter.UseVisualStyleBackColor = False
        '
        'btn_connexion
        '
        Me.btn_connexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_connexion.Location = New System.Drawing.Point(147, 126)
        Me.btn_connexion.Name = "btn_connexion"
        Me.btn_connexion.Size = New System.Drawing.Size(100, 30)
        Me.btn_connexion.TabIndex = 4
        Me.btn_connexion.Text = "Connexion"
        Me.btn_connexion.UseVisualStyleBackColor = False
        '
        'txtbox_password
        '
        Me.txtbox_password.Location = New System.Drawing.Point(147, 78)
        Me.txtbox_password.Name = "txtbox_password"
        Me.txtbox_password.Size = New System.Drawing.Size(313, 22)
        Me.txtbox_password.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mot de passe :"
        '
        'txtbox_pseudo
        '
        Me.txtbox_pseudo.Location = New System.Drawing.Point(147, 32)
        Me.txtbox_pseudo.Name = "txtbox_pseudo"
        Me.txtbox_pseudo.Size = New System.Drawing.Size(313, 22)
        Me.txtbox_pseudo.TabIndex = 1
        '
        'label_nom
        '
        Me.label_nom.AutoSize = True
        Me.label_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nom.Location = New System.Drawing.Point(30, 35)
        Me.label_nom.Name = "label_nom"
        Me.label_nom.Size = New System.Drawing.Size(61, 16)
        Me.label_nom.TabIndex = 0
        Me.label_nom.Text = "Pseudo :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'connexion_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 316)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "connexion_admin"
        Me.Text = "Connexion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_categorie_quitter As Button
    Friend WithEvents btn_connexion As Button
    Friend WithEvents txtbox_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_pseudo As TextBox
    Friend WithEvents label_nom As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
