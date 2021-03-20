using Microsoft.EntityFrameworkCore;
using TesteSys10.Models;

namespace TesteSys10.Data
{
    public class EducationContext : DbContext 
    {
        public EducationContext (DbContextOptions<EducationContext> options) : base(options)
        {
        }

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Escola> Escola { get; set; }
        public DbSet<Turma> Turma { get; set; }
    }
}
