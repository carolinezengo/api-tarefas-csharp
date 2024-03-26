using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefas.ModelsViewa
{
    public struct HomeView
    {
        
   
       [Required]
       public  string Mensagem { get; set; }
       [Required]
       public string Documentacao { get; set; } 

    }
}