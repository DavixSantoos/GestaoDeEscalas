using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEscalas
{
    public partial class TelaInicial 
    {
        
        public TelaInicial()
        {
            InitializeComponent();
           
        } 
        async void BtnPerfil_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Perfil");
        }
        async void BtnEscalas_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Escalas");
        }
        async void BtnRegistrarPonto_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("RegistrarPonto");
        }
        async void BtnFinanceiro_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Financeiro");
        }
        async void BtnTrocas_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Trocas");
        }
    }


}
