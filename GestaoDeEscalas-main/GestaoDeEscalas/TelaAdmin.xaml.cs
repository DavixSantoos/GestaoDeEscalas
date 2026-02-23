using System.Collections.ObjectModel;
using GestaoDeEscalas.DTO;
using GestaoDeEscalas.Models;
using GestaoDeEscalas.Services;
using Syncfusion.Maui.Scheduler;

namespace GestaoDeEscalas;

public partial class TelaAdmin : ContentPage
{
    public TelaAdmin()
    {
        InitializeComponent();

        var escalas = new ObservableCollection<SchedulerAppointment>()
        {
            new SchedulerAppointment()
            {
                Subject = "Ana",
                StartTime = DateTime.Today.AddHours(7),
                EndTime = DateTime.Today.AddHours(19),
                Background = Colors.Green
            },
            new SchedulerAppointment()
            {
                Subject = "Carlos",
                StartTime = DateTime.Today.AddHours(19),
                EndTime = DateTime.Today.AddDays(1).AddHours(7),
                Background = Colors.Blue
            }
        };

        Agenda.AppointmentsSource = escalas;
    }    
    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }

    private async void OnCriarEscalaClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CriarEscala");
    }
    private async void OnFuncionariosClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TelaFuncionarios");
    }
    private async void OnSolicitacoesTrocaClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("SolicitacoesTroca");
    }
}