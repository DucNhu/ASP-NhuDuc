using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ListTrailer.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;


namespace ListTrailer.Services
{
    public class JsonMovieService { 
        public JsonMovieService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    public IWebHostEnvironment WebHostEnvironment { get; }

    private string JsonFileName
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "youtube.json"); }
    }

    public IEnumerable<Movie> GetMovies()
    {
        using (var jsonFileReader = File.OpenText(JsonFileName))
        {
            return JsonSerializer.Deserialize<Movie[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
    }
    
    }
}
