using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ListTrailer.Models;
using ListTrailer.Services;

namespace ListTrailer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonMovieService MovieService;
        public IEnumerable<Movie> Movies { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonMovieService movieService)
        {
            _logger = logger;
            MovieService = movieService;
        }

        public void OnGet()
        {
            Movies = MovieService.GetMovies();
        }
    }
}
