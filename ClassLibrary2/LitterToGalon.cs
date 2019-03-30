using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public static class LitterToGalon
    {
        public static double GallonsToLitar(string gallonInput)
        {
            double gallon = Double.Parse(gallonInput);
            double litar = gallon / 3.785;
            return litar;
        }
        public static double LitarToGallon(string litarInput)
        {
            double litar = Double.Parse(litarInput);
            double gallon = litar*3.785;
            return gallon;
        }

    }
}

