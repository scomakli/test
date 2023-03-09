using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class Bus : Interfaces.IVehicle
    {
        public Bus()
        {
            Type = "Otobüs";
            Brand = "Mercedes";
            ModelYear = "2012";
        }
        public string Type { get ; set ; }
        public string Brand { get; set ; }
        public string ModelYear { get ; set; }

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
