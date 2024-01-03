

using AuroraApp_MAUI.Repositories;

namespace AuroraApp_MAUI;

public partial class App : Application
{
	
	public static ReservaRepository reservaRepo {  get; set; }
    public App(ReservaRepository repo)
	{

		InitializeComponent();
		reservaRepo = repo;

		MainPage = new AppShell();
	}
}
