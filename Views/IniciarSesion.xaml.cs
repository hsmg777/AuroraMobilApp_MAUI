namespace AuroraApp_MAUI.Views;

public partial class IniciarSesion : ContentPage
{
	public IniciarSesion()
	{
		InitializeComponent();
	}
	private void Regresar_Clicked(object sender, EventArgs e) {
		Shell.Current.GoToAsync("..");
	}
	private void Ingresar_Clicked(object sender, EventArgs e) {
		Shell.Current.GoToAsync(nameof(MenuPrinc));
	}
}