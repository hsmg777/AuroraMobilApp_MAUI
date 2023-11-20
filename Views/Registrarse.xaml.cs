namespace AuroraApp_MAUI.Views;

public partial class Registrarse : ContentPage
{
	public Registrarse()
	{
		InitializeComponent();
	}
    private void Regresar_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}