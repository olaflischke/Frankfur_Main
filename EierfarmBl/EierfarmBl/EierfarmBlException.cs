using System;
using System.Runtime.Serialization;

namespace EierfarmBl
{
    [Serializable]
    internal class EierfarmBlException : Exception
    {
        public EierfarmBlException()
        {
        }

        public EierfarmBlException(string message) : base(message)
        {
        }

        public EierfarmBlException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EierfarmBlException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}