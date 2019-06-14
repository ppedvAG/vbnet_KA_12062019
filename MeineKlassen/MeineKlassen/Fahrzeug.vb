Public Class Fahrzeug

    Public Property Farbe As String
    Public Property Hersteller As String
    Public Property Modell As String
    Public Property Türen As Integer
    Public Property Leistung As Integer


    Public Overridable Sub Hupen()
        Console.Beep(Leistung, 500)
    End Sub

    Sub New() 'Konstruktor (ctor)
        'public Fahrzeug() 'C# Konstruktor
        Me.New("weiss")
    End Sub

    Sub New(farbe As String)
        Me.New(farbe, 100)
    End Sub

    Sub New(farbe As String, leistung As Integer)
        Me.Farbe = farbe
        Me.Leistung = leistung
        Me.Antriebsart = Antriebsart.Sonne 'setzte auf sonne
    End Sub

    Public Property Antriebsart As Antriebsart

End Class

Public Enum Antriebsart
    Motor
    EMotor
    Muskel
    Dampf
    Wind
    Sonne
End Enum


Public Structure Blö
    Property Zahl As Integer
    Property Zahl2 As Integer
    Property Zahl3 As Integer

End Structure

