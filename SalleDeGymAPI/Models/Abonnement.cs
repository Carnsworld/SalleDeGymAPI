namespace SalleDeGymAPI.Models
{
    public class Abonnement
    {
        public int abonnement_id { get; set; }
        public string type { get; set; }
        public decimal prix { get; set; }
        public DateTime date_debut { get; set; }
        public DateTime date_fin { get; set; }

    }
}