using Indexe_Exception_Practice.Helpers.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Indexe_Exception_Practice.Exceptions
{
    public class RegisterFailedException:Exception
    {
        public RegisterFailedException():this(AccountMessages.RegisterFailed)
        {
            
        }
        public RegisterFailedException(string message):base(message)
        {
            
        }
    }
}
