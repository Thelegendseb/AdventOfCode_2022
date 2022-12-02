Module Solution_D2P2

    Sub Main()

        Dim Score As Integer

        FileOpen(1, "D:\Users\sebcl\Documents\AdventOfCode2022\AOC2022_VS\AdventOfCode_2022\Day2\data.txt", OpenMode.Input)

        Do

            Dim Turn As String = LineInput(1)

            Dim Options() As String = Turn.Split(" ")

            If Options(1) = "X" Then
                ' // Lose

                Select Case Options(0)

                    Case "A"
                        ' // Rock
                        Score += 3

                    Case "B"
                        ' // Paper
                        Score += 1

                    Case "C"
                        ' // Scissors
                        Score += 2


                End Select

            ElseIf Options(1) = "Y" Then
                ' // Draw

                Score += 3

                Select Case Options(0)

                    Case "A"
                        ' // Rock

                        Score += 1

                    Case "B"
                        ' // Paper
                        Score += 2

                    Case "C"
                        ' // Scissors
                        Score += 3


                End Select

            ElseIf Options(1) = "Z" Then
                ' // Win

                Score += 6

                Select Case Options(0)

                    Case "A"
                        ' // Rock

                        Score += 2

                    Case "B"
                        ' // Paper
                        Score += 3

                    Case "C"
                        ' // Scissors
                        Score += 1


                End Select

            End If

        Loop Until EOF(1)

        FileClose(1)

        Console.WriteLine(Score)

        Console.ReadLine()

    End Sub

End Module
