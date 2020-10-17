using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Generadores
{
    public class Poisson : Generador
    {
        public Poisson()
        {
            random = new Random();
        }

        //ver pdf
        public override double generar(double lambda)
        {
            double u = random.NextDouble();
            double x = 0;
            double P = Math.Pow(Math.E, -lambda);
            double F = Math.Pow(Math.E, -lambda);

            while (true)
            {
                if (u < F) return x;

                P = lambda * P / (x + 1);
                F = F + P;
                x = x + 1;
            }

        }

        public override double generar(double a, double b)
        {
            throw new NotImplementedException();
        }
    }
}
