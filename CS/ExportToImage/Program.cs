using DevExpress.Pdf;
using System.Drawing;

namespace ExportToImage {
    class Program {
        static void Main(string[] args) {

            int largestEdgeLength = 1000;
            int[] pageNumbers = new int[] { 1, 3, 5 };

            // Create a PDF Document Processor.
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a document. 
                processor.LoadDocument("..\\..\\Document.pdf");

                // Export pages to a multi-page tiff image.
                processor.CreateTiff("..\\..\\Image.tiff", largestEdgeLength, pageNumbers);

                for (int i = 1; i <= processor.Document.Pages.Count; i++) {

                    // Export pages to bitmaps.
                    Bitmap image = processor.CreateBitmap(i, largestEdgeLength);

                    // Save the bitmaps.
                    image.Save("..\\..\\MyBitmap" + i + ".bmp");
                }
            }
        }
    }
}


