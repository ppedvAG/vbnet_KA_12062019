Module Module1

    Sub Main()
        Console.OutputEncoding = Text.Encoding.UTF8 'damit kann die Console das € Zeichen darstellen
        Console.WriteLine("** Hallo Klassen **")

#If DEBUG Then
        Console.WriteLine("DEBUG VERSION")
#End If

#If WURST Then
        Console.WriteLine("WURST VERSION")
#End If

        Dim pizza As Essen 'deklaration
        pizza = New Essen() 'instanzierung
        pizza.Name = "Pizza"
        pizza.IstVegetarisch = False
        pizza.KCal = 1020
        'pizza.Preis = 8.5
        pizza.SetPreis(8.5)

        Dim suppe As Essen = New Essen()
        suppe.Name = "Suppe"
        suppe.IstVegetarisch = True
        suppe.KCal = 300
        'suppe.Preis = 4.2
        suppe.SetPreis(4.2)


        ZeigeEssen(pizza)
        ZeigeEssen(suppe)

        Dim zahl As Integer = 156
        Verdoppeln(zahl)


        EinfacheMethode()
        ZeigeText("Fred")

        ZeigeWert("PS", 237)
        ZeigeWert("PS", 237.4D)
        Dim input = Console.ReadKey()
        Console.WriteLine("Ende")
    End Sub

    Sub EinfacheMethode()
        Console.WriteLine("Hallo")
    End Sub

    Sub ZeigeText(text As String)
        Console.WriteLine($"Hallo: {text}")
    End Sub

    Sub ZeigeWert(text As String, zahl As Integer)
        Console.WriteLine($"{text}: {zahl}")
    End Sub

    Sub ZeigeWert(text As String, zahl As Decimal)
        Console.WriteLine($"{text}: {zahl}")
    End Sub

    Function GibMirFünf() As Integer
        If "cool" = "cool" Then
            Return 5
        End If
        Return 0
    End Function

    Private Sub Verdoppeln(eineZahl As Integer)
        eineZahl = eineZahl * 2
    End Sub

    Sub ZeigeEssen(einEssen As Essen)
        Console.WriteLine($"{einEssen.Name}: {einEssen.GetPreis():c} [{einEssen.KCal} KCal] Vege: {IIf(einEssen.IstVegetarisch, "Jo", "Nöp")}")
    End Sub

End Module

Class Essen
    Public Property Name As String

    'AUTO Property
    Public Property IstVegetarisch As Boolean

    'FULL Property
    Private _kcal As Integer
    Public Property KCal As Integer
        Get
            Return _kcal
        End Get
        Set(ByVal value As Integer)
            _kcal = value
        End Set
    End Property

    Private Preis As Decimal

    Public Function GetPreis() As Decimal
        Return Preis
    End Function

    Friend Sub SetPreis(neuPreis As Decimal)
        If neuPreis < 0 Then
            Console.WriteLine("Der Preis darf nicht negativ sein!!!!!")
        Else
            Preis = neuPreis
        End If
    End Sub

End Class


