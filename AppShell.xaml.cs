using AuroraApp_MAUI.Views;
namespace AuroraApp_MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(IniciarSesion), typeof(IniciarSesion));
		Routing.RegisterRoute(nameof(MenuPrincipal), typeof(MenuPrincipal));
		Routing.RegisterRoute(nameof(Registrarse), typeof(Registrarse));
		Routing.RegisterRoute(nameof(MenuPrinc), typeof(MenuPrinc));
		Routing.RegisterRoute(nameof(ReservaPage), typeof(ReservaPage));
		Routing.RegisterRoute(nameof(mostrarReservas), typeof(mostrarReservas));
        Routing.RegisterRoute(nameof(MenuReservas), typeof(MenuReservas));


    }
}
