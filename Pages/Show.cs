using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThisDevelopersLife.Models;
using ThisDevelopersLife.Services;

namespace ThisDevelopersLife.Pages
{
    public class Show : Page
    {
        private readonly IShowService _showService;
        
        public Show(IShowService showService)
        {
            _showService = showService;
        }
        
        public async Task<Episode> GetEpisode()
        {
            var slug = Context.Request.Query["slug"].Single();

            return await _showService.FindAsync(slug);
        }
    }
}