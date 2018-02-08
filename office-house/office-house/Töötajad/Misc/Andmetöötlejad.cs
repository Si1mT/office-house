using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house
{
    class Andmetöötlejad : Töötaja
    {
        public void Andmetöötleja()
        {
            Andmetöötlejaõigus = true;
            Töötajaõigus = true;
        }
    }
}
