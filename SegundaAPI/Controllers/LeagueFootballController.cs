using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundaAPI.Models;
using System.Security.Cryptography.X509Certificates;


namespace SegundaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeagueFootballController : Controller
    {
        LeagueFootball league = new LeagueFootball();
        [HttpGet]
        // GET: api/LeagueFootballController
        public List<FootballTeam> Get()
        {
            return league.Teams;
        }
        // GET: api/LeagueFootballController/5
        [HttpGet("{id}")]
        public FootballTeam Get(int id)
        {
            // checar a condição caso não exista o time com respectivo id
            if (id > league.Teams.Count)
            {
                return new FootballTeam();
            }
            FootballTeam t = new FootballTeam();
            foreach (var team in league.Teams)
            {
                if (team.Id == id)
                {
                    t = team; 
                    break;
                }
            }
            return t;
        }
        // POST: api/LeagueFootballController
        [HttpPost]
        public List<FootballTeam> Post([FromBody] FootballTeam team)
        {
            league.Teams.Add(team);
            return league.Teams;
        }
        // PUT: api/LeagueFootballController
        [HttpPut("{id}")]
        public List<FootballTeam> Put(int id, [FromBody] FootballTeam t)
        {
            foreach (var team in league.Teams)
            {
                if (id == team.Id)
                {
                    team.Id = t.Id;
                    team.NameTeam = t.NameTeam;
                    team.CountryTeam = t.CountryTeam;
                    team.QuantityPlayers = t.QuantityPlayers;
                    break;
                }
            }
            return league.Teams;
        }
        // DELETE: api/LeagueFootballController
        [HttpDelete("{id}")]
        public List<FootballTeam> Delete(int id)
        {
            // descobrir o por que isso lança exception
            foreach (var team in league.Teams)
            {
                if (team.Id == id)
                {
                    league.Teams.Remove(team);
                    break;
                }
            }

            return league.Teams;
        }
    }
}
