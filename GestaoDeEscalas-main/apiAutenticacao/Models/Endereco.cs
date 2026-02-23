using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace apiAutenticacao.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int Id { get; set; } // PK do endereço

        [Required(ErrorMessage = "O Cep é obrigatório")]
        [StringLength(9, ErrorMessage = "O Cep deve ter no máximo 9 caracteres")]
        public string Cep { get; set; } = string.Empty;


        [Required(ErrorMessage = "O Logradouro é obrigatório")]
        [StringLength(200, ErrorMessage = "O Logradouro deve ter no máximo 200 caracteres")]
        public string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Número é obrigatório")]
        [StringLength(10, ErrorMessage = "O Número deve ter no máximo 10 caracteres")]
        public string Numero { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "O Complemento deve ter no máximo 100 caracteres")]
        public string Complemento { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Bairro é obrigatório")]
        [StringLength(100, ErrorMessage = "O Bairro deve ter no máximo 100 caracteres")]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Cidade é obrigatória")]
        [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres")]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Estado é obrigatório")]
        [StringLength(2, ErrorMessage = "O Estado deve ter no máximo 2 caracteres")]
        public string Estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "O País é obrigatório")]
        [StringLength(100, ErrorMessage = "O País deve ter no máximo 100 caracteres")]
        public string Pais { get; set; } = string.Empty;

        [Required]
        public int UsuarioId { get; set; } // Chave estrangeira para o usuário

        [ForeignKey(nameof(UsuarioId))]
        public Usuario Usuario { get; set; } // Propriedade de navegação para o usuário
       



    }
}
