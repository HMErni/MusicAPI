using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        // Navigation properties
        public Authors Authors { get; set; }
    }
}