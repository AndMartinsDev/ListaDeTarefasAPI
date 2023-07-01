using ListaDeTarefas.Enums;

namespace ListaDeTarefas.Models;

public class TarefaModel
{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public StatusTarefa Status { get; set; }
}
