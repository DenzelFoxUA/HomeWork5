using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public static class PlayTask
    {
        public static void Run()
        {
            Play play = new Play
            (
                "Hamlet",
                "Shakespeare, William",
                1601,
                Genres.Drama, Genres.Tragedy
            );

            Console.WriteLine(play);

            //розкоментувати для використання методу Dispose()
            //play.Dispose();
        }
    }
}
