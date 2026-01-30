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
        async void OnCadastrarClicked(object sender, EventArgs e) 
        {
            await Shell.Current.GoToAsync("Cadastro");
        }
    }
}
