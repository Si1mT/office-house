using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house.Toad
{
    class Arendajate_ruum : Ruum
    {
        public override void ÕigusjaTöö()
        {
            if (Andmetöötlejaõigus==true)
            {
                Console.WriteLine("Andmetöötlejad ei ole lubatud Arendajate ruumi");
            }
            else
            {
                Console.WriteLine("Tulge sisse");
            }
            base.ÕigusjaTöö();
        }
    }
}
