using AuroraApp_MAUI.ViewModels;

namespace AuroraApp_MAUI.Views;

public partial class misCoctelesViews : ContentPage
{
	public misCoctelesViews()
	{
		InitializeComponent();
		BindingContext = new verCoctelesViewModel();
	}
}