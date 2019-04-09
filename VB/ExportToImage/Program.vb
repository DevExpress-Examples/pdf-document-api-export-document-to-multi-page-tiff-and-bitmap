Imports DevExpress.Pdf
Imports System.Drawing

Namespace ExportToImage
	Friend Class Program
		Shared Sub Main(ByVal args() As String)

			Dim largestEdgeLength As Integer = 1000
			Dim pageNumbers() As Integer = { 1, 3, 5 }

			' Create a PDF Document Processor.
			Using processor As New PdfDocumentProcessor()

				' Load a document. 
				processor.LoadDocument("..\..\Document.pdf")

				' Export pages to a multi-page tiff image.
				processor.CreateTiff("..\..\Image.tiff", largestEdgeLength, pageNumbers)

				For i As Integer = 1 To processor.Document.Pages.Count

					' Export pages to bitmaps.
					Dim image As Bitmap = processor.CreateBitmap(i, largestEdgeLength)

					' Save the bitmaps.
					image.Save("..\..\MyBitmap" & i & ".bmp")
				Next i
			End Using
		End Sub
	End Class
End Namespace


