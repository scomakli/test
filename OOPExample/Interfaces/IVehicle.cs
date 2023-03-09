using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample.Interfaces
{
    public interface IVehicle
    {
        string Type { get; set; }
        string Brand { get; set; }
        string ModelYear { get; set; }

        void EnteredPark();
        void CameOutPark();
    }
}
