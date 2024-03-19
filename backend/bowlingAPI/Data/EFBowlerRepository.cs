using bowlingAPI.Data;

using Microsoft.EntityFrameworkCore;
using static bowlingAPI.Data.EFBowlerRepository;

namespace bowlingAPI.Data
{
    public class EFBowlerRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlerContext;

        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _bowlerContext = temp;
        }

        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers.Include(x => x.Team).ToList();
        public IEnumerable<Team> Teams => _bowlerContext.Teams;
    }
}