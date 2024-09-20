using Ecommerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Movie
    {
        [Key]
        public int Id{ get; set; }
        public string MovieImageURL { get; set; }
        public string MovieTitle{ get; set; }
        public string Description {  get; set; }
        public MovieType MovieType { get; set; }

        //Relationship
        public int MovieCategoryId { get; set; }
        [ForeignKey("MovieCategoryId")]
        public MovieCategory MovieCategory { get; set; }

        public List<MovieActor> MovieActors { get; set; }
    }
}
