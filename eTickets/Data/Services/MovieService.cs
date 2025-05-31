using eTickets.Data.Base;
using eTickets.Models;
using eTickets.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _context.Movies
                .Include(m => m.Cinema)
                .Include(m => m.Producer)
                .Include(m => m.Actors_Movies)
                    .ThenInclude(am => am.Actor)
                .FirstOrDefaultAsync(m => m.id == id);
        }

        public async Task AddNewMovieAsync(NewMovieVM data)
        {
            var movie = new Movie()
            {
                name = data.name,
                description = data.description,
                price = data.price,
                imageURL = data.imageURL,
                startDate = data.startDate,
                endDate = data.endDate,
                movieCategory = data.movieCategory,
                CinemaId = data.CinemaId,
                ProducerId = data.ProducerId,
            };

            // Add movie
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();

            // Add actor relationships
            foreach (var actorId in data.ActorIds)
            {
                var actorMovie = new Actor_Movie()
                {
                    MovieId = movie.id,
                    ActorId = actorId
                };
                await _context.Actor_Movies.AddAsync(actorMovie);
            }

            await _context.SaveChangesAsync();
        }



    }
}
