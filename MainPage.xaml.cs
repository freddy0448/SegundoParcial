using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using SegundoParcial.ViewModel;

namespace SegundoParcial;

public partial class MainPage : ContentPage
{
    RegisterViewModel viewModel;


    public MainPage(MainViewModel mainViewModel) //Inyeccion
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }

    /// <summary>
    /// Toma foto
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public async void Button_Clicked(object sender, EventArgs e)
    {

        if (MediaPicker.Default.IsCaptureSupported)
        {
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
            photo.FileName = DateTime.Now.ToString("dd-MM-yyyy") + ".jpg";
            if (photo != null)
            {
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName); //localFilePath va a ser igual a la combinacion del directorio del cache con el nombre del archivo
                using Stream source = await photo.OpenReadAsync();
                using FileStream fileStream = File.OpenWrite(localFilePath);
                source.CopyTo(fileStream);
            }
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage(viewModel));
    }
}

