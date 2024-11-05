namespace SalleDeGymAPI.Models
{
    public class Activite
    {
        public int Activite_id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int CapaciteMax { get; set; }
        public DateTime DateHeure { get; set; }
    }
}
