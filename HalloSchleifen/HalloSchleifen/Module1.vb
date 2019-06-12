Imports System.IO

Module Module1

    Sub Main()
        Console.WriteLine("*** Hallo Schleifen ***")

        'For i = 1 To 1000000000
        '    If i Mod 100000000 = 0 Then
        '        Console.WriteLine(i)
        '    End If
        'Next

        'While DateTime.Now.Second < 30
        '    Console.WriteLine("Warten...")
        'End While

        'Dim sw = New StreamWriter("zahlen.txt")
        'For i = 1 To 100
        '    sw.WriteLine(i)
        'Next
        'sw.Close()


        Dim sr = New StreamReader("zahlen.txt")
        While Not sr.EndOfStream
            Dim line = sr.ReadLine()
            Console.WriteLine($"Line: {line}")
            If line = "EXIT" Then
                Exit While
            End If
        End While
        sr.Close()

        Console.WriteLine("Ende")
        Console.ReadKey()
    End Sub

End Module
