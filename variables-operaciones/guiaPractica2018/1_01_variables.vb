Module _1_01_variables
    Public nombrePersona As String
    Friend tipoDocumento As String
    Friend numeroDocumento As UInteger
    Friend fechaNacimiento As Date
    Private localidad As String

    Private alturaCorporalcms As Byte
    Private estadoCivil As String
    Private argentino As Boolean

    Sub Main()

        Dim edad As Byte


        nombrePersona = "Homer"
        tipoDocumento = "DNI"
        numeroDocumento = 24136795
        localidad = "La Plata"
        fechaNacimiento = #8/6/1962#
        edad = 30
        alturaCorporalcms = 177
        estadoCivil = "Soltero"
        argentino = True

        Console.WriteLine("Nombre: " & nombrePersona)
        Console.WriteLine("Tipo de documento: " & tipoDocumento)
        Console.WriteLine("Numero de documento: " & numeroDocumento)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Fecha de nacimiento: " & fechaNacimiento)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura corporal en centimetros: " & alturaCorporalcms)
        Console.WriteLine("Estado civil: " & estadoCivil)
        Console.WriteLine("Argentino: " & argentino)
        Console.ReadKey()





    End Sub

End Module
