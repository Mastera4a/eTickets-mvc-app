using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
