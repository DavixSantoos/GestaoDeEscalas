using apiAutenticacao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using apiAutenticacao.Data;
using Microsoft.EntityFrameworkCore;
using static BCrypt.Net.BCrypt;
using apiAutenticacao.Models.DTO;
using apiAutenticacao.Services;
using apiAutenticacao.Models.Response;

namespace apiAutenticacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly UserServices _userServices;

        public UsuariosController(AuthService authService, UserServices userServices  )
        {

            _authService = authService;
            _userServices = userServices;

        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> CadastarUsuariosAsync
            ([FromBody] CadastroUsuarioDTO dadosUsuario){
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseCadastro response = await _authService.CadastrarUsuarioAsync(dadosUsuario);

            if (response.Erro)
            {
                return BadRequest(response);
            }

            return Ok(response);



        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO dadosUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ResponseLogin response = await _authService.Login(dadosUsuario);

            if (response.Erro)
            {
                return BadRequest( response.Message );
            }
            return Ok(response );


        }


        [HttpPut("AlterarSenha")]

        public async Task<IActionResult> AlterarSenha([FromBody] AlterarSenhaDTO dadosAlterarSenha)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ResponseAlteraSenha response = await _authService.AlterarSenhaAsync(dadosAlterarSenha);
            if (response.Erro)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpPatch("InativarUsuario")]

        public async Task<IActionResult> InativarUsuario([FromBody] DeleteUsuarioDTO dadosInativarUsuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ResponseDelete response = await _authService.DeletarUsuarioAsync(dadosInativarUsuario);
            if (response.Erro)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }


        [HttpGet("ListarUsuarios")]
        public async Task<IActionResult> ListarUsuarios()
        {
            var usuarios = await _userServices.ListarUsuariosAsync();
            return Ok(usuarios);
        }



    }

}