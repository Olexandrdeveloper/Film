using System;
using System.Collections.Generic;
using System.Text;

namespace Film
{
    internal class Film : IDisposable
    {
        public string Name { get; set; } = string.Empty;
        public string Studio { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int Duration { get; set; } = 0;
        public int ReleaseYear { get; set; } = 0;

        private bool isDisposed = false;

        public Film(string name, string studio, string genre, int duration, int releaseYear)
        {
            Name = name;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            ReleaseYear = releaseYear;
        }

        ~Film()
        {
            Cleaning(false);
        }

        private void Cleaning(bool disposing)
        {
            if(!isDisposed)
            {
                if(disposing)
                {
                    Console.WriteLine("Звільнення керованих ресурсів");
                }
                Console.WriteLine("Звільнення некерованих ресурсів");
            }
            isDisposed = true;
        }

        public void Dispose()
        {
            Cleaning(true);
            GC.SuppressFinalize(this);
        }

        public override string ToString()
        {
            return $"Назва: {Name}, Студія: {Studio}, Жанр: {Genre}, Тривалість: {Duration} хв, Рік випуску: {ReleaseYear}";
        }
    }
}
