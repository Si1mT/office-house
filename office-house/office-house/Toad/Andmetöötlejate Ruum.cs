using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house.Toad
{
    class Andmetöötlejate_Ruum : Ruum
    {
        public override void ÕigusjaTöö()
        {
            if (Nooremarendajaõigus == true)
            {
                Console.WriteLine("Nooremarendaja ei ole lubatud Andmetöötlejate ruumi");
            }
            else
            {
                Console.WriteLine("Tulge sisse");
            }
            base.ÕigusjaTöö();
        }
    }
}
