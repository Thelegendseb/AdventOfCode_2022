Module Solution_D4P1

    Sub Main()

        Dim Elf1List As New List(Of Integer)
        Dim Elf2List As New List(Of Integer)

        Dim Tally As Integer

        FileOpen(1, "D:\Users\sebcl\Documents\AdventOfCode2022\AOC2022_VS\AdventOfCode_2022\Day4\data.txt", OpenMode.Input)

        Do

            Elf1List.Clear()
            Elf2List.Clear()

            Dim line As String = LineInput(1)

            Dim roomarrays() As String = line.Split(",")

            Dim elf1() As String = roomarrays(0).Split("-")

            Dim elf2() As String = roomarrays(1).Split("-")

            FillList(elf1, Elf1List)

            FillList(elf2, Elf2List)

            If ListContainedInList(Elf1List, Elf2List) Or ListContainedInList(Elf1List, Elf2List) Then
                Tally += 1
            End If

        Loop Until EOF(1)

        FileClose(1)

        Console.WriteLine(Tally)

        Console.ReadLine()

    End Sub
    Private Sub FillList(elfdata() As String, ElfList As List(Of Integer))
        Dim startloop As Integer = Convert.ToInt32(elfdata(0))
        Dim endloop As Integer = Convert.ToInt32(elfdata(1))
        For i = startloop To endloop
            ElfList.Add(i)
        Next
    End Sub
    Private Function ListContainedInList(Sublist As List(Of Integer), List_ As List(Of Integer)) As Boolean
        For Each item As Integer In Sublist
            If Not List_.Contains(item) Then Return False
        Next
        Return True
    End Function

End Module
