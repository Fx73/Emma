Public Class Morpion
    Public Adversaire As String
    Dim grid As MorpionGrid
    Dim xturn As Boolean = True

    Delegate Sub SetTextDelegate(ByVal L As Label, ByVal sText As String)
    Private SetText As New SetTextDelegate(AddressOf SetRecuTextBoxText)
    Private Sub SetRecuTextBoxText(ByVal L As Label, ByVal sText As String)
        L.Text = sText
        L.Enabled = True
    End Sub
    Delegate Sub EnableButtonDelegate(ByVal B As Button)
    Private EnableButton As New EnableButtonDelegate(AddressOf EnableB)
    Private Sub EnableB(ByVal B As Button)
        B.Enabled = True
        B.Text = ""
    End Sub
    Delegate Sub DisableButtonDelegate(ByVal B As String, ByVal text As String)
    Private DisableButton As New DisableButtonDelegate(AddressOf DisableB)
    Private Sub DisableB(ByVal B As String, ByVal text As String)
        Dim abutton = CType(Me.Controls.Find(String.Format(B), True)(0), Button)
        abutton.Enabled = False
        abutton.Text = text
    End Sub

    Private Sub Morpion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend Sub Morpion_Load_Rep(S As String)
        Adversaire = S
        LabelAdversaire.Text = S
        BoxEntree.Visible = False
        grid = New MorpionGrid
        EnableMorpion()

        xturn = False
        LabelAttente.Text = "En attente de " + Adversaire
        Emma.FluxWriter.WriteLine("+d+" + Adversaire + "+d+" + "+m+" + "+a+" + Environment.UserName + "+a+" + "launch" + vbCrLf)
    End Sub

    Private Sub ButtonOk_Click() Handles ButtonOk.Click
        If Adversaire Is Nothing Then
            Adversaire = AdversaireBox.Text
            LabelAdversaire.Text = Adversaire
        End If
        If Adversaire <> "Moi" Then
            Try
                Emma.FluxWriter.WriteLine("+d+" + Adversaire + "+d+" + "+l+" + Environment.UserName + vbCrLf)
                Emma.FluxWriter.Flush()
                LabelAttente.Text = "En attente de " + Adversaire
                DisableMorpion()
            Catch ex As Exception
                MsgBox("Impossible de se connecter, essai une partie en local", vbCritical)
                Exit Sub
            End Try
        Else
            LabelAttente.Visible = True
            EnableMorpion()
        End If
        BoxEntree.Visible = False
        grid = New MorpionGrid

    End Sub

    Public Sub SendMorpion(sender As Object, e As EventArgs) Handles C3.Click, C2.Click, C1.Click, B3.Click, B2.Click, B1.Click, A3.Click, A2.Click, A1.Click
        If Adversaire = "Moi" Then
            If xturn Then
                CType(Me.Controls.Find(String.Format(sender.name), True)(0), Button).Text = "X"
                grid.getcase(sender.name).croix = True
                xturn = False
                LabelAttente.Text = "Tour de O"
            Else
                CType(Me.Controls.Find(String.Format(sender.name), True)(0), Button).Text = "O"
                grid.getcase(sender.name).rond = True
                xturn = True
                LabelAttente.Text = "Tour de X"
            End If
            CType(Me.Controls.Find(String.Format(sender.name), True)(0), Button).Enabled = False

        Else
            If xturn Then
                Emma.FluxWriter.WriteLine("+d+" + Adversaire + "+d+" + "+m+" + "+a+" + Environment.UserName + "+a+" + sender.name + vbCrLf)
                Emma.FluxWriter.Flush()
                CType(Me.Controls.Find(String.Format(sender.name), True)(0), Button).Text = "X"
                grid.getcase(sender.name).croix = True
                xturn = False
                LabelAttente.Visible = True
            End If
        End If
        FinMorpion()
    End Sub


    Public Sub ReceiveMorpion(S As String)
        Dim Stemp() As String = S.Split({"+a+"}, StringSplitOptions.None)

        If Not Stemp(1) = Adversaire Then
            Exit Sub
        End If

        S = Stemp(2)
        If (S = "launch") Then
            EnableMorpionbyInvoke()
            LabelAdversaire.Invoke(SetText, New Object() {LabelAdversaire, Adversaire + " a rejoint la partie"})
            LabelAttente.Invoke(SetText, New Object() {LabelAdversaire, "Tour de " + Adversaire})
        ElseIf (S = "refus") Then
            MsgBox(Adversaire + " a refusé la partie", vbCritical)
        ElseIf (S = "quit") Then
            MsgBox(Adversaire + " a quitté la partie, tu es vainqueur par abandon", vbExclamation)
            Me.Close()
        Else
            grid.getcase(S).rond = True
            xturn = True
            LabelAttente.Invoke(SetText, New Object() {LabelAdversaire, "Tour de " + Adversaire})
            CType(Me.Controls.Find(String.Format(S), True)(0), Button).Invoke(DisableButton, {S, "O"})
            FinMorpion()
        End If
    End Sub


    Sub FinMorpion()
        Dim fin As Int16 = 0

        If (grid.Eg(grid.A1, grid.A2) And grid.Eg(grid.A1, grid.A3)) Or (grid.Eg(grid.A1, grid.B1) And grid.Eg(grid.A1, grid.C1)) Then
            fin = grid.A1.croix + grid.A1.rond * 2
        End If
        If (grid.Eg(grid.B1, grid.B2) And grid.Eg(grid.B1, grid.B3)) Or (grid.Eg(grid.A2, grid.B2) And grid.Eg(grid.A2, grid.C2)) Or (grid.Eg(grid.A1, grid.B2) And grid.Eg(grid.A1, grid.C3)) Or (grid.Eg(grid.A3, grid.B2) And grid.Eg(grid.A3, grid.C1)) Then
            fin = grid.B2.croix + grid.B2.rond * 2
        End If
        If (grid.Eg(grid.C1, grid.C2) And grid.Eg(grid.C1, grid.C3)) Or (grid.Eg(grid.A3, grid.B3) And grid.Eg(grid.A3, grid.C3)) Then
            fin = grid.C3.croix + grid.C3.rond * 2
        End If

        If fin = -1 Then
            Try
                LabelAdversaire.Text = Environment.UserName + " gagne la partie"
            Catch
                LabelAdversaire.Invoke(SetText, New Object() {LabelAdversaire, Environment.UserName + " gagne la partie"})
            End Try
            MsgBox("Bravo, Gagné !", vbExclamation)
            DisableMorpion()
            Replay()
        End If
        If fin = -2 Then
            Try
                LabelAdversaire.Text = Adversaire + " : gagne la partie"
            Catch
                LabelAdversaire.Invoke(SetText, New Object() {LabelAdversaire, Adversaire + " gagne la partie"})
            End Try
            MsgBox("Haha, Perdu !", vbCritical)
            DisableMorpion()
            Replay()
        End If
        If fin = 0 And grid.Iscomplete() Then
            Try
                LabelAdversaire.Text += "Egalité"
            Catch
                LabelAdversaire.Invoke(SetText, New Object() {LabelAdversaire, "Egalité"})
            End Try
            MsgBox("Egalité ! --'", vbInformation)
            DisableMorpion()
            Replay()
        End If

    End Sub

    Sub DisableMorpion()
        Try
            A1.Enabled = False
            A2.Enabled = False
            A3.Enabled = False
            B1.Enabled = False
            B2.Enabled = False
            B3.Enabled = False
            C1.Enabled = False
            C2.Enabled = False
            C3.Enabled = False
        Catch
            DisableMorpionbyInvoke()
        End Try
    End Sub

    Sub DisableMorpionbyInvoke()
        A1.Invoke(DisableButton, {"A1", ""})
        A2.Invoke(DisableButton, {"A2", ""})
        A3.Invoke(DisableButton, {"A3", ""})
        B1.Invoke(DisableButton, {"B1", ""})
        B2.Invoke(DisableButton, {"B2", ""})
        B3.Invoke(DisableButton, {"B3", ""})
        C1.Invoke(DisableButton, {"C1", ""})
        C2.Invoke(DisableButton, {"C2", ""})
        C3.Invoke(DisableButton, {"C3", ""})
    End Sub

    Sub EnableMorpion()
        Try
            A1.Enabled = True
            A2.Enabled = True
            A3.Enabled = True
            B1.Enabled = True
            B2.Enabled = True
            B3.Enabled = True
            C1.Enabled = True
            C2.Enabled = True
            C3.Enabled = True
            A1.Text = ""
            A2.Text = ""
            A3.Text = ""
            B1.Text = ""
            B2.Text = ""
            B3.Text = ""
            C1.Text = ""
            C2.Text = ""
            C3.Text = ""
        Catch
            EnableMorpionbyInvoke()
        End Try
    End Sub

    Sub EnableMorpionbyInvoke()
        A1.Invoke(EnableButton, A1)
        A2.Invoke(EnableButton, A2)
        A3.Invoke(EnableButton, A3)
        B1.Invoke(EnableButton, B1)
        B2.Invoke(EnableButton, B2)
        B3.Invoke(EnableButton, B3)
        C1.Invoke(EnableButton, C1)
        C2.Invoke(EnableButton, C2)
        C3.Invoke(EnableButton, C3)
    End Sub

    Sub Replay()
        Dim rep = MsgBox("Refaire une partie ?", vbYesNo + vbQuestion + vbDefaultButton1)
        If rep = vbYes Then
            ButtonOk_Click()
        End If
        If rep = vbNo Then
            Me.Close()
        End If
    End Sub
End Class

Public Class MorpionGrid
    Public A1 As MCases = New MCases
    Public A2 As MCases = New MCases
    Public A3 As MCases = New MCases
    Public B1 As MCases = New MCases
    Public B2 As MCases = New MCases
    Public B3 As MCases = New MCases
    Public C1 As MCases = New MCases
    Public C2 As MCases = New MCases
    Public C3 As MCases = New MCases
    Sub New()
    End Sub
    Public Function getcase(s As String) As MCases
        Select Case s(0)
            Case "A"
                Select Case s(1)
                    Case "1"
                        Return A1
                    Case "2"
                        Return A2
                    Case "3"
                        Return A3
                End Select

            Case "B"
                Select Case s(1)
                    Case "1"
                        Return B1
                    Case "2"
                        Return B2
                    Case "3"
                        Return B3
                End Select
            Case "C"
                Select Case s(1)
                    Case "1"
                        Return C1
                    Case "2"
                        Return C2
                    Case "3"
                        Return C3
                End Select
        End Select
        Return B2
    End Function

    Public Function Eg(a As MCases, b As MCases)
        Return (a.croix = b.croix Or a.rond = b.rond) And (a.croix Or a.rond) And (b.croix Or b.rond)
    End Function
    Public Function Iscomplete()
        Return (A1.croix Or A1.rond) And (A2.croix Or A2.rond) And (A3.croix Or A3.rond) And (B1.croix Or B1.rond) And (B2.croix Or B2.rond) And (B3.croix Or B3.rond) And (C1.croix Or C1.rond) And (C2.croix Or C2.rond) And (C3.croix Or C3.rond)
    End Function

End Class

Public Class MCases
    Public rond As Boolean
    Public croix As Boolean
End Class
