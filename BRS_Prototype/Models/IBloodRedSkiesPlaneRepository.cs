namespace BRS_Prototype.Models
{
    public interface IBloodRedSkiesPlaneRepository
    {
        IEnumerable<BloodRedSkiesPlane> AllBloodRedSkiesPlanes  { get;}
        IEnumerable<BloodRedSkiesPlane> BloodRedSkiesPlaneByCountry { get; }
        BloodRedSkiesPlane? GetBRSPlaneById(int bloodRedSkiesPlaneID);
    }
}

