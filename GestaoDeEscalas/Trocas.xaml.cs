using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeEscalas
{
    partial class Trocas
    {
        public Trocas() 
        {
            InitializeComponent();
        }
        async void OnVoltarTelaInicialCliked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TelaInicial");
        }
    }
}
