using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UPK_E_Poster.Pages
{
    public class PosterlerModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public PosterlerModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
