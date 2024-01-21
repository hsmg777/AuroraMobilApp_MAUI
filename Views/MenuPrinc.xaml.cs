using AuroraApp_MAUI.ViewModels;
using Microsoft.Maui;
using System;
using System.Threading.Tasks;


namespace AuroraApp_MAUI.Views
{
    public partial class MenuPrinc : ContentPage
    {
        private mostrarReservaViewModel reservationListViewModel;
       
        public MenuPrinc()
        {
            InitializeComponent();
            reservationListViewModel = new mostrarReservaViewModel();
        }

       

        private void Regresar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("..");
        }

        private void verReservas_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(mostrarReservas));
        }

        private void Actualizar_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(MenuReservas));
        }
    }

}
