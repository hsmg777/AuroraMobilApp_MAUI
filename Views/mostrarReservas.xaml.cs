using AuroraApp_MAUI.Models;
using AuroraApp_MAUI.ViewModels;

namespace AuroraApp_MAUI.Views;

public partial class mostrarReservas : ContentPage
{
	public mostrarReservas()
	{
		InitializeComponent();
        BindingContext = new mostrarReservaViewModel();
        
    }
  
    
}