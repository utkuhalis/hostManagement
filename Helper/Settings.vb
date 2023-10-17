Imports System.Web.Script.Serialization

Public Class Settings

    Public setting
    Sub load()

        If System.IO.File.Exists(Environment.CurrentDirectory & "\\settings.json") Then
            Dim FileStream As New System.IO.StreamReader(Environment.CurrentDirectory & "\\settings.json")
            setting = FileStream.ReadToEnd()
        Else
            MsgBox("settings.json not found", MsgBoxStyle.Information)
        End If
    End Sub

    Public Function _get(ByVal key As String)
        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(setting)

        Try
            Return dict(key)
        Catch ex As Exception
            Return "Key Not Found::" & key
        End Try


    End Function

End Class
