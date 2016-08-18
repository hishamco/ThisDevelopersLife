using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThisDevelopersLife.Models;
using ThisDevelopersLife.Services;

namespace ThisDevelopersLife.Pages
{
    public class Index : Page
    {
        private readonly IShowService _showService;
        
        public Index(IShowService showService)
        {
            _showService = showService;
        }

        public async Task<IEnumerable<Episode>> GetRecentEpisodes()
        {
            var episodes =  await _showService.LoadAsync();

            return episodes.Take(10).ToList();
        }
    }
}