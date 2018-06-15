using System.Drawing.Printing;
using System.Windows;
using DevExpress.Pdf;

namespace SpecifyPrinterSettings {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            // Load a PDF document.
            pdfViewer.OpenDocument(@"..\..\Demo.pdf");
        }

        private void pdfViewer_DocumentLoaded(object sender, RoutedEventArgs e) {
            // If required, declare and specify the system printer settings.
            PrinterSettings printerSettings = new PrinterSettings();
            printerSettings.PrinterName = "Microsoft XPS Document Writer";
            printerSettings.PrintToFile = true;
            printerSettings.PrintFileName = @"..\..\Demo.xps";

            // Declare the PDF printer settings.
            // If required, pass the system settings to the PDF printer settings constructor.
            PdfPrinterSettings pdfPrinterSettings = new PdfPrinterSettings(printerSettings);

            // Specify the PDF printer settings.
            pdfPrinterSettings.PageOrientation = PdfPrintPageOrientation.Auto;
            pdfPrinterSettings.PageNumbers = new int[] { 1, 3, 4, 5 };
            pdfPrinterSettings.ScaleMode = PdfPrintScaleMode.CustomScale;
            pdfPrinterSettings.Scale = 90;

            // Print the document using the specified printer settings.            
            pdfViewer.Print(pdfPrinterSettings);
        }
    }
}
