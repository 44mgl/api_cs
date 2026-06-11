using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Interfaces; 
using Escola.Domain.Entities;

namespace Escola.Infra.Data.Repository
{
    public class NotaRepository : INotaRepository
    {
        public Task<Nota> AddAsync(Nota nota)
        {
            throw new NotImplementedException();
        }

        public Task<Nota> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Nota>> GetAllAsync()
        {
            throw new NotImplementedException(); 
        }

        public Task<Nota> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Nota> UpdateAsync(Nota nota)
        {
            throw new NotImplementedException();
        }
    }
}