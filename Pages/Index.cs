using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThisDevelopersLife.Models;

namespace ThisDevelopersLife.Pages
{
    public class Index : Page
    {
        public IEnumerable<Episode> GetRecentEpisodes()
        {
            return ShowDatabase.Recent(10);
        }
    }
}