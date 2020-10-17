using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Generadores
{
    public class Uniforme : Generador
    {
        public Uniforme()
        {
            random = new Random();
        }

        public override double generar(double a, double b)
        {

            if (b < a)
            {
                double aux = a;
                a = b;
                b = aux;
            }

            return (a + random.NextDouble() * (b - a));
        }

        public override double generar(double lambda)
        {
            throw new NotImplementedException();
        }
    }
}
