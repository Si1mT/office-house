using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house.Toad
{
    class Ülemuste_Ruum : Ruum
    {
        public override void ÕigusjaTöö()
        {
            if (Vanemarendajaõigus == true)
            {
                Console.WriteLine("Saad sisse");
            }
            else if(Spetsiaalkoristajaõigus==true)
            {
                Console.WriteLine("Saad sisse");
            }
            else if (Ülemusõigus == true)
            {
                Console.WriteLine("Saad sisse");
            }
            else
            {
                Console.WriteLine("Ainult vanemarendajad,ülemused ja spetsiaalkoristajad saavad sisse");
            }
            base.ÕigusjaTöö();
        }
    }
}
