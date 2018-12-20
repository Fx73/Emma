<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Emma
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emma))
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button_Accept = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.TextBox()
        Me.Button_quit = New System.Windows.Forms.Button()
        Me.MyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button_Compliment = New System.Windows.Forms.Button()
        Me.Options = New System.Windows.Forms.CheckBox()
        Me.Button_msg = New System.Windows.Forms.Button()
        Me.CheckBoot = New System.Windows.Forms.CheckBox()
        Me.TextEnvoi = New System.Windows.Forms.TextBox()
        Me.TextRecu = New System.Windows.Forms.TextBox()
        Me.Destinataire = New System.Windows.Forms.ComboBox()
        Me.flager = New System.Windows.Forms.Timer(Me.components)
        Me.CheckCompliment = New System.Windows.Forms.CheckBox()
        Me.interv_comp = New System.Windows.Forms.NumericUpDown()
        Me.MDLserverpic = New System.Windows.Forms.PictureBox()
        CType(Me.interv_comp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDLserverpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'Button_Accept
        '
        Me.Button_Accept.Location = New System.Drawing.Point(86, 93)
        Me.Button_Accept.Name = "Button_Accept"
        Me.Button_Accept.Size = New System.Drawing.Size(312, 23)
        Me.Button_Accept.TabIndex = 0
        Me.Button_Accept.Text = "Button_accept"
        Me.Button_Accept.UseVisualStyleBackColor = True
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.Crimson
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Titre.Cursor = System.Windows.Forms.Cursors.Default
        Me.Titre.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.ForeColor = System.Drawing.Color.Black
        Me.Titre.Location = New System.Drawing.Point(7, 12)
        Me.Titre.Multiline = True
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(422, 49)
        Me.Titre.TabIndex = 1
        '
        'Button_quit
        '
        Me.Button_quit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_quit.Location = New System.Drawing.Point(86, 122)
        Me.Button_quit.Name = "Button_quit"
        Me.Button_quit.Size = New System.Drawing.Size(312, 23)
        Me.Button_quit.TabIndex = 2
        Me.Button_quit.Text = "Button_quit"
        Me.Button_quit.UseVisualStyleBackColor = True
        '
        'MyTimer
        '
        Me.MyTimer.Enabled = True
        Me.MyTimer.Interval = 20000
        '
        'Button_Compliment
        '
        Me.Button_Compliment.Location = New System.Drawing.Point(405, 93)
        Me.Button_Compliment.Name = "Button_Compliment"
        Me.Button_Compliment.Size = New System.Drawing.Size(24, 22)
        Me.Button_Compliment.TabIndex = 3
        Me.Button_Compliment.Text = "Compliment"
        Me.Button_Compliment.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.Appearance = System.Windows.Forms.Appearance.Button
        Me.Options.AutoSize = True
        Me.Options.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Options.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.Options.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Options.Location = New System.Drawing.Point(404, 122)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(53, 23)
        Me.Options.TabIndex = 4
        Me.Options.Text = "Options"
        Me.Options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Options.UseVisualStyleBackColor = False
        '
        'Button_msg
        '
        Me.Button_msg.Location = New System.Drawing.Point(7, 93)
        Me.Button_msg.Name = "Button_msg"
        Me.Button_msg.Size = New System.Drawing.Size(73, 52)
        Me.Button_msg.TabIndex = 5
        Me.Button_msg.Text = "Button_msg"
        Me.Button_msg.UseVisualStyleBackColor = True
        '
        'CheckBoot
        '
        Me.CheckBoot.AutoSize = True
        Me.CheckBoot.Location = New System.Drawing.Point(12, 235)
        Me.CheckBoot.Name = "CheckBoot"
        Me.CheckBoot.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoot.TabIndex = 6
        Me.CheckBoot.Text = "CheckBoot"
        Me.CheckBoot.UseVisualStyleBackColor = True
        '
        'TextEnvoi
        '
        Me.TextEnvoi.Location = New System.Drawing.Point(86, 67)
        Me.TextEnvoi.Name = "TextEnvoi"
        Me.TextEnvoi.Size = New System.Drawing.Size(342, 20)
        Me.TextEnvoi.TabIndex = 7
        '
        'TextRecu
        '
        Me.TextRecu.Location = New System.Drawing.Point(102, 170)
        Me.TextRecu.Multiline = True
        Me.TextRecu.Name = "TextRecu"
        Me.TextRecu.ReadOnly = True
        Me.TextRecu.Size = New System.Drawing.Size(325, 40)
        Me.TextRecu.TabIndex = 8
        '
        'Destinataire
        '
        Me.Destinataire.FormattingEnabled = True
        Me.Destinataire.Items.AddRange(New Object() {"FX", "Lele Dav", "Emma", "Blandine"})
        Me.Destinataire.Location = New System.Drawing.Point(7, 67)
        Me.Destinataire.Name = "Destinataire"
        Me.Destinataire.Size = New System.Drawing.Size(73, 21)
        Me.Destinataire.TabIndex = 10
        Me.Destinataire.Text = "Moi"
        '
        'flager
        '
        Me.flager.Enabled = True
        Me.flager.Interval = 2000
        '
        'CheckCompliment
        '
        Me.CheckCompliment.AutoSize = True
        Me.CheckCompliment.Location = New System.Drawing.Point(12, 214)
        Me.CheckCompliment.Name = "CheckCompliment"
        Me.CheckCompliment.Size = New System.Drawing.Size(166, 17)
        Me.CheckCompliment.TabIndex = 11
        Me.CheckCompliment.Text = "Compliments (toutes les x min)"
        Me.CheckCompliment.UseVisualStyleBackColor = True
        '
        'interv_comp
        '
        Me.interv_comp.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.interv_comp.Location = New System.Drawing.Point(185, 214)
        Me.interv_comp.Name = "interv_comp"
        Me.interv_comp.Size = New System.Drawing.Size(39, 20)
        Me.interv_comp.TabIndex = 12
        Me.interv_comp.ThousandsSeparator = True
        Me.interv_comp.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MDLserverpic
        '
        Me.MDLserverpic.BackColor = System.Drawing.Color.Crimson
        Me.MDLserverpic.BackgroundImage = Global.Emma.My.Resources.Resources.MDLserverKO
        Me.MDLserverpic.ErrorImage = Global.Emma.My.Resources.Resources.MDLserverOK
        Me.MDLserverpic.Image = Global.Emma.My.Resources.Resources.MDLserverKO
        Me.MDLserverpic.InitialImage = Global.Emma.My.Resources.Resources.MDLserverLinked
        Me.MDLserverpic.Location = New System.Drawing.Point(405, 13)
        Me.MDLserverpic.Name = "MDLserverpic"
        Me.MDLserverpic.Size = New System.Drawing.Size(18, 18)
        Me.MDLserverpic.TabIndex = 13
        Me.MDLserverpic.TabStop = False
        '
        'Emma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.Emma.My.Resources.Resources.Fond
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(440, 260)
        Me.Controls.Add(Me.MDLserverpic)
        Me.Controls.Add(Me.interv_comp)
        Me.Controls.Add(Me.CheckCompliment)
        Me.Controls.Add(Me.Destinataire)
        Me.Controls.Add(Me.TextRecu)
        Me.Controls.Add(Me.TextEnvoi)
        Me.Controls.Add(Me.CheckBoot)
        Me.Controls.Add(Me.Button_msg)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Button_Compliment)
        Me.Controls.Add(Me.Button_quit)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.Button_Accept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Emma"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emma"
        CType(Me.interv_comp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDLserverpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents Button_Accept As Button
    Friend WithEvents Titre As TextBox
    Friend WithEvents Button_quit As Button
    Friend WithEvents MyTimer As Timer
    Friend WithEvents Button_Compliment As Button
    Friend WithEvents Options As CheckBox
    Friend WithEvents Button_msg As Button
    Friend WithEvents CheckBoot As CheckBox
    Friend WithEvents TextEnvoi As TextBox
    Friend WithEvents TextRecu As TextBox
    Friend WithEvents Destinataire As ComboBox
    Friend WithEvents flager As Timer
    Friend WithEvents CheckCompliment As CheckBox
    Friend WithEvents interv_comp As NumericUpDown
    Friend WithEvents MDLserverpic As PictureBox
End Class
