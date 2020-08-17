using OikonomiaAPI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaGUI.Data
{
    public interface IAffiliationRepo
    {
        IEnumerable<AffiliationReadDto> GetAffiliations();
        AffiliationReadDto GetAffiliationByID(int AffiliationId);
    }
}
