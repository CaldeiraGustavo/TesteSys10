using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSys10.Models
{
    public class Turma
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public List<Alunos> Alunos { get; set; }
        public long EscolaId { get; set; }
    }
}
