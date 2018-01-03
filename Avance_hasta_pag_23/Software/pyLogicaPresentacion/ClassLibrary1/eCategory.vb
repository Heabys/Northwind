Imports System.IO
Imports System.Drawing
Public Class eCategory
    Public Class eCategory

        Public Property CategorylD As Integer

        Public Property CategoryName As String

        Public Property Description As String

        Public Property Picture As Byte()


        Public Property PictureDPG As Image
            Set(value As Image)
                Dim ms As New MemoryStream()
                value.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Picture = ms.GetBuffer()

            End Set
            Get
                Dim ms As New MemoryStream(Picture)
                Return Image.FromStream(ms)
            End Get
        End Property
    End Class
End Class
