using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class Car : Interfaces.IVehicle, Interfaces.IInfo<Car>
    {
        public Car(string _type, string _brand, string _modelyear) 
        { 
            Type=_type;
            Brand= _brand;
            ModelYear= _modelyear;
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
     
        public void Info()
        {
            Console.WriteLine("Başarılı");
        }
    }

    
}
