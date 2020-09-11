Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Util
    Public Shared Function GetImageFromUrl(ByVal url As String) As Image
        Dim tClient As WebClient = New WebClient

        Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(url)))
        Return tImage
    End Function

    Public Shared Function ValidateEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")

        Return emailExpression.IsMatch(email)
    End Function
End Class
