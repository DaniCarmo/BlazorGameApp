using BlazorGameApp.Data;
using BlazorGameApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorGameApp.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly DataContext _context;

        public VideoGameService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<VideoGame>> GetAllGamesAsync()
        {
            var result = await _context.VideoGames.ToListAsync();
            return result;
        }
    }
}
