namespace WebApplication1.Models
{
    public class EFBowlingRepository : IBowlingRepository
    {
        private BowlingLeagueContext _bowlingLeagueContext;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingLeagueContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _bowlingLeagueContext.Bowlers;

        public IEnumerable<BowlerScore> BowlerScores => _bowlingLeagueContext.BowlerScores;

        public IEnumerable<MatchGame> MatchGames => _bowlingLeagueContext.MatchGames;

        public IEnumerable<Team> Teams => _bowlingLeagueContext.Teams;

        public IEnumerable<Tournament> Tournaments => _bowlingLeagueContext.Tournaments;

        public IEnumerable<TourneyMatch> TourneyMatches => _bowlingLeagueContext.TourneyMatches;

        public IEnumerable<ZtblBowlerRating> ZtblBowlerRatings => _bowlingLeagueContext.ZtblBowlerRatings;

        public IEnumerable<ZtblSkipLabel> ZtblSkipLabels => _bowlingLeagueContext.ZtblSkipLabels;

        public IEnumerable<ZtblWeek> ZtblWeeks => _bowlingLeagueContext.ZtblWeeks;
    }
}
