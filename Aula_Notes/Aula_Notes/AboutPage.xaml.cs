namespace Aula_Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		//� um m�todo ASS�NCRONO que abre um site (URI)
		await Launcher.OpenAsync("https://www.google.com.br");
	}
}