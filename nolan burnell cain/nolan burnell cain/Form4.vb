Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f3 As New Form3
        f3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        total += 149.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        total = 0
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        total += 149.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        total += 149.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        total += 49.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        total += 49.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        total += 159.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        total += 69.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        total += 14.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        total += 59.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        total += 5.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        total += 9.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        total += 449.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        total += 449.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        total += 1499.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        total += 200.0
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        total += 999.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        total += 749.99
        MoneyTextBox.Text = total.ToString("C2")
    End Sub
End Class