using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using SegundoParcial.ViewModel;

namespace SegundoParcial;

public partial class MainPage : ContentPage
{
    private  IMediaPicker mediaPicker; //Propiedad del media picker
    RegisterViewModel viewModel;

    public MainPage()
    {
    }

    public MainPage(IMediaPicker mediaPicker, MainViewModel mainViewModel) //Inyeccion
	{
		InitializeComponent();
        this.mediaPicker = mediaPicker; //Inicializacion
        BindingContext = mainViewModel;
    }

    /// <summary>
    /// Toma foto
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (mediaPicker.IsCaptureSupported)
        {
            FileResult photo = await mediaPicker.CapturePhotoAsync();
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

