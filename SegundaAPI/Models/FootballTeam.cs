using SegundaAPI.Models.Interface;

namespace SegundaAPI.Models
{
    public class FootballTeam : IFootballTeam
    {
        public int Id { get; set; }
        public string NameTeam { get; set; }
        public int QuantityPlayers { get; set; }
        public ECountry CountryTeam { get; set; }
        public FootballTeam() { }
        public FootballTeam(int id, string nameTeam, int quantityPlayers, ECountry countryTeam)
        {
            Id = id;
            NameTeam = nameTeam;
            QuantityPlayers = quantityPlayers;
            CountryTeam = countryTeam;
        }
    }
}
