Public Class N_Gon
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Public Property s As Integer
    Public Property r As Integer


    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b

    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            Dim points(s - 1) As Point

            For index = 0 To s - 1
                Dim x As Integer
                Dim y As Integer
                y = Math.Sin(index * (2 * Math.PI / s)) * r
                x = Math.Cos(index * (2 * Math.PI / s)) * r
                points(index) = New Point(m_a.X + x, m_a.Y + y)
            Next

            g.DrawPolygon(Pen, points)
        End Using
    End Sub
End Class
