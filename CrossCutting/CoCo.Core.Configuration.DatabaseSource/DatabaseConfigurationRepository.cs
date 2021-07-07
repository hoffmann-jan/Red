using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration.DataClasses;

using System;
using System.Collections.Generic;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Configuration.DatabaseSource
{
    public class DatabaseConfigurationRepository : IConfigurationRepository
    {
        public IEnumerable<ConfigurationEntry> Load() => new List<ConfigurationEntry>
        {
            new ConfigurationEntry{Category = "Persons", Key = "AgeThreshold", Value = 6},
            new ConfigurationEntry{Category = "DataStoring.Csv", Key = "FilePath", Value = "data.csv"},
        };

        public void Save(IEnumerable<ConfigurationEntry> entriesToStore)
        {
            throw new NotImplementedException();
        }

        public void SaveEntry(ConfigurationEntry entry)
        {
            throw new NotImplementedException();
        }
    }
}
