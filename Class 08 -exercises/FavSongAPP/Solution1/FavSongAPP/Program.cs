using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace FavSongAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person("Natasha", "Andova", Genre.Hip_Hop);
            Song song1 = new Song("My Song1", 123, Genre.Classical);
            Song song2 = new Song("My Song2", 456, Genre.Rock);
            Song song3 = new Song("My Song3", 789, Genre.Techno);
            Song song4 = new Song("My Song4", 1233, Genre.Hip_Hop);
            person1.AddSong(song1);
            person1.AddSong(song2);
            person1.AddSong(song3);
            person1.AddSong(song4);

            person1.GetFavSong();
            
            


            Console.ReadLine();

        }
    }
}
