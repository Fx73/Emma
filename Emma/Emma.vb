'Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.IO
Imports System.Drawing

Public Class Emma


    Dim user = Environment.UserName
    Dim flag As String = "+w" + user
    Const ERREUR As String = "Essaie de relancer l'app et contacte FX ou Leon"
    Dim Mytooltip As New ToolTip

    Dim compliment(1)
    Dim nb_compliment As Integer
    Dim shutup As Boolean = False

    Dim Flux As NetworkStream
    Dim FluxWriter As StreamWriter
    Dim FluxReader As StreamReader
    Public TCPClient As TcpClient = New TcpClient
    'Public TCPListener As TcpListener = New TcpListener(IPAddress.Any, 11000)
    Public ThreadReceive As System.Threading.Thread = New Threading.Thread(AddressOf Receive_message)
    Public ThreadConnect As System.Threading.Thread = New Threading.Thread(AddressOf Connect_server)
    Dim MdlIpAdress As IPAddress
    Dim EtatConnexion As Integer = 0
    '- 0 server introuvable
    '- 1 trouvé mais TCP unlinked
    '- 2 trouvé TCP en cours
    '- 3 TCP linked mais Flux KO
    '- 4 Connecté mmais Reception KO
    '- 5 Connecté

    Delegate Sub SetTextDelegate(ByVal TB As TextBox, ByVal sText As String)
    Private SetText As New SetTextDelegate(AddressOf SetRecuTextBoxText)
    Private Sub SetRecuTextBoxText(ByVal TB As TextBox, ByVal sText As String)
        TB.Text = sText
    End Sub


    Private Sub Emma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                           Handles MyBase.Load
        'Description de l'app
        Me.Height -= 100
        NotifyIcon.Text = "Mot du jour"
        Titre.Text = "Bienvenue sur la super app de" + vbCrLf + "Fx & Leon"
        Titre.TextAlign = HorizontalAlignment.Center
        Titre.Font = New Font("Berlin Sans FB Demi", 14, FontStyle.Bold)
        Titre.CharacterCasing = CharacterCasing.Upper
        Button_Accept.Text = "J'aime bien votre appli, vous etes des gens biens :-)"
        Button_quit.Text = "Nan, C'est tout nul. Ciao"
        Button_Compliment.Text = "C"
        Options.Text = "Opt"
        Button_msg.Text = "Envoyer un mot d'amour"
        CheckBoot.Text = "Lancer au demarrage de l'ordinateur"
        CheckCompliment.Text = "Compliments (toutes les x min)"
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

        'Creation du fichier de proverbes s'il n'existe pas
        If System.IO.File.Exists(Application.StartupPath() + "\Compliments.txt") = False Then
            Dim Swriter As FileStream = File.Create(Application.StartupPath() + "\Compliments.txt")
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("Il faut rajouter des compliments ou recuperer le fichier de compliments aupres de FX")
            Swriter.Write(info, 0, info.Length)
            Swriter.Close()
        End If


        'Lecture et stockage des proverbes
        Dim SReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath() + "\Compliments.txt")
        While Not SReader.EndOfStream
            SReader.ReadLine()
            nb_compliment += 1
        End While
        ReDim compliment(nb_compliment)

        Dim i = 0
        SReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath() + "\Compliments.txt")
        While Not SReader.EndOfStream
            compliment(i) = SReader.ReadLine()
            Interprete_perso(compliment(i))
            i += 1
        End While
        SReader.Close()

        'Lancement des compliments
        MyTimer.Interval = 60000 * interv_comp.Text + 1
        MyTimer.Stop()

        'Lancement du client
        'TCPListener.Start()
        flager.Start()

    End Sub



    Public Sub CreateContextMenu()
        'Define New Context Menu and Menu Item 
        Dim contextMenu As New ContextMenu
        Dim MenuEclair As New MenuItem("Eclair")
        Dim MenuExit As New MenuItem("Exit")
        contextMenu.MenuItems.Add(MenuEclair)
        contextMenu.MenuItems.Add(MenuExit)



        NotifyIcon.ContextMenu = contextMenu

        'Add functionality for menu Item click 
        AddHandler MenuEclair.Click, AddressOf MenuEclair_Click
        AddHandler MenuExit.Click, AddressOf MenuExit_Click

    End Sub

    Private Sub MenuEclair_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        shutup = True
        NotifyIcon.BalloonTipText = "Au revoir"
        NotifyIcon.ShowBalloonTip(2000)
        Threading.Thread.Sleep(2000)
        Me.Close()
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
        Dim alea = Int(Rnd() * nb_compliment)
        NotifyIcon.BalloonTipText = compliment(alea)
        NotifyIcon.ShowBalloonTip(5000)

    End Sub

    Private Sub Button_Compliment_Click(sender As Object, e As EventArgs) Handles Button_Compliment.Click
        Process.Start(Application.StartupPath() + "\Compliments.txt")
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

    Private Sub Textbox2_enter(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextEnvoi.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim f As EventArgs = New EventArgs()
            Button_msg_Click(sender, f)
        End If
    End Sub


    Private Sub Button_msg_Click(sender As Object, e As EventArgs) Handles Button_msg.Click
        'envoi du message
        If (EtatConnexion = 4 Or EtatConnexion = 5) Then
            Try
                FluxWriter.WriteLine("+d+" + Destinataire.Text + "+d+" + "Message de " + user + " :" + vbCrLf + TextEnvoi.Text + vbCrLf)
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
                MsgRecu = FluxReader.ReadLine() + vbCrLf + FluxReader.ReadLine()
            Catch ex As Exception
                If Not shutup Then
                    TextRecu.Invoke(SetText, New Object() {TextRecu, "Erreur reception message : " + ex.Message})
                End If
            End Try

            'Exriture du message
            If MsgRecu IsNot Nothing Then
                Interprete_perso(MsgRecu)
                If (MsgRecu IsNot "" Or MsgRecu IsNot vbCrLf) Then
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
        If EtatConnexion = 4 Or EtatConnexion = 5 Then
            Try
                FluxWriter.WriteLine(flag)
                FluxWriter.Flush()
                Titre.Text = "Bienvenue sur la super app de" + vbCrLf + "Fx & Leon"
            Catch ex As Exception
                Titre.Text = "Envoi du flag : " + ex.Message
            End Try
        End If

        Probleme()
    End Sub

    Private Sub Solution()
        'connexion
        If EtatConnexion = 0 Then
            Try
                MdlIpAdress = IPAddress.Parse(Dns.GetHostEntry("mdlserver.ddns.net").AddressList(0).ToString())
                EtatConnexion = 1
            Catch ex As Exception
                Exit Sub
            End Try
        End If

        'Lancement du thread de connexion
        If EtatConnexion = 1 Then
            Try
                ThreadConnect.Abort()
                ThreadConnect = New Threading.Thread(AddressOf Connect_server)
                    ThreadConnect.Start(Destinataire.Text)
                    EtatConnexion = 2
                Catch ex As Exception
                Titre.Text = "Connection TCP : " + ex.Message
                Exit Sub
            End Try
        End If

        'Attente du thread de connexion
        If EtatConnexion = 2 And Not ThreadConnect.IsAlive Then
            If TCPClient.Connected Then
                EtatConnexion = 3
            Else
                EtatConnexion = 1
                Exit Sub
            End If
        End If

        'lancement du stream
        If EtatConnexion = 3 Then
            Try
                Flux = TCPClient.GetStream()
                FluxWriter = New StreamWriter(Flux)
                EtatConnexion = 4
            Catch ex As Exception
                Titre.Text = "Creation du flux : " + ex.Message + ERREUR
                Exit Sub
            End Try
        End If
        'lancement du thread de reception
        If EtatConnexion = 4 Then
            Try
                FluxReader = New StreamReader(Flux)
                ThreadReceive = New Threading.Thread(AddressOf Receive_message)
                ThreadReceive.Start()
                EtatConnexion = 5
            Catch ex As Exception
                Titre.Text = "Erreur du Thread de Reception: " & vbCrLf & ex.Message & ERREUR
            End Try
        End If
    End Sub

    Private Sub Probleme()
        If EtatConnexion >= 5 Then
            If Not ThreadReceive.IsAlive Then
                ThreadReceive.Abort()
                EtatConnexion = 4
            End If
        End If

        If EtatConnexion >= 2 Then
            If Not TCPClient.Connected And Not ThreadConnect.IsAlive Then
                EtatConnexion = 1
            End If
        End If

        If EtatConnexion >= 1 Then
            Try
                Dns.GetHostEntry("mdlserver.ddns.net")
            Catch ex As Exception
                EtatConnexion = 0
            End Try
        End If
    End Sub

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
            Case 0
                MDLserverpic.Image = MDLserverpic.BackgroundImage
                Mytooltip.SetToolTip(MDLserverpic, "MDLserveur introuvable")
            Case 1
                MDLserverpic.Image = MDLserverpic.ErrorImage
                Mytooltip.SetToolTip(MDLserverpic, "MDLserveur trouvé, en attente de connection")
            Case 2
                MDLserverpic.Image = MDLserverpic.ErrorImage
                Mytooltip.SetToolTip(MDLserverpic, "Connection")
            Case 3
                MDLserverpic.Image = MDLserverpic.ErrorImage
                Mytooltip.SetToolTip(MDLserverpic, "MDl server, lien établi")
            Case 4
                MDLserverpic.Image = MDLserverpic.InitialImage
                Mytooltip.SetToolTip(MDLserverpic, "Connecté")
            Case 5
                MDLserverpic.Image = MDLserverpic.InitialImage
                Mytooltip.SetToolTip(MDLserverpic, "Connecté, à l'écoute")
        End Select
    End Function


    Private Function Interprete_perso(ByRef S As String)
        If S = "" Or S = vbCrLf Then
            Exit Function
        End If

        Dim j = 0

            While (j < S.Length - 1)
            If (S.Chars(j) = "+") Then
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
                        S = S.Substring(2) + " s'est connecté"
                End Select
            End If
            j += 1
        End While
        Return 0
    End Function


End Class