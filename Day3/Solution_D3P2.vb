Module Solution_D3P2

    Sub Main()

        FileOpen(1, "D:\Users\sebcl\Documents\AdventOfCode2022\AOC2022_VS\AdventOfCode_2022\Day3\data.txt", OpenMode.Input)

        Dim Matches As New List(Of Char)
        Dim InternalMatches As New List(Of Char)

        Do

            Dim first = LineInput(1)
            Dim last1 = LineInput(1)
            Dim last2 = LineInput(1)

            InternalMatches.Clear()

            For i = 0 To first.Length - 1

                If last1.Contains(first(i)) And last2.Contains(first(i)) Then
                    If Not InternalMatches.Contains(first(i)) Then
                        InternalMatches.Add(first(i))
                    End If
                End If

            Next

            Matches.AddRange(InternalMatches)

        Loop Until EOF(1)

        FileClose(1)

        Dim sum As Integer

        For Each Match As String In Matches

            Select Case Match

                Case "a" To "z"

                    Dim val As Integer = Asc(Match) - 96
                    sum += val

                Case "A" To "Z"

                    Dim val As Integer = Asc(Match.ToLower) - 96 + 26
                    sum += val

            End Select

        Next

        Console.WriteLine(sum)

        Console.ReadLine()

    End Sub

End Module
