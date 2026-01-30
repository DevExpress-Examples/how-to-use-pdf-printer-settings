Imports System.Drawing.Printing
Imports System.Windows
Imports DevExpress.Pdf

Namespace SpecifyPrinterSettings

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            ' Load a PDF document.
            Me.pdfViewer.OpenDocument("..\..\Demo.pdf")
        End Sub

        Private Sub pdfViewer_DocumentLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ' If required, declare and specify the system printer settings.
            Dim printerSettings As PrinterSettings = New PrinterSettings()
            printerSettings.PrinterName = "Microsoft XPS Document Writer"
            printerSettings.PrintToFile = True
            printerSettings.PrintFileName = "..\..\Demo.xps"
            ' Declare the PDF printer settings.
            ' If required, pass the system settings to the PDF printer settings constructor.
            Dim pdfPrinterSettings As PdfPrinterSettings = New PdfPrinterSettings(printerSettings)
            ' Specify the PDF printer settings.
            pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Auto
            pdfPrinterSettings.PageNumbers = New Integer() {1, 3, 4, 5}
            pdfPrinterSettings.ScaleMode = PdfPrintScaleMode.CustomScale
            pdfPrinterSettings.Scale = 90
            ' Print the document using the specified printer settings.            
            Me.pdfViewer.Print(pdfPrinterSettings, True)
        End Sub
    End Class
End Namespace
