using MovieAddictPro.Models.Database;
using MovieAddictPro.Models.TMDB;

namespace MovieAddictPro.Services.Interfaces
{
    public interface IDataMappingService
    {
        Task<Movie> MapMovieDetailAsync(MovieDetail movie);
        ActorDetail MapActorDetail(ActorDetail actor);
    }
}
