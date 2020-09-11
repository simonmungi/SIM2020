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


        public double generarCongruencial(long c, long a, long m, long semilla)
        {
            return (c + a * semilla) % m;
        }


        public double generarAleatorio()
        {
            if (bandera)
            {
                return generarCongruencial(c,a,m,semilla);
            }
            else
            {
                return rnd.NextDouble();
            }
        }


        public double generarRandNormal(double r1, double r2, double media,double sigma)
        {

            double z = Math.Sqrt(-2 * Math.Log(1 - r1)) * Math.Cos(2 * Math.PI * r2);

            double x =media + z * sigma;

            return x;
        }

        public double generarRandExponencial(double media)
        {
            double r1 = generarAleatorio();

            //la original es -1/lambda, pero lambda es = a 1/media
            return -1 / (1/media) * (Math.Log(1 - r1));
        }

        //le paso por parametro los datos del form y veo de qué forma genero los aleatorios
        public Aleatorio(bool bandera,string semilla, string a, string c, string m)
        {
            if (bandera)
            {
                this.semilla = Convert.ToInt64(semilla);
                this.a = Convert.ToInt64(a);
                this.c = Convert.ToInt64(c);
                this.m = Convert.ToInt64(m);
            }
            else
            {
                this.rnd = new Random();
            }
        }
    }
}
