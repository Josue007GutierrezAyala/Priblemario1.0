using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1._0.Clases
{
    class Porcentaje
    {
        public double Porcentajes(double N1, double N2)
        {
            double Por;
            Por = (N1/100) * N2;
            return Por;
        }
    }
}
