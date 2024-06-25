<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/180365435/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830435)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
#  PDF Document API - Export a PDF Document to Multi-Page Tiff and Bitmap Images 
<p>To accomplish this task:</p>

<p>Create a <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.class"><u>PdfDocumentProcessor</u></a> instance and load the required PDF document using the overloaded <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.LoadDocument.method(miP5YA)"><u>PdfDocumentProcessor.LoadDocument </u></a> method.</p>

<p>To export a page to a bitmap image, call the <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.CreateBitmap.method"><u>PdfDocumentProcessor.CreateBitmap</u></a> method using the page number and the <strong>largestEdgeLength</strong> parameter measured in pixels. The latter parameter determines the output image height for pages in the portrait orientation and width - for landscape pages.</p>
  
<p>To export a page to a multi-page tiff image, call one of the <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.CreateTiff.overloads"><u>PdfDocumentProcessor.CreateTiff</u></a> overloaded methods using, for example, the file path where the converted image will be located, the <strong>largestEdgeLength</strong> parameter measured in pixels and page numbers.</p>
<br/>
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-export-document-to-multi-page-tiff-and-bitmap&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=pdf-document-api-export-document-to-multi-page-tiff-and-bitmap&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
