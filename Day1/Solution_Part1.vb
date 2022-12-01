Module Solution_Part1

    Sub Main()

        Dim highestFound As Integer = 0

        Dim currentCount As Integer = 0

        FileOpen(1, "D:\Users\sebcl\Documents\AdventOfCode2022\AOC2022_VS\AdventOfCode_2022\Day1\data.txt", OpenMode.Input)

        Do

            Dim CalorieForItem_str As String = LineInput(1)

            If CalorieForItem_str = "" Then

                If currentCount > highestFound Then

                    highestFound = currentCount

                End If

                currentCount = 0

            Else

                Dim CalorieForItem_int As Integer = CInt(CalorieForItem_str)

                currentCount += CalorieForItem_int

            End If

        Loop Until EOF(1)

        FileClose(1)

        Console.WriteLine(highestFound)

        Console.ReadLine()

    End Sub

End Module
