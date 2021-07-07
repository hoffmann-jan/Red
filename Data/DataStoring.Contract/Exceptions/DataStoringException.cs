using System;
using System.Runtime.Serialization;

namespace JanHoffmann.Red.Data.DataStoring.Contract.Exceptions
{
    [Serializable]
    public class DataStoringException : Exception
    {
        public DataStoringException()
        {

        }

        public DataStoringException(string message) : base(message)
        {

        }

        public DataStoringException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public DataStoringException(SerializationInfo serializationInfo, StreamingContext streamingContext) :
            base(serializationInfo, streamingContext)
        {

        }
    }
}
