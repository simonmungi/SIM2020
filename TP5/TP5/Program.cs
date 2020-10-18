﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5.Entidades;
using TP5.Entidades.Pedidos;
using TP5.Generadores;

namespace TP5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pantalla());

            /*
            //Prueba

            Pedido pedido = new Pedido();

            for(int i = 0; i < 50; i++)
            {
                Pedido siguiente = pedido.siguientePedido();

                Console.WriteLine(siguiente.toString());

            }
            */
        }
    }
}
