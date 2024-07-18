using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAPI.Models
{    public class Music
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [ForeignKey(nameof(Authors))]
        public int AuthorsID { get; set; }
        //Navigation properties
        public Authors Authors {get; set; }


        [ForeignKey(nameof(Genre))]
        public int GenreID { get; set; }
        // Navigation properties
        public Genre Genre { get; set; }

        //Navigation properties
        public ICollection<Album> Album { get; set; }
    }
}