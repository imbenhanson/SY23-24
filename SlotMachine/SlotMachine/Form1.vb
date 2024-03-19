Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reelcontrol21.spin()
        Timer1.Enabled = True
        Reelcontrol22.spin()
        Reelcontrol23.spin()
        Label1.Text = Reelcontrol21.itemValue
        Label2.Text = Reelcontrol22.itemValue
        Label3.Text = Reelcontrol23.itemValue
        cs.spin()
        Label4.Text = cs.total.ToString("c2")
    End Sub
    Dim WithEvents cs As New coinslot
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertnickel()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdime()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarter()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdollar()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cs.coinreturn()
        Label4.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = cs.total.ToString("c2")
        Label1.Text = Reelcontrol21.itemValue
        Label2.Text = Reelcontrol22.itemValue
        Label3.Text = Reelcontrol23.itemValue
    End Sub
End Class
