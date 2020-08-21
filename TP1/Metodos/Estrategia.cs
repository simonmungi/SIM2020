using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    public abstract class Estrategia
    {
        public string nombre { get; set; }

        public Int64 ultimaSemilla;

        public double x0 { get; set; }
        public abstract List<double> generarNumeros(int n);

        public abstract double generarSiguienteRandom(double x);

        public abstract Int64 generarSiguienteX(double semilla);

        public abstract double generarSiguienteSecuencial(double semilla);
    }
}
