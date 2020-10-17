using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Generadores
{
    public class Normal : Generador
    {
        public Normal()
        {
            random = new Random();
        }

        override
        public double generar(double media, double desviacion)
        {

            double rnd1 = random.NextDouble();
            double rnd2 = random.NextDouble();
            return ((Math.Sqrt(-2 * Math.Log(rnd1)) * Math.Cos(2 * Math.PI * rnd2)) * desviacion + media);

        }

        public override double generar(double lambda)
        {
            throw new NotImplementedException();
        }
    }
}
