using Events.Model;
namespace Events.Services
{
    public interface ITalksService
    {
        IEnumerable<Talk> GetAllTalks();

        int Count();

        Talk GetTalk(int count);
    }
}
