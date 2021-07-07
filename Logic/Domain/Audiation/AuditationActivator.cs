using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Bootstrapping;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection.DataClasses;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.EventBrokerage;
using JanHoffmann.Red.Logic.Domain.Audiation.Contract;

namespace JanHoffmann.Red.Logic.Domain.Audiation
{
    public class AuditationActivator : IComponentActivator
    {
        public void Activating()
        {
        }

        public void Activated()
        {
        }

        public void Deactivating()
        {
        }

        public void Deactivated()
        {
        }

        public void RegisterMappings(ICoCoKernel kernel)
        {
            kernel.Register<IAuditor, Auditor>(RegisterScope.Unique);
        }

        public void AddMessageSubscriptions(IEventBroker broker)
        {
        }

        public void Configure(IConfigurator configurator)
        {
        }
    }
}
