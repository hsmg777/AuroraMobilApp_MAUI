using AuroraApp_MAUI.ViewModels;

namespace AuroraApp_MAUI.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class MenuReservas : ContentPage
{
    private FIestasViewModel _viewModel;
    public MenuReservas()
	{
		InitializeComponent();
        _viewModel = new FIestasViewModel();
        BindingContext = _viewModel;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadPartysAsync();
    }
    private void Reservar_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ReservaPage));
    }
}