using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house.Toad
{
    class Köök : Ruum
    {
        public override void ÕigusjaTöö()
        {
            if (Töötajaõigus == true)
            {
                Console.WriteLine("Saad sisse");
            }
            else
            {
                Console.WriteLine("ainult töötajad saavad sisse");
            }
            base.ÕigusjaTöö();
        }
    }
}
