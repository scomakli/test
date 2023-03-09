using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class Car : Interfaces.IVehicle
    {
        public Car() 
        { 
            Type= "Araba";
            Brand= "BMW";
            ModelYear= "2021";
        }
        public string Type { get; set; }
        public string Brand { get; set; }       
        public string ModelYear { get ; set ; }

        public void CameOutPark()
        {
            Console.WriteLine(ModelYear + " Model " + Brand + " Marka " + Type + " Otoparktan Çıktı.");
        }

        public void EnteredPark()
        {
            Console.WriteLine(ModelYear + " Model " + Brand + " Marka " + Type + " Otoparka Girdi.");
        }
    }

    
}
