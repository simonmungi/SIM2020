using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace WindowsFormsApp1
{
    class EstrategiaCongruencialMultiplicativo : Estrategia
    {
        //public Int64 x0 { get; set; }
        public Int64 a { get; set; }
        //public int k { get; set; } //se usa despues para hacer a = 1+4*k

        //public int g { get; set; } //para despues hacer m = 2^g
        public Int64 m { get; set; }


        public override List<double> generarNumeros(int n)
        {
            //double[] numeros = new double[n];
            List<double> numeros = new List<double>();

            double semilla = x0;

            semilla = generarSiguienteX(semilla);
            numeros.Add(Math.Round(generarSiguienteRandom(semilla),4));


            for (int i = 1; i < n; i++)
            {
                semilla = generarSiguienteX(semilla);//actualizo la semilla 
                numeros.Add(( Math.Round(generarSiguienteRandom(semilla), 4)));
            }

            return numeros;
        }

        public override Int64 generarSiguienteX(double semilla)
        {

            Int64 xi = Convert.ToInt64((a * semilla) % m);
            ultimaSemilla = xi;//esta se usa para agregar el siguiente
            return xi;
        }

        public override double generarSiguienteRandom(double x)
        {
            double xid = Convert.ToDouble(x);

            return xid / m;
        }

        public override double generarSiguienteSecuencial(double semilla)
        {
            semilla = generarSiguienteX(semilla);
            return Math.Round(generarSiguienteRandom(semilla), 4);
        }

        public EstrategiaCongruencialMultiplicativo()
        {

        }

    }
}
