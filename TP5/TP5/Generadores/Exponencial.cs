using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Generadores
{
    public class Exponencial : Generador
    {

        public Exponencial()
        {
            random = new Random();
        }

        override
        public double generar(double lambda)
        {
            return -(1 / lambda) * Math.Log(1 - random.NextDouble());
        }

        public override double generar(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}
