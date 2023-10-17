Class Welcome
    Private Sub Welcome_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim WindowsHostSession As New WindowsHost()
        welcomeText.Content = String.Format("Total {0} project loaded", WindowsHostSession.Items.Count)
    End Sub
End Class
