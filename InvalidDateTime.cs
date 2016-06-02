using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseboatRental
{
    class InvalidDateTime : Exception
    {
        public InvalidDateTime(String message): base(message)
        {

        }
    }
}
