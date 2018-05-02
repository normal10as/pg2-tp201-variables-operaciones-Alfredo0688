Module _1_08_semanas
    Sub main()

        Const diasAnuales As Short = 365
        Const diasLaborales As Byte = 5
        Const diasSemanales As Byte = 7

        Console.WriteLine("Semanas del año: " & diasAnuales / diasSemanales)
        Console.WriteLine("Semanas laborables: " & (diasAnuales / diasSemanales) * diasLaborales / (7))
        Console.ReadKey()

    End Sub
End Module
