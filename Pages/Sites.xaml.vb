Class Sites
    Private Sub Sites_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim WindowsHostSession As New WindowsHost()

        For Each host As HostMap In WindowsHostSession.Items
            If host.domain.Contains("localhost") Then
                Dim project As New Project(host)
                siteList.Children.Add(project)
            End If
        Next
    End Sub

    Private Sub addNewSite(sender As Object, e As RoutedEventArgs)
        Dim newProject As New ProjectEdit()
        newProject.Show()
    End Sub
End Class
