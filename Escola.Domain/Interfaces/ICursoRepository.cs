using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Entities;

namespace Escola.Domain.obj
{
    public interface ICursoRepository
    {
        Task<Curso> GetByIdAsync(int id); // Método para obter um curso por ID
        Task<List<Curso>> GetAllAsync(); // Método para obter todos os cursos
        Task<Curso> AddAsync(Curso curso); // Método para adicionar um novo curso
        Task<Curso> UpdateAsync(Curso curso); // Método para atualizar um curso existente
        Task<Curso> DeleteAsync(int id); // Método para excluir um curso
    }
}