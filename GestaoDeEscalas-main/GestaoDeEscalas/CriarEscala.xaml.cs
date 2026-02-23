namespace GestaoDeEscalas;

public partial class CriarEscala : ContentPage
{
	public CriarEscala()
	{
		InitializeComponent();
	}
	private async void OnCancelarClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("TelaAdmin");
    }
}