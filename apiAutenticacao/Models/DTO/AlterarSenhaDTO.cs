using System.ComponentModel.DataAnnotations;

namespace apiAutenticacao.Models.DTO
{
    public class AlterarSenhaDTO
    {
        [Required(ErrorMessage = "O email é um campo obrigatório")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha atual é um campo obrigatório")]
        public string SenhaAtual { get; set; } = string.Empty;

        [Required(ErrorMessage = "A nova senha é um campo obrigatório")]
        [StringLength(100, MinimumLength = 6,
            ErrorMessage = "A nova senha deve ter entre 6 e 100 caracteres")]
        public string NovaSenha { get; set; } = string.Empty;

        [Required(ErrorMessage = "A confirmação da nova senha é um campo obrigatório")]
        [Compare("NovaSenha", ErrorMessage = "As senhas não conferem")]
        public string ConfirmacaoNovaSenha { get; set; } = string.Empty;


    }
}
