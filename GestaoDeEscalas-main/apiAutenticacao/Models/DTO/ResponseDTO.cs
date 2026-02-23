using Microsoft.EntityFrameworkCore.Query;

namespace apiAutenticacao.Models.DTO
{
    public class ResponseDTO 
    {
        public bool Erro { get; set; }
        public string Message { get; set; } = string.Empty;
        public UsuarioResponseDTO? Usuario { get; set; }
    }
}
