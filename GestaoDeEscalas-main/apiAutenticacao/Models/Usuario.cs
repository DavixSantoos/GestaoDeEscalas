using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace apiAutenticacao.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O nome é um campo obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        [StringLength(150, ErrorMessage = "O email deve ter no máximo 150 caracteres")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é um campo obrigatório")]
        [StringLength(255 , ErrorMessage = "A senha deve ter no máximo 255 caracteres")]
        public string Senha { get; set; } = string.Empty;



        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; } = true;

        public ICollection<Endereco> Enderecos { get; set; } = new List<Endereco>();


        public Usuario()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }


    }
}
