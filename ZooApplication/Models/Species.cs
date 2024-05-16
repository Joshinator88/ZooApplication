namespace ZooApplication.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public enum Size 
        {
        Microscopic,
        VerySmall,
        Small,
        Medium,
        Large,
        VeryLarge
        }
        public enum DietaryClass
        {
            Carnivore,
            Herbivore,
            Omnivore,
            Insectivore,
            Piscivore
        }
        public enum ActivityPattern
        {
            Diurnal,
            Nocturnal,
            Cathemeral
        }
        public PreditorPrey Prey { get; set; }
        public Enclosure Enclosure { get; set; }
        public double SpaceRequirement { get; set; }
        public enum SecurityRequirement
        {
            Low,
            Medium,
            High
        }
    }
}
