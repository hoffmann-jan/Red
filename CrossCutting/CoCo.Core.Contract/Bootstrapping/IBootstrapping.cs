using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.EventBrokerage;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Bootstrapping
{
    public interface IBootstrapper
    {
        void ActivatingAll();
        void ActivatedAll();
        void DeactivatedAll();
        void DeactivatingAll();
        void RegisterAllMappings(ICoCoKernel kernel);
        void AddAllMessageSubscriptions(IEventBroker broker);
        void ConfigureAll(IConfigurator config);
    }
}
