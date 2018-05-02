Module _1_14
    Sub main()

        Dim fechaActual As Date = Now

        Console.WriteLine("Día: " & fechaActual.DayOfYear)
        Console.WriteLine("Mes: " & fechaActual.Month)
        Console.WriteLine("Hora: " & fechaActual.Hour)
        Console.WriteLine("Minuto: " & fechaActual.Minute)

        Console.ReadKey()


    End Sub
End Module
