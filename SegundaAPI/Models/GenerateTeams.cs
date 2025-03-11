namespace SegundaAPI.Models
{
    public sealed class GenerateTeams
    {
        // colocar para não gerar repetido
        static readonly List<string> TeamsName;
        static GenerateTeams()
        {
            TeamsName = new List<string> { "Borussia Dortmund", "Bayern de Munique", "Gamba Osaka", "Flamengo", "Bournemouth" };
        }
        public static string GenerateNameTeam()
        {
            var r = new Random();
            // ver por que isso dá tanto erro
            int positionGenerated = r.Next(0, TeamsName.Count - 1);
            return TeamsName[positionGenerated]; 
        }
        public static int GenerateQuantityPlayers()
        {
            var r = new Random();
            return r.Next(15, 26);
        }
        public static ECountry GenerateCountryTeams()
        {
            var r = new Random();
            return (ECountry)r.Next(0, 4);
        }
    }
}
