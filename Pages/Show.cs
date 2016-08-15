using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ThisDevelopersLife.Models;

namespace ThisDevelopersLife.Pages
{
    public class Show : Page
    {
        public Episode GetEpisode(string slug)
        {
            return ShowDatabase.Find(slug);
        }
    }
}