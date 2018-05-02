Module _1_09
    Sub main()

        Dim verdadero As Boolean = True
        Dim falso As Boolean = False


        Console.WriteLine("Tablas de verdad")
        Console.WriteLine("**************And***************")
        Console.Write("Verdadero y Falso: ")
        Console.WriteLine(verdadero And falso)
        Console.Write("Verdadero y Verdadero: ")
        Console.WriteLine(verdadero And verdadero)
        Console.Write("Falso y Verdadero: ")
        Console.WriteLine(falso And verdadero)
        Console.Write("Falso y Falso: ")
        Console.WriteLine(falso And falso)


        Console.WriteLine("***********Or***************")
        Console.Write("Verdadero o Falso: ")
        Console.WriteLine(verdadero Or falso)
        Console.Write("Verdadero o Verdadero: ")
        Console.WriteLine(verdadero Or verdadero)
        Console.Write("Falso o Verdadero: ")
        Console.WriteLine(falso Or verdadero)
        Console.Write("Falso o Falso: ")
        Console.WriteLine(falso Or falso)

        Console.WriteLine("********Not********")
        Console.Write("Not Verdadero: ")
        Console.WriteLine(Not verdadero)
        Console.Write("Not Falso: ")
        Console.WriteLine(Not falso)

        Console.WriteLine("***********Xor***************")
        Console.Write("Verdadero xor Falso: ")
        Console.WriteLine(verdadero Xor falso)
        Console.Write("Verdadero xor Verdadero: ")
        Console.WriteLine(verdadero Xor verdadero)
        Console.Write("Falso xor Verdadero: ")
        Console.WriteLine(falso Xor verdadero)
        Console.Write("Falso xor Falso: ")
        Console.WriteLine(falso Xor falso)


        Console.ReadKey()
    End Sub
End Module
