using Mopups.Services;


namespace Printing;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new PrintView());
    }
}

