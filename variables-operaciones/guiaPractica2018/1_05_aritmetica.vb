Module _1_05_aritmetica
    Sub main()
        Dim valor_a As Integer
        Dim valor_b As Integer
        Dim valor_c As Single
        Dim valor_d As Single

        valor_a = 41
        valor_b = 877
        valor_c = 9.66
        valor_d = 65.6565

        Console.WriteLine("Valores enteros:" & valor_a & " y " & valor_b)
        Console.WriteLine("Valores de punto florante:" & valor_c & " y " & valor_d)

        Console.WriteLine("Sumar entero con entero: " & valor_a + valor_b)
        Console.WriteLine("Sumar entero con punto flotante: " & valor_a + valor_d)
        Console.WriteLine("Sumar punto flotante con punto flotante: " & valor_c + valor_d)
        Console.WriteLine("Restar entero con punto flotante: " & valor_b - valor_d)
        Console.WriteLine("Restar punto flotante con punto flotante: " & valor_c - valor_d)
        Console.WriteLine("Multiplicar entero con entero: " & valor_a * valor_b)
        Console.WriteLine("Multiplicar punto flotante con punto flotante: " & valor_c * valor_d)
        Console.WriteLine("Dividir entero con entero: " & valor_a / valor_b)
        Console.WriteLine("Dividir punto flotante con punto flotante: " & valor_c / valor_d)

        Console.ReadKey()

    End Sub
End Module
