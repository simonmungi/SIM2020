using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class EstrategiaRandom : Estrategia
    {
        Random autoRand;
        public override List<double> generarNumeros(int n)
        {

            List<double> numeros = new List<double>();
            
            for (int i = 0; i < n; i++)
            {
                double num = autoRand.NextDouble();
                num = Math.Round(num, 4);
                numeros.Insert(i, num);

            }

            return numeros;
        }

        public override double generarSiguienteRandom(double x)
        {
            double num = autoRand.NextDouble();
            return Math.Round(num, 4);
        }

        public override long generarSiguienteX(double semilla)
        {
            throw new NotImplementedException();
        }

        public override double generarSiguienteSecuencial(double semilla)
        {
            double num = autoRand.NextDouble();
            return Math.Round(num, 4);
        }

        public EstrategiaRandom()
        {
            this.autoRand = new Random();
        }


    }
}
