using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListMyProduct.Models;
using ListMyProduct.Services;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace ListMyProduct.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileFestivalService FestivalService;
        public IEnumerable<festival> Festivals { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileFestivalService festivalService)
        {
            _logger = logger;
            FestivalService = festivalService;
        }

        public void OnGet()
        {
            Festivals = FestivalService.GetFestivals();
        }
    }
}
