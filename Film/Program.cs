using Microsoft.VisualBasic.FileIO;

namespace Film
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateAndUseFilms();
            Console.WriteLine();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine();

            Film film = new Film("Interstellar", "Paramount Pictures", "Science Fiction", 169, 2014);
            Console.WriteLine(film);
            film.Dispose();
        }

        static void CreateAndUseFilms()
        {
            Film[] films =
            {
                new Film("Inception", "Warner Bros.", "Science Fiction", 148, 2010),
                new Film("The Godfather", "Paramount Pictures", "Crime", 175, 1972),
                new Film("The Dark Knight", "Warner Bros.", "Action", 152, 2008),
                new Film("Pulp Fiction", "Miramax", "Crime", 154, 1994),
                new Film("The Shawshank Redemption", "Columbia Pictures", "Drama", 142, 1994)
            };

            foreach (var film in films)
            {
                Console.WriteLine(film);
            }
        }
    }
}
