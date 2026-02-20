using System.ComponentModel.DataAnnotations;


namespace apiAutenticacao.Models.DTO
{
    public class EnderecoCadastroDTO

    {

        [Required(ErrorMessage = "O CEP é um campo obrigatório")]
        [StringLength(9, ErrorMessage = "O Cep deve ter no máximo 9 caracteres")]
        public string Cep { get; set; } = string.Empty;


        [Required(ErrorMessage = "O Logradouro é um campo obrigatório")]
        [StringLength(200, ErrorMessage = "O Logradouro deve ter no máximo 200 caracteres")]
        public string Logradouro { get; set; } = string.Empty;


        [Required(ErrorMessage = "O Número é um campo obrigatório")]
        [StringLength(10, ErrorMessage = "O Número deve ter no máximo 10 caracteres")]
        public string Numero { get; set; } = string.Empty;


        [StringLength(100, ErrorMessage = "O Complemento deve ter no máximo 100 caracteres")]
        public string Complemento { get; set; } = string.Empty;


        [Required(ErrorMessage = "O Bairro é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O Bairro deve ter no máximo 100 caracteres")]
        public string Bairro { get; set; } = string.Empty;


        [Required(ErrorMessage = "A Cidade é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres")]
        public string Cidade { get; set; } = string.Empty;


        [Required(ErrorMessage = "O Estado é um campo obrigatório")]
        [StringLength(2, ErrorMessage = "O Estado deve ter no máximo 2 caracteres")]
        public string Estado { get; set; } = string.Empty;


        [Required(ErrorMessage = "O País é um campo obrigatório")]
        [StringLength(100, ErrorMessage = "O País deve ter no máximo 100 caracteres")]
        public string Pais { get; set; } = string.Empty;


    }




}
