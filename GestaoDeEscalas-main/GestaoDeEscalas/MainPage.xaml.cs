using GestaoDeEscalas.DTO;
using GestaoDeEscalas.Services;

namespace GestaoDeEscalas;

public partial class MainPage : ContentPage
{
    private readonly AuthService _authService;

    public MainPage()
    {
        InitializeComponent();
        
    }

    public MainPage(AuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }


    private async void OnCadastrarClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Cadastro");
    }

    private async void OnVoltarInicialCliked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    //private async void OnTelaInicialCliked(object? sender, EventArgs e)
    //{
    //    await Shell.Current.GoToAsync("TelaInicial");
    //}
    private async void OnAdminClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TelaAdmin");
    }

    private async void OnTelaInicialCliked(object? sender, EventArgs e)
    {
        string email = Email.Text;
        string senha = Senha.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
        {
            await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
            return;
       }

        var dadosUsuarioGE = new RequestLoginDTO
        {
            Email = email,
            Senha = senha
        };

        var responseLogin = await _authService.LoginAsync(dadosUsuarioGE);

        if (!responseLogin.Success)
        {
            await Shell.Current.GoToAsync("TelaInicial");
            return;
        }

        await DisplayAlert("Erro de Login", "Dados inválidos. Verifique seus dadso e tente novamente ", "OK");
    }
}