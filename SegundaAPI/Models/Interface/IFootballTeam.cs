namespace SegundaAPI.Models.Interface
{
    public interface IFootballTeam
    {
        int Id { get; set; }
        string NameTeam { get; set; }
        int QuantityPlayers { get; set; }
        ECountry CountryTeam { get; set; }
    }
}
