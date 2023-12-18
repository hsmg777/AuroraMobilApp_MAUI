using AuroraApp_MAUI.Models;
using AuroraApp_MAUI.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace AuroraApp_MAUI.Views
{
    public partial class MostrarReservas : ContentPage
    {
        public MostrarReservas()
        {
            InitializeComponent();

            // Agregar reservas predeterminadas

            // Establecer el contexto de enlace para la vista
            BindingContext = new mostrarReservaViewModel();
        }

        private void Regresar_Clicked(object sender, EventArgs e)
        {
          Shell.Current.GoToAsync("..");
        }
    }
    }



