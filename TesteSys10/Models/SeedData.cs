using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TesteSys10.Data;
using System;
using System.Linq;

namespace TesteSys10.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EducationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EducationContext>>()))
            {
                // Look for any movies.
                if (context.Alunos.Any())
                {
                    return;   // DB has been seeded
                }

                context.Escola.AddRange(
                    new Escola
                    {
                        Nome = "Escola Estadual Elias Issa"
                    },
                    new Escola
                    {
                        Nome = "Escola Municipal Sebastião Fernandes"
                    },
                    new Escola
                    {
                        Nome = "CEFET-MG"
                    }
                );
                context.Turma.AddRange(
                    new Turma
                    {
                        Nome = "Turma Luz",
                        EscolaId = 1
                    },
                    new Turma
                    {
                        Nome = "Turma Alegria",
                        EscolaId = 1
                    },
                    new Turma
                    {
                        Nome = "Turma Felicidade",
                        EscolaId = 1
                    },
                    new Turma
                    {
                        Nome = "Turma A",
                        EscolaId = 2
                    },
                    new Turma
                    {
                        Nome = "Turma B",
                        EscolaId = 2
                    },
                    new Turma
                    {
                        Nome = "Turma C",
                        EscolaId = 2
                    },
                    new Turma
                    {
                        Nome = "Turma Alfa",
                        EscolaId = 3
                    },
                    new Turma
                    {
                        Nome = "Turma Beta",
                        EscolaId = 3
                    },
                    new Turma
                    {
                        Nome = "Turma Omega",
                        EscolaId = 3
                    }
                );

                context.Alunos.AddRange(
                    new Alunos
                    {
                        Nome = "Gustavo",
                        Nota = 10,
                        TurmaId = 1
                    },
                    new Alunos
                    {
                        Nome = "Lucas",
                        Nota = 7,
                        TurmaId = 2
                    },
                    new Alunos
                    {
                        Nome = "Camila",
                        Nota = 9,
                        TurmaId = 3
                    },
                    new Alunos
                    {
                        Nome = "Marina",
                        Nota = 10,
                        TurmaId = 4
                    },
                    new Alunos
                    {
                        Nome = "Julia",
                        Nota = 3,
                        TurmaId = 5
                    },
                    new Alunos
                    {
                        Nome = "Rafael",
                        Nota = 8,
                        TurmaId = 6
                    },
                    new Alunos
                    {
                        Nome = "Joaquim",
                        Nota = 4,
                        TurmaId = 7
                    },
                    new Alunos
                    {
                        Nome = "Ana",
                        Nota = 2,
                        TurmaId = 8
                    },
                    new Alunos
                    {
                        Nome = "Aline",
                        Nota = 1,
                        TurmaId = 9
                    }
                );

                context.Usuario.AddRange(
                    new Usuario
                    {
                        Tipo = 1,
                        Nome = "Gustavo",
                        Email = "gustavo@hotmail.com",
                        Senha = "gust12"
                    },
                    new Usuario
                    {
                        Tipo = 2,
                        Nome = "Joao",
                        Email = "joao@gmail.com",
                        Senha = "Joa1"
                    },
                    new Usuario
                    {
                        Tipo = 1,
                        Nome = "Marina",
                        Email = "marina@outlook.com",
                        Senha = "M@r1n@"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
