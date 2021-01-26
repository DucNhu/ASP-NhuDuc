using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListTrailer.Services;
using Microsoft.AspNetCore.Mvc;
using ListTrailer.Models;

namespace ListTrailer.Controllers
{
    [Route("controller")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public MoviesController(JsonMovieService movieService)
        {
            this.MovidService = movieService;
        }
        public JsonMovieService MovidService { get; }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return MovidService.GetMovies();
        }
    }
}
