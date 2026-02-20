using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace apiAutenticacao.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // Use a MESMA connection string do appsettings.json
            optionsBuilder.UseSqlServer(
                "Server=TIT0676455W11-1\\SQLEXPRESS;Database=apiAutenticacao;Trusted_Connection=true;TrustServerCertificate=true");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
