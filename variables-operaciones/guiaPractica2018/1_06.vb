Module _1_06
    Sub main()
        Dim a As Byte = 1
        Dim b As Byte = 5
        Dim c As Byte = 2
        Dim x As Single
        x = (b ^ 2 - 4 * a * c) / (2 * a)
        Console.WriteLine("Formula: " & x)
        Console.ReadKey()
    End Sub
End Module
