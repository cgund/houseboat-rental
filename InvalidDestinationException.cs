using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseboatRental
{
    class InvalidDestinationException : Exception
    {
        public InvalidDestinationException():base("Departure town and arrival town must be different")
        {

        }
    }
}
