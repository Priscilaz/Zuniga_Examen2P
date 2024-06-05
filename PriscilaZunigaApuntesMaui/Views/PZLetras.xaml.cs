namespace PriscilaZunigaApuntesMaui;

public partial class PZLetras : ContentPage
{
	public PZLetras()
	{
		InitializeComponent();
	}

    

    private async void Send_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.PZLetra letras)
        {
            // Navigate to the specified URL in the system browser.
            await Launcher.Default.OpenAsync(letras.MoreInfoUrl);
        }
    }
}