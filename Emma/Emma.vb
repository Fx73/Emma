'Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Drawing

Public Class Emma


    Dim user = Environment.UserName
    Dim pageMorpion As Morpion
    Dim pageEsearchB As EsearchB
    Dim flag As String = "+w" + user + "+"
    Dim wanttoplay As String = ""
    Dim mot As String
    Const ERREUR As String = "Essaie de relancer l'app et contacte FX ou Leon"
    Dim Mytooltip As New ToolTip
    Dim lettres(25) As Boolean ''= false by default

    Dim compliment As String()
    Dim shutup As Boolean = False

    Dim Flux As NetworkStream
    Public FluxWriter As StreamWriter
    Public FluxReader As StreamReader
    Public TCPClient As TcpClient = New TcpClient
    'Public TCPListener As TcpListener = New TcpListener(IPAddress.Any, 11000)
    Public ThreadReceive As System.Threading.Thread = New Threading.Thread(AddressOf Receive_message)
    Public ThreadFind As System.Threading.Thread = New Threading.Thread(AddressOf Find_server)
    Public ThreadConnect As System.Threading.Thread = New Threading.Thread(AddressOf Connect_server)
    Public ThreadDelonQuit As System.Threading.Thread = New Threading.Thread(AddressOf Delete_on_quit)
    Dim MdlIpAdress As IPAddress
    Dim EtatConnexion As Integer = 0
    '- 0 server introuvable
    '- 1 en recherche du server
    '- 2 trouvé mais TCP unlinked
    '- 3 trouvé TCP en cours
    '- 4 TCP linked mais Flux KO
    '- 5 Connecté mmais Reception KO
    '- 6 Connecté

    Delegate Sub SetTextDelegate(ByVal TB As TextBox, ByVal sText As String)
    Private SetText As New SetTextDelegate(AddressOf SetRecuTextBoxText)
    Private Sub SetRecuTextBoxText(ByVal TB As TextBox, ByVal sText As String)
        TB.Text = sText
    End Sub


    Private Sub Emma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                           Handles MyBase.Load

        'Visuel de l'app
        Me.Height -= 100
        NotifyIcon.Text = "Mot du jour"
        Titre.Text = "Bienvenue sur la super app de" + vbCrLf + "Fx & Leon"
        Titre.TextAlign = HorizontalAlignment.Center
        Titre.Font = New Font("Berlin Sans FB Demi", 14, FontStyle.Bold)
        Titre.CharacterCasing = CharacterCasing.Upper
        Button_Accept.Text = "J'aime bien votre appli, vous etes des gens biens :-)"
        Button_quit.Text = "Nan, C'est tout nul. Ciao"
        Button_msg.Text = "Envoyer un mot d'amour"
        CheckBoot.Text = "Lancer au demarrage"
        Mytooltip.ShowAlways = True
        Mytooltip.IsBalloon = True
        Mytooltip.UseFading = True

        If My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run\" + Application.ProductName, False) Is Nothing Then
            CheckBoot.Checked = True
        End If
        If My.Settings.SetCompliment Then
            CheckCompliment.Checked = True
        End If
        Destinataire.Text = "FX"
        CreateContextMenu()
        Randomize()

        'Lancement des compliments
        compliment = Split(My.Resources.Compliments, vbCrLf)
        MyTimer.Interval = 60000 * interv_comp.Text + 1
        MyTimer.Stop()

        'Lancement du client
        'TCPListener.Start() 'a ajouter pour pouvoir faire du peerTopeer
        flager.Start()

    End Sub



    Public Sub CreateContextMenu()
        'Define New Context Menu and Menu Item 
        Dim contextMenu As New ContextMenu
        Dim MenuEclair As New MenuItem("Eclair")
        Dim MenuPendu As New MenuItem("Pendu")
        Dim MenuMorpion As New MenuItem("Morpion")
        Dim MenuEsearchB As New MenuItem("Emma cherche Blandine")
        Dim MenuExit As New MenuItem("Exit")
        contextMenu.MenuItems.Add(MenuEclair)
        contextMenu.MenuItems.Add(MenuPendu)
        contextMenu.MenuItems.Add(MenuMorpion)
        contextMenu.MenuItems.Add(MenuEsearchB)
        contextMenu.MenuItems.Add(MenuExit)


        NotifyIcon.ContextMenu = contextMenu

        'Add functionality for menu Item click 
        AddHandler MenuEclair.Click, AddressOf MenuEclair_Click
        AddHandler MenuPendu.Click, AddressOf MenuPendu_Click
        AddHandler MenuMorpion.Click, AddressOf MenuMorpion_Click
        AddHandler MenuEsearchB.Click, AddressOf MenuEsearchB_Click
        AddHandler MenuExit.Click, AddressOf Button_quit_Click

    End Sub


    Private Sub MenuEclair_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            My.Computer.FileSystem.WriteAllBytes(Path.GetTempPath & "\EmmaEclairTemp.exe", My.Resources.emmaeclair, False)
        Catch
        End Try
        Shell(Path.GetTempPath & "\EmmaEclairTemp.exe")

        ThreadDelonQuit = New Threading.Thread(AddressOf Delete_on_quit)
        ThreadDelonQuit.Start(Path.GetTempPath & "\EmmaEclairTemp.exe")

    End Sub


    Private Sub MenuPendu_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Titre.Text = "Pendu lancé"
        LettresGrid.Visible = True
        BarPendu.Visible = True
        'BarPendu.BackColor = Color.FromArgb(128, 255, 0, 1)
        mot = Split(My.Resources.MotsPendu, vbCrLf)(Rnd() * 600)
        TextRecu.Text = "_"
        For i = 1 To mot.Length - 1
            TextRecu.Text += "_"
        Next
    End Sub


    Private Sub UneLettre_Click(sender As Object, e As EventArgs) Handles ButtonA.Click, ButtonB.Click, ButtonZ.Click, ButtonY.Click, ButtonX.Click, ButtonW.Click, ButtonV.Click, ButtonU.Click, ButtonT.Click, ButtonS.Click, ButtonR.Click, ButtonQ.Click, ButtonP.Click, ButtonO.Click, ButtonN.Click, ButtonM.Click, ButtonL.Click, ButtonK.Click, ButtonJ.Click, ButtonI.Click, ButtonH.Click, ButtonG.Click, ButtonF.Click, ButtonE.Click, ButtonD.Click, ButtonC.Click
        lettres(Convert.ToInt32(sender.ToString.Last) - 65) = True
        sender.Enabled = False
        sender.text = sender.text.tolower()

        Dim plusun = True
        For i = 0 To mot.Length - 1
            If mot(i) = sender.text Or ((mot(i) = "é" Or mot(i) = "è" Or mot(i) = "ê") And sender.text = "e") Or (mot(i) = "ô" And sender.text = "o") Or (mot(i) = "î" And sender.text = "i") Then
                plusun = False
                Exit For
            End If
        Next
        If plusun Then
            BarPendu.Value += 1
        End If

        TextRecu.Text = ""
        Dim win = True
        For i = 0 To mot.Length - 1
            If ((mot(i) = "é" Or mot(i) = "è" Or mot(i) = "ê") And lettres(4)) Or (mot(i) = "ô" And lettres(14)) Or (mot(i) = "î" And lettres(8)) Then
                TextRecu.Text += mot(i)
            ElseIf mot(i) = "é" Or mot(i) = "è" Or mot(i) = "ê" Or mot(i) = "ô" Or mot(i) = "î" Then
                TextRecu.Text += "_"
            ElseIf lettres(Convert.ToInt32(mot(i)) - 97) Then
                TextRecu.Text += mot(i)
            Else
                TextRecu.Text += "_"
                win = False
            End If
        Next

        If win Then
            LettresGrid.Visible = False
            BarPendu.Visible = False
            TextRecu.Text += vbCrLf + "BRAVO !!"
            For i = 0 To 25
                lettres.SetValue(False, i)
                CType(Me.Controls.Find(String.Format("Button{0}", Convert.ToChar(i + 65)), True)(0), Button).Enabled = True
            Next
        End If

        If BarPendu.Value = 10 Then
            LettresGrid.Visible = False
            TextRecu.Text = mot + vbCrLf + "PERDU !!"
            For i = 0 To 25
                lettres.SetValue(False, i)
                CType(Me.Controls.Find(String.Format("Button{0}", Convert.ToChar(i + 65)), True)(0), Button).Enabled = True
            Next
        End If
    End Sub

    Private Sub MenuMorpion_Click()
        Titre.Text = "Morpion lancé"
        pageMorpion = New Morpion
        pageMorpion.Show(Me)
        If (wanttoplay <> "") Then
            pageMorpion.Morpion_Load_Rep(wanttoplay)
        End If
    End Sub

    Private Sub MenuEsearchB_Click()
        pageEsearchB = New EsearchB
        Titre.Text = "Emma cherche Blandine lancé"
        pageEsearchB.Show(Me)
    End Sub



    ''Private Sub Button_Compliment_Click(sender As Object, e As EventArgs)
    ''    My.Computer.FileSystem.WriteAllText(Path.GetTempPath + "\ComplimentsTemp.txt", My.Resources.Compliments, False)
    ''    Process.Start(Application.StartupPath() + "\ComplimentsTemp.txt")
    ''    My.Computer.FileSystem.ReadAllText(Path.GetTempPath + "\ComplimentsTemp.txt")
    ''End Sub


    Private Sub Delete_on_quit(filepath As String)
        Dim opened = True
        While (opened)
            Try
                My.Computer.FileSystem.DeleteFile(filepath)
                opened = False
            Catch ex As Exception
                If (ex.HResult = -2147024894) Then 'Erreur fichier deja supprimé
                    opened = False
                End If
            End Try
        End While
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub Escape(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Hide()
        Me.Hide()
    End Sub

    Private Sub Button_Accept_Click(sender As Object, e As EventArgs) Handles Button_Accept.Click
        Me.Hide()
        If My.Settings.SetCompliment Then
            MyTimer.Start()
        End If


    End Sub

    Private Sub Button_quit_Click(sender As Object, e As EventArgs) Handles Button_quit.Click
        Me.Hide()
        shutup = True
        If Not Flux Is Nothing Then
            Flux.Close()
        End If
        If Not TCPClient Is Nothing Then
            TCPClient.Close()
        End If
        If Not ThreadReceive Is Nothing Then
            If ThreadReceive.IsAlive Then
                ThreadReceive.Abort()
            End If
        End If
        NotifyIcon.BalloonTipText = "A plus"
        NotifyIcon.ShowBalloonTip(2000)
        Threading.Thread.Sleep(2000)
        Me.Close()
    End Sub


    Private Sub MyTimer_Tick(sender As Object, e As EventArgs) Handles MyTimer.Tick
        Dim alea = Int(Rnd() * compliment.Length)
        NotifyIcon.BalloonTipText = Interprete_perso(compliment(alea))
        NotifyIcon.ShowBalloonTip(5000)

    End Sub


    Private Sub CheckCompliment_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCompliment.CheckedChanged
        If CheckCompliment.Checked = True Then
            MyTimer.Start()
            My.Settings.SetCompliment = True
            My.Settings.Save()
        Else
            MyTimer.Stop()
            My.Settings.SetCompliment = False
            My.Settings.Save()
        End If
    End Sub


    Private Sub Interv_comp_ValueChanged(sender As Object, e As EventArgs) Handles interv_comp.ValueChanged
        If interv_comp.Text = 0 Then
            MyTimer.Interval = 1000
        Else
            MyTimer.Interval = 60000 * interv_comp.Text
        End If
    End Sub

    Private Sub Options_CheckedChanged(sender As Object, e As EventArgs) Handles Options.CheckedChanged
        If Options.Checked = True Then
            Me.Height += 100
        Else
            Me.Height -= 100
        End If
    End Sub

    Private Sub CheckBoot_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoot.CheckedChanged
        If CheckBoot.Checked = True Then
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
        Else
            My.Computer.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(Application.ProductName)
        End If
    End Sub

    Private Sub TextEnvoi_enter(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextEnvoi.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim f As EventArgs = New EventArgs()
            Button_msg_Click(sender, f)
        End If
    End Sub


    Private Sub Button_msg_Click(sender As Object, e As EventArgs) Handles Button_msg.Click
        'If Destinataire.Text(0) = "1" Then
        'EtatConnexion = 2
        'Solution()
        'End If

        'envoi du message
        If (EtatConnexion = 5 Or EtatConnexion = 6) Then
            Try
                FluxWriter.WriteLine("+d+" + Destinataire.Text + "+d+" + "Message de " + user + " : +n+" + TextEnvoi.Text + vbCrLf)
                FluxWriter.Flush()
                TextEnvoi.Text = ""
                Titre.Text = "Message bien envoyé à " + Destinataire.Text
            Catch ex As Exception
                Titre.Text = "Envoi du Message : " + ex.Message
                Exit Sub
            End Try
        Else
            Titre.Text = "Attends que ca se connecte !"
        End If
    End Sub


    Public Sub Receive_message()
        Dim MsgRecu As String
        While (TCPClient.Connected And Not shutup)
            'Reception des données
            Try
                MsgRecu = FluxReader.ReadLine()
            Catch ex As Exception
                If Not shutup Then
                    TextRecu.Invoke(SetText, New Object() {TextRecu, "Erreur reception message : " + ex.Message})
                End If
            End Try

            'Exriture du message
            If MsgRecu IsNot Nothing Then
                Interprete_perso(MsgRecu)
                If (MsgRecu <> "" And MsgRecu <> vbCrLf And Not MsgRecu.EndsWith(vbCrLf)) Then
                    NotifyIcon.BalloonTipText = MsgRecu
                    NotifyIcon.ShowBalloonTip(5000)
                End If
                TextRecu.Invoke(SetText, New Object() {TextRecu, MsgRecu})
            End If
        End While
    End Sub


    Private Sub Flager_Tick() Handles flager.Tick
        'Mise a jour de l'etat de la connection
        Solution()
        MAJvisuel()

        'envoi du flag
        If EtatConnexion = 5 Or EtatConnexion = 6 Then
            Try
                FluxWriter.WriteLine(flag)
                FluxWriter.Flush()
                'Titre.Text = "Bienvenue sur la super app de" + vbCrLf + "Fx & Leon"
            Catch ex As Exception
                Titre.Text = "Envoi du flag : " + ex.Message
            End Try
        End If

        If (wanttoplay <> "") Then
            MenuMorpion_Click()
            wanttoplay = ""
        End If

        'Correction des erreurs
        Probleme()
    End Sub

    Private Sub Solution()
        'connexion
        If EtatConnexion = 0 Then
            Try
                If Destinataire.Text(0) = "1" Then
                    EtatConnexion = 2
                    Exit Try
                End If
                ThreadFind.Abort()
                ThreadFind = New Threading.Thread(AddressOf Find_server)
                ThreadFind.Start()
                EtatConnexion = 1
            Catch ex As Exception
                Exit Sub
            End Try
        End If

        'attente du thread de recherche
        If EtatConnexion = 1 Then
            If MdlIpAdress IsNot Nothing Then
                EtatConnexion = 2
            ElseIf Not ThreadFind.IsAlive Then
                EtatConnexion = 0
            End If
        End If
        'Lancement du thread de connexion
        If EtatConnexion = 2 Then
            Try
                ThreadConnect.Abort()
                ThreadConnect = New Threading.Thread(AddressOf Connect_server)
                ThreadConnect.Start(Destinataire.Text)
                EtatConnexion = 3
            Catch ex As Exception
                Titre.Text = "Connection TCP : " + ex.Message
                Exit Sub
            End Try
        End If

        'Attente du thread de connexion
        If EtatConnexion = 3 And Not ThreadConnect.IsAlive Then
            If TCPClient.Connected Then
                EtatConnexion = 4
            Else
                EtatConnexion = 2
                Exit Sub
            End If
        End If

        'lancement du stream de données
        If EtatConnexion = 4 Then
            Try
                Flux = TCPClient.GetStream()
                FluxWriter = New StreamWriter(Flux)
                EtatConnexion = 5
            Catch ex As Exception
                Titre.Text = "Creation du flux : " + ex.Message + ERREUR
                Exit Sub
            End Try
        End If
        'lancement du thread de reception
        If EtatConnexion = 5 Then
            Try
                FluxReader = New StreamReader(Flux)
                ThreadReceive = New Threading.Thread(AddressOf Receive_message)
                ThreadReceive.Start()
                EtatConnexion = 6
            Catch ex As Exception
                Titre.Text = "Erreur du Thread de Reception: " & vbCrLf & ex.Message & ERREUR
            End Try
        End If
    End Sub

    Private Sub Probleme()
        If EtatConnexion >= 6 Then
            If Not ThreadReceive.IsAlive Then
                ThreadReceive.Abort()
                EtatConnexion = 5
            End If
        End If

        If EtatConnexion >= 3 Then
            If Not TCPClient.Connected And Not ThreadConnect.IsAlive Then
                EtatConnexion = 2
            End If
        End If

        If EtatConnexion >= 2 And Destinataire.Text(0) <> "1" Then
            Try
                Dns.GetHostEntry("mdlserver.ddns.net")
            Catch ex As Exception
                EtatConnexion = 0
                MdlIpAdress = Nothing
            End Try
        End If
    End Sub

    Function Find_server()
        Try
            MdlIpAdress = IPAddress.Parse(Dns.GetHostEntry("mdlserver.ddns.net").AddressList(0).ToString())
        Catch
        End Try
    End Function

    Function Connect_server(Dest As String) As Boolean
        If Dest(0) = "1" Then
            Try
                TCPClient = New TcpClient(Dest, "11000")
            Catch ex As Exception
                Titre.Invoke(SetText, New Object() {Titre, "Erreur de connection au client. Il vaut mieux passer par la MDL." + ERREUR})
                Thread.Sleep(5000)
                Return False
            End Try
        Else
            Try
                TCPClient = New TcpClient(MdlIpAdress.ToString, "11000")

            Catch ex As Exception
                If Not shutup Then
                    Titre.Invoke(SetText, New Object() {Titre, " Erreur de connexion au serveur MDL.   Le serveur a peut-etre un probleme. " + ERREUR})
                    Thread.Sleep(5000)
                End If
                Return False
            End Try
        End If
        Return True
    End Function


    Private Function MAJvisuel()
        Select Case EtatConnexion
            Case 0, 1
                MDLserverpic.Image = MDLserverpic.BackgroundImage
                Mytooltip.SetToolTip(MDLserverpic, "MDLserveur introuvable")
            Case 2
                MDLserverpic.Image = MDLserverpic.ErrorImage
                Mytooltip.SetToolTip(MDLserverpic, "MDLserveur trouvé, en attente de connection")
            Case 3
                MDLserverpic.Image = MDLserverpic.ErrorImage
                Mytooltip.SetToolTip(MDLserverpic, "Connection")
            Case 4
                MDLserverpic.Image = MDLserverpic.ErrorImage
                Mytooltip.SetToolTip(MDLserverpic, "MDl server, lien établi")
            Case 5
                MDLserverpic.Image = MDLserverpic.InitialImage
                Mytooltip.SetToolTip(MDLserverpic, "Connecté")
            Case 6
                MDLserverpic.Image = MDLserverpic.InitialImage
                Mytooltip.SetToolTip(MDLserverpic, "Connecté, à l'écoute")
        End Select
    End Function


    Public Function Interprete_perso(ByRef S As String)
        If S = "" Or S = vbCrLf Then
            Exit Function
        End If

        Dim j = 0

        While (j < S.Length - 2)
            If (S.Chars(j) = "+" AndAlso (S.Chars(j + 1) = "w") OrElse S.Chars(j + 2) = "+") Then
                Select Case (S.Chars(j + 1))
                    Case "u"
                        Dim temp_string = Split(S, "+u+")
                        S = temp_string(0)
                        For k = 1 To temp_string.Length - 1
                            S = S + user + temp_string(k)
                        Next
                    Case "d"
                        Dim temp_string = Split(S, "+d+")
                        S = temp_string(0)
                        For k = 2 To temp_string.Length - 1 Step 2
                            S = S + temp_string(k)
                        Next
                    Case "w"
                        Dim k As Integer
                        For k = 2 To S.Length - j - 1
                            If S.Chars(j + k) = "+" Then
                                k += 1
                                Exit For
                            End If
                        Next
                        Titre.Invoke(SetText, New Object() {Titre, S.Substring(j + 2, k - 3) + " s'est connecté"})
                        S = S.Substring(0, j) + S.Substring(j + k)
                        j -= 1
                    Case "m"
                        If Application.OpenForms().OfType(Of Morpion).Count = 0 Then
                            FluxWriter.WriteLine("+d+" + S.Substring(3) + "+d++m++a+" + user + "+a+" + "quit" + vbCrLf)
                        End If
                        For Each f As Morpion In Application.OpenForms().OfType(Of Morpion)
                            f.ReceiveMorpion(S.Substring(3))
                        Next
                        S = ""
                    Case "l"
                        Dim rep = MsgBox(S.Substring(3) + " voudrais jouer au morpion", vbYesNo + vbInformation)
                        If rep = vbYes Then
                            wanttoplay = S.Substring(3)
                        End If
                        If rep = vbNo Then
                            FluxWriter.WriteLine("+d+" + S.Substring(3) + "+d++m++a+" + user + "+a+" + "refus" + vbCrLf)
                            FluxWriter.Flush()
                        End If
                        S = ""
                    Case "n"
                        S = S.Substring(0, j) + vbCrLf + S.Substring(j + 3)
                End Select
            End If
            j += 1
        End While
        Return 0
    End Function

End Class