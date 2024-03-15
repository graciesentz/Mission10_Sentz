using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingRepository _bowlingLeagueRepository;
        public BowlingLeagueController(IBowlingRepository temp) {
            _bowlingLeagueRepository = temp;
        }

        [HttpGet("bowlers")]
        public IEnumerable<Bowler> GetBowlers()
        {
            var bowlerData = _bowlingLeagueRepository.Bowlers.ToArray();

            return bowlerData;
        }

        [HttpGet("teams")]
        public IEnumerable<Team> GetTeams()
        {
            var teamData = _bowlingLeagueRepository.Teams.ToArray();

            return teamData;
        }
    }
}
