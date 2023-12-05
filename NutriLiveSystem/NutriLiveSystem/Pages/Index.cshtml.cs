using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NutriLiveSystem.Pages
{
    public class IndexModel : PageModel
    {
        public string Title { get; set; }
        public void OnGet()
        {
            Title = "NutriLive System";
        }
    }
}
