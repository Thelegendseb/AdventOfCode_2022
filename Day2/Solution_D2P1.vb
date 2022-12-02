Module Solution_D2P1

    Sub Main()

        Dim Score As Integer

        FileOpen(1, "D:\Users\sebcl\Documents\AdventOfCode2022\AOC2022_VS\AdventOfCode_2022\Day2\data.txt", OpenMode.Input)

        Do

            Dim Turn As String = LineInput(1)

            Dim Options() As String = Turn.Split(" ")

            If Options(1) = "X" Then
                ' // Rock

                Score += 1

                Select Case Options(0)

                    Case "A"
                        ' // Rock

                        Score += 3

                    Case "B"
                        ' // Paper


                    Case "C"
                        ' // Scissors
                        Score += 6


                End Select

            ElseIf Options(1) = "Y" Then
                ' // Paper

                Score += 2

                Select Case Options(0)

                    Case "A"
                        ' // Rock

                        Score += 6

                    Case "B"
                        ' // Paper
                        Score += 3

                    Case "C"
                        ' // Scissors
                        Score += 0


                End Select

            ElseIf Options(1) = "Z" Then
                ' // Scissors

                Score += 3

                Select Case Options(0)

                    Case "A"
                        ' // Rock

                        Score += 0

                    Case "B"
                        ' // Paper
                        Score += 6

                    Case "C"
                        ' // Scissors
                        Score += 3


                End Select

            End If

        Loop Until EOF(1)

        FileClose(1)

        Console.WriteLine(Score)

        Console.ReadLine()

    End Sub

End Module
