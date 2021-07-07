using JanHoffmann.Red.CrossCutting.CoCo.Core.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Configuration.ConfigurationObjects;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Configuration.DatabaseSource;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Bootstrapping;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.DependencyInjection.DataClasses;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.EventBrokerage;
using JanHoffmann.Red.CrossCutting.CoCo.Core.EventBrokerage;
using JanHoffmann.Red.CrossCutting.Core.NinjectAdapter;
using JanHoffmann.Red.Mappings.DiMappings;
using System.IO;

namespace JanHoffmann.Red.UI.RedTaskBar
{
    internal sealed class Startup
    {
        internal IKernelContainer Start()
        {
            // Initialisation
            var kernelContainer = new KernelContainer();
            ICoCoKernel kernel = kernelContainer.Kernel;

            // Register CoCo.Core
            // Add Bootstrapper
            kernel.Register<IBootstrapper, Bootstrapper>(RegisterScope.Unique);
            // Add EventBroker
            kernel.Register<IEventBroker, EventBroker>(RegisterScope.Unique);
            // Add Configuration
            kernel.Register<IConfigurationRepository, DatabaseConfigurationRepository>();
            kernel.Register<IConfigurator, Configurator>(RegisterScope.Unique);
            kernel.Register<IConfigurationObjectProvider, ConfigurationObjectProvider>();

            //Register components
            new KernelInitializer().Initialize(kernel);

            var currentDirectory = Directory.GetCurrentDirectory();
            var configurator = kernel.Get<IConfigurator>();
            configurator.Set("DataStoring", "RootPath", currentDirectory);

            //Activate components
            var bootstrapper = kernel.Get<IBootstrapper>();
            bootstrapper.ActivatingAll();
            bootstrapper.ActivatedAll();
            bootstrapper.RegisterAllMappings(kernel);

            var eventBroker = kernel.Get<IEventBroker>();
            eventBroker.SetResolverCallback(t => kernel.Get(t));
            bootstrapper.AddAllMessageSubscriptions(eventBroker);
            
            return kernelContainer;
        }
    }
}
