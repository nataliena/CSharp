using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        /*Create a class Person with the following properties:
        Id, FirstName, LastName, Age, FavoriteMusicType (Genre enum) 
        and FavoriteSongs
        FavoriteSongs is a list of Songs*/

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person (string firstName,string lastName,Genre favoriteMusicType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FavoriteMusicType = favoriteMusicType;
            this.FavoriteSongs = new List<Song>();

        }
        public void AddSong(Song song)
        {
            this.FavoriteSongs.Add(song);
        }

        public void GetFavSong()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("There are no favorite Songs in your List ");
            }
            else
            {
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.PrintSongInfo());
                }
            }
        }


    }
}
