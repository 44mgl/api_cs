using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Interfaces;
using Escola.Domain.Entities;

namespace Escola.Infra.Data.Repository
{
    public class TurmaRepository : ITurmaRepository
    {
        public Task<Turma> AddAsync(Turma turma)
        {
            throw new NotImplementedException();
        }

        public Task<Turma> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Turma>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Turma> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Turma> UpdateAsync(Turma turma)
        {
            throw new NotImplementedException();
        }
    }
}