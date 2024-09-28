namespace AppNav2.Vistas;

public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}
    private async void IdentificarseBtn(object sender, EventArgs e)
    {
        var InicioPage = new Aplicacion();

        // Envolver la página en un NavigationPage para mantener el header
        var navPage = new NavigationPage(InicioPage);

        // Navegar de manera modal
        await Navigation.PushModalAsync(navPage);
    }
}