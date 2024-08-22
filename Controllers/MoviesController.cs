using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        // GET: Movies/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _service.GetMovieById(id);
            return View(movieDetail);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to Our Store";
            ViewBag.Description = "This is The Store Description";

            return View();
        }
    }
}
