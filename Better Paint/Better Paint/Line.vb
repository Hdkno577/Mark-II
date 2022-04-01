Public Class Line
    Public Property xSpeed As Integer
    Public Property ySpeed As Integer
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim xOffset As Integer
    Dim yOffset As Integer

    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            xOffset += xSpeed
            yOffset += ySpeed
            g.DrawLine(Pen, m_a.X + xOffset, m_a.Y + yOffset, m_b.X + xOffset, m_b.Y + yOffset)
        End Using

    End Sub

End Class

