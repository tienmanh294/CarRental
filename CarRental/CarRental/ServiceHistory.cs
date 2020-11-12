using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class ServiceHistory
    {
        public Engine _Engine;
        public Transmission _Tranmission;
        public Tires _Tires;
        private Vehicles vehicle;
        public ServiceHistory(Vehicles vhc)
        {
            vehicle = vhc;
        }

    }
}
