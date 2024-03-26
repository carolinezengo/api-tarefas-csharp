

using ApiTarefas.DataBase;
using ApiTarefas.Dto;
using ApiTarefas.Model;
using ApiTarefas.Model.Erros;
using ApiTarefas.Servicos.Interfaces;

namespace ApiTarefas.Servicos
{

    public class TarefaServicos : ITarefaServicos
    {
        public TarefaServicos(TarefasContext db)
        {
            _db = db;

        }


        private TarefasContext _db;

        public List<Tarefa> Lista(int page)
        {
            if(page < 1) page = 1;
            int limit = 10;
            int offset = (page -1) * limit;
            return _db.Tarefas.Skip(offset).Take(limit).ToList();
        }


        public Tarefa Incluir(TarefaDTO tarefaDto)
        {

            if (string.IsNullOrEmpty(tarefaDto.Titulo))
                throw new TarefaErros("O titulo da tarefa não pode ser vazio");

            var tarefa = new Tarefa
            {
                Titulo = tarefaDto.Titulo,
                Descricao = tarefaDto.Descricao,
                Concluido = tarefaDto.Concluido
            };
            _db.Tarefas.Add(tarefa);
            _db.SaveChanges();

            return tarefa;
        }

        public Tarefa Alterar(int id, TarefaDTO tarefaDto)

        {
            if (string.IsNullOrEmpty(tarefaDto.Titulo))
                throw new TarefaErros("O titulo da tarefa não pode ser vazio");

            var tarefaDb = _db.Tarefas.Find(id);
            if (tarefaDb == null)
                throw new TarefaErros("Tarefa não encontrado");

            tarefaDb.Titulo = tarefaDto.Titulo;
            tarefaDb.Descricao = tarefaDto.Descricao;
            tarefaDb.Concluido = tarefaDto.Concluido;

            _db.Tarefas.Update(tarefaDb);
            _db.SaveChanges();

            return tarefaDb;
        }

        public void Deletar(int id)
        {
            var tarefaDb = _db.Tarefas.Find(id);
            if (tarefaDb == null)
                throw new TarefaErros("Tarefa não encontrado");

            _db.Tarefas.Remove(tarefaDb);
            _db.SaveChanges();


        }
        public Tarefa BuscarPorId(int id)
        {
            var tarefaDb = _db.Tarefas.Find(id);

            if (tarefaDb == null)
                throw new TarefaErros("Tarefa não encontrada");
            return tarefaDb;
        }








    }
}