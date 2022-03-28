Public Class Pentagon
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim points(4) As Point
    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            points(0) = New Point(m_a.X, m_a.Y)
            points(1) = New Point(m_a.X, m_a.Y + 50)
            points(3) = New Point(m_a.X + 50, m_a.Y)
            points(2) = New Point(m_a.X + 50, m_a.Y + 50)
            points(4) = New Point(m_a.X + 25, m_a.Y + 25)
            g.DrawPolygon(Pen, points)
        End Using

    End Sub
End Class
