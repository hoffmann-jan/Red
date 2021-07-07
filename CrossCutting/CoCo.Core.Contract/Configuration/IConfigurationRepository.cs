using System.Collections.Generic;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration.DataClasses;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration
{
    public interface IConfigurationRepository
    {
        IEnumerable<ConfigurationEntry> Load();
        void Save(IEnumerable<ConfigurationEntry> entriesToStore);
        void SaveEntry(ConfigurationEntry entry);
    }
}
