using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class auto
    {
        private string marka;
        private string modellneve;
        private string evjarat;
        private string megtettkm;
        private string uzemanyagtipus;
        private string ar;

        public auto(string marka, string modellneve, string evjarat, string megtettkm, string uzemanyagtipus, string ar)
        {
            this.marka = marka;
            this.modellneve = modellneve;
            this.evjarat = evjarat;
            this.megtettkm = megtettkm;
            this.uzemanyagtipus = uzemanyagtipus;
            this.ar = ar;
        }

        public override string ToString()
        {
            return marka + " " + modellneve + " " + evjarat + " " + megtettkm + " " + uzemanyagtipus + " " + ar;
        }
    }
}
