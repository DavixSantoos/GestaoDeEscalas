using GestaoDeEscalas.DTO;
using GestaoDeEscalas.Services;
using System.Runtime.CompilerServices;

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
        DisplayLoading();

        string email = Email.Text;
        string senha = Senha.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
        {
            await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
            DisplayLoading();

            return;
        }

        try  //Tentar executar o código 
        {
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
        catch (Exception erro) //Se ocorrer um erro, ele será capturado aqui
        {
            throw new Exception($"Ocorreu um erro durante o login: {erro.Message}");
        }
        finally //Esse bloco é executado independentemente de ocorrer um erro ou não
        {
            DisplayLoading();

        }


    }

    private void DisplayLoading()
    {

        btnEntrara.IsVisible = !btnEntrara.IsVisible;
        Loading.IsVisible = !Loading.IsVisible;

     }




}