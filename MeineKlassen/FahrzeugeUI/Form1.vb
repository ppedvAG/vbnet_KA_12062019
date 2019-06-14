Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization
Imports MeineKlassen

Public Class Form1

    Dim liste As New BindingList(Of Fahrzeug)

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataGridView1.DataSource = liste
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim neuesF As New Fahrzeug()
        neuesF.Hersteller = "NEU"
        liste.Add(neuesF)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim neuerPKW As New PKW()
        neuerPKW.Hersteller = "PKW NEU"
        neuerPKW.Sitze = 7652
        neuerPKW.Antriebsart = Antriebsart.EMotor
        liste.Add(neuerPKW)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim neuerLKW As New LKW()
        neuerLKW.Hersteller = "LKW NEU"
        neuerLKW.Schlafmöglichkeit = True
        neuerLKW.Antriebsart = Antriebsart.Motor
        liste.Add(neuerLKW)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim schiff As New Schiff()
        schiff.Hersteller = "Schiff NEU"
        schiff.Anker = 8
        schiff.AnzahlBullaugen = 67
        schiff.AnzahlContainer = 98
        schiff.Antriebsart = Antriebsart.Dampf
        liste.Add(schiff)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        Dim item As Object = DataGridView1.CurrentRow.DataBoundItem

        'hupen!
        Dim einFahrzeug As Fahrzeug = TryCast(item, Fahrzeug) 'boxing
        If Not einFahrzeug Is Nothing Then
            einFahrzeug.Hupen()
        End If

        Dim istContainer As MeineKlassen.IContainer = TryCast(item, MeineKlassen.IContainer)
        If Not istContainer Is Nothing Then
            MessageBox.Show($"Kann Container: {istContainer.GetTypen()} Anzahl: {istContainer.AnzahlContainer}")
        End If

        If TypeOf item Is Schiff Then 'typprüfung
            Dim einSchiff As Schiff = CType(item, Schiff) 'typ umwandlung (casting)
            'einSchiff.Hupen()
            MessageBox.Show($"Das ist ein Schiff ({einSchiff.Hersteller}) mit {einSchiff.Anker} Ankern und {einSchiff.AnzahlBullaugen} Bullaugen")
        End If

        Dim einAuto As PKW = TryCast(item, PKW) 'boxing
        If Not einAuto Is Nothing Then
            MessageBox.Show($"Das ist ein {einAuto.Farbe} Auto")
        End If


    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim einSchiff As Schiff = New Schiff()


        'array == alt!
        Dim schiffe(3) As Schiff
        schiffe(1) = New Schiff()
        schiffe(2) = New Schiff()
        schiffe(3) = New Schiff()

        Dim text As String = ""
        For index = 1 To schiffe.Length - 1
            text += schiffe(index).Hersteller
        Next

        'generic (generische) list
        Dim liste As List(Of String) = New List(Of String)()
        liste.Add("Hallo") '0
        liste.Add("Das ist doof") '1 
        liste.Add("Und noch mehr text") '2 -> 3
        liste.Insert(2, "Mehr Text!")
        liste.RemoveAt(1)


        ListBox1.Items.Clear()
        For Each item In liste
            ListBox1.Items.Add(item)
        Next




    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim dlg = New SaveFileDialog()
        dlg.Title = "Fahrzeugzieldatei auswählen"
        dlg.Filter = "Fahrzeugdateien|*.xml|Alle Dateien|*.*"
        If dlg.ShowDialog() = DialogResult.OK Then

            Dim sw = New StreamWriter(dlg.FileName)
            Dim serial = New XmlSerializer(GetType(BindingList(Of Fahrzeug)))

            serial.Serialize(sw, DataGridView1.DataSource)

            sw.Close()
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim dlg = New OpenFileDialog()
        dlg.Title = "Fahrzeugzieldatei auswählen"
        dlg.Filter = "Fahrzeugdateien|*.xml|Alle Dateien|*.*"
        If dlg.ShowDialog() = DialogResult.OK Then

            Dim sr = New StreamReader(dlg.FileName)
            Dim serial = New XmlSerializer(GetType(BindingList(Of Fahrzeug)))

            DataGridView1.DataSource = serial.Deserialize(sr)

            sr.Close()
        End If
    End Sub
End Class
