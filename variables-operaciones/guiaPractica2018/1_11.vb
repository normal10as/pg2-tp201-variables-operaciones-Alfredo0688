Module _1_11
    Sub main()
        Dim valor As Single
        Console.Write("Ingrese un valor: ")
        valor = Console.ReadLine
        valor = Math.Abs(valor)
        Console.WriteLine("Valor absoluto: " & valor)
        Console.WriteLine("Decima potencia: " & Math.Pow(valor, 10))
        Console.WriteLine("Raiz cuadrada: " & Math.Sqrt(valor))
        Console.ReadKey()

    End Sub
End Module
