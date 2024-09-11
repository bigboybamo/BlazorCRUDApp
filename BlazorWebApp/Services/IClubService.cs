using BlazorWebApp.Models;

namespace BlazorWebApp.Services
{
    public interface IClubService
    {
        Task<List<Club>> GetClubs();
        Task<Club> GetClub(int id);
        Task AddClub(Club club);
        Task UpdateClub(Club club);
        Task DeleteClub(int id);
    }
}
