using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection;
using JanHoffmann.Red.Logic.Business.AudiationWorkflows;
using JanHoffmann.Red.Logic.Domain.Audiation;

namespace JanHoffmann.Red.Mappings.DiMappings
{
    public class KernelInitializer : IKernelInitializer
    {
        public void Initialize(ICoCoKernel kernel)
        {
            kernel.RegisterComponent<AuditationWorkflowsActivator>();
            kernel.RegisterComponent<AuditationActivator>();
        }
    }
}
