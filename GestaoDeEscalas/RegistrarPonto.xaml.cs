using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeEscalas
{
    partial class RegistrarPonto
    {

        public RegistrarPonto()
        {
            InitializeComponent();
        }
        async void onVoltarTelaInicialCliked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TelaInicial");
        }

    }
}
