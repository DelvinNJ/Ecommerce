using Ecommerce.Data.Enums;
using Ecommerce.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Data
{
    public class AppDbinitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) { 
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //MovieCategory
                if (!context.MovieCategories.Any())
                {
                    context.MovieCategories.AddRange(new List<MovieCategory>()
                    {
                        new MovieCategory() {
                            CategoryName = "Action",
                            Description = "Action",
                            CategoryImage = "https://picsum.photos/200"
                        },
                        new MovieCategory() {
                            CategoryName = "Comedy",
                            Description = "Comedy",
                            CategoryImage = "https://picsum.photos/200"
                        },
                    });
                    context.SaveChanges();
                }

                //Movie
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {   
                        new Movie() {
                            MovieImageURL = "https://picsum.photos/200/300",
                            MovieTitle = "ARM",
                            Description = "Malayalam movies",    
                            MovieType = MovieType.Flim,
                            MovieCategoryId = 1
                        },
                        new Movie() {
                            MovieImageURL = "https://picsum.photos/200/300",
                            MovieTitle = "Empuraan",
                            Description = "Malayalam movies",
                            MovieType = MovieType.Flim,
                            MovieCategoryId = 2
                        }
                    });
                    context.SaveChanges();
                }

                //Actor
                if (!context.Actors.Any()) {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor() {
                            Name = "Tovino thomas",
                            ActorImage = "https://picsum.photos/200/300"
                        }, 
                        new Actor() {
                            Name = "Mohanlal",
                            ActorImage = "https://picsum.photos/200/300"
                        }
                    });
                    context.SaveChanges();
                }

                //MovieActor
                if (!context.MovieActors.Any())
                {
                    context.MovieActors.AddRange(new List<MovieActor>() {
                        new MovieActor() {
                            MovieId=1,
                            ActorId=1
                        }
                    });
                    context.MovieActors.AddRange(new List<MovieActor>() {
                        new MovieActor() {
                            MovieId=1,
                            ActorId=2
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
