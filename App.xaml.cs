using Microsoft.IdentityModel.Tokens;
using SegundoParcial.ViewModel;

namespace SegundoParcial;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainViewModel mainViewModel = new MainViewModel();
        MainPage = new NavigationPage(new MainPage(mainViewModel));
    }
}
