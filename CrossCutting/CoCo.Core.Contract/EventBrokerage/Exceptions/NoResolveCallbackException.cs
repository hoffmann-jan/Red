using System;
using System.Runtime.Serialization;

namespace JanHoffmann.Red.CrossCutting.CoCo.Core.Contract.EventBrokerage.Exceptions
{
    [Serializable]
    public class NoResolveCallbackException : EventBrokerageException
    {
        public NoResolveCallbackException()
        {
        }

        public NoResolveCallbackException(string message) : base(message)
        {
        }

        public NoResolveCallbackException(string message, Exception inner) : base(message, inner)
        {
        }

        protected NoResolveCallbackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
