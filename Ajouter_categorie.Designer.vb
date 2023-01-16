<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ajouter_categorie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ajouter_categorie))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_categorie_quitter = New System.Windows.Forms.Button()
        Me.btn_ajout_categorie = New System.Windows.Forms.Button()
        Me.txtbox_nom = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(187, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ajouter une catégorie"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_categorie_quitter)
        Me.GroupBox1.Controls.Add(Me.btn_ajout_categorie)
        Me.GroupBox1.Controls.Add(Me.txtbox_nom)
        Me.GroupBox1.Controls.Add(Me.label_nom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(56, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 158)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ajouter"
        '
        'btn_categorie_quitter
        '
        Me.btn_categorie_quitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_categorie_quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_categorie_quitter.Location = New System.Drawing.Point(199, 94)
        Me.btn_categorie_quitter.Name = "btn_categorie_quitter"
        Me.btn_categorie_quitter.Size = New System.Drawing.Size(100, 30)
        Me.btn_categorie_quitter.TabIndex = 5
        Me.btn_categorie_quitter.Text = "Quitter"
        Me.btn_categorie_quitter.UseVisualStyleBackColor = False
        '
        'btn_ajout_categorie
        '
        Me.btn_ajout_categorie.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_ajout_categorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajout_categorie.Location = New System.Drawing.Point(77, 94)
        Me.btn_ajout_categorie.Name = "btn_ajout_categorie"
        Me.btn_ajout_categorie.Size = New System.Drawing.Size(100, 30)
        Me.btn_ajout_categorie.TabIndex = 4
        Me.btn_ajout_categorie.Text = "Ajouter"
        Me.btn_ajout_categorie.UseVisualStyleBackColor = False
        '
        'txtbox_nom
        '
        Me.txtbox_nom.Location = New System.Drawing.Point(172, 35)
        Me.txtbox_nom.Name = "txtbox_nom"
        Me.txtbox_nom.Size = New System.Drawing.Size(206, 22)
        Me.txtbox_nom.TabIndex = 1
        '
        'label_nom
        '
        Me.label_nom.AutoSize = True
        Me.label_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nom.Location = New System.Drawing.Point(19, 35)
        Me.label_nom.Name = "label_nom"
        Me.label_nom.Size = New System.Drawing.Size(147, 16)
        Me.label_nom.TabIndex = 0
        Me.label_nom.Text = "Libellé de la catégorie :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ajouter_categorie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 313)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(423, 174)
        Me.Name = "ajouter_categorie"
        Me.Text = "Ajouter catégorie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbox_nom As TextBox
    Friend WithEvents label_nom As Label
    Friend WithEvents btn_ajout_categorie As Button
    Friend WithEvents btn_categorie_quitter As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
