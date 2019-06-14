Imports MeineKlassen

Public Class Schiff
    Inherits Fahrzeug
    Implements IContainer

    Public Property Anker As Integer
    Public Property AnzahlBullaugen As Integer
    Public Property Länge As Integer

    Public Property AnzahlContainer As Integer Implements IContainer.AnzahlContainer


    Public Overrides Sub Hupen()
        Console.Beep(400, 3000)
    End Sub

    Public Function GetTypen() As String Implements IContainer.GetTypen
        Return "20Fuss, 40Fuss"
    End Function
End Class