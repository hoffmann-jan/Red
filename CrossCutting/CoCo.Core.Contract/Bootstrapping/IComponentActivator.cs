using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.EventBrokerage;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Bootstrapping
{
    public interface IComponentActivator
    {
        void Activating();
        void Activated();
        void Deactivating();
        void Deactivated();
        void RegisterMappings(ICoCoKernel kernel);
        void AddMessageSubscriptions(IEventBroker broker);
        void Configure(IConfigurator configurator); 
    }
}
