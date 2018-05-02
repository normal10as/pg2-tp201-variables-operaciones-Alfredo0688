Module _1_10
    Sub main()

        Dim montoInicial As UShort
        Dim tasaInteres As Single
        Dim tiempo As UShort
        Dim interesProducido As Decimal

        Console.Write("Ingresar monto inicial: ")
        montoInicial = Console.ReadLine
        Console.Write("Ingresar el interes anual en %: ")
        tasaInteres = Console.ReadLine
        Console.Write("Ingresar el tiempo en dias sobre el cual se producirá el interes: ")
        tiempo = Console.ReadLine
        'tasaInteres = tasaInteres / 100
        'tiempo = tiempo / 365
        'interesAnual = montoInicial * (tasaInteres / 100) * tiempo -- interes simple
        interesProducido = (montoInicial * tasaInteres * tiempo) / (365 * 100)
        Console.WriteLine("El interes producido es de: " & interesProducido)
        Console.WriteLine("El capital acumulado es: " & interesProducido + montoInicial)
        Console.ReadKey()
    End Sub
End Module
