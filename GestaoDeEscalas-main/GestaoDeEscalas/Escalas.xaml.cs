using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using GestaoDeEscalas.Models;


namespace GestaoDeEscalas
{
    public partial class Escalas : ContentPage
    {

        public Escalas()
        {
            InitializeComponent();

        }
        async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TelaInicial");
        }

       
    }
}
