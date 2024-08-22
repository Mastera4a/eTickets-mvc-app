using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "ProfilePictureURL")]
        public string ProfilePictureURL { get; set; }
        [Required]
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
