using MusicAPI.Models;

namespace MusicAPI.DTOs
{    public class MusicReadDTO
    {
        
        public int Id { get; set; }

        public string Name { get; set; }
   
        public int AuthorsID { get; set; }

        //Navigation properties
        public Authors Authors {get; set; }

        public int GenreID { get; set; }
        // Navigation properties
        public Genre Genre { get; set; }

        //Navigation properties
        public ICollection<Album> Album { get; set; }
    }
}