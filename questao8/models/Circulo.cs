using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace questao8.models
{
    public class Circulo
    {
        public double Raio;

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}