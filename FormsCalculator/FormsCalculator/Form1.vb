Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MessageBox.Show($"Summe: { Decimal.Parse(TextBox1.Text) + Decimal.Parse(TextBox2.Text)}")
        TextBox3.Text = Decimal.Parse(TextBox1.Text) + Decimal.Parse(TextBox2.Text)
    End Sub


    Dim zahl As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        zahl = zahl + 1

        Button1.Text = zahl.ToString()

        Dim einBool As Boolean = CheckBox1.Checked

        If Date.Now.Minute >= 8 Then
            CheckBox1.BackColor = Color.Yellow
        Else
            CheckBox1.BackColor = Color.LightCoral
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
