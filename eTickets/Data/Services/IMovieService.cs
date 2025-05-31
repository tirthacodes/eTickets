using eTickets.Data.Base;
using eTickets.Models;
using eTickets.ViewModels;

namespace eTickets.Data.Services
{
    public interface IMovieService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetByIdAsync(int id);  // Overriding 

        Task AddNewMovieAsync(NewMovieVM data);

    }
}
