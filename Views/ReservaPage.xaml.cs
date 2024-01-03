
using AuroraApp_MAUI.ViewModels;

namespace AuroraApp_MAUI.Views
{
    public partial class ReservaPage : ContentPage
    {
        public ReservaPage()
        {
            InitializeComponent();
            BindingContext = new ReservasPageViewModel(); 
        }
        private void Regresar_Clicked(object sender, EventArgs e)
        {
            
          Shell.Current.GoToAsync("..");
            
        }

        
    }
}









