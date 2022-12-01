Module Solution_Part2

    Sub Main()

        Dim currentCount As Integer = 0

        Dim CalorieSums As New List(Of Integer)

        FileOpen(1, "D:\Users\sebcl\Documents\AdventOfCode2022\AOC2022_VS\AdventOfCode_2022\Day1\data.txt", OpenMode.Input)

        Do

            Dim CalorieForItem_str As String = LineInput(1)

            If CalorieForItem_str = "" Then

                CalorieSums.Add(currentCount)

                currentCount = 0

            Else

                Dim CalorieForItem_int As Integer = CInt(CalorieForItem_str)

                currentCount += CalorieForItem_int

            End If

        Loop Until EOF(1)

        FileClose(1)

        CalorieSums.Sort()

        CalorieSums.Reverse()

        Console.WriteLine(CalorieSums.GetRange(0, 3).Sum())

        Console.ReadLine()

    End Sub

End Module
