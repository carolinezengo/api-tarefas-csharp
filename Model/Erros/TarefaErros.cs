using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefas.Model.Erros
{
    public class TarefaErros : Exception
    {
        public TarefaErros(string message) : base(message){
        }
        
    }
    
}