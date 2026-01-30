namespace GestaoDeEscalas
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        async void OnCadastrarClicked(object sender, EventArgs e) 
        {
            await Shell.Current.GoToAsync("Cadastro");
        }
    }
}

