using BlazorGameApp.Models;

namespace BlazorGameApp.Services
{
    public interface IVideoGameService
    {
        Task<List<VideoGame>> GetAllGamesAsync();
    }
}
