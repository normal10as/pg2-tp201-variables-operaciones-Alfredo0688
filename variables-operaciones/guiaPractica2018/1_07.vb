Module _1_07
    Sub main()

        Dim a, b, c, d As Short
        Dim sumatoria As Integer

        Console.WriteLine("Ingresar 4 valores y el programa calculará la sumatoria y la media de los mismos")
        Console.Write("Valor 1: ")
        a = Console.ReadLine
        Console.Write("Valor 2: ")
        b = Console.ReadLine
        Console.Write("Valor 3: ")
        c = Console.ReadLine
        Console.Write("Valor 4: ")
        d = Console.ReadLine

        sumatoria = a + b + c + d


        Console.WriteLine("Sumatoria: " & sumatoria)
        Console.WriteLine("Media: " & sumatoria / 4)
        Console.ReadKey()

    End Sub
End Module
