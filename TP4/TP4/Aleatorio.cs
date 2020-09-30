using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    public class Aleatorio
    {

        bool bandera;
        Random rnd;
        //variables para el congruencial
        long semilla;
        long c;
        long a;
        long m;


        public double generarCongruencial()
        {
            semilla = Convert.ToInt64((a * semilla + c) % m);
            return (double)semilla / (double)m;
        }

        public double generarAleatorio()
        {
            if (bandera)
            {
                return Math.Round(generarCongruencial(),3);
            }
            else
            {
                return Math.Round(rnd.NextDouble(),3);
            }
        }

        public double generarRandNormal(double r1, double r2, double media,double sigma)
        {
            if (r1 == 1)
            {
                r1 = r1 - 0.001;

            }
            if (r2 == 1)
            {
                r2 = r2 - 0.001;
            }
            double z = Math.Sqrt(-2 * Math.Log(1 - r1)) * Math.Cos(2 * Math.PI * r2);

            double x =media + z * sigma;

            return Math.Round(x,3);
        }

        public double generarRandExponencial(double media)
        {
            double r1 = generarAleatorio();
            if (r1 == 1)
            {
                r1 = r1 - 0.001;
            }

            //la original es -1/lambda, pero lambda es = a 1/media
            return Math.Round(-1 / (1/media) * (Math.Log(1 - r1)), 3);
        }

        //le paso por parametro los datos del form y veo de qué forma genero los aleatorios
        public Aleatorio(bool bandera,string semilla, string a, string c, string m)
        {
            this.bandera = bandera;
            if (bandera)
            {
                this.semilla = Convert.ToInt64(semilla);
                this.a = Convert.ToInt64(a);
                this.c = Convert.ToInt64(c);
                this.m = Convert.ToInt64(m);
                this.bandera = true;
            }
            else
            {
                this.rnd = new Random();
            }
        }
    }
}
