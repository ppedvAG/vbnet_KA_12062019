Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MessageBox.Show($"Summe: { Decimal.Parse(TextBox1.Text) + Decimal.Parse(TextBox2.Text)}")
        TextBox3.Text = Decimal.Parse(TextBox1.Text) + Decimal.Parse(TextBox2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CheckBox1.BackColor = Color.LightGray


        MessageBox.Show("Hallo")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
