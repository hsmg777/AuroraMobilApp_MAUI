using AuroraApp_MAUI.Repositories;

namespace AuroraApp_MAUI;

public partial class App : Application
{

	public static cotizacionRepository cotiRepo { get;  private set; }
    public App(cotizacionRepository repo )
	{

		InitializeComponent();
		cotiRepo = repo;
	    MainPage = new AppShell();
		
	}
}
