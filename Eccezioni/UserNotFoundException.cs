using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni
{
    class UserNotFoundException:Exception
    {

        public UserNotFoundException()
        {
        }

        public UserNotFoundException(string message): base(message)
        {
                
        }

        public UserNotFoundException(string messaggio, Exception innerException) : base(messaggio, innerException)
        {

        }

        protected UserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
