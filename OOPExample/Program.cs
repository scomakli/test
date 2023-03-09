using OOPExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.EnteredPark();

            Bus bus = new Bus();
            bus.CameOutPark();

            Truck truck = new Truck();
            truck.EnteredPark();
        }
    }

}
