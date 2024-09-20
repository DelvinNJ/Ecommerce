using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class MovieCategory
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string CategoryImage { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
