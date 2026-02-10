using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeEscalas
{
    partial class Perfil
    {
        public Perfil()
        {
            InitializeComponent();
        }

        async void OnVoltarTelaInicialCliked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TelaInicial");
        }
        async void OnVoltarTelaLogin(object sender, EventArgs e) 
        { 
         await Shell.Current.GoToAsync("///MainPage");
        }
    }
}
