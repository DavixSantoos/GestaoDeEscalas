using System.ComponentModel.DataAnnotations;


namespace apiAutenticacao.Models.DTO
{
    public class DeleteUsuarioDTO
    {
        [Required(ErrorMessage = "O Nome é um campo obrigatório")]
        [StringLength(100, MinimumLength = 2 )]
        public string Nome { get; set; } = string.Empty;

        public bool Ativo { get; set; }
    }
}
