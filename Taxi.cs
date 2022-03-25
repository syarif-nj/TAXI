using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectTaxi
{
    class Taxi
    {
        public string Drivername { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver : {0}", Drivername);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            if (OnDuty == false)
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number Of Passenger: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedanga Menjemput Penumpang", Drivername);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang", Drivername);
        }
    }
}
