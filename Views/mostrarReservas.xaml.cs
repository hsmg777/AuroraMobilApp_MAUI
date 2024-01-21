using AuroraApp_MAUI.Models;
using AuroraApp_MAUI.ViewModels;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace AuroraApp_MAUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class mostrarReservas : ContentPage
    {

        private mostrarReservaViewModel _viewModel;
        public mostrarReservas()
        {
            InitializeComponent();
            _viewModel = new mostrarReservaViewModel ();
            BindingContext = _viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadReservasAsync();
        }


    }
    }



