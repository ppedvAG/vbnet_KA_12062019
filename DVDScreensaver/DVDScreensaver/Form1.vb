Imports System.Threading

Public Class Form1


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Dim toLeft As Integer = 5
    Dim toDown As Integer = 5
    Dim ran As Random = New Random()

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Button1.Left = Button1.Left + toLeft

        If Button1.Left + Button1.Width >= ClientSize.Width Or Button1.Left <= 0 Then
            toLeft = toLeft * -1
            MakeFun()
        End If

        Button1.Top = Button1.Top + toDown

        If Button1.Top + Button1.Height >= ClientSize.Height Or Button1.Top <= 0 Then
            toDown = toDown * -1
            MakeFun()
        End If
    End Sub

    Sub MakeFun()
        Task.Run(Sub() Console.Beep(360, 80))


        Dim newColor = Color.FromArgb(ran.Next(256), ran.Next(256), ran.Next(256))
        Button1.BackColor = newColor

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        toLeft = TrackBar1.Value
        toDown = TrackBar1.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MakeFun()
    End Sub


    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        'Button2.Left = Button2.Left + 5
        Button2.Left += ran.Next(-50, 50)
        Button2.Top += ran.Next(-20, 20)
    End Sub
End Class
