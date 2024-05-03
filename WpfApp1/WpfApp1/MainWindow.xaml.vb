Class MainWindow
    Private Sub ccnum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ccnum.TextChanged
        If Not paybutton Is Nothing Then
            If ccnum.Text Like "###" Then
                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub email_TextChanged(sender As Object, e As TextChangedEventArgs) Handles email.TextChanged
        If Not paybutton Is Nothing Then
            If email.Text Like "*@*.*" Then
                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub holdname_TextChanged(sender As Object, e As TextChangedEventArgs) Handles holdname.TextChanged
        If Not paybutton Is Nothing Then
            If holdname.Text Like "*" Then
                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub expdate_TextChanged(sender As Object, e As TextChangedEventArgs) Handles expdate.TextChanged
        If Not paybutton Is Nothing Then
            If expdate.Text Like "##/##" Then
                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub phone_TextChanged(sender As Object, e As TextChangedEventArgs) Handles phone.TextChanged
        If Not paybutton Is Nothing Then
            If phone.Text Like "###-###-####" Then
                paybutton.IsEnabled = True
            Else
                paybutton.IsEnabled = False
            End If
        End If
    End Sub

    Private Sub paybutton_Click(sender As Object, e As RoutedEventArgs) Handles paybutton.Click
        phone.Text = ""
        email.Text = ""
        expdate.Text = ""
        holdname.Text = ""
        ccnum.Text = ""
    End Sub
End Class
