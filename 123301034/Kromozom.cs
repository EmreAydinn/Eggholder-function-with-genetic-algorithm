using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123301034
{
    public  class Kromozom
    {
        public double[] Gen = new double[2];

        public double amaç_fonksiyon()
        {
            return ((-(Gen[1]+47))*Math.Sin(Math.Sqrt(Math.Abs(Gen[1]+(Gen[0]/2)+47)))-(Gen[0]*Math.Sin(Math.Sqrt(Math.Abs(Gen[0]-(Gen[1]+47))))));
        }
    }
}
