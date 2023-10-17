Public Class Project

    Dim pData As HostMap

    Sub New(ByVal host As HostMap)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        pData = host
    End Sub
    Sub New(ByVal _dom As String, ByVal _ip As System.Net.IPAddress)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        pData.domain = _dom
        pData.Ip = _ip
    End Sub

    Private Sub Project_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        projectName.Content = pData.domain
        projectIp.Content = pData.Ip.ToString
    End Sub

    Private Sub editProject(sender As Object, e As RoutedEventArgs)
        Dim projectEdit As New ProjectEdit()
        projectEdit.Show()
    End Sub

    Private Sub openInWeb(sender As Object, e As RoutedEventArgs)
        If pData.domain.Contains("http") Then
            Process.Start(pData.domain)
        Else
            Process.Start("http://" & pData.domain)
        End If

    End Sub
End Class
