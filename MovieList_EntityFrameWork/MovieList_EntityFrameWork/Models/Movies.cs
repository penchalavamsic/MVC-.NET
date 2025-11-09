using System.ComponentModel.DataAnnotations;
namespace MovieList_EntityFrameWork.Models

//validations
{
    public class Movies
    {
        public int id { get; set; } 

        [Required(ErrorMessage= "Movie name is required")]
        public string Mname { get; set; }
        public string Hero { get; set; }
    [Required(ErrorMessage= "Budget is required")]
    [Range(1000, 1000000000, ErrorMessage = "Budget must be between 1,000 and 1,000,000,000")]
    public int budget { get; set; }
    }
}
