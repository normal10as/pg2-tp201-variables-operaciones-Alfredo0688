Module _1_16
    Sub main()

        Dim fecha As DateTime
        Dim numeroDias As Byte
        Console.Write("Ingrese una fecha respetando el orden DD/MM/AA: ")
        fecha = Console.ReadLine
        Console.Write("Ingrese un número de dia: ")
        numeroDias = Console.ReadLine

        Console.WriteLine("Fecha ingresada: " & fecha & " días ingresados: " & numeroDias)
        fecha.AddDays(numeroDias)
        Console.WriteLine("Fecha con los días agregados: " & fecha.AddDays(numeroDias))


        Console.ReadKey()

    End Sub
End Module
