using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<NewMovieVM>
    {
        Task<NewMovieVM> GetMovieById(int id);
    }
}
