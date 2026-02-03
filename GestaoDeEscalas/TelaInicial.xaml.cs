using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeEscalas
{
    partial class TelaInicial
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        async void BtnPerfil_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Perfil");
        }
    }
}
