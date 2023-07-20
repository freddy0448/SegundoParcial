using SegundoParcial.ViewModel;
using Syncfusion.Maui;
namespace SegundoParcial;

public partial class RegisterPage : ContentPage
{
    public RegisterPage(RegisterViewModel registerViewModel)
    {
        InitializeComponent();
        BindingContext = registerViewModel;
    }
}