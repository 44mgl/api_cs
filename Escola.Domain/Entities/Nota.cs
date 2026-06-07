using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Domain.Entities
{
    public class Nota
    {
        public int Id { get; set; }
        public int MatriculaId { get; set; } // Chave estrangeira para a matrícula
        public int ValorNota { get; set; } 
        public bool Aprovado { get; set; } 
        public Matricula Matricula { get; set; } // Relacionamento com a matrícula
        
    }
}