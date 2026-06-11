using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Entities;

namespace Escola.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> GetByIdAsync(int id); // Método para obter um usuário por ID
        Task<List<Usuario>> GetAllAsync(); // Método para obter todos os usuários
        Task<Usuario> AddAsync(Usuario usuario); // Método para adicionar um novo usuário
        Task<Usuario> UpdateAsync(Usuario usuario); // Método para atualizar um usuário existente
        Task<Usuario> DeleteAsync(int id); // Método para excluir um usuário
    }
}