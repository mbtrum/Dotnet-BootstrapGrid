using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BootstrapGrid.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<String> Dogs { get; set; } = new();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            Dogs.Add("Charlie");
            Dogs.Add("Max");
            Dogs.Add("Cooper");
            Dogs.Add("Milo");
            Dogs.Add("Buddy");
            Dogs.Add("Teddy");
            Dogs.Add("Rocky");
            Dogs.Add("Bear");
            Dogs.Add("Leo");
            Dogs.Add("Duk");
            Dogs.Add("Luna");
            Dogs.Add("Bella");
            Dogs.Add("Daisy");
            Dogs.Add("Lucy");
            Dogs.Add("Lily");
            Dogs.Add("Lola");
            Dogs.Add("Zoe");
            Dogs.Add("Sadie");
            Dogs.Add("Stella");
            Dogs.Add("Bailey");
            Dogs.Add("Audrey");
        }

        public void OnGet()
        {

        }
    }
}