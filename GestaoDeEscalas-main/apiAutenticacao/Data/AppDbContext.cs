using apiAutenticacao.Models;
using Microsoft.EntityFrameworkCore;

namespace apiAutenticacao.Data
{
    public class AppDbContext : DbContext // Classe que representa o contexto do banco de dados
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)// Construtor da classe que recebe as opções de configuração do DbContext
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }// Vai ser cirada a tabela Usuarios no banco de dados

        public DbSet<Endereco> Enderecos { get; set; } // Vai ser criada a tabela Enderecos no banco de dados

    }
}
