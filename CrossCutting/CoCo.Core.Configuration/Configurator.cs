using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration.DataClasses;
using JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Configuration
{
    public class Configurator : IConfigurator
    {
        private readonly IConfigurationRepository _repository;
        private readonly IList<ConfigurationEntry> _entries;

        public Configurator(IConfigurationRepository repository)
        {
            if (repository == null) throw new ArgumentNullException(nameof(repository));

            _repository = repository;
            _entries = _repository.Load().ToList();
        }

        public int Count => _entries.Count;

        public T Get<T>(string category, string key)
        {
            if (string.IsNullOrWhiteSpace(category)) throw new ArgumentNullException(nameof(category));
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            var exist = _entries.Any(e => e.Category == category && e.Key == key);
            if (!exist)
            {
                throw new KeyOrCategoryNoException(category, key);
            }

            var value = Get<T>(category, key, default(T));
            return value;
        }

        public T Get<T>(string category, string key, T defaultValue)
        {
            if (string.IsNullOrWhiteSpace(category)) throw new ArgumentNullException(nameof(category));
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            var entry = _entries.SingleOrDefault(e => e.Category == category && e.Key == key);
            if (entry == null)
            {
                return defaultValue;
            }

            return (T) entry.Value;
        }

        public void Set<T>(string category, string key, T value, bool persist = false)
        {
            if (string.IsNullOrWhiteSpace(category)) throw new ArgumentNullException(nameof(category));
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));

            var predicate = new Func<ConfigurationEntry, bool>(e => e.Category == category && e.Key == key);

            ConfigurationEntry entry = null;
            var exist = _entries.Any(predicate);
            if (exist)
            {
                entry = _entries.Single(predicate);
                entry.Value = value;
                entry.Persist = persist;
            }
            else
            {
                entry = new ConfigurationEntry
                {
                    Category = category,
                    Key = key,
                    Persist = persist,
                    Value = value,
                    Source = null
                };
                _entries.Add(entry);
            }

            if (persist)
            {
                _repository.SaveEntry(entry);
            }
        }
    }
}
