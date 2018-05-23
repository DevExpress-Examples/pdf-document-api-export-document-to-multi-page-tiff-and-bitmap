#  How to export a PDF document to a multi-page tiff and bitmap images 
<p>To accomplish this task:</p>

<p>Create a <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.class"><u>PdfDocumentProcessor</u></a> instance and load the required PDF document using the overloaded <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.LoadDocument.method(miP5YA)"><u>PdfDocumentProcessor.LoadDocument </u></a> method.</p>

<p>To export a page to a bitmap image, call the <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.CreateBitmap.method"><u>PdfDocumentProcessor.CreateBitmap</u></a> method using the page number and the <strong>largestEdgeLength</strong> parameter measured in pixels. The latter parameter determines the output image height for pages in the portrait orientation and width - for landscape pages.</p>
  
<p>To export a page to a multi-page tiff image, call one of the <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.CreateTiff.overloads"><u>PdfDocumentProcessor.CreateTiff</u></a> overloaded methods using, for example, the file path where the converted image will be located, the <strong>largestEdgeLength</strong> parameter measured in pixels and page numbers.</p>
<br/>
