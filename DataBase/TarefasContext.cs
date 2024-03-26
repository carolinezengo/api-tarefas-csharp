using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTarefas.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.DataBase
{
   
    public class TarefasContext : DbContext
    {    
       #nullable disable
       public TarefasContext(DbContextOptions<TarefasContext> options) : base(options)
        {

        }            

        public DbSet<Tarefa> Tarefas { get; set; }



    }
}