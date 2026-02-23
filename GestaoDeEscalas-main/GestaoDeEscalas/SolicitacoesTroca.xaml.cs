namespace GestaoDeEscalas;

public partial class SolicitacoesTroca : ContentPage
{
	public SolicitacoesTroca()
	{
		InitializeComponent();
	}
    async void OnVoltarTelaInicialCliked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TelaInicial");
    }
}