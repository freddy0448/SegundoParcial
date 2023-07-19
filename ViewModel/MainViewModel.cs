﻿
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using Microsoft.Maui.Controls;

namespace SegundoParcial.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        string description;

        [ObservableProperty]
        DateTime date;

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }

    }
}
