Imports DevExpress.Drawing
Imports DevExpress.Pdf

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
				processor.CreateTiff("..\..\Image.tiff", pageNumbers, 96)

				For i As Integer = 1 To processor.Document.Pages.Count

					' Export pages to bitmaps.
					Dim image As DXImage = processor.CreateDXBitmap(i, largestEdgeLength)

					' Save the bitmaps.
					image.Save("..\..\MyBitmap" & i & ".bmp", DXImageFormat.Bmp)
				Next i

				Dim renderingParameters As PdfPageRenderingParameters = PdfPageRenderingParameters.CreateWithResolution(72F)
				' Export pages to SVGs
				Dim svgImage As DXImage = processor.CreateSvgImage(pageNumbers(0), renderingParameters)

				' Save the images
				svgImage.Save("..\..\MySvg", DXImageFormat.Svg)
			End Using
		End Sub
	End Class
End Namespace



