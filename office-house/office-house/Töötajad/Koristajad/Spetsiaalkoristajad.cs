using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house
{
    class Spetsiaalkoristajad : Töötaja
    {
        public void SpetsiaalKoristaja()
        {
            Spetsiaalkoristajaõigus = true;
            Töötajaõigus = true;
        }
    }
}
