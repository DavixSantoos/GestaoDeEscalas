using System.ComponentModel.DataAnnotations;

namespace apiAutenticacao.Models.DTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage ="O emial é obrigatório")]
        [EmailAddress(ErrorMessage ="O email é inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage ="A senha é obrigatória")]
        public string Senha { get; set; } = string.Empty;
    }
}
