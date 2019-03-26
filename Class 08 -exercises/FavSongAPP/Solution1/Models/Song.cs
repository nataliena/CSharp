using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }
        public Song (string title, int length,Genre genre)
        {
            this.Title = title;
            this.Length = length;
            this.Genre =genre;

        }
      

        public string PrintSongInfo()
        {
            return $"Title: {Title}, Length {Length}, Genre {Genre}";
        }
    }
}
