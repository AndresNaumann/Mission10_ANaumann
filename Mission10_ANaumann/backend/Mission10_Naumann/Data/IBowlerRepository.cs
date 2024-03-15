

using Mission10_Naumann.Data;

namespace backendAPI.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
        IEnumerable<Teams> Teams { get; }

        IEnumerable<BowlersAndTeams> GetBowlersAndTeams();
    }
}
