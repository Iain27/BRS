using System;
namespace BRS_Prototype.Models
{
    public interface INationRepository
    {
        IEnumerable<Nation> AllNations { get; }
        Nation? GetNationById(int nationId);
    }
}

