namespace GestaoDeEscalas
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
           
            Routing.RegisterRoute(nameof(Cadastro), typeof(Cadastro));

            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
           
            Routing.RegisterRoute(nameof(TelaInicial),typeof(TelaInicial));


        }
    }
}
