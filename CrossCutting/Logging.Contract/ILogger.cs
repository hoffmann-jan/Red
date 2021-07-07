namespace JanHoffmann.Red.CrossCutting.Logging.Contract
{
    public interface ILogger
    {
        void Gerneral(string message);
        void Warning(string message);
    }
}
