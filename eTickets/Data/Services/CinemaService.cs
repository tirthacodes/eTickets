using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        private readonly AppDbContext _context;

        public CinemaService(AppDbContext context) : base(context) { }
        
    }
}
