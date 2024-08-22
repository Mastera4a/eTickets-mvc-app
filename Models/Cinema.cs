using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Required]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Descriptions")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
