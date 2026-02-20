using apiAutenticacao.Data;
using apiAutenticacao.Models;
using apiAutenticacao.Models.DTO;
using apiAutenticacao.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static BCrypt.Net.BCrypt;


namespace apiAutenticacao.Services
{
    public class UserServices
    {
        private readonly AppDbContext _context;

        public UserServices(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<UsuarioResponseDTO>> ListarUsuariosAsync()
        {
            var usuarios = await _context.Usuarios.Include(u => u.Enderecos).ToListAsync();

            return usuarios.Select(u => new UsuarioResponseDTO
            {
                Id = u.Id,
                Nome = u.Nome,
                Email = u.Email,
                Enderecos = u.Enderecos.Select(e => new EnderecoResponseDTO
                {
                    Id = e.Id,
                    Logradouro = e.Logradouro,
                    Numero = e.Numero,
                    Cidade = e.Cidade,
                    Estado = e.Estado,
                    Cep = e.Cep
                }).ToList()
            }).ToList();
        }



    }




}
