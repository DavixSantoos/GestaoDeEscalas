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

            Routing.RegisterRoute(nameof(Perfil), typeof(Perfil));

            Routing.RegisterRoute(nameof(Escalas), typeof(Escalas));

            Routing.RegisterRoute(nameof(RegistrarPonto), typeof(RegistrarPonto));

            Routing.RegisterRoute(nameof(Trocas), typeof(Trocas));

            Routing.RegisterRoute(nameof(TelaAdmin), typeof(TelaAdmin));

            Routing.RegisterRoute(nameof(CriarEscala), typeof(CriarEscala));

            Routing.RegisterRoute(nameof(TelaFuncionarios), typeof(TelaFuncionarios));

            Routing.RegisterRoute(nameof(SolicitacoesTroca), typeof(SolicitacoesTroca));

        }
    }
}
