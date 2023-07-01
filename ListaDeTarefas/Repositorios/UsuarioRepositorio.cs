using ListaDeTarefas.Data;
using ListaDeTarefas.Models;
using ListaDeTarefas.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly TarefasDBContext _dbContext;

        public UsuarioRepositorio(TarefasDBContext dBContext) 
        {
            _dbContext = dBContext;
        }

        public async Task<UsuarioModel> BuscarUsuarioPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(it=>it.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);

            if(usuarioPorId == null)
            {
                throw new Exception($"Usuário Não Encontrado. Id{id}");
            }

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarUsuarioPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário Não Encontrado. Id{id}");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
