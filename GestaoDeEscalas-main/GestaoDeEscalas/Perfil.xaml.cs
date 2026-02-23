using System;

namespace GestaoDeEscalas;

public partial class Perfil : ContentPage
{
    public Perfil()
    {
        InitializeComponent();
    }

    private async void OnVoltarTelaInicialCliked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TelaInicial");
    }

    private async void OnVoltarTelaLogin(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }

}