using ApiTarefas.DataBase;
using ApiTarefas.Dto;
using ApiTarefas.Model;
using ApiTarefas.Model.Erros;
using ApiTarefas.ModelsViewa;
using ApiTarefas.Servicos;
using ApiTarefas.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ApiTarefas.Controllers;

[ApiController]
[Route("/tarefas")]
public class TarefasController : ControllerBase
{

   public TarefasController(ITarefaServicos servicos)
   {
      _servicos = servicos;
   }
   private ITarefaServicos _servicos;


   [HttpGet]
   public IActionResult Index(int page = 1)
   {
      
      var tarefas = _servicos.Lista(page);
      return StatusCode(200, tarefas);
   }

   [HttpGet("{id}")]
   public IActionResult Show([FromRoute] int id)
   {
      try
      {

         var tarefaDb = _servicos.BuscarPorId(id);

         return StatusCode(200, tarefaDb);
      }
      catch (TarefaErros erro)
      {

         return StatusCode(404, new ErrorView { Mensagem = erro.Message });

      }

   }
   [HttpPost]
   public IActionResult Create([FromBody] TarefaDTO tarefaDTO)
   {
      try
      {
         var tarefa = _servicos.Incluir(tarefaDTO);

         return StatusCode(201, tarefa);
      }
      catch (TarefaErros erro)
      {

         return StatusCode(400, new ErrorView { Mensagem = erro.Message });

      }


   }

   [HttpPut("{id}")]
   public IActionResult Update([FromRoute] int id, [FromBody] TarefaDTO tarefaDTO)
   {
      try
      {
         var tarefaDb = _servicos.Alterar(id, tarefaDTO);

         return StatusCode(200, tarefaDb);
     }
      
      catch (TarefaErros erro)
      {

         return StatusCode(400, new ErrorView { Mensagem = erro.Message });

      }
   }
      
   [HttpDelete("{id}")]
   public IActionResult Delete([FromRoute] int id)
   {
         try
      {
          _servicos.Deletar(id);

         return StatusCode(204);
      }
      catch (TarefaErros erro)
      {

         return StatusCode(404, new ErrorView { Mensagem = erro.Message });

      }
   }
}





