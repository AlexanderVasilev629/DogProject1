using System.ComponentModel.DataAnnotations;

namespace DogsApp.Models.Dog
{
    public class DogCreateViewModel
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display (Name = "Name")]

    }
}
