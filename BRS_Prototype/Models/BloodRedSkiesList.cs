namespace BRS_Prototype.Models
{
    public class BloodRedSkiesList
    {
        public int BloodRedSkiesListId { get; set; }
        public string Name { get; set; } = String.Empty;
        public string? Description { get; set; }
        public int NationId { get; set; }
        public List<BloodRedSkiesPlane>? BloodRedSkiesPLane { get; set; }
        public List<BloodRedSkiesPilot>? BloodRedSkiesPilot { get; set; }
        public List<BloodRedSkiesTraits>? BloodRedSkiesTraits { get; set; }
        public int Year { get; set; }

    }
}

