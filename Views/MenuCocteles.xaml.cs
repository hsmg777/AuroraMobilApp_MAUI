namespace AuroraApp_MAUI.Views;

using AuroraApp_MAUI.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;

public partial class MenuCocteles : ContentPage
{
	public MenuCocteles()
	{
		InitializeComponent();
	}

    public async void verCocteles_Clicked(object sender, EventArgs e)
    {
        
       
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://the-cocktail-db3.p.rapidapi.com/"),
            Headers =
    {
        { "X-RapidAPI-Key", "ca2de54915msh47c6f73f1c96837p100833jsnfdecc09caff8" },
        { "X-RapidAPI-Host", "the-cocktail-db3.p.rapidapi.com" },
    },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var cocteles = JsonConvert.DeserializeObject<List<Cocteles>>(body);

            
            for (int i = 0; i <= cocteles.Count; i++) {
                switch (i)
                {
                    case 0:
                        coctel1.Text = cocteles[i].title;
                        idcoctel1.Text = cocteles[i].id;
                        imagen1.Source = cocteles[i].image;
                        break;
                    case 1:
                        coctel2.Text = cocteles[i].title;
                        idcoctel2.Text = cocteles[i].id;
                        imagen2.Source = cocteles[i].image;

                        break;
                    case 2:
                        coctel3.Text = cocteles[i].title;
                        idcoctel3.Text = cocteles[i].id;
                        imagen3.Source = cocteles[i].image;
                        break;
                    case 3:
                        coctel4.Text = cocteles[i].title;
                        idcoctel4.Text = cocteles[i].id;
                        imagen4.Source = cocteles[i].image;
                        break;
                    case 4:
                        coctel5.Text = cocteles[i].title;
                        idcoctel5.Text = cocteles[i].id;
                        imagen5.Source = cocteles[i].image;
                        break;
                    case 5:
                        coctel6.Text = cocteles[i].title;
                        idcoctel6.Text = cocteles[i].id;
                        imagen6.Source = cocteles[i].image;
                        break;
                    case 6:
                        coctel7.Text = cocteles[i].title;
                        idcoctel7.Text = cocteles[i].id;
                        imagen7.Source = cocteles[i].image;
                        break;
                    case 7:
                        coctel8.Text = cocteles[i].title;
                        idcoctel8.Text = cocteles[i].id;
                        imagen8.Source = cocteles[i].image;
                        break;
                    case 8:
                        coctel9.Text = cocteles[i].title;
                        idcoctel9.Text = cocteles[i].id;
                        imagen9.Source = cocteles[i].image;
                        break;
                    case 9:
                        coctel10.Text = cocteles[i].title;
                        idcoctel10.Text = cocteles[i].id;
                        imagen10.Source = cocteles[i].image;
                        break;
                    case 10:
                        coctel11.Text = cocteles[i].title;
                        idcoctel11.Text = cocteles[i].id;
                        imagen11.Source = cocteles[i].image;
                        break;
                    case 11:
                        coctel12.Text = cocteles[i].title;
                        idcoctel12.Text = cocteles[i].id;
                        imagen12.Source = cocteles[i].image;
                        break;
                    case 12:
                        coctel13.Text = cocteles[i].title;
                        idcoctel13.Text = cocteles[i].id;
                        imagen13.Source = cocteles[i].image;
                        break;
                    case 13:
                        coctel14.Text = cocteles[i].title;
                        idcoctel14.Text = cocteles[i].id;
                        imagen14.Source = cocteles[i].image;
                        break;
                    case 14:
                        coctel15.Text = cocteles[i].title;
                        idcoctel15.Text = cocteles[i].id;
                        imagen15.Source = cocteles[i].image;
                        break;

                }
            }




        }
    }

    private void cotizar_clicked(object sender, EventArgs e)
    {

        string nombreC = coctel1.Text;
        string idCoctel = idcoctel1.Text;
        string ima = imagen1.Source.ToString();
        string nombreRese = nombreReserva.Text;
        cotizacion coti = new cotizacion() {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);  
        DisplayAlert("RESERVA COCTEL",$"Se ha realizado la reserva del coctel a nombre de {nombreRese}","ACEPTAR");

        nombreReserva.Text = null;
    }

    private void cotizar_clicked2(object sender, EventArgs e)
    {
        string nombreC = coctel2.Text;
        string idCoctel = idcoctel2.Text;
        string ima = imagen2.Source.ToString();
        string nombreRese = nombreReserva2.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva2.Text = null;
    }

    private void cotizar_clicked3(object sender, EventArgs e)
    {
        string nombreC = coctel3.Text;
        string idCoctel = idcoctel3.Text;
        string ima = imagen3.Source.ToString();
        string nombreRese = nombreReserva3.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva3.Text = null;
    }

    private void cotizar_clicked4(object sender, EventArgs e)
    {
        string nombreC = coctel4.Text;
        string idCoctel = idcoctel4.Text;
        string ima = imagen4.Source.ToString();
        string nombreRese = nombreReserva4.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva4.Text = null;
    }

    private void cotizar_clicked5(object sender, EventArgs e)
    {
        string nombreC = coctel5.Text;
        string idCoctel = idcoctel5.Text;
        string ima = imagen5.Source.ToString();
        string nombreRese = nombreReserva5.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva5.Text = null;
    }

    private void cotizar_clicked6(object sender, EventArgs e)
    {
        string nombreC = coctel6.Text;
        string idCoctel = idcoctel6.Text;
        string ima = imagen6.Source.ToString();
        string nombreRese = nombreReserva6.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva6.Text = null;
    }

    private void cotizar_clicked7(object sender, EventArgs e)
    {
        string nombreC = coctel7.Text;
        string idCoctel = idcoctel7.Text;
        string ima = imagen7.Source.ToString();
        string nombreRese = nombreReserva7.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva7.Text = null;
    }

    private void cotizar_clicked8(object sender, EventArgs e)
    {
        string nombreC = coctel8.Text;
        string idCoctel = idcoctel8.Text;
        string ima = imagen8.Source.ToString();
        string nombreRese = nombreReserva8.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva8.Text = null;
    }

    private void cotizar_clicked9(object sender, EventArgs e)
    {
        string nombreC = coctel9.Text;
        string idCoctel = idcoctel9.Text;
        string ima = imagen9.Source.ToString();
        string nombreRese = nombreReserva9.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva9.Text = null;
    }

    private void cotizar_clicked10(object sender, EventArgs e)
    {
        string nombreC = coctel10.Text;
        string idCoctel = idcoctel10.Text;
        string ima = imagen10.Source.ToString();
        string nombreRese = nombreReserva10.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva10.Text = null;
    }

    private void cotizar_clicked11(object sender, EventArgs e)
    {
        string nombreC = coctel11.Text;
        string idCoctel = idcoctel11.Text;
        string ima = imagen11.Source.ToString();
        string nombreRese = nombreReserva11.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");

        nombreReserva11.Text = null;
    }

    private void cotizar_clicked12(object sender, EventArgs e)
    {
        string nombreC = coctel12.Text;
        string idCoctel = idcoctel12.Text;
        string ima = imagen12.Source.ToString();
        string nombreRese = nombreReserva12.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva12.Text = null;
    }

    private void cotizar_clicked13(object sender, EventArgs e)
    {
        string nombreC = coctel13.Text;
        string idCoctel = idcoctel13.Text;
        string ima = imagen13.Source.ToString();
        string nombreRese = nombreReserva13.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva13.Text = null;
    }

    private void cotizar_clicked14(object sender, EventArgs e)
    {
        string nombreC = coctel14.Text;
        string idCoctel = idcoctel14.Text;
        string ima = imagen14.Source.ToString();
        string nombreRese = nombreReserva14.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva14.Text = null;
    }

    private void cotizar_clicked15(object sender, EventArgs e)
    {
        string nombreC = coctel15.Text;
        string idCoctel = idcoctel15.Text;
        string ima = imagen15.Source.ToString();
        string nombreRese = nombreReserva15.Text;
        cotizacion coti = new cotizacion()
        {
            nombreCoctel = nombreC,
            imagen = ima,
            nombreReserva = nombreRese

        };
        App.cotiRepo.AddorUpdate(coti);
        DisplayAlert("RESERVA COCTEL", $"Se ha realizado la reserva del coctel a nombre de {nombreRese}", "ACEPTAR");
        nombreReserva15.Text = null;
    }
}