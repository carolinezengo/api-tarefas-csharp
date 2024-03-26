

using ApiTarefas.DataBase;
using ApiTarefas.Dto;
using ApiTarefas.Model;
using ApiTarefas.Model.Erros;

namespace ApiTarefas.Servicos.Interfaces
{

    public interface ITarefaServicos
    {
        List<Tarefa> Lista( int page);
        Tarefa Incluir(TarefaDTO tarefaDto);
        Tarefa Alterar(int id, TarefaDTO tarefaDto);

        void Deletar(int id);

        Tarefa BuscarPorId(int id);


    }
}