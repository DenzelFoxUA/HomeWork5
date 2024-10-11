using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public enum Genres
    {
        Default = 0,
        Comedy = 1,
        Drama,
        Horror,
        Musicle,
        Satiric,
        Lovestory,
        Historical,
        Tragedy
    }

    public class Play : IDisposable
    {
        private bool _disposed = false;

        public string Name { get; set; }

        public string Author { get; set; }

        public List<Genres> Genre { get; set; }

        public int Year { get; set; }

        public Play()
        {
            Name = string.Empty;
            Author = string.Empty;
            Genre = new List<Genres>();
            Genre.Add(Genres.Default);
            Year = DateTime.MinValue.Year;
        }

        public Play(string name, string author, int year, params Genres[] genre)
        {
            Name = name;
            Author = author;
            Year = year;
            Genre = new List<Genres>();

            if(genre is not null)
            {
                foreach (var item in genre)
                {
                    Genre.Add(item);
                }
            }
        }

        public override string ToString()
        {
            string genres = string.Empty;

            foreach (var item in Genre)
            {
                genres += item.ToString() + ", ";
            }

            return $"Play: {Name}\n" +
                $"Genre: {genres}\n" +
                $"Author: {Author}\n" +
                $"Year: {Year}\n";
        }

        protected virtual void Dispose(bool isDisposed)
        {
            if (_disposed) return;
            if (isDisposed)
            {
                Console.WriteLine($"Object {Name} disposed by Dispose() method.");
                ClearData();
            }
            else
            {
                Console.WriteLine($"Object {Name} disposed by ~Destructor.");
                ClearData();
            }
            _disposed = true;
        }

        protected virtual void ClearData()
        {
            Name = string.Empty;
            Author = string.Empty;
            Genre.Clear();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        ~Play()
        {
            Dispose(false);
        }
    }
}