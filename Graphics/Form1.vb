Public Class Form1
    Dim drawOptions As Integer = 0
    Dim pen1 As Pen
    Dim rectangle1 As Rectangle
    Dim rectangle2 As Rectangle
    Dim rectangle3 As Rectangle
    Dim brush1 As Brush
    Dim polygonPoints(5) As Point
    Dim hatchBrush As Drawing2D.HatchBrush
    Dim TextToDraw As String
    Dim chosenFont As Font
    Dim solidBrush As SolidBrush
    Dim stringFormat As StringFormat

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim surface As Drawing.Graphics = CreateGraphics()
        pen1 = New Pen(Color.BlueViolet, 2)
        drawOptions = 1
        Invalidate()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Select Case drawOptions
            Case 1
                e.Graphics.DrawLine(pen1, 10, 10, 100, 10)
                e.Graphics.DrawLine(pen1, 10, 10, 100, 100)
                e.Graphics.DrawLine(pen1, 10, 100, 100, 10)
                pen1 = New Pen(Color.Red, 5)
                e.Graphics.DrawLine(pen1, 10, 10, 10, 100)
            Case 2
                e.Graphics.DrawRectangle(pen1, rectangle1)
                e.Graphics.FillRectangle(brush1, rectangle1)
            Case 3
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                e.Graphics.DrawEllipse(pen1, rectangle2)
                e.Graphics.FillEllipse(brush1, rectangle2)
            Case 4
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                e.Graphics.DrawEllipse(pen1, rectangle3)
                e.Graphics.FillEllipse(brush1, rectangle3)
            Case 5
                e.Graphics.DrawPolygon(pen1, polygonPoints)
                e.Graphics.FillPolygon(hatchBrush, polygonPoints)
            Case 6
                e.Graphics.DrawString(TextToDraw, chosenFont, solidBrush, 100, 10, stringFormat)
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        drawOptions = 0
        Invalidate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rectangle1 = New Rectangle()
        rectangle1.X = 10
        rectangle1.Y = 10
        rectangle1.Width = 100
        rectangle1.Height = 300
        pen1 = New Pen(Color.Blue, 1)
        brush1 = Brushes.Blue
        drawOptions = 2
        Invalidate()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rectangle2 = New Rectangle(10, 10, 150, 100)
        pen1 = New Pen(Color.DarkBlue, 2)
        brush1 = Brushes.DarkBlue
        drawOptions = 3
        Invalidate()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        rectangle3 = New Rectangle(10, 10, 100, 100)
        pen1 = New Pen(Color.DarkGreen, 2)
        brush1 = Brushes.DarkGreen
        drawOptions = 4
        Invalidate()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        polygonPoints(0) = New Point(50, 150)
        polygonPoints(1) = New Point(20, 65)
        polygonPoints(2) = New Point(100, 10)
        polygonPoints(3) = New Point(175, 65)
        polygonPoints(4) = New Point(150, 150)
        polygonPoints(5) = New Point(50, 150)
        pen1 = New Pen(Color.Black, 2)
        hatchBrush = New Drawing2D.HatchBrush(Drawing2D.HatchStyle.BackwardDiagonal, Color.DarkCyan, Color.Aqua)
        drawOptions = 5
        Invalidate()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextToDraw = "Home and Learn"
        chosenFont = New Font("Aria", 30, FontStyle.Bold)
        solidBrush = New SolidBrush(Color.Purple)
        stringFormat = New StringFormat(StringFormatFlags.DirectionVertical)
        drawOptions = 6
        Invalidate()
    End Sub
End Class
