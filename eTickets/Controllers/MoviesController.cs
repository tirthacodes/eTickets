using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _service;

        public MoviesController(IMovieService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }


        //Get: Movies/Details/1
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null) return View("NotFound");
            return View(movieDetails);
        }





    }
}
