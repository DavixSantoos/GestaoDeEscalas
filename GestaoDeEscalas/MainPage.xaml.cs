namespace GestaoDeEscalas
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        async void OnCadastrarClicked(object? sender, EventArgs e) 
        {
            await Shell.Current.GoToAsync("Cadastro");
           
        }

        async void OnVoltarInicialCliked(object? sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Mainpage");
        }

        async void OnTelaInicialCliked(object? sender, EventArgs e) 
        {
            await Shell.Current.GoToAsync("TelaInicial");
        } 
       
      
        }
    }
   
    

