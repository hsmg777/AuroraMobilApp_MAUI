namespace AuroraApp_MAUI.Views;

public partial class ReservaPage : ContentPage
{
	public ReservaPage()
	{
		InitializeComponent();
	}
    private void Regresar_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}