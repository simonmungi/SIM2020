using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Generadores
{
    public abstract class Generador
    {
        protected double min;
        protected double max;
        protected Random random;
        protected double lam;
        protected double med;
        protected double desv;
        protected double[] generados;

        public abstract double[] generar(int n, double a, double b);

        public abstract double[] generar(int n, double lambda);
    }
}
