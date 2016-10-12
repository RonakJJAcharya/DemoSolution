using SampleSolution.Entities.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSolution.Interfaces.Personnel
{
    public interface IPersonnelRepository
    {
        IEnumerable<PersonnelList> GetPersonnelList();
    }
}
