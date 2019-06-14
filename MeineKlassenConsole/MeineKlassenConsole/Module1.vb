Imports MeineKlassen

Module Module1

    Sub Main()


        Dim pkw As New PKW()



        Dim fz1 As Fahrzeug = New Fahrzeug With {
            .Farbe = "Gelb",
            .Hersteller = "Baudi",
            .Modell = "B4",
            .Türen = 7,
            .Leistung = 400
        }
        fz1.Hupen()


        Dim fz2 As Fahrzeug = New Fahrzeug("Blau") With {
            .Leistung = 600,
            .Türen = 7
        }

        fz2.Hupen()

        Console.WriteLine("Ende")
        Console.ReadKey()
    End Sub

End Module
