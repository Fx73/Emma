<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Morpion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AdversaireBox = New System.Windows.Forms.ComboBox()
        Me.BoxEntree = New System.Windows.Forms.GroupBox()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.LabelEntree = New System.Windows.Forms.Label()
        Me.LabelAdversaire = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.Button()
        Me.A2 = New System.Windows.Forms.Button()
        Me.A3 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.C3 = New System.Windows.Forms.Button()
        Me.C2 = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.Button()
        Me.LabelAttente = New System.Windows.Forms.Label()
        Me.BoxEntree.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdversaireBox
        '
        Me.AdversaireBox.FormattingEnabled = True
        Me.AdversaireBox.Items.AddRange(New Object() {"FX", "ldavi", "Emma", "Blandine"})
        Me.AdversaireBox.Location = New System.Drawing.Point(64, 41)
        Me.AdversaireBox.Name = "AdversaireBox"
        Me.AdversaireBox.Size = New System.Drawing.Size(75, 21)
        Me.AdversaireBox.TabIndex = 11
        Me.AdversaireBox.Text = "Moi"
        '
        'BoxEntree
        '
        Me.BoxEntree.BackColor = System.Drawing.SystemColors.Control
        Me.BoxEntree.Controls.Add(Me.ButtonOk)
        Me.BoxEntree.Controls.Add(Me.LabelEntree)
        Me.BoxEntree.Controls.Add(Me.AdversaireBox)
        Me.BoxEntree.Location = New System.Drawing.Point(65, 115)
        Me.BoxEntree.Name = "BoxEntree"
        Me.BoxEntree.Size = New System.Drawing.Size(200, 100)
        Me.BoxEntree.TabIndex = 14
        Me.BoxEntree.TabStop = False
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(64, 71)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOk.TabIndex = 13
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'LabelEntree
        '
        Me.LabelEntree.AutoSize = True
        Me.LabelEntree.Location = New System.Drawing.Point(40, 16)
        Me.LabelEntree.Name = "LabelEntree"
        Me.LabelEntree.Size = New System.Drawing.Size(125, 13)
        Me.LabelEntree.TabIndex = 12
        Me.LabelEntree.Text = "Qui sera ton adversaire ?"
        '
        'LabelAdversaire
        '
        Me.LabelAdversaire.AutoEllipsis = True
        Me.LabelAdversaire.BackColor = System.Drawing.Color.Transparent
        Me.LabelAdversaire.Font = New System.Drawing.Font("Bauhaus 93", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdversaire.ForeColor = System.Drawing.Color.Moccasin
        Me.LabelAdversaire.Location = New System.Drawing.Point(40, 9)
        Me.LabelAdversaire.Name = "LabelAdversaire"
        Me.LabelAdversaire.Size = New System.Drawing.Size(250, 28)
        Me.LabelAdversaire.TabIndex = 15
        Me.LabelAdversaire.Text = "En attente"
        Me.LabelAdversaire.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'A1
        '
        Me.A1.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A1.Location = New System.Drawing.Point(40, 40)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(80, 80)
        Me.A1.TabIndex = 16
        Me.A1.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A2.Location = New System.Drawing.Point(40, 125)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(80, 80)
        Me.A2.TabIndex = 17
        Me.A2.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A3.Location = New System.Drawing.Point(40, 210)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(80, 80)
        Me.A3.TabIndex = 18
        Me.A3.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.Location = New System.Drawing.Point(125, 210)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(80, 80)
        Me.B3.TabIndex = 21
        Me.B3.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.Location = New System.Drawing.Point(125, 125)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(80, 80)
        Me.B2.TabIndex = 20
        Me.B2.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.Location = New System.Drawing.Point(125, 40)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(80, 80)
        Me.B1.TabIndex = 19
        Me.B1.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C3.Location = New System.Drawing.Point(210, 210)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(80, 80)
        Me.C3.TabIndex = 24
        Me.C3.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C2.Location = New System.Drawing.Point(210, 125)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(80, 80)
        Me.C2.TabIndex = 23
        Me.C2.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.Font = New System.Drawing.Font("Goudy Stout", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1.Location = New System.Drawing.Point(210, 40)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(80, 80)
        Me.C1.TabIndex = 22
        Me.C1.UseVisualStyleBackColor = True
        '
        'LabelAttente
        '
        Me.LabelAttente.AutoSize = True
        Me.LabelAttente.Location = New System.Drawing.Point(136, 293)
        Me.LabelAttente.Name = "LabelAttente"
        Me.LabelAttente.Size = New System.Drawing.Size(68, 13)
        Me.LabelAttente.TabIndex = 25
        Me.LabelAttente.Text = "En attente ..."
        Me.LabelAttente.Visible = False
        '
        'Morpion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(334, 312)
        Me.Controls.Add(Me.LabelAttente)
        Me.Controls.Add(Me.LabelAdversaire)
        Me.Controls.Add(Me.BoxEntree)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.A2)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.A1)
        Me.Controls.Add(Me.A3)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.C3)
        Me.Name = "Morpion"
        Me.Text = "Morpion"
        Me.BoxEntree.ResumeLayout(False)
        Me.BoxEntree.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdversaireBox As ComboBox
    Friend WithEvents BoxEntree As GroupBox
    Friend WithEvents ButtonOk As Button
    Friend WithEvents LabelEntree As Label
    Friend WithEvents LabelAdversaire As Label
    Friend WithEvents A1 As Button
    Friend WithEvents A2 As Button
    Friend WithEvents A3 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents C3 As Button
    Friend WithEvents C2 As Button
    Friend WithEvents C1 As Button
    Friend WithEvents LabelAttente As Label
End Class
