
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HelloworldRazopage.Models;

namespace HelloworldRazopage.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public AppMessage Heading { get; set; }
        public string SubHeading { get; set; }
        public void OnGet()
        {
            this.Heading = new AppMessage();
            this.Heading.Message = "HELL";
        }

        public void OnPost()
        {
            this.SubHeading = "Mess changed";
        }
    }
}
