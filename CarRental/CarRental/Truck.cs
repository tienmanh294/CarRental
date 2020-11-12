using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Truck:Vehicles
    {
        public override void ServiceEngine()
        {
            History._Engine.major = "";
            History._Engine.minor = "";
            History._Engine.oilChange = "";

        }
        public override void ServiceTires()
        {
            History._Tires.adjustment = "";
            History._Tires.replacement = "";

        }
        public override void ServiceTransmission()
        {
            History._Engine.major = "";
            History._Engine.minor = "";
            History._Engine.oilChange = "";
        }
    }
}
