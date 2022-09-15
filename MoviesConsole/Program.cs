using MoviesConsole;

Movies movies = new();

while (true)
{
    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Movie Watch Log");
    Console.WriteLine("====================");
    Console.WriteLine("1) Add Movie");
    Console.WriteLine("2) Remove Movie");
    Console.WriteLine("3) Show All Movies");
    Console.WriteLine("6) Quit");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Input: {number}");
    Console.WriteLine(" ");
    if (number == 1) movies.AddMovie();
    if (number == 2) movies.RemoveMovie();
    if (number == 3) movies.GetMovies();
    if (number == 6) return;
}
