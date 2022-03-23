Public Class Form1
    Private m_Previous As System.Nullable(Of Point) = Nothing
    Dim m_shapes As New Collection
    Dim c As Color
    Dim t As Integer
    Dim type As String


    Private Sub pictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        m_Previous = e.Location
        pictureBox1_MouseMove(sender, e)
    End Sub

    Private Sub pictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If m_Previous IsNot Nothing Then
            Dim d As Object

            If type = "Line" Then
                d = New Line(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, t)
            End If
            If type = "Rectangle" Then
                d = New MyRec(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, t)
            End If
            If type = "Circle" Then
                d = New Circle(PictureBox1.Image, m_Previous, e.Location)
                d.Pen = New Pen(c, t)
            End If
            m_shapes.Add(d)
            PictureBox1.Invalidate()
            m_Previous = e.Location
        End If
    End Sub

    Private Sub pictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        m_Previous = Nothing
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PictureBox1.Image Is Nothing Then
            Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.Clear(Color.White)
            End Using
            PictureBox1.Image = bmp
        End If

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        For Each s As Object In m_shapes
            s.Draw()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Button1.BackColor = c

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = sender.backcolor
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = sender.backcolor
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        t = TrackBar1.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = sender.backcolor
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = sender.backcolor
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        type = "Line"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        type = "Rectangle"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        c = sender.backcolor
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        c = sender.backcolor
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        c = sender.backcolor
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        type = "Circle"
    End Sub
End Class
