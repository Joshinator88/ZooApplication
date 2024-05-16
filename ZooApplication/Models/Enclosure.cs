namespace ZooApplication.Models
{
    public class Enclosure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public enum Climate
        {
            Tropical,
            Temperate,
            Artic
        }
        public enum HabitatType
        {
            Forest,
            Aquatic,
            Desert,
            Grassland
        }
        public enum SecurityLevel
        {
            Low,
            Medium, 
            High
        }
        public double Size { get; set; }
    }
}
