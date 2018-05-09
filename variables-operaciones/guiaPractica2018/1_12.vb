Module _1_12
    Sub main()

        Dim valor As Double

        Console.WriteLine("Ingresar un numero real para ver su valor por defecto, en exceso y redondeado: ")
        Console.Write("Numero: ")
        valor = Console.ReadLine

        Console.WriteLine("Valor apróximado por exceso: " & Math.Ceiling(valor))
        Console.WriteLine("Valor apróximado por defecto: " & Math.Floor(valor))
        Console.WriteLine("Valor redondeado: " & Math.Round(valor))

        Console.ReadLine()



    End Sub
End Module
