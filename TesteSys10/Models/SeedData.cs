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
                        Nome = "Turma Luz"
                    },
                    new Turma
                    {
                        Nome = "Turma Alegria"
                    },
                    new Turma
                    {
                        Nome = "Turma Felicidade"
                    },
                    new Turma
                    {
                        Nome = "Turma A"
                    },
                    new Turma
                    {
                        Nome = "Turma B"
                    },
                    new Turma
                    {
                        Nome = "Turma C"
                    },
                    new Turma
                    {
                        Nome = "Turma Alfa"
                    },
                    new Turma
                    {
                        Nome = "Turma Beta"
                    },
                    new Turma
                    {
                        Nome = "Turma Omega"
                    }
                );

                context.Alunos.AddRange(
                    new Alunos
                    {
                        Nome = "Gustavo",
                        Nota = 10
                    },
                    new Alunos
                    {
                        Nome = "Lucas",
                        Nota = 7
                    },
                    new Alunos
                    {
                        Nome = "Camila",
                        Nota = 9
                    },
                    new Alunos
                    {
                        Nome = "Marina",
                        Nota = 10
                    },
                    new Alunos
                    {
                        Nome = "Julia",
                        Nota = 3
                    },
                    new Alunos
                    {
                        Nome = "Rafael",
                        Nota = 8
                    },
                    new Alunos
                    {
                        Nome = "Joaquim",
                        Nota = 4
                    },
                    new Alunos
                    {
                        Nome = "Ana",
                        Nota = 2
                    },
                    new Alunos
                    {
                        Nome = "Aline",
                        Nota = 1
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
