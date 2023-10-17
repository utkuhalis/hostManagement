Public Class XamppConfig
    Dim vhosts

    Sub load(ByVal vhostsPath As String)
        If System.IO.File.Exists(vhostsPath) Then
            Dim FileStream As New System.IO.StreamReader(vhostsPath)
            Dim Lines() As String = FileStream.ReadToEnd.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            FileStream.Close()

            For Each line As String In Lines
                If Not line.Contains("#") And line.Length > 1 Then
                    vhosts &= line & vbNewLine
                End If
            Next
        Else
            MsgBox("vhosts not found", MsgBoxStyle.Information)
        End If
    End Sub

    Function _getAll()
        Return vhosts
    End Function
End Class
