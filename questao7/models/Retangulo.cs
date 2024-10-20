using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao7.models
{
    public class Retangulo
    {
        public double L1;
        public double L2;

        public double CalcularArea()
        {
            return L1 * L2;
        }

        public double CalcularPerimetro()
        {
            return L1*2 + L2*2;
        }
    }
}