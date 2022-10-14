using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependencyInjection
{
    class Redmi7 : apple
    {
        public double GetPart1Cost()
        {
            return 20000;
        }

        public string GetPhonePart1()
        {
            return "Display";
        }
    }
}
