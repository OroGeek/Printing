using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Printing;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		PdfDocument pdf = new PdfDocument(new PdfWriter(path + "/facture.pdf"));
		Document document = new Document(pdf);
		string line = "Hello World";
		document.Add(new Paragraph(line));
		document.Close();

		DisplayAlert("Success", "Document Created", "OK"); 
    }
}

