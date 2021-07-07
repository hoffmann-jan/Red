namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Configuration
{
    public interface IConfigurator
    {
        T Get<T>(string category, string key, T defaultValue = default(T));
        void Set<T>(string category, string key, T value, bool persist = false);
    }
}
