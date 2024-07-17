using System.ComponentModel.DataAnnotations;

namespace MusicAPI.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        

        public Music Music { get; set; }   

        public ICollection<Authors> Authors{ get; set; }
        
    }
}