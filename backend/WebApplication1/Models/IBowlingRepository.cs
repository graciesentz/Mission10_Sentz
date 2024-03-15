using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public interface IBowlingRepository
    {
        IEnumerable<Bowler> Bowlers { get; }

        IEnumerable<BowlerScore> BowlerScores { get; }

        IEnumerable<MatchGame> MatchGames { get; }

        IEnumerable<Team> Teams { get; }

        IEnumerable<Tournament> Tournaments { get; }

        IEnumerable<TourneyMatch> TourneyMatches { get; }

        IEnumerable<ZtblBowlerRating> ZtblBowlerRatings { get; }

        IEnumerable<ZtblSkipLabel> ZtblSkipLabels { get; }

        IEnumerable<ZtblWeek> ZtblWeeks { get; }
    }
}
