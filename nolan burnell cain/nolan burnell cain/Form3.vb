Public Class Form3
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Hide()
        Dim f4 As New Form4
        f4.ShowDialog()
        Me.Show()
    End Sub
End Class