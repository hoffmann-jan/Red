using System;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.Aspects
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = true)]
    public sealed class ExceptionMapAttribute : Attribute
    {
        public Type TypeToMapTo { get; }
        public string Message { get; }

        public ExceptionMapAttribute(Type typeToMapTo, string message = null)
        {
            TypeToMapTo = typeToMapTo;
            Message = message;
        }
    }
}
