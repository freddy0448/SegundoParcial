
using CommunityToolkit.Mvvm.ComponentModel;

namespace SegundoParcial.ViewModel
{

    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;
        

        [ObservableProperty]
        string description;
    }
}
