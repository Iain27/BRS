using System;
namespace BRS_Prototype.Models
{
    public class MockBloodRedSkiesPlaneRepository : IBloodRedSkiesPlaneRepository
    {
        private readonly INationRepository _countryRepository = new
            MockCountryRepository();

        public IEnumerable<BloodRedSkiesPlane> AllBloodRedSkiesPlanes =>
            new List<BloodRedSkiesPlane>
            {
                new BloodRedSkiesPlane{ BloodRedSkiesPlaneID = 1, NationId =1, Points = 41,  Speed = 9, Type = "Spitfire XIV", Firepower = 2, Manouverability = 2 },
                new BloodRedSkiesPlane{ BloodRedSkiesPlaneID = 2, NationId =1, Points = 31,  Speed = 7, Type = "Spitfire II", Firepower = 1, Manouverability = 3 },
                new BloodRedSkiesPlane{ BloodRedSkiesPlaneID = 3, NationId =1, Points = 32,  Speed = 6, Type = "Spitfire VB", Firepower = 1, Manouverability = 2 },
                new BloodRedSkiesPlane{ BloodRedSkiesPlaneID = 4, NationId =1, Points = 26,  Speed = 6, Type = "Hurricane I", Firepower = 1, Manouverability = 2 },
                new BloodRedSkiesPlane{ BloodRedSkiesPlaneID = 5, NationId =2, Points = 37,  Speed = 8, Type = "Bf109 G", Firepower = 2, Manouverability = 2 },
                new BloodRedSkiesPlane{ BloodRedSkiesPlaneID = 6, NationId =2, Points = 50,  Speed = 7, Type = "Bf110 G", Firepower = 3, Manouverability = 0 },
               
            };

        public IEnumerable<BloodRedSkiesPlane> BloodRedSkiesPlaneByCountry => throw new NotImplementedException();

        public BloodRedSkiesPlane? GetBRSPlaneById(int bloodRedSkiesPlaneId) => AllBloodRedSkiesPlanes.FirstOrDefault(p => p.BloodRedSkiesPlaneID == bloodRedSkiesPlaneId);

    }
}

