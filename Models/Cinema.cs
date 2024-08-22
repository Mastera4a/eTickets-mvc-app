using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Cinema Logo is Required")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Cinema Name is Required")]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cinema Description is Required")]
        [Display(Name = "Descriptions")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
