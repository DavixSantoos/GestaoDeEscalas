using System.Collections.ObjectModel;
using GestaoDeEscalas.Models;

namespace GestaoDeEscalas;

public partial class TelaFuncionarios : ContentPage
{
    public ObservableCollection<Funcionario> Funcionarios { get; set; }

    public TelaFuncionarios()
    {
        InitializeComponent();

        Funcionarios = new ObservableCollection<Funcionario>
        {
            new Funcionario
            {
                Nome = "Ana Souza",
                Cargo = "Estagiária",
                Setor = "1",
 
                CorSetor = Colors.Green
            },
            new Funcionario
            {
                Nome = "Carlos Lima",
                Cargo = "Gerente",
                Setor = "2",
 
                CorSetor = Colors.Red
            },
            new Funcionario
            {
                Nome = "Mariana Alves",
                Cargo = "Técnica",
                Setor = "3",

                CorSetor = Colors.Blue
            }
        };
        ListaFuncionarios.ItemsSource = Funcionarios;
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TelaAdmin");
    }
}