using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    internal interface IMovies
    {
        string Title { get; set; }
        int Year { get; set; }
        string Director { get; set; }
        string[] Actors { get; set; }
        string Plot { get; set; }

    }
}
