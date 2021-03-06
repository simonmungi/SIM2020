﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;


namespace TP2_NetFramework.Distribuciones
{
    class EstrategiaContinuaExponencial : IEstrategia
    {
        public void obtenerEsperados(Gestor g)
        {

            for (int i = 0; i < g.intervalos.Count; i++)
            {
                g.frecuenciasEsperadas[i] = (Exponential.CDF(g.lambda,g.intervalos[i][1])-Exponential.CDF(g.lambda,g.intervalos[i][0])) * g.n;
                
            }

            //actualizo las probabilidades
            for (int i = 0; i < g.intervalos.Count; i++)
            {
                g.probEsperadas[i] = g.frecuenciasEsperadas[i] / g.n;
            }
            //actualizo acumuladores
            g.acumProbEsperada[0] = g.probEsperadas[0];
            for (int i = 1; i < g.cantIntervalos; i++)
            {
                g.acumProbEsperada[i] = g.acumProbEsperada[i - 1] + g.probEsperadas[i];

            }
        }
    }
}
