using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public class MovieService : EntityBaseRepository<Movie>, IMovieService
    {
        private readonly AppDbContext _context;

        public MovieService(AppDbContext context) : base(context) 
        {

        }

    }
}
