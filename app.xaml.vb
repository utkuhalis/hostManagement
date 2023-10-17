Class app
    Public settings As New Settings
    Public xampp As New XamppConfig

    Private Sub goWelcome(sender As Object, e As RoutedEventArgs)
        pageView.Navigate(New Welcome())
    End Sub

    Private Sub goSites(sender As Object, e As RoutedEventArgs)
        pageView.Navigate(New Sites())
    End Sub

    Private Sub goSettings(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        settings.load()
        xampp.load(settings._get("xampp") & settings._get("vhosts"))

        MsgBox(xampp._getAll())
    End Sub
End Class
