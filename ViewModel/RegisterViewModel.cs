using CommunityToolkit.Mvvm.ComponentModel;

namespace SegundoParcial.ViewModel
{
    [ObservableObject]
    public partial class RegisterViewModel
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        DateTime date;

        [ObservableProperty]
        string description;
    }
}
