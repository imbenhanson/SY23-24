Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim D As Integer
        Dim M As Integer
        M = cal1.SelectedDate.Value.Month
        D = cal1.SelectedDate.Value.Day
        If M = 3 And D > 20 Or M = 4 And D < 20 Then
            label1.Content = "Aries"
            ariespic.Visibility = Visibility.Visible
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
        End If
        If M = 4 And D > 19 Or M = 5 And D < 21 Then
            label1.Content = "Taurus"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Visible
            geminipic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
        End If
        If M = 5 And D > 20 Or M = 6 And D < 21 Then
            label1.Content = "Gemini"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Visible
            cancerpic.Visibility = Visibility.Collapsed
        End If
        If M = 6 And D > 20 Or M = 7 And D < 23 Then
            label1.Content = "Cancer"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Visible
        End If
        If M = 7 And D > 22 Or M = 8 And D < 23 Then
            label1.Content = "Leo"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
        End If
        If M = 8 And D > 22 Or M = 9 And D < 23 Then
            label1.Content = "Virgo"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
        End If
        If M = 9 And D > 22 Or M = 10 And D < 23 Then
            label1.Content = "Libra"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed
        End If
        If M = 10 And D > 22 Or M = 11 And D < 22 Then
            label1.Content = "Scorpio"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
            cancerpic.Visibility = Visibility.Collapsed


        End If
        If M = 11 And D > 22 Or M = 12 And D < 20 Then
            label1.Content = "Sagittarius"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
        End If
        If M = 12 And D > 21 Or M = 1 And D < 20 Then
            label1.Content = "Capricorn"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
        End If
        If M = 1 And D > 19 Or M = 2 And D < 19 Then
            label1.Content = "Aquarius"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
        End If
        If M = 2 And D > 18 Or M = 3 And D < 21 Then
            label1.Content = "Pisces"
            ariespic.Visibility = Visibility.Collapsed
            tauruspic.Visibility = Visibility.Collapsed
            geminipic.Visibility = Visibility.Collapsed
        End If
    End Sub
End Class
