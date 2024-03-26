using ApiTarefas.ModelsViewa;
using Microsoft.AspNetCore.Mvc;

namespace ApiTarefas.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{

    public HomeController()
    {
        
    }

    [HttpGet]
    public  HomeView Index()
    {
       return new HomeView
        {
        Mensagem = "Bem vindo Api de Tarefas",
        Documentacao = "/swagger"
        };
    }
}
