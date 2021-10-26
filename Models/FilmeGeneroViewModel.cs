using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class FilmeGeneroViewModel
    {
        public List<Filme> filmes { get; set; }
        public SelectList generos { get; set; }
        public string FilmeGenero { get; set; }
        public string strigDeBusca { get; set; }
    }
}
