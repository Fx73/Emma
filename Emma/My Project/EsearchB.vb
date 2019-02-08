Public Class EsearchB

    Public currentlvl As Grille

    Private Sub EsearchB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentlvl = New Grille
    End Sub

End Class


Public Class Grille
    Public tab(30, 30) As Int16
    Public e As Emmanuelle
    Sub New()
    End Sub
End Class

Public Class Emmanuelle
    Public x As Integer
    Public y As Integer
End Class