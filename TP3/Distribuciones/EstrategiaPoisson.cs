﻿using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_NetFramework;

namespace TP3.Distribuciones
{
    class EstrategiaPoisson : IEstrategia
    {
        Random rnd;

        public void obtenerEsperados(Gestor g)
        {
            for (int i = 0; i < g.intervalos.Count; i++)
            {
                //g.frecuenciasEsperadas[i] = (Poisson.CDF(g.lambda, g.intervalos[i][1]) - Poisson.CDF(g.lambda, g.intervalos[i][0])) * g.n;
                g.frecuenciasEsperadas[i] = ((Math.Pow(g.lambda,i)*Math.Pow(Math.E,-g.lambda))/SpecialFunctions.Factorial(i))*g.n;
            }

            //actualizo las probabilidades
            for (int i = 0; i < g.intervalos.Count; i++)
            {
                //g.probEsperadas[i] = g.frecuenciasEsperadas[i] / g.n;
                g.probEsperadas[i] = Poisson.PMF(g.lambda,i);
            }
            //actualizo acumuladores
            g.acumProbEsperada[0] = g.probEsperadas[0];
            for (int i = 1; i < g.cantIntervalos; i++)
            {
                //g.acumProbEsperada[i] = g.acumProbEsperada[i - 1] + g.probEsperadas[i];
                g.acumProbEsperada[i] = Poisson.CDF(g.lambda, i);
            }
        }

        public double generarValor(Gestor g)
        {
            Poisson ps = new Poisson(g.lambda, rnd);

            return ps.Sample();
        }

        public EstrategiaPoisson()
        {
            rnd = new Random();
        }

    }
}
