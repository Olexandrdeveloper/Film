using System;
using System.Collections.Generic;
using System.Text;

namespace Film
{
    internal class Film
    {
        public string Name { get; set; } = string.Empty;
        public string Studio { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int Duration { get; set; } = 0;
        public int ReleaseYear { get; set; } = 0;

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
            Console.WriteLine($"Деструктор для фільму: {Name}");
        }

        public override string ToString()
        {
            return $"Назва: {Name}, Студія: {Studio}, Жанр: {Genre}, Тривалість: {Duration} хв, Рік випуску: {ReleaseYear}";
        }
    }
}
