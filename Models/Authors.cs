using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MusicAPI.Models
{
    public class Authors
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Music> Music { get; set; }

        public int ArtistID { get; set; }
        public Artist Artist { get; set; }

        public ICollection<Album> Album { get; set; }   
 
    }
}