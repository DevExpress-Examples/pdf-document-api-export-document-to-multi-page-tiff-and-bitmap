using DevExpress.Drawing;
using DevExpress.Pdf;
using System.Diagnostics;

namespace ExportToImage
{
    class Program
    {
        static void Main(string[] args)
        {

            int largestEdgeLength = 1000;
            int[] pageNumbers = new int[] { 1, 3, 5 };

            // Create a PDF Document Processor.
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor())
            {

                // Load a document.
                processor.LoadDocument("Document.pdf");

                // Export pages to a multi-page tiff image.
                processor.CreateTiff("Image.tiff", pageNumbers, 96);

                for (int i = 1; i <= processor.Document.Pages.Count; i++)
                {

                    // Export pages to bitmaps.
                    DXImage image = processor.CreateDXBitmap(i, largestEdgeLength);

                    // Save the bitmaps.
                    image.Save("MyBitmap" + i + ".bmp", DXImageFormat.Bmp);
                }

                PdfPageRenderingParameters renderingParameters = PdfPageRenderingParameters.CreateWithResolution(72f);
                // Export pages to SVGs
                DXImage svgImage = processor.CreateSvgImage(pageNumbers[0], renderingParameters);

                // Save the images
                svgImage.Save("MySvg", DXImageFormat.Svg);
            }
            Process.Start(new ProcessStartInfo("Image.tiff") { UseShellExecute = true });
        }
    }
}



