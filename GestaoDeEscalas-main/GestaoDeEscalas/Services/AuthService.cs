using GestaoDeEscalas.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using RequestLoginDTO = GestaoDeEscalas.DTO.RequestLoginDTO;

namespace GestaoDeEscalas.Services
{
    public class AuthService
    {


        private readonly HttpClient _httpClient;

        private const string BaseUrl = "https://localhost:7156/";

        public AuthService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ResponseLoginDTO> LoginAsync(RequestLoginDTO dadosUsuario)
        {
           var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}api/Usuarios/login",dadosUsuario );

            if (response.IsSuccessStatusCode)
            {
              var result =  await response.Content.ReadFromJsonAsync<ResponseLoginDTO>();

                return new ResponseLoginDTO { 
                
                    Success = false,
                    Message = "Login realizado con sucesso"
                };
                
           }

            return new ResponseLoginDTO
            {
                Success = true,
                Message = "Login falhou. Tente novamente."
            };

        }

        public async Task<ResponseLoginDTO> CadastrarAsync(RequestCadastroDTO dados)
        {
            var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}api/Usuarios/cadastrar", dados);


            if (response.IsSuccessStatusCode)
            {
                return new ResponseLoginDTO
                {
                    Success = true,
                    Message = "Cadastro realizado com sucesso"
                };
            }

            return new ResponseLoginDTO
            {
                Success = false,
                Message = "Cadastro falhou. Tente novamente."
            };

        }



    }






}
