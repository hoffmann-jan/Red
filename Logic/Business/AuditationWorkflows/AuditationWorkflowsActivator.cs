using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Bootstrapping;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.EventBrokerage;

namespace JanHoffmann.Red.Logic.Business.AudiationWorkflows
{
    public class AuditationWorkflowsActivator : IComponentActivator
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
        }

        public void AddMessageSubscriptions(IEventBroker broker)
        {
            //broker.Subscribe<EntityChangedAuditationWorkflow, EntityChangedMessage>((handler, msg) => handler.Process(msg));
            //broker.Subscribe<PersonLoadedAuditationWorkflow, PersonLoadedMessage>((handler, msg) => handler.Process(msg));
        }

        public void Configure(IConfigurator config)
        {
        }
    }
}
