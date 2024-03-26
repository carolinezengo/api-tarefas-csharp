using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefas.Model
{
    [Table(name: "tarefas")]
    public class Tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = default!;
        [Column(TypeName = "text")]
        public string Descricao { get; set; } = default!;
        public bool Concluido { get; set; } = default!;
    }
}