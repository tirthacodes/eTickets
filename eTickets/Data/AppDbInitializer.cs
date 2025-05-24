using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            name = "Cinema 1",
                            logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            description = "This is the description of the first cinema"
                        },

                        new Cinema()
                        {
                            name = "Cinema 2",
                            logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            description = "This is the description of the second cinema"
                        },

                        new Cinema()
                        {
                            name = "Cinema 3",
                            logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            description = "This is the description of the third cinema"
                        },

                        new Cinema()
                        {
                            name = "Cinema 4",
                            logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            description = "This is the description of the fourth cinema"
                        },

                    }
                    );
                    context.SaveChanges();

                }
                //actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            fullName = "Actor 1",
                            bio="This is the bio of first actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },

                        new Actor()
                        {
                            fullName = "Actor 2",
                            bio="This is the bio of second actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },

                        new Actor()
                        {
                            fullName = "Actor 3",
                            bio="This is the bio of third actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },

                        new Actor()
                        {
                            fullName = "Actor 4",
                            bio="This is the bio of fourth actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },

                        new Actor()
                        {
                            fullName = "Actor 5",
                            bio="This is the bio of fifth actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        },

                    }
                    );
                    context.SaveChanges();
                }
                //producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            fullName = "Producer 1",
                            bio="This is the bio of first Producer",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },

                        new Producer()
                        {
                            fullName = "Producer 2",
                            bio="This is the bio of second Producer",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },

                        new Producer()
                        {
                            fullName = "Producer 3",
                            bio="This is the bio of third Producer",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },

                        new Producer()
                        {
                            fullName = "Producer 4",
                            bio="This is the bio of fourth Producer",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },

                        new Producer()
                        {
                            fullName = "Producer 5",
                            bio="This is the bio of fifth Producer",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        },

                    }
                    );
                    context.SaveChanges();
                }
                //movies
                if (!context.Movies.Any())
                {

                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            name = "Life",
                            description = "This is the Life movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            movieCategory = movieCategory.Documentary
                        },
                        new Movie()
                        {
                            name = "The Shawshank Redemption",
                            description = "This is the Shawshank Redemption description",
                            price = 29.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            movieCategory = movieCategory.Action
                        },
                        new Movie()
                        {
                            name = "Ghost",
                            description = "This is the Ghost movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(7),
                            CinemaId = 2,
                            ProducerId = 4,
                            movieCategory = movieCategory.Horror
                        },
                        new Movie()
                        {
                            name = "Race",
                            description = "This is the Race movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            movieCategory = movieCategory.Documentary
                        },
                        new Movie()
                        {
                            name = "Scoob",
                            description = "This is the Scoob movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            movieCategory = movieCategory.Cartoon
                        },
                        new Movie()
                        {
                            name = "Cold Soles",
                            description = "This is the Cold Soles movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            startDate = DateTime.Now.AddDays(3),
                            endDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            movieCategory = movieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //actors & movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 2
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
