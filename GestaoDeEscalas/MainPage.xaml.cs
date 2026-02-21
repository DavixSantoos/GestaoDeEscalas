using GestaoDeEscalas.DTO;
using GestaoDeEscalas.Services;
 

namespace GestaoDeEscalas
{
    partial class MainPage : ContentPage
    {
        private readonly AuthService _authservice;

        public MainPage(AuthService authService)
        {
            InitializeComponent();
            _authservice = authService;
        }
        async void OnCadastrarClicked(object? sender, EventArgs e) 
        {
            await Shell.Current.GoToAsync("Cadastro");
           
        }

        async void OnVoltarInicialCliked(object? sender, EventArgs e)
        {
            string senha = Senha.Text;
            string email = Email.Text;

            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(email))
            {
                await DisplayAlertAsync("Erro", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            RequestLoginDTO dadosUsuariosFora = new RequestLoginDTO
            {
                Email = email,
                Senha = senha
            };

            ResponseLoginDTO respostaLogin = await _authservice.LoginAsync(dadosUsuariosFora);

            if (respostaLogin.Success)
            {
                await Shell.Current.GoToAsync("TelaInicial");
                return;
            }

            await DisplayAlertAsync("Erro de login", "Email ou senha inválidos.", "OK");



            await Shell.Current.GoToAsync("Mainpage");




        }

        async void OnTelaInicialCliked(object? sender, EventArgs e) 
        {
            await Shell.Current.GoToAsync("TelaInicial");
        } 
       
      
        }
    }
   
    

