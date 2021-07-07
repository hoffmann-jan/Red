using JanHoffmann.Red.Logic.Domain.Audiation.Contract;

using System;

namespace JanHoffmann.Red.Logic.Domain.Audiation
{
    public class Auditor : IAuditor
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
