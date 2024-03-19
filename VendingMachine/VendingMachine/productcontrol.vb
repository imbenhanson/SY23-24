Public Class productcontrol

    Public Property productcount As Integer
    Public Property productid As String
    Public Property productprice As Decimal
    Public Property productpicture As Image

    Private Sub productcontrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = productid
        PriceLabel.Text = productprice.ToString("c2")
        PictureBox1.Image = productpicture
    End Sub
    Sub Buy()
        If productcount > 0 Then
            productcount = productcount - 1
        End If
        If productcount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
