Imports System.Text

Module Module1

    Sub Main()
        Console.OutputEncoding = Encoding.UTF8

        Dim text As String = "Hallo Welt"
        Dim zeichen As Char = "B"c

        Dim zahl As Integer = -57648 '*
        Dim großeZahl As Long = -2345678934567893445
        Dim großeZahlU As ULong = 125678934567893445
        Dim kleineZahl As Short = 4745
        Dim kleinsteZahl As Byte = 255
        Dim kleinsteZahl2 As SByte = -127

        Dim kleineKommeZahl As Single = 6.344354F
        Dim kommaZahlen As Double = 7.4358543553443468R '*
        Dim geld As Decimal = 5.2345678456743432423732732833D 'geld

        Dim bool As Boolean = True

        Console.WriteLine(kommaZahlen.ToString("000.###"))
        Console.WriteLine(geld.ToString("c", New Globalization.CultureInfo("en-US")))
        Console.WriteLine("Preis für " & kleineZahl & " ist: " & geld.ToString("c")) 'uncool
        Console.WriteLine(String.Format("Preis für {0} ist: {1:c}", kleineZahl, geld)) 'cool
        Console.WriteLine($"Preis für {kleineZahl} ist: {geld:c}") 'neu und sehr cool 

        Dim nichtZuGroßeZahl As Decimal = 23456.3456D
        kleineZahl = CType(nichtZuGroßeZahl, Short)

        'casting
        Console.WriteLine($"NichtZuGroßeZahl: {nichtZuGroßeZahl} wird zu: {kleineZahl}")

        Console.WriteLine("Bitte eine Zahl eingabe")
        Dim eingabe = Console.ReadLine()


        'parsen
        Dim eingabeAlsInt As Decimal = Decimal.Parse(eingabe)
        Dim verdoppeln As Decimal = eingabeAlsInt * 2
        Console.WriteLine($"Das doppelte ist: {verdoppeln}")

        Console.WriteLine(text.ToUpper())
        Console.WriteLine(text)
        Console.WriteLine(text.ToLower())

        Console.ReadKey()
    End Sub

End Module
