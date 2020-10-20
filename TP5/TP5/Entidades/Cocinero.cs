using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades.Pedidos;
using TP5.Entidades.StateServidor;

namespace TP5.Entidades
{
    class Cocinero : Servidor
    {
        public static int contador = 1;
        
        public Cocinero()
        {
            nombre = "Cocinero" + contador;
            contador++;
            estado = new Libre();
        }

        public bool prepara(double tiempo)
        {
            return estado.ocupar(this, tiempo);
        }


    }
}
