namespace SegundaAPI.Models
{
    public class LeagueFootball
    {
        // colocar para não gerar repetido
        public List<FootballTeam> Teams { get; set; }
        public LeagueFootball() 
        { 
            Teams = new List<FootballTeam>();
            var r = new Random();
            int quantityTeams = r.Next(2, 5);
            for (int i = 0; i < quantityTeams - 1; i++)
            {
                Teams.Add(new FootballTeam(i, GenerateTeams.GenerateNameTeam(), GenerateTeams.GenerateQuantityPlayers(), GenerateTeams.GenerateCountryTeams()));
            }
        }
    }
}
