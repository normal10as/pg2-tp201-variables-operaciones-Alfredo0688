Module _1_15
    Sub main()
        '        Dim fecha As Date

        Dim dia As Date
        Dim hora As Byte
        
        'Dim fecha As New DateTime(Year(Now), Month(Now))

        Console.WriteLine("Ingrese un día(1-31)")
        dia = Console.ReadLine

        Console.WriteLine("Ingrese una hora(0-24)")
        hora = Console.ReadLine

        Dim fechaModificada As New DateTime(Year(Now), Month(Now), Day(dia))
        Console.WriteLine(fechaModificada)
        Console.ReadKey()
        'fecha = Now
        'hora = fecha.Hour
        'dia = fecha.Day

        ''Dim fecha As New DateTime(Year(Now), Month(Now), Day(dia))

        'Console.WriteLine("Año{0}, Mes{1}, Día{2}, Hora{3} ", fecha.Year, fecha.Month, fecha.Day, fecha.Hour)
        'Console.ReadKey()

    End Sub
End Module
