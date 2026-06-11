using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public byte[] PassWordHash { get; set; } // Hash da senha do usuário
        public byte[] PassWordSalt { get; set; } // Salt utilizado para verificar o hash da senha

        public string Perfil { get; set; } 
        public ICollection<Matricula> Matriculas { get; set; } // Relacionamento com as matrículas do usuário
    }
}