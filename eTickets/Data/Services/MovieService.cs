using eTickets.Data.Base;
using eTickets.Models;
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

    }
}
