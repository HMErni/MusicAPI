using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MusicAPI.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }

        // [ForeignKey(nameof(Artist))]
        // public int ArtistID { get; set; }

        // Navigation properties
        public ICollection<Artist> Artist { get; set; }

       // Navigation properties
        public ICollection<Music> Music { get; set; }
        // Navigation properties
        public ICollection<Album> Album { get; set; }   
 
    }
}