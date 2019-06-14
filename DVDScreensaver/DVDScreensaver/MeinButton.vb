Public Class MeinButton
    Inherits Button


    Public Overrides Property BackColor As Color

        Get
            Return MyBase.BackColor
        End Get

        Set(value As Color)

            If value = Color.Pink Then
                MyBase.BackColor = Color.Black
            Else
                MyBase.BackColor = value
            End If

        End Set

    End Property



    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        'MyBase.OnPaint(pevent)

        'GDI+
        pevent.Graphics.FillRectangle(Brushes.Black, Me.ClientRectangle)
        pevent.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        pevent.Graphics.FillEllipse(New SolidBrush(BackColor), Me.ClientRectangle)

        Dim sf = New StringFormat()
        sf.LineAlignment = StringAlignment.Center
        sf.Alignment = StringAlignment.Center

        Dim f = New Font("Broadway", 24)
        pevent.Graphics.DrawString(Me.Text, f, Brushes.Blue, Me.ClientRectangle, sf)

    End Sub
End Class
