using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicAPI.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        //Navigation properties
        public ICollection<Music> Music { get; set; }


        //Navigation properties
        public ICollection<Authors> Authors{ get; set; }
        
    }

}