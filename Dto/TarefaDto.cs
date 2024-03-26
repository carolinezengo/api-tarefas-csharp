

namespace ApiTarefas.Dto
{
  
    public record TarefaDTO // record objeto mais leve que uma classe retornar
    {
        
        
        public string Titulo { get; set; } = default!;
        public string Descricao { get; set; } = default!;
        public bool Concluido { get; set; } = default!;
    }
}