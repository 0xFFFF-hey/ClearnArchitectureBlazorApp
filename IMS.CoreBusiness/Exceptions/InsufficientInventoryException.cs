using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.CoreBusiness.Exceptions
{
    public class InsufficientInventoryException : Exception
    {
        public InsufficientInventoryException(string message) : base(message) 
        { 
            
        }
    }
}
