using Microsoft.AspNetCore.Mvc;
using Model;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class Login : ControllerBase
{

    [HttpGet("teste/{valor}")]
    public object teste(double valor)
    {
        return new
        {
            nome = "alisson",
            idade = valor
        };
    }

    [HttpGet("login/{login}/{senha}")]
    public object RealizarLogin(string login, string senha)
    {
        Usuario user = new Usuario(login, senha);
        return new
        {
            login = user.GetLogin(),
            senha = user.GetPassword()
        };
    }

}
