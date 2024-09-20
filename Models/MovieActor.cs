using Ecommerce.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class MovieActor
    {
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movies { get; set; }
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actors { get; set; }
    }
}
