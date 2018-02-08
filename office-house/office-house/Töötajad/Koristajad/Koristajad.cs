using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house
{
    class Koristajad : Töötaja
    {
        public void Koristaja()
        {
            Koristajaõigus = true;
            Töötajaõigus = true;
        }
    }
}
