using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace office_house
{
    class Töötaja
    {
        public bool Ülemusõigus;
        public bool Arendajaõigus;
        public bool Koristajaõigus;
        public bool Spetsiaalkoristajaõigus;
        public bool Andmetöötlejaõigus;
        public bool Nooremarendajaõigus;
        public bool Vanemarendajaõigus;
        public bool Töötajaõigus;
        
        public virtual void Work()
        {
            Console.WriteLine("Teen tööd");
        }
    }
}
