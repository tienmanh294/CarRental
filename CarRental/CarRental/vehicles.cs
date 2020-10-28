using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    class Vehicles
    {
        public string color;
        public int price;
        public string type;
        public string brand;
        public int seat;
        public string state;

        public Vehicles()
        {

        }
        ~Vehicles() { }
        
    }

    class Car : Vehicles
    {
        
    }
    
    class Truck: Vehicles
    {
        public int weightLoad;
    }

    class Bus: Vehicles
    {

    }

}
