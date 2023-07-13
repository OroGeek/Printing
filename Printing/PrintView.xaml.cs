using System.Drawing;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace Printing;

public partial class PrintView
{
    PrintDocument printDocument;

    public PrintView()
    {
        InitializeComponent();
    }
    public void Print()
    {

        List<string> PrinterFound = new List<string>();

        foreach (var item in PrinterSettings.InstalledPrinters)
        {
            PrinterFound.Add(item.ToString());
        }

        //string name = "\\barcode.pdf";

        //string path  = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + name;

        printDocument = new PrintDocument();


        printDocument.DefaultPageSettings.PrinterSettings.PrinterName = "Xprinter XP-350B";
        printDocument.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
        printDocument.DefaultPageSettings.Landscape = true;

        printDocument.PrintPage += PrintDocument_PrintPage;

        printDocument.Print();
    }

    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/barcode.gif";
        System.Drawing.Image image = System.Drawing.Image.FromFile(path);
        e.Graphics.DrawImage(image, 3.5f, 4.5f);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Print();
    }
}