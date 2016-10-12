using Ninject.Modules;
using SampleSolution.Data.Repository;
using SampleSolution.Data.Repository.Personnel;
using SampleSolution.Data.Repository.TrainSolution;
using SampleSolution.Interfaces.Personnel;
using SampleSolution.Interfaces.TrainSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSolution.DependencyResolution
{
    public class SampleNinjectDependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Bind<ITest>().To<EfTest>();
            Bind<IDataReaderRepository>().To<EfDataReaderRepository>();
            Bind<IPersonnelRepository>().To<EfPersonnelRepository>();
        }
    }
}
