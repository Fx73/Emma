Public Class EsearchB
    Private current As Cochon = New Cochon
    Public ThreadDep As System.Threading.Thread = New Threading.Thread(AddressOf Deplacement)

    Delegate Sub SetPanelDelegate(ByVal P As Panel, ByVal b As Button)
    Private SetPanel As New SetPanelDelegate(AddressOf SetPanelSelect)
    Private Sub SetPanelSelect(ByVal P As Panel, ByVal b As Button)
        P.Visible = Not P.Visible
        If P.Visible Then b.Select()
    End Sub




    Private Sub EsearchB_Load() Handles MyBase.Load
        MyDataGridView.DataSource = GetDataTable()
        MyDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        For Index = 0 To 25
            MyDataGridView.Columns(Index).Width = 40
            MyDataGridView.Columns(Index).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Private Sub Initialisation() Handles Buttonok.Click

        MyDataGridView.DataSource = CreateLevel()
        ColorTable()
        MyDataGridView.Select()
        PanelSelect.Visible = False
    End Sub


    Private Function CreateLevel() As DataTable
        Dim table = GetDataTable()
        Dim modele = Split(Lvlselection(Int(ComboBoxLvl.Text)), vbCrLf)
        For j = 0 To 21
            For i = 0 To 25
                Select Case (modele(j)(i))
                    Case "1"
                        table.Rows(j).Item(i) = "O"
                    Case "2"
                        table.Rows(j).Item(i) = "/"
                    Case "3"
                        table.Rows(j).Item(i) = "\"
                    Case "x", "X"
                        table.Rows(j).Item(i) = "X"
                        current.x = i
                        current.y = j
                    Case "e", "E"
                        table.Rows(j).Item(i) = "Exit"
                End Select
            Next
        Next

        Return table
    End Function




    Private Sub ColorTable()
        For Index = 0 To 25
            For Index2 = 0 To 21
                ColorCell(MyDataGridView.Rows(Index2).Cells(Index))
            Next
        Next
    End Sub

    Private Sub ColorCell(c As DataGridViewCell)
        Select Case (c.Value.ToString)
            Case "O"
                c.Style.BackColor = Color.Black
            Case "Exit"
                c.Style.BackColor = Color.LightGreen
        End Select
    End Sub

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

    Private Sub GridKeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MyDataGridView.KeyDown
        If e.KeyCode = Keys.F3 Then
            PanelSelect.Visible = Not PanelSelect.Visible
        ElseIf e.KeyCode = Keys.Left Or Keys.Right Or Keys.Up Or Keys.Down Then
            ThreadDep = New Threading.Thread(AddressOf Deplacement)
            ThreadDep.Start(e.KeyCode)
        End If
    End Sub

    Private Function Deplacement(e As Keys)
        Dim a = Collision(e)
        While a
            MyDataGridView.Rows(current.y).Cells(current.x).Value = ""
            Select Case e
                    Case Keys.Left
                        current.x = current.x - 1
                    Case Keys.Right
                        current.x = current.x + 1
                    Case Keys.Up
                        current.y = current.y - 1
                    Case Keys.Down
                        current.y = current.y + 1
                End Select
            MyDataGridView.Rows(current.y).Cells(current.x).Value = "X"
            a = Collision(e)
            Threading.Thread.Sleep(20)
        End While
    End Function

    Private Function Collision(ByRef e As Keys) As Int32
        Dim rep = ""
        Select Case e
            Case Keys.Left
                If current.x = 0 Then rep = "O" Else rep = MyDataGridView.Rows(current.y).Cells(current.x - 1).Value.ToString
            Case Keys.Right
                If current.x = 25 Then rep = "O" Else rep = MyDataGridView.Rows(current.y).Cells(current.x + 1).Value.ToString
            Case Keys.Up
                If current.y = 0 Then rep = "O" Else rep = MyDataGridView.Rows(current.y - 1).Cells(current.x).Value.ToString
            Case Keys.Down
                If current.y = 21 Then rep = "O" Else rep = MyDataGridView.Rows(current.y + 1).Cells(current.x).Value.ToString
        End Select
        Select Case rep
            Case ""
                Return True
            Case "O"
                Return False
            Case "E"
                Gagne()
                Return False
            Case "\"
                Select Case e
                    Case Keys.Left
                        e = Keys.Up
                    Case Keys.Up
                        e = Keys.Left
                    Case Keys.Down
                        e = Keys.Right
                    Case Keys.Right
                        e = Keys.Down
                End Select
                Return Collision(e)
            Case "/"
                Select Case e
                    Case Keys.Left
                        e = Keys.Down
                    Case Keys.Down
                        e = Keys.Left
                    Case Keys.Up
                        e = Keys.Right
                    Case Keys.Right
                        e = Keys.Up
                End Select
                Return Collision(e)
            Case Else
                Return False
        End Select
    End Function

    Private Sub Perdu()
        'MsgBox("Perdu !!", vbInformation)
        PanelSelect.Invoke(SetPanel, New Object() {PanelSelect, Buttonok})
    End Sub

    Private Sub Gagne()
        MsgBox("Gagné !!", vbInformation)
        PanelSelect.Invoke(SetPanel, New Object() {PanelSelect, Buttonok})
    End Sub

    Private Function Lvlselection(a As Int32)
        Select Case a
            Case 1
                Return My.Resources.Level1
            Case 2
                Return My.Resources.Level2
            Case 3
                Return My.Resources.Level3
            Case Else
                MsgBox("Niveau inexistant")
                Return My.Resources.Level1
        End Select
    End Function


    Public Class Cochon
        Public x As Integer
        Public y As Integer

        Public Function Win(dt As DataGridView, Optional i As Integer = 0, Optional j As Integer = 0) As Boolean
            Return dt.Rows(y + j).Cells(x + i).Value.ToString = "Exit"
        End Function
    End Class


End Class



