using SampleSolution.Entities.Personnel;
using SampleSolution.Interfaces.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSolution.Data.Repository.Personnel
{
    public class EfPersonnelRepository : IPersonnelRepository
    {
        public IEnumerable<PersonnelList> GetPersonnelList()
        {
            var personnelList = new[]
            {
              new PersonnelList {PersonnelId= 1, PersonnelName="ALEX", PersonnelCode="A0011", Email="alex@test.test", ContactNumber= "02 5632 1233", Address="BELROSE"},
              new PersonnelList {PersonnelId= 2, PersonnelName="BOB", PersonnelCode="B0022", Email="bob@test.test", ContactNumber= "02 2531 2587", Address="ST IVES"},
              new PersonnelList {PersonnelId= 3, PersonnelName="JACKI", PersonnelCode="C0033", Email="jacki@test.test", ContactNumber= "02 6324 1257", Address="THE PONDS"}
            };
            return personnelList;
        }
    }
}
