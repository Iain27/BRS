using System;

namespace BRS_Prototype.Models
{
    public class MockCountryRepository : INationRepository
    {

        public IEnumerable<Nation> AllNations =>
            new List<Nation>
            {
                new Nation{ NationId = 1, NationName="Britain"},
                new Nation{ NationId = 2, NationName="Germany"},
                new Nation{ NationId = 3, NationName="USA"},
                new Nation{ NationId = 4, NationName="Russia"},
                new Nation{ NationId = 5, NationName="Japan"}
            };

        public Nation? GetNationById(int nationId) => AllNations.FirstOrDefault(n => n.NationId == nationId);


    }
}

