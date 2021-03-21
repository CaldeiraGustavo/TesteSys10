using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSys10.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        /*
         1 - Escola
         2 - Professor
         3 - Aluno
        */
        public int Tipo { get; set; }        
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
