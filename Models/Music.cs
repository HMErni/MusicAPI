using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models
{    public class Music
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public int AuthorsID { get; set; }
        public Authors Authors {get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}