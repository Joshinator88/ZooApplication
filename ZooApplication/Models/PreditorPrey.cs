namespace ZooApplication.Models
{
    public class PreditorPrey
    {
        public int Id { get; set; }
        public Species Preditor { get; set; }
        public Species Prey { get; set; }
    }
}
