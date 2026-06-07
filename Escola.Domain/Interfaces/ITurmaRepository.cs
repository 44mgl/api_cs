using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Entities;
namespace Escola.Domain.Interfaces
{
    public interface ITurmaRepository
    {
        Task<Turma> GetByIdAsync(int id); // Método para obter uma turma por ID
        Task<List<Turma>> GetAllAsync(); // Método para obter todas as turmas
        Task<Turma> AddAsync(Turma turma); // Método para adicionar uma nova turma
        Task<Turma> UpdateAsync(Turma turma); // Método para atualizar uma turma existente
        Task<Turma> DeleteAsync(int id); // Método para excluir uma turma
    }
}