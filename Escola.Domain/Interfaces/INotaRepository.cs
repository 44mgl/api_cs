using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Entities;

namespace Escola.Domain.Interfaces
{
    public interface INotaRepository
    {
        Task<Nota> GetByIdAsync(int id); // Método para obter uma nota por ID
        Task<List<Nota>> GetAllAsync(); // Método para obter todas as notas
        Task<Nota> AddAsync(Nota nota); // Método para adicionar uma nova nota
        Task<Nota> UpdateAsync(Nota nota); // Método para atualizar uma nota existente
        Task<Nota> DeleteAsync(int id); // Método para excluir uma nota
    }
}