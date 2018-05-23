#  How to obtain a checked appearance name for each radio button in the radio group

<p>This example shows how to get a checked appearance name for each radio button and check the corresponding radio button with the obtained value.</p>
<p>To accomplish this task, call the <strong>GetRadioGroupCheckedAppearanceNames</strong> method using a <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.class"><u>PdfDocumentProcessor</u></a> instance and the field. 
</p>
<p>To obtain interactive form data, call the <a href="https://documentation.devexpress.com/OfficeFileAPI/DevExpress.Pdf.PdfDocumentProcessor.GetFormData.method"><u> PdfDocumentProcessor.GetFormData</u></a> method. To check the "Female" radio button, use the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Pdf.PdfFormData.Value.property"><u>PdfFormData.Value</u></a> property.</p>

<br/>
