using eTickets.Data.Services;
using eTickets.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IActorService _actorService;
        private readonly ICinemaService _cinemaService;
        private readonly IProducersService _producerService;

        public MoviesController(
            IMovieService movieService,
            IActorService actorService,
            ICinemaService cinemaService,
            IProducersService producerService)
        {
            _movieService = movieService;
            _actorService = actorService;
            _cinemaService = cinemaService;
            _producerService = producerService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _movieService.GetAllAsync();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _movieService.GetByIdAsync(id);
            if (movieDetails == null) return View("NotFound");
            return View(movieDetails);
        }

        // GET: Movies/Create
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var newMovieVM = new NewMovieVM()
            {
                Actors = await _actorService.GetAllAsync(),
                Cinemas = await _cinemaService.GetAllAsync(),
                Producers = await _producerService.GetAllAsync()
            };

            return View(newMovieVM);
        }

        // POST: Movies/Create
        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM data)
        {
            if (!ModelState.IsValid)
            {
                // Print all model state errors
                foreach (var key in ModelState.Keys)
                {
                    var errors = ModelState[key].Errors;
                    foreach (var error in errors)
                    {
                        Console.WriteLine($"ModelState error for {key}: {error.ErrorMessage}");
                    }
                }

                data.Actors = await _actorService.GetAllAsync();
                data.Cinemas = await _cinemaService.GetAllAsync();
                data.Producers = await _producerService.GetAllAsync();
                return View(data);
            }

            await _movieService.AddNewMovieAsync(data);  
            return RedirectToAction(nameof(Index));
        }

    }
}
