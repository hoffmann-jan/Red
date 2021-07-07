using System;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration.DataClasses
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConfigurationMapAttribute : Attribute
    {
        public string Category { get; }
        public string Key { get; }
        public bool Persist { get; }

        public ConfigurationMapAttribute(string category, string key, bool persist = false)
        {
            Category = category;
            Key = key;
            Persist = persist;
        }
    }
}
