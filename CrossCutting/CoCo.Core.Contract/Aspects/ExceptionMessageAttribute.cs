using System;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Aspects
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, Inherited = true)]
    public sealed class ExceptionMessageAttribute : Attribute
    {
        public string Message { get; }

        public ExceptionMessageAttribute(string message)
        {
            Message = message;
        }
    }
}
