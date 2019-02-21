Public Class EsearchB

    Private Sub EsearchB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyDataGridView.DataSource = CreateLevel()
        For index = 0 To 26
            MyDataGridView.Columns(index).Width = 40
        Next
    End Sub

    Private Function CreateLevel() As DataTable
        Dim table = GetDataTable()
        Dim modele = Split(My.Resources.Level1, vbCrLf)
        Dim a = 0
        For j = 0 To 22
            For i = 0 To 26
                If modele(j)(i) = "1" Then
                    a += 1
                    'table.Rows(i).Item(j) = "O"
                End If
            Next
        Next



        Return table
    End Function


    Private Function GetDataTable() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("A")
        dt.Columns.Add("B")
        dt.Columns.Add("C")
        dt.Columns.Add("D")
        dt.Columns.Add("E")
        dt.Columns.Add("F")
        dt.Columns.Add("G")
        dt.Columns.Add("H")
        dt.Columns.Add("I")
        dt.Columns.Add("J")
        dt.Columns.Add("K")
        dt.Columns.Add("L")
        dt.Columns.Add("M")
        dt.Columns.Add("N")
        dt.Columns.Add("O")
        dt.Columns.Add("P")
        dt.Columns.Add("Q")
        dt.Columns.Add("R")
        dt.Columns.Add("S")
        dt.Columns.Add("T")
        dt.Columns.Add("U")
        dt.Columns.Add("V")
        dt.Columns.Add("W")
        dt.Columns.Add("X")
        dt.Columns.Add("Y")
        dt.Columns.Add("Z")

        For Index = 1 To 22
            dt.Rows.Add()
        Next
        Return dt
    End Function

End Class



Public Class Emmanuelle
    Public x As Integer
    Public y As Integer
End Class