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

        private const string BaseUrl = "https://localhost:7177/";

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ResponseLoginDTO> LoginAsync(RequestLoginDTO dadosUsuario)
        {
           var response = await _httpClient.PostAsJsonAsync($"{BaseUrl}api/Usuarios/login",dadosUsuario );

            if (response.IsSuccessStatusCode)
            {
              var result =  await response.Content.ReadFromJsonAsync<ResponseLoginDTO>();

                
                
            }

            return new ResponseLoginDTO
            {
                Success = false,
                Message = "Login falhou. Tente novamente."
            };

        }



    }






}
