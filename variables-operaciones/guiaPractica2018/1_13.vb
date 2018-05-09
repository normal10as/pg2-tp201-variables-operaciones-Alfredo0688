Module _1_13
    Sub main()
        Dim valorA As Short
        Dim valorB As Short
        Dim valorC As Short

        console.writeline("Ingrese tres valores, el programa le dirá cual es el mayor")

        console.write("Valor 1: ")
        valora = console.readline

        console.write("Valor 2: ")
        valorB = console.readline

        console.write("Valor 3: ")
        valorC = console.readline

        console.writeline("El mayor valor es: " & math.max(math.max(valorA, valorB), valorC))
        console.readkey()
    End Sub
End Module
