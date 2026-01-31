using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeEscalas
{
    partial class Cadastro
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        async void OnVoltarInicialCliked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }

    }
    
}
