using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new MvcMovieContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<MvcMovieContext>>()))
      {
        // Look for any movies.
        if (context.Filme.Any())
        {
          return;   // DB has been seeded
        }

        context.Filme.AddRange(
            new Filme
            {
              titulo = "When Harry Met Sally",
              lancamento = DateTime.Parse("1989-2-12"),
              genero = "Romantic Comedy",
              classificacao = "R",
              preco = 7.99M
            },

            new Filme
            {
              titulo = "Ghostbusters ",
              lancamento = DateTime.Parse("1984-3-13"),
              genero = "Comedy",
              classificacao = "S",
              preco = 8.99M
            },

            new Filme
            {
              titulo = "Ghostbusters 2",
              lancamento = DateTime.Parse("1986-2-23"),
              genero = "Comedy",
              classificacao = "A",
              preco = 9.99M
            },

            new Filme
            {
              titulo = "Rio Bravo",
              lancamento = DateTime.Parse("1959-4-15"),
              genero = "Western",
              classificacao = "B",
              preco = 3.99M
            }
        );
        context.SaveChanges();
      }
    }
  }
}
