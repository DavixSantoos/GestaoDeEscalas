using System.ComponentModel.DataAnnotations;

namespace apiAutenticacao.Models.DTO
{
    public class CadastroUsuarioDTO
    {
        [Required(ErrorMessage = "O Nome é um campo obrigatório")]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatório")]
        [StringLength(100, MinimumLength = 6,
            ErrorMessage = "A senha deve ter entre 6 e 100 caracteres")]
        public string Senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatório")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmacaoSenha { get; set; } = string.Empty;

        [MinLength(1, ErrorMessage = "Informe pelo menos um endereço")]
        public List<EnderecoCadastroDTO> Enderecos { get; set; } = new List<EnderecoCadastroDTO>();

    }
}
