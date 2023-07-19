using Microsoft.IdentityModel.Tokens;

namespace SegundoParcial;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        MainPage = new NavigationPage (new MainPage());
    }
}
