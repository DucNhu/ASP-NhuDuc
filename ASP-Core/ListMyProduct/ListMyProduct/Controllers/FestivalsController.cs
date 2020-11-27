using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListMyProduct.Models;
using ListMyProduct.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListMyProduct.Controllers
{
    [Route("controller")]
    [ApiController]
    public class FestivalsController : ControllerBase
    {
        public FestivalsController(JsonFileFestivalService fesService)
        {
            this.FestivalService = fesService;
        }

        public JsonFileFestivalService FestivalService { get; }

        [HttpGet] 
        public IEnumerable<festival> Get()
        {
            return FestivalService.GetFestivals();
        }

    }
}
