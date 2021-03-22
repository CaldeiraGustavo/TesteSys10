using System;
using System.Threading.Tasks;
using TesteSys10.Helpers;
using TesteSys10.Models;
using TesteSys10.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TesteSys10.Data;

namespace TesteSys10.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly EducationContext _context;

        [HttpPost]
        [AllowAnonymous]
        [Route("/api/v1/auth")]
        public async Task<IActionResult> Auth([FromBody]Usuario user)
        {
            try
            {
                var userController = new UsuariosController(_context);

                var userExists = userController.GetByEmail(user.Email);

                if (userExists == null)
                    return BadRequest(new { Message = "Email e/ou senha está(ão) inválido(s)." });

                /*
                if(userExists.Senha != user.Senha)
                    return BadRequest(new { Message = "Email e/ou senha está(ão) inválido(s)." });


                var token = JwtAuth.GenerateToken(userExists);
                */
                return Ok(new
                {
                    Token = "fedaf7d8863b48e197b9287d492b708e",
                    Usuario = userExists
                });

            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Ocorreu algum erro interno na aplicação, por favor tente novamente." });
            }
        }
    }
}