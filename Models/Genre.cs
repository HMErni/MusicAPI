using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string GenreName { get; set; }

        public ICollection<Music> Music { get; set; }
    }
}