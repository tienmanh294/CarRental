using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
   
    class CarRentalManagement
    {

        CarRentalManagement()
        {
           
        }
        public void ServiceFleet(List<Car> carList,List<Bicycle> bicycleList,List<Truck>truckList)
        {
            foreach(Vehicles item in carList)
            {
                if(item.mileage>100000)
                {
                    item.ServiceEngine();
                    item.ServiceTires();
                    item.ServiceTransmission();
                }
            }
            foreach (Vehicles item in bicycleList)
            {
                if (item.mileage > 100000)
                {
                    item.ServiceEngine();
                    item.ServiceTires();
                    item.ServiceTransmission();
                }
            }
            foreach (Vehicles item in bicycleList)
            {
                if (item.mileage > 100000)
                {
                    item.ServiceEngine();
                    item.ServiceTires();
                    item.ServiceTransmission();
                }
            }
        }
    }
}
