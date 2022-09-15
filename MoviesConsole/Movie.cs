using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesConsole
{
    [Serializable]
    internal class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }

        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
        }
    }
}
