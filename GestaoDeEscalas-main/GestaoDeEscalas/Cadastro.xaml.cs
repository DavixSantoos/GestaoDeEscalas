using System;
using System.Collections.Generic;
using System.Text;
using GestaoDeEscalas.DTO;
using GestaoDeEscalas.Services;


namespace GestaoDeEscalas
{
    partial class Cadastro
    {
        private readonly AuthService _authService;
        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        async void OnVoltarInicialClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///MainPage");
        }


        async void OnCadastrarClicked(object sender, EventArgs e)
        {
            DisplayLoadingCadastrar();
            var dados = new RequestCadastroDTO
            {
                Nome = Nome.Text,
                Email = EmailCadastro.Text,
                Senha = SenhaCadastro.Text
            };

            var resultado = await _authService.CadastrarAsync(dados);

            await DisplayAlert("Cadastro", resultado.Message, "OK");
            DisplayLoadingCadastrar();

            if (resultado.Success)
            {
                await Shell.Current.GoToAsync("///MainPage");
                DisplayLoadingCadastrar();
            }

        }



        private void DisplayLoadingCadastrar()
        {
            btnCadastrar.IsVisible = !btnCadastrar.IsVisible;
            LoadingCadastro.IsVisible = !LoadingCadastro.IsVisible;

        }

        //private void OnShowPasswordClicked(object sender, EventArgs e)
        //{
        //    // Inverte o estado (se for true vira false, se for false vira true)
        //    EntrySenha.IsPassword = !EntrySenha.IsPassword;


        //}

    }
}

