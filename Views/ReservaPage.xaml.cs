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
  
    private void Reserva_clicked(object sender, EventArgs e)
    {
        DisplayAlert("AURORA RESERVAS", "Tu reserva se ha realizado con exito", "Aceptar");
    }
}