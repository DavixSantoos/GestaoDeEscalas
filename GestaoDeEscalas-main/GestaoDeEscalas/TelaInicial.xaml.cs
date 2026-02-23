using System;

namespace GestaoDeEscalas;

public partial class TelaInicial : ContentPage
{
    public TelaInicial()
    {
        InitializeComponent();
    }

    private void OnFecharMenuClicked(object sender, EventArgs e)
    {
        MenuGaveta.TranslateTo(-320, 0, 250, Easing.CubicOut);
        SombraMenu.Opacity = 0;
        SombraMenu.InputTransparent = true;
    }

    private async void BtnPerfil_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Perfil));
    }

    private async void BtnRegistrarPonto_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RegistrarPonto");
    }

    private async void BtnEscalas_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Escalas");
    }

    private async void BtnTrocas_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Trocas");
    }

    private async void BtnFinanceiro_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Financeiro");
    }
}