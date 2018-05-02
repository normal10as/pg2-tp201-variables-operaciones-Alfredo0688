Module _1_04_concatenacion
    Sub main()

        Dim nombreEmpresa As String
        Dim calleEmpresa As String
        Dim alturaCalle As Short
        Dim inicioActividades As Date

        nombreEmpresa = "Pollo los hermanos"
        calleEmpresa = "East 6th St"
        alturaCalle = 1345
        inicioActividades = #5/13/2008#
        Console.WriteLine("Conversión implicita")
        Console.WriteLine(nombreEmpresa & " " & calleEmpresa & " " & alturaCalle & " " & inicioActividades)
        Console.ReadKey()
        Console.WriteLine("Conversión explicita")
        Console.WriteLine(nombreEmpresa & " " & calleEmpresa & " " & alturaCalle = Convert.ToString(alturaCalle) & " " & inicioActividades = Convert.ToString(inicioActividades))
        Console.ReadKey()

    End Sub
End Module
