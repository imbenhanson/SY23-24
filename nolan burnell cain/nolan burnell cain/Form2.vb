Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f1 As New Form1
        f1.ShowDialog()
        Me.Show()
    End Sub
End Class