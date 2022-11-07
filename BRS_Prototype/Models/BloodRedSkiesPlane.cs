using System;
namespace BRS_Prototype.Models
{
    public class BloodRedSkiesPlane
    {
        public int BloodRedSkiesPlaneID { get; set; }
        public int NationId { get; set; }
        public string? Type { get; set; }
        public int Points { get; set; }
        public int Firepower { get; set; }
        public int Manouverability { get; set; }
        public int Speed { get; set; }
        public int? Year { get; set; }
        public List<BloodRedSkiesTraits>? BRSTraits { get; }
    }
}

