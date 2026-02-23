using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace apiAutenticacao.Models.DTO
{
    public class UsuarioResponseDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public List<EnderecoResponseDTO> Enderecos { get; set; } = new List<EnderecoResponseDTO>();
    }
}
