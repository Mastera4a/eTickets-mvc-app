using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Data.ViewModels
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is Required")]
        public double Price { get; set; }
        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is Required")]
        public string ImageURL { get; set; }
        [Display(Name = "Movie Start Date")]
        [Required(ErrorMessage = "Start Date is Required")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Movie End Date")]
        [Required(ErrorMessage = "End Date is Required")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Select a Category")]
        [Required(ErrorMessage = "Movie Category is Required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is Required")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Select a Cinema")]
        [Required(ErrorMessage = "Movie Cinema is Required")]
        public int CinemaId { get; set; }
        [Display(Name = "Select a Producer")]
        [Required(ErrorMessage = "Movie Producer is Required")]
        public int ProducerId { get; set; }
    }
}
