using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace MoviesConsole
{
    internal class Movies
    {
        private List<Movie> allMovies = new List<Movie>();

        public void AddMovie()
        {
            Console.WriteLine("Add Movies:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            allMovies.Add(new Movie(name, length, year));
        }

        public void RemoveMovie()
        {
            foreach (var (movie, index) in allMovies.Select((value, i) => (value, i)))
            {
                Console.Write($"{index + 1}) {movie.Title} ({movie.Year}), {movie.Length} minutes.\n\r");
            }
            if (allMovies.Count > 0)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Input: {number}");
                allMovies.RemoveAt(number - 1);
            }
        }

        public void GetMovies()
        {
            int totalLength = 0;
            foreach (var movie in allMovies)
            {
                Console.Write($"Title: {movie.Title}, year: {movie.Year}, length: {movie.Length} min\n\r");
                totalLength += movie.Length;
            }
            Console.WriteLine($"\nWatched a total of {allMovies.Count} movies, total duration {totalLength} minutes.");
        }

        
    }
}
