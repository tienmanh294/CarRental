using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    abstract class Vehicles
    {
        public string color;
        public int price;
        public string brand;
        public int seat;
        public string state;
        public int mileage;
        
        public ServiceHistory History;
        public Vehicles() { }
        public Vehicles(string c, int p, string b, int s, string _state)
        {
            color = c;
            price = p;
            brand = b;
            seat = s;
            state = _state;
           
            
        }
        public Vehicles(int n)
        {
            List<Vehicles> VehicleList = new List<Vehicles>();
        }
        public Vehicles(ServiceHistory H)
        {
            History = H;
        }
        public abstract void ServiceEngine();

        public abstract void ServiceTransmission();
        public abstract void ServiceTires();
        
    }

}
