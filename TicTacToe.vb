Public Class TicTacToe
    Friend WithEvents myButton As System.Windows.Forms.Button
    Dim board(3, 3) As Button
    Dim r As New Random(1000)
    Dim symbol(2) As Char
    Dim player As Char
    Dim foundWin As Boolean = False
    Dim xWin As Integer = 0
    Dim oWin As Integer = 0
    Dim noWin As Integer = 0
    Dim numrow, numcol As Integer
    Dim counter As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' create the board
        myButton = New System.Windows.Forms.Button()

        Dim num As Integer

        For row = 1 To 3
            For col = 1 To 3
                myButton = New System.Windows.Forms.Button()
                With myButton
                    num = r.Next(1, 3)
                    .Text = ""
                    .Location = New System.Drawing.Point(col * 60, row * 60)
                    .Size = New System.Drawing.Size(60, 60)
                End With
                Me.Controls.Add(myButton)
                board(row, col) = myButton
            Next col
        Next row
    End Sub
    '
    'default strategy
    'random plays
    Private Sub strategyA()

        While counter < 1000
            'clear the board at the beginning of every run
            clearBoard()
            'initialize player at the beginning of every run
            initializePlayer()

            For i = 1 To 9
                Do While True
                    numrow = r.Next(1, 4)
                    numcol = r.Next(1, 4)
                    If board(numrow, numcol).Text = "" Then
                        board(numrow, numcol).Text = player
                        If (i >= 5) Then
                            'after 5 moves, check if someone wins the game
                            If CheckWin(player) Then
                                foundWin = True
                                countWins()
                                'end the current game when winner is found
                                Exit For
                            End If
                        End If
                        'call changeTurn sub procedure to do the turn change
                        changeTurn()
                        Exit Do
                    End If
                Loop
            Next

            If foundWin = False Then
                noWin += 1
            End If
            'counter the numbers of games ran
            counter += 1
            'reset the found winner var to false
            foundWin = False
        End While
        'call printResult sub procedure to print the result
        printResult()
        'call resetCount sub procedure to reset all the counters for the next strategy
        resetCount()
    End Sub

    Private Sub strategyB()

        While counter < 1000
            clearBoard()
            initializePlayer()
            '
            'Have X move in the center spac
            board(2, 2).Text = player
            player = symbol(2)

            For i = 2 To 9
                Do While True
                    numrow = r.Next(1, 4)
                    numcol = r.Next(1, 4)
                    If board(numrow, numcol).Text = "" Then
                        board(numrow, numcol).Text = player
                        If (i >= 5) Then

                            If CheckWin(player) Then
                                foundWin = True
                                countWins()
                                Exit For
                            End If
                        End If
                        changeTurn()
                        Exit Do
                    End If
                Loop
            Next

            If foundWin = False Then
                noWin += 1
            End If

            counter += 1
            foundWin = False
        End While

        printResult()
        resetCount()
    End Sub

    Private Sub strategyC()

        While counter < 1000
            clearBoard()
            initializePlayer()

            For i = 1 To 9
                Do While True
                    numrow = r.Next(1, 4)
                    numcol = r.Next(1, 4)

                    Do While i = 2
                        'have the O move in the center if X didn't on the first turn
                        If board(2, 2).Text = "" Then
                            board(2, 2).Text = player
                            'if O move into the center, change turn
                            GoTo line1
                        Else
                            'else, randomly placement
                            GoTo line2
                        End If
                    Loop
line2:
                    If board(numrow, numcol).Text = "" Then
                        board(numrow, numcol).Text = player

                        If (i >= 5) Then

                            If CheckWin(player) Then
                                foundWin = True
                                countWins()
                                Exit For
                            End If
                        End If
line1:
                        changeTurn()
                        Exit Do
                    End If
                Loop
            Next

            If foundWin = False Then
                noWin += 1
            End If

            counter += 1
            foundWin = False
        End While

        printResult()
        resetCount()
    End Sub
    Private Function CheckWin(ByVal inplayer As String) As Boolean

        If board(1, 1).Text = inplayer And board(2, 1).Text = inplayer And board(3, 1).Text = inplayer Then
            Return True
        ElseIf board(1, 1).Text = inplayer And board(1, 2).Text = inplayer And board(1, 3).Text = inplayer Then
            Return True
        ElseIf board(1, 1).Text = inplayer And board(2, 2).Text = inplayer And board(3, 3).Text = inplayer Then
            Return True
        ElseIf board(1, 3).Text = inplayer And board(2, 2).Text = inplayer And board(3, 1).Text = inplayer Then
            Return True
        ElseIf board(2, 1).Text = inplayer And board(2, 2).Text = inplayer And board(2, 3).Text = inplayer Then
            Return True
        ElseIf board(3, 1).Text = inplayer And board(3, 2).Text = inplayer And board(3, 3).Text = inplayer Then
            Return True
        ElseIf board(1, 2).Text = inplayer And board(2, 2).Text = inplayer And board(3, 2).Text = inplayer Then
            Return True
        ElseIf board(1, 3).Text = inplayer And board(2, 3).Text = inplayer And board(3, 3).Text = inplayer Then
            Return True
        End If

        Return False
    End Function

    Private Sub noStr_CheckedChanged(sender As Object, e As EventArgs) Handles noStr.CheckedChanged
        'print the strategy
        Label4.Text = "No strategy, random placement."
        strategyA()
    End Sub

    Private Sub xCtr_CheckedChanged(sender As Object, e As EventArgs) Handles xCtr.CheckedChanged
        Label4.Text = "Have X move in the center space for every game."
        strategyB()
    End Sub

    Private Sub oCtr_CheckedChanged(sender As Object, e As EventArgs) Handles oCtr.CheckedChanged
        Label4.Text = "Have O move in the center space first, for games where X does not randomly move there first."
        strategyC()
    End Sub

    Private Sub initializePlayer()
        symbol(1) = "X"
        symbol(2) = "O"
        player = symbol(1)
    End Sub
    Private Sub countWins()
        If player = symbol(1) Then
            xWin += 1
        ElseIf player = symbol(2) Then
            oWin += 1
        End If
    End Sub

    Private Sub changeTurn()
        If player = symbol(1) Then
            player = symbol(2)
        Else
            player = symbol(1)
        End If
    End Sub

    Private Sub clearBoard()
        For row = 1 To 3
            For col = 1 To 3
                board(row, col).Text = ""
            Next
        Next
    End Sub

    Private Sub printResult()
        xLb.Text = "X wins " + xWin.ToString
        oLb.Text = "O wins " + oWin.ToString
        noLb.Text = "No wins " + noWin.ToString
    End Sub

    Private Sub resetCount()
        xWin = 0
        oWin = 0
        noWin = 0
        foundWin = False
        counter = 0
    End Sub

End Class

