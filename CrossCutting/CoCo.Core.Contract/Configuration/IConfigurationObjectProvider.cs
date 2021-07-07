using System;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration
{
    public interface IConfigurationObjectProvider
    {
        TConfig Get<TConfig>();
        object Get(Type configType);
    }
}
