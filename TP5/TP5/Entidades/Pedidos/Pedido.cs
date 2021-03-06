﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TP5.Generadores;

namespace TP5.Entidades.Pedidos
{
    public class Pedido
    {
        private double lambda = 5;//pedidos por hora
        private double probSandwich = 0.2;
        private double probPizza = 0.4;
        private double probEmpanadas = 0.3;
        private double probHamburguesa = 0.05;
        private double probLomito = 0.05;

        private dynamic[,] acumuladas;
        private Random rand;

        public double costo;
        public double demora;
        public double cantidad;
        public string nombre;

        protected Generador generador;
        //private EstadoPedido estadoPedido;


        public Pedido()
        {
            acumuladas = obtenerAcumuladas();
            rand = new Random();
        }

        public double calcularTiempoEntrePedidos()
        {
            generador = new Poisson();
            return generador.generar(lambda)/60; //pedidos por minuto para que se cumpla los 5 por hora
        }

        public Pedido siguientePedido()
        {
            double rn = rand.NextDouble();
            string resultado = "";

            for (int i = 0; i < 5; i++)
            {
                if (rn >= acumuladas[i, 1] && rn < acumuladas[i, 2])
                    resultado = acumuladas[i, 0];
            }

            switch (resultado)
            {
                case "sandwich":
                    return new Sandwich();
                    
                case "hamburguesa":
                    return new Hamburguesa();
                    
                case "lomito":
                    return new Lomito();
                    
                case "pizza":
                    return new Pizza();

                case "empanadas":
                    return new Empanada();

                default:
                    return null;
            }
        }

        private dynamic[,] obtenerAcumuladas()
        {
            dynamic[] probabilidades = { probSandwich, probPizza, probEmpanadas, probHamburguesa, probLomito };
            dynamic[,] probAcumuladas = new dynamic[5, 3] { {"sandwich",0,0},
                                                            { "pizza", 0, 0 },
                                                            { "empanadas", 0, 0 },
                                                            { "hamburguesa", 0, 0 },
                                                            { "lomito", 0, 0 } };


            probAcumuladas[0, 2] = probSandwich;
            for (int i = 1; i < probabilidades.Length; i++)
            {
                probAcumuladas[i, 1] = probAcumuladas[i - 1, 2];
                probAcumuladas[i, 2] = probAcumuladas[i, 1] + probabilidades[i];
            }

            return probAcumuladas;
        }

        //Esto es para debuggear nomas
        public String toString()
        {
            String cadena = "Pedido:" + nombre + "| Cantidad:" + cantidad + "|Costo:" + costo + "|Demora: " + demora;

            return cadena;

        }

        public virtual void calcularDemora() { }
        public virtual void calcularCantidad() { }


    }
}
