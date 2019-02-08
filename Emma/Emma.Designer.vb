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
        Me.LettresGrid = New System.Windows.Forms.Panel()
        Me.ButtonZ = New System.Windows.Forms.Button()
        Me.ButtonY = New System.Windows.Forms.Button()
        Me.ButtonX = New System.Windows.Forms.Button()
        Me.ButtonW = New System.Windows.Forms.Button()
        Me.ButtonV = New System.Windows.Forms.Button()
        Me.ButtonU = New System.Windows.Forms.Button()
        Me.ButtonT = New System.Windows.Forms.Button()
        Me.ButtonS = New System.Windows.Forms.Button()
        Me.ButtonR = New System.Windows.Forms.Button()
        Me.ButtonQ = New System.Windows.Forms.Button()
        Me.ButtonP = New System.Windows.Forms.Button()
        Me.ButtonO = New System.Windows.Forms.Button()
        Me.ButtonN = New System.Windows.Forms.Button()
        Me.ButtonM = New System.Windows.Forms.Button()
        Me.ButtonL = New System.Windows.Forms.Button()
        Me.ButtonK = New System.Windows.Forms.Button()
        Me.ButtonJ = New System.Windows.Forms.Button()
        Me.ButtonI = New System.Windows.Forms.Button()
        Me.ButtonH = New System.Windows.Forms.Button()
        Me.ButtonG = New System.Windows.Forms.Button()
        Me.ButtonF = New System.Windows.Forms.Button()
        Me.ButtonE = New System.Windows.Forms.Button()
        Me.ButtonD = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.BarPendu = New System.Windows.Forms.ProgressBar()
        CType(Me.interv_comp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MDLserverpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LettresGrid.SuspendLayout()
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
        'Options
        '
        Me.Options.Appearance = System.Windows.Forms.Appearance.Button
        Me.Options.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Options.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green
        Me.Options.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Options.Image = Global.Emma.My.Resources.Resources.flechebas
        Me.Options.Location = New System.Drawing.Point(404, 122)
        Me.Options.MaximumSize = New System.Drawing.Size(23, 23)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(23, 23)
        Me.Options.TabIndex = 4
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
        Me.CheckBoot.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoot.Location = New System.Drawing.Point(12, 235)
        Me.CheckBoot.Name = "CheckBoot"
        Me.CheckBoot.Size = New System.Drawing.Size(79, 17)
        Me.CheckBoot.TabIndex = 6
        Me.CheckBoot.Text = "CheckBoot"
        Me.CheckBoot.UseVisualStyleBackColor = False
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
        Me.TextRecu.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextRecu.Location = New System.Drawing.Point(12, 165)
        Me.TextRecu.Multiline = True
        Me.TextRecu.Name = "TextRecu"
        Me.TextRecu.ReadOnly = True
        Me.TextRecu.Size = New System.Drawing.Size(415, 45)
        Me.TextRecu.TabIndex = 8
        '
        'Destinataire
        '
        Me.Destinataire.FormattingEnabled = True
        Me.Destinataire.Items.AddRange(New Object() {"FX", "ldavi", "Emma", "Blandine"})
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
        Me.CheckCompliment.BackColor = System.Drawing.Color.Transparent
        Me.CheckCompliment.Location = New System.Drawing.Point(12, 214)
        Me.CheckCompliment.Name = "CheckCompliment"
        Me.CheckCompliment.Size = New System.Drawing.Size(105, 17)
        Me.CheckCompliment.TabIndex = 11
        Me.CheckCompliment.Text = "Compliment (min)"
        Me.CheckCompliment.UseVisualStyleBackColor = False
        '
        'interv_comp
        '
        Me.interv_comp.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.interv_comp.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.interv_comp.Location = New System.Drawing.Point(123, 214)
        Me.interv_comp.Name = "interv_comp"
        Me.interv_comp.Size = New System.Drawing.Size(26, 20)
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
        'LettresGrid
        '
        Me.LettresGrid.Controls.Add(Me.ButtonZ)
        Me.LettresGrid.Controls.Add(Me.ButtonY)
        Me.LettresGrid.Controls.Add(Me.ButtonX)
        Me.LettresGrid.Controls.Add(Me.ButtonW)
        Me.LettresGrid.Controls.Add(Me.ButtonV)
        Me.LettresGrid.Controls.Add(Me.ButtonU)
        Me.LettresGrid.Controls.Add(Me.ButtonT)
        Me.LettresGrid.Controls.Add(Me.ButtonS)
        Me.LettresGrid.Controls.Add(Me.ButtonR)
        Me.LettresGrid.Controls.Add(Me.ButtonQ)
        Me.LettresGrid.Controls.Add(Me.ButtonP)
        Me.LettresGrid.Controls.Add(Me.ButtonO)
        Me.LettresGrid.Controls.Add(Me.ButtonN)
        Me.LettresGrid.Controls.Add(Me.ButtonM)
        Me.LettresGrid.Controls.Add(Me.ButtonL)
        Me.LettresGrid.Controls.Add(Me.ButtonK)
        Me.LettresGrid.Controls.Add(Me.ButtonJ)
        Me.LettresGrid.Controls.Add(Me.ButtonI)
        Me.LettresGrid.Controls.Add(Me.ButtonH)
        Me.LettresGrid.Controls.Add(Me.ButtonG)
        Me.LettresGrid.Controls.Add(Me.ButtonF)
        Me.LettresGrid.Controls.Add(Me.ButtonE)
        Me.LettresGrid.Controls.Add(Me.ButtonD)
        Me.LettresGrid.Controls.Add(Me.ButtonC)
        Me.LettresGrid.Controls.Add(Me.ButtonB)
        Me.LettresGrid.Controls.Add(Me.ButtonA)
        Me.LettresGrid.Location = New System.Drawing.Point(152, 214)
        Me.LettresGrid.Name = "LettresGrid"
        Me.LettresGrid.Size = New System.Drawing.Size(277, 47)
        Me.LettresGrid.TabIndex = 17
        Me.LettresGrid.Visible = False
        '
        'ButtonZ
        '
        Me.ButtonZ.Location = New System.Drawing.Point(254, 24)
        Me.ButtonZ.Name = "ButtonZ"
        Me.ButtonZ.Size = New System.Drawing.Size(20, 20)
        Me.ButtonZ.TabIndex = 25
        Me.ButtonZ.Tag = "Lettres"
        Me.ButtonZ.Text = "Z"
        Me.ButtonZ.UseVisualStyleBackColor = True
        '
        'ButtonY
        '
        Me.ButtonY.Location = New System.Drawing.Point(233, 24)
        Me.ButtonY.Name = "ButtonY"
        Me.ButtonY.Size = New System.Drawing.Size(20, 20)
        Me.ButtonY.TabIndex = 24
        Me.ButtonY.Tag = "Lettres"
        Me.ButtonY.Text = "Y"
        Me.ButtonY.UseVisualStyleBackColor = True
        '
        'ButtonX
        '
        Me.ButtonX.Location = New System.Drawing.Point(212, 24)
        Me.ButtonX.Name = "ButtonX"
        Me.ButtonX.Size = New System.Drawing.Size(20, 20)
        Me.ButtonX.TabIndex = 23
        Me.ButtonX.Tag = "Lettres"
        Me.ButtonX.Text = "X"
        Me.ButtonX.UseVisualStyleBackColor = True
        '
        'ButtonW
        '
        Me.ButtonW.Location = New System.Drawing.Point(191, 24)
        Me.ButtonW.Name = "ButtonW"
        Me.ButtonW.Size = New System.Drawing.Size(20, 20)
        Me.ButtonW.TabIndex = 22
        Me.ButtonW.Tag = "Lettres"
        Me.ButtonW.Text = "W"
        Me.ButtonW.UseVisualStyleBackColor = True
        '
        'ButtonV
        '
        Me.ButtonV.Location = New System.Drawing.Point(171, 24)
        Me.ButtonV.Name = "ButtonV"
        Me.ButtonV.Size = New System.Drawing.Size(20, 20)
        Me.ButtonV.TabIndex = 21
        Me.ButtonV.Tag = "Lettres"
        Me.ButtonV.Text = "V"
        Me.ButtonV.UseVisualStyleBackColor = True
        '
        'ButtonU
        '
        Me.ButtonU.Location = New System.Drawing.Point(150, 24)
        Me.ButtonU.Name = "ButtonU"
        Me.ButtonU.Size = New System.Drawing.Size(20, 20)
        Me.ButtonU.TabIndex = 20
        Me.ButtonU.Tag = "Lettres"
        Me.ButtonU.Text = "U"
        Me.ButtonU.UseVisualStyleBackColor = True
        '
        'ButtonT
        '
        Me.ButtonT.Location = New System.Drawing.Point(129, 24)
        Me.ButtonT.Name = "ButtonT"
        Me.ButtonT.Size = New System.Drawing.Size(20, 20)
        Me.ButtonT.TabIndex = 19
        Me.ButtonT.Tag = "Lettres"
        Me.ButtonT.Text = "T"
        Me.ButtonT.UseVisualStyleBackColor = True
        '
        'ButtonS
        '
        Me.ButtonS.Location = New System.Drawing.Point(108, 24)
        Me.ButtonS.Name = "ButtonS"
        Me.ButtonS.Size = New System.Drawing.Size(20, 20)
        Me.ButtonS.TabIndex = 18
        Me.ButtonS.Tag = "Lettres"
        Me.ButtonS.Text = "S"
        Me.ButtonS.UseVisualStyleBackColor = True
        '
        'ButtonR
        '
        Me.ButtonR.Location = New System.Drawing.Point(87, 24)
        Me.ButtonR.Name = "ButtonR"
        Me.ButtonR.Size = New System.Drawing.Size(20, 20)
        Me.ButtonR.TabIndex = 17
        Me.ButtonR.Tag = "Lettres"
        Me.ButtonR.Text = "R"
        Me.ButtonR.UseVisualStyleBackColor = True
        '
        'ButtonQ
        '
        Me.ButtonQ.Location = New System.Drawing.Point(66, 24)
        Me.ButtonQ.Name = "ButtonQ"
        Me.ButtonQ.Size = New System.Drawing.Size(20, 20)
        Me.ButtonQ.TabIndex = 16
        Me.ButtonQ.Tag = "Lettres"
        Me.ButtonQ.Text = "Q"
        Me.ButtonQ.UseVisualStyleBackColor = True
        '
        'ButtonP
        '
        Me.ButtonP.Location = New System.Drawing.Point(45, 24)
        Me.ButtonP.Name = "ButtonP"
        Me.ButtonP.Size = New System.Drawing.Size(20, 20)
        Me.ButtonP.TabIndex = 15
        Me.ButtonP.Tag = "Lettres"
        Me.ButtonP.Text = "P"
        Me.ButtonP.UseVisualStyleBackColor = True
        '
        'ButtonO
        '
        Me.ButtonO.Location = New System.Drawing.Point(24, 24)
        Me.ButtonO.Name = "ButtonO"
        Me.ButtonO.Size = New System.Drawing.Size(20, 20)
        Me.ButtonO.TabIndex = 14
        Me.ButtonO.Tag = "Lettres"
        Me.ButtonO.Text = "O"
        Me.ButtonO.UseVisualStyleBackColor = True
        '
        'ButtonN
        '
        Me.ButtonN.Location = New System.Drawing.Point(3, 24)
        Me.ButtonN.Name = "ButtonN"
        Me.ButtonN.Size = New System.Drawing.Size(20, 20)
        Me.ButtonN.TabIndex = 13
        Me.ButtonN.Tag = "Lettres"
        Me.ButtonN.Text = "N"
        Me.ButtonN.UseVisualStyleBackColor = True
        '
        'ButtonM
        '
        Me.ButtonM.Location = New System.Drawing.Point(254, 3)
        Me.ButtonM.Name = "ButtonM"
        Me.ButtonM.Size = New System.Drawing.Size(20, 20)
        Me.ButtonM.TabIndex = 12
        Me.ButtonM.Tag = "Lettres"
        Me.ButtonM.Text = "M"
        Me.ButtonM.UseVisualStyleBackColor = True
        '
        'ButtonL
        '
        Me.ButtonL.Location = New System.Drawing.Point(233, 3)
        Me.ButtonL.Name = "ButtonL"
        Me.ButtonL.Size = New System.Drawing.Size(20, 20)
        Me.ButtonL.TabIndex = 11
        Me.ButtonL.Tag = "Lettres"
        Me.ButtonL.Text = "L"
        Me.ButtonL.UseVisualStyleBackColor = True
        '
        'ButtonK
        '
        Me.ButtonK.Location = New System.Drawing.Point(212, 3)
        Me.ButtonK.Name = "ButtonK"
        Me.ButtonK.Size = New System.Drawing.Size(20, 20)
        Me.ButtonK.TabIndex = 10
        Me.ButtonK.Tag = "Lettres"
        Me.ButtonK.Text = "K"
        Me.ButtonK.UseVisualStyleBackColor = True
        '
        'ButtonJ
        '
        Me.ButtonJ.Location = New System.Drawing.Point(191, 3)
        Me.ButtonJ.Name = "ButtonJ"
        Me.ButtonJ.Size = New System.Drawing.Size(20, 20)
        Me.ButtonJ.TabIndex = 9
        Me.ButtonJ.Tag = "Lettres"
        Me.ButtonJ.Text = "J"
        Me.ButtonJ.UseVisualStyleBackColor = True
        '
        'ButtonI
        '
        Me.ButtonI.Location = New System.Drawing.Point(171, 3)
        Me.ButtonI.Name = "ButtonI"
        Me.ButtonI.Size = New System.Drawing.Size(20, 20)
        Me.ButtonI.TabIndex = 8
        Me.ButtonI.Tag = "Lettres"
        Me.ButtonI.Text = "I"
        Me.ButtonI.UseVisualStyleBackColor = True
        '
        'ButtonH
        '
        Me.ButtonH.Location = New System.Drawing.Point(150, 3)
        Me.ButtonH.Name = "ButtonH"
        Me.ButtonH.Size = New System.Drawing.Size(20, 20)
        Me.ButtonH.TabIndex = 7
        Me.ButtonH.Tag = "Lettres"
        Me.ButtonH.Text = "H"
        Me.ButtonH.UseVisualStyleBackColor = True
        '
        'ButtonG
        '
        Me.ButtonG.Location = New System.Drawing.Point(129, 3)
        Me.ButtonG.Name = "ButtonG"
        Me.ButtonG.Size = New System.Drawing.Size(20, 20)
        Me.ButtonG.TabIndex = 6
        Me.ButtonG.Tag = "Lettres"
        Me.ButtonG.Text = "G"
        Me.ButtonG.UseVisualStyleBackColor = True
        '
        'ButtonF
        '
        Me.ButtonF.Location = New System.Drawing.Point(108, 3)
        Me.ButtonF.Name = "ButtonF"
        Me.ButtonF.Size = New System.Drawing.Size(20, 20)
        Me.ButtonF.TabIndex = 5
        Me.ButtonF.Tag = "Lettres"
        Me.ButtonF.Text = "F"
        Me.ButtonF.UseVisualStyleBackColor = True
        '
        'ButtonE
        '
        Me.ButtonE.Location = New System.Drawing.Point(87, 3)
        Me.ButtonE.Name = "ButtonE"
        Me.ButtonE.Size = New System.Drawing.Size(20, 20)
        Me.ButtonE.TabIndex = 4
        Me.ButtonE.Tag = "Lettres"
        Me.ButtonE.Text = "E"
        Me.ButtonE.UseVisualStyleBackColor = True
        '
        'ButtonD
        '
        Me.ButtonD.Location = New System.Drawing.Point(66, 3)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(20, 20)
        Me.ButtonD.TabIndex = 3
        Me.ButtonD.Tag = "Lettres"
        Me.ButtonD.Text = "D"
        Me.ButtonD.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Location = New System.Drawing.Point(45, 3)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(20, 20)
        Me.ButtonC.TabIndex = 2
        Me.ButtonC.Tag = "Lettres"
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'ButtonB
        '
        Me.ButtonB.Location = New System.Drawing.Point(24, 3)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(20, 20)
        Me.ButtonB.TabIndex = 1
        Me.ButtonB.Tag = "Lettres"
        Me.ButtonB.Text = "B"
        Me.ButtonB.UseVisualStyleBackColor = True
        '
        'ButtonA
        '
        Me.ButtonA.Location = New System.Drawing.Point(3, 3)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(20, 20)
        Me.ButtonA.TabIndex = 0
        Me.ButtonA.Tag = "Lettres"
        Me.ButtonA.Text = "A"
        Me.ButtonA.UseVisualStyleBackColor = True
        '
        'BarPendu
        '
        Me.BarPendu.BackColor = System.Drawing.Color.LavenderBlush
        Me.BarPendu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BarPendu.ForeColor = System.Drawing.Color.DeepPink
        Me.BarPendu.Location = New System.Drawing.Point(12, 197)
        Me.BarPendu.Maximum = 10
        Me.BarPendu.Name = "BarPendu"
        Me.BarPendu.Size = New System.Drawing.Size(415, 15)
        Me.BarPendu.TabIndex = 18
        Me.BarPendu.Visible = False
        '
        'Emma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.Emma.My.Resources.Resources.Fond
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(440, 260)
        Me.Controls.Add(Me.BarPendu)
        Me.Controls.Add(Me.LettresGrid)
        Me.Controls.Add(Me.interv_comp)
        Me.Controls.Add(Me.CheckCompliment)
        Me.Controls.Add(Me.Destinataire)
        Me.Controls.Add(Me.TextRecu)
        Me.Controls.Add(Me.TextEnvoi)
        Me.Controls.Add(Me.CheckBoot)
        Me.Controls.Add(Me.Button_msg)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Button_quit)
        Me.Controls.Add(Me.Button_Accept)
        Me.Controls.Add(Me.MDLserverpic)
        Me.Controls.Add(Me.Titre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Emma"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emma"
        CType(Me.interv_comp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MDLserverpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LettresGrid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents Button_Accept As Button
    Friend WithEvents Titre As TextBox
    Friend WithEvents Button_quit As Button
    Friend WithEvents MyTimer As Timer
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
    Friend WithEvents LettresGrid As Panel
    Friend WithEvents ButtonA As Button
    Friend WithEvents ButtonB As Button
    Friend WithEvents ButtonZ As Button
    Friend WithEvents ButtonY As Button
    Friend WithEvents ButtonX As Button
    Friend WithEvents ButtonW As Button
    Friend WithEvents ButtonV As Button
    Friend WithEvents ButtonU As Button
    Friend WithEvents ButtonT As Button
    Friend WithEvents ButtonS As Button
    Friend WithEvents ButtonR As Button
    Friend WithEvents ButtonQ As Button
    Friend WithEvents ButtonP As Button
    Friend WithEvents ButtonO As Button
    Friend WithEvents ButtonN As Button
    Friend WithEvents ButtonM As Button
    Friend WithEvents ButtonL As Button
    Friend WithEvents ButtonK As Button
    Friend WithEvents ButtonJ As Button
    Friend WithEvents ButtonI As Button
    Friend WithEvents ButtonH As Button
    Friend WithEvents ButtonG As Button
    Friend WithEvents ButtonF As Button
    Friend WithEvents ButtonE As Button
    Friend WithEvents ButtonD As Button
    Friend WithEvents ButtonC As Button
    Friend WithEvents BarPendu As ProgressBar
End Class
