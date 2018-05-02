Module _1_17
    Enum diasSemana As Byte
        lunes = 1
        martes = 2
        miercoles = 3
        juevez = 4
        viernes = 5
        sabado = 6
        domingo = 7
    End Enum

    Sub main()

        Dim fecha As DateTime
        Dim numeroDias As UShort


        Console.Write("Agregar una Fecha(DD/MM/AA): ")
        fecha = Console.ReadLine
        Console.Write("Agregar número de dias a sumar a dicha fecha: ")

        numeroDias = Console.ReadLine

        Console.WriteLine("Fecha ingresada: " & fecha)
        Console.WriteLine("Días agregados: " & numeroDias)

        fecha = fecha.AddDays(numeroDias)

        Console.WriteLine("Fecha con días agregados: " & fecha)
        Dim diaSemanal As diasSemana = fecha.DayOfWeek
        Console.WriteLine("Dia de la semana de la fecha: " & diaSemanal.ToString)

        Console.ReadKey()

    End Sub


End Module
