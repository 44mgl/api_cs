using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Entities;

namespace Escola.Domain.Interfaces
{
    public interface IMatriculaRepository
    {
        Task<Matricula> GetByIdAsync(int id); // Método para obter um curso por ID
        Task<List<Matricula>> GetAllAsync(); // Método para obter todos os cursos
        Task<Matricula> AddAsync(Matricula matricula); // Método para adicionar um novo curso
        Task<Matricula> UpdateAsync(Matricula matricula); // Método para atualizar um curso existente
        Task<Matricula> DeleteAsync(int id); // Método para excluir um curso
    }
}