using System.Collections.Generic;
using System.Threading.Tasks;
using ThisDevelopersLife.Models;

namespace ThisDevelopersLife.Services
{
    public interface IShowService
    {
        Task AddAsync(Episode episode);
        Task<Episode> FindAsync(string slug);
        Task<IEnumerable<Episode>> LoadAsync();
    }
}