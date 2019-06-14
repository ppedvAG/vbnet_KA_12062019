Imports MeineKlassen

Public Class LKW
    Inherits Fahrzeug
    Implements IContainer

    Public Property Beladung As Integer
    Public Property Länge As Integer
    Public Property Schlafmöglichkeit As Boolean

    Public Property AnzahlContainer As Integer Implements IContainer.AnzahlContainer

    Public Function GetTypen() As String Implements IContainer.GetTypen
        Return "20Füsse"
    End Function
End Class
