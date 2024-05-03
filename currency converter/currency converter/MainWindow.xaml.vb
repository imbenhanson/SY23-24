Class MainWindow
    Dim US As Decimal
    Dim Conv As Decimal

    Private Sub USD_TextChanged(sender As Object, e As TextChangedEventArgs) Handles USD.TextChanged
        Decimal.TryParse(USD.Text, US)

    End Sub

    Private Sub Euros_Checked(sender As Object, e As RoutedEventArgs) Handles Euros.Checked

        If Decimal.TryParse(US, Conv) = True Then
            Conv = US * 0.93
            ConvertedMoney.Text = Conv

        End If
        europic.Visibility = Visibility.Visible
        poundspic.Visibility = Visibility.Collapsed
        pesospic.Visibility = Visibility.Collapsed
        rupeespic.Visibility = Visibility.Collapsed
        yenpic.Visibility = Visibility.Collapsed
        yuanpic.Visibility = Visibility.Collapsed
    End Sub

    Private Sub Pounds_Checked(sender As Object, e As RoutedEventArgs) Handles Pounds.Checked
        If Decimal.TryParse(US, Conv) = True Then
            Conv = US * 0.8
            ConvertedMoney.Text = Conv

        End If
        europic.Visibility = Visibility.Collapsed
        poundspic.Visibility = Visibility.Visible
        pesospic.Visibility = Visibility.Collapsed
        rupeespic.Visibility = Visibility.Collapsed
        yenpic.Visibility = Visibility.Collapsed
        yuanpic.Visibility = Visibility.Collapsed
    End Sub

    Private Sub Pesos_Checked(sender As Object, e As RoutedEventArgs) Handles Pesos.Checked
        If Decimal.TryParse(US, Conv) = True Then
            Conv = US * 17.13
            ConvertedMoney.Text = Conv

        End If
        europic.Visibility = Visibility.Collapsed
        poundspic.Visibility = Visibility.Collapsed
        pesospic.Visibility = Visibility.Visible
        rupeespic.Visibility = Visibility.Collapsed
        yenpic.Visibility = Visibility.Collapsed
        yuanpic.Visibility = Visibility.Collapsed
    End Sub

    Private Sub Rupees_Checked(sender As Object, e As RoutedEventArgs) Handles Rupees.Checked
        If Decimal.TryParse(US, Conv) = True Then
            Conv = US * 83.35
            ConvertedMoney.Text = Conv

        End If
        europic.Visibility = Visibility.Collapsed
        poundspic.Visibility = Visibility.Collapsed
        pesospic.Visibility = Visibility.Collapsed
        rupeespic.Visibility = Visibility.Visible
        yenpic.Visibility = Visibility.Collapsed
        yuanpic.Visibility = Visibility.Collapsed
    End Sub

    Private Sub Yen_Checked(sender As Object, e As RoutedEventArgs) Handles Yen.Checked
        If Decimal.TryParse(US, Conv) = True Then
            Conv = US * 155.07
            ConvertedMoney.Text = Conv

        End If
        europic.Visibility = Visibility.Collapsed
        poundspic.Visibility = Visibility.Collapsed
        pesospic.Visibility = Visibility.Collapsed
        rupeespic.Visibility = Visibility.Collapsed
        yenpic.Visibility = Visibility.Visible
        yuanpic.Visibility = Visibility.Collapsed
    End Sub

    Private Sub yuan_Checked(sender As Object, e As RoutedEventArgs) Handles yuan.Checked
        If Decimal.TryParse(US, Conv) = True Then
            Conv = US * 7.25
            ConvertedMoney.Text = Conv

        End If
        europic.Visibility = Visibility.Collapsed
        poundspic.Visibility = Visibility.Collapsed
        pesospic.Visibility = Visibility.Collapsed
        rupeespic.Visibility = Visibility.Collapsed
        yenpic.Visibility = Visibility.Collapsed
        yuanpic.Visibility = Visibility.Visible
    End Sub

    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        USD.Text = "0"
        ConvertedMoney.Text = "0"
        US = "0"
        Conv = "0"
        europic.Visibility = Visibility.Collapsed
        poundspic.Visibility = Visibility.Collapsed
        pesospic.Visibility = Visibility.Collapsed
        rupeespic.Visibility = Visibility.Collapsed
        yenpic.Visibility = Visibility.Collapsed
        yuanpic.Visibility = Visibility.Collapsed
    End Sub
End Class
