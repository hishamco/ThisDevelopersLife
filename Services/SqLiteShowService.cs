using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThisDevelopersLife.Models;

namespace ThisDevelopersLife.Services
{
    public class SqLiteShowService : IShowService
    {
        private readonly TDLContext _db;
        
        public SqLiteShowService(TDLContext db)
        {
            _db = db;
        }
        
        public Task AddAsync(Episode episode)
        {
            _db.Add(episode);
            _db.SaveChangesAsync();
            return Task.FromResult(0);
        }
        
        public Task AddAsync(string title, string summary, string slug)
        {
            var episode = new Episode(){
                Title = title,
                Summary = summary,
                Slug = slug
            };
            
            return AddAsync(episode);
        }

        public Task<Episode> FindAsync(string slug)
        {
            var episode = LoadAsync().Result.Where(e => e.Slug == slug).Single();
            
            return Task.FromResult(episode);
        }

        public Task<IEnumerable<Episode>> LoadAsync()
        { 
            var episodes = _db.Episodes.OrderByDescending(e => e.Title).AsEnumerable();
                      
            return Task.FromResult(episodes);
        }
    }
}