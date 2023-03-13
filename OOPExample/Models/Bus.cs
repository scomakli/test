using OOPExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Models
{
    public class Bus : Interfaces.IVehicle,Interfaces.IInfo<Bus>
    {
        public Bus(string _type, string _brand, string _modelyear)
        {
            Type =_type;
            Brand =_brand;
            ModelYear =_modelyear;
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
            Console.WriteLine(ModelYear + " Model " + Brand + " Marka " + Type + " Otoparka Girdi.Sisteme Kaydedildi");
        }       

        public void Info()
        {
            Console.WriteLine("Başarılı");
        }

        
    }
}
