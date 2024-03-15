
using Microsoft.AspNetCore.Identity;
using Mission10_Naumann.Data;
using System.IO.Compression;

namespace backendAPI.Data
{
    public class EFBowlersRepository : IBowlerRepository
    {
        private BowlerContext _bowlercontext;
        public EFBowlersRepository(BowlerContext temp) {
            _bowlercontext = temp;
        }

        public IEnumerable<Bowlers> Bowlers => _bowlercontext.Bowlers;

        public IEnumerable<Teams> Teams => _bowlercontext.Teams;

        public IEnumerable<BowlersAndTeams> GetBowlersAndTeams()
        {
            var query = from bowler in _bowlercontext.Bowlers
                        join team in _bowlercontext.Teams on bowler.TeamID equals team.TeamID
                        where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                        select new BowlersAndTeams
                        {
                            BowlerId = bowler.BowlerID,
                            BowlerFirstName = bowler.BowlerFirstName,
                            BowlerLastName = bowler.BowlerLastName,
                            BowlerMiddleInit = bowler.BowlerMiddleInit,
                            BowlerAddress = bowler.BowlerAddress,
                            BowlerCity = bowler.BowlerCity,
                            BowlerState = bowler.BowlerState,
                            BowlerZip = bowler.BowlerZip,
                            BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                            TeamName = team.TeamName
                        };

            return query.ToList();
        }


    }
}
