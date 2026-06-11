using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Domain.Interfaces;
using Escola.Domain.Entities;

namespace Escola.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task<Usuario> AddAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> UpdateAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}