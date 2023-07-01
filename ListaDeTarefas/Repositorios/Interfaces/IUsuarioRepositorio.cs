using ListaDeTarefas.Models;

namespace ListaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        public Task<List<UsuarioModel>> BuscarTodosUsuarios();
        public Task<UsuarioModel> BuscarUsuarioPorId(int id);
        public Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        public Task<bool> Apagar(int id);
    }
}
