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

        private void OnShowPasswordClicked(object sender, EventArgs e)
        {
            // Inverte o estado (se for true vira false, se for false vira true)
            EntrySenha.IsPassword = !EntrySenha.IsPassword;

      
        }

    }
}

