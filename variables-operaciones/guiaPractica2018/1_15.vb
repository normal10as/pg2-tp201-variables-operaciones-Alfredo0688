Module _1_15
    Sub main()

        Dim dia As Byte
        Dim hora As Byte
        
        Console.WriteLine("Ingrese un día(1-31)")
        dia = Console.ReadLine

        Console.WriteLine("Ingrese una hora(0-24)")
        hora = Console.ReadLine

        Dim fechaModificada As New Date(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)
        Console.WriteLine(fechaModificada)
        Console.ReadKey()
       

    End Sub
End Module
