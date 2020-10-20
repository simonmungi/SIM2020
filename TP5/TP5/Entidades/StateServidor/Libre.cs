using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades.Pedidos;

namespace TP5.Entidades.StateServidor
{
    class Libre : EstadoServidor
    {
        public Libre()
        {
            nombre = "Libre";
        }

        public override bool esLibre()
        {
            return true;
        }

        public override bool liberar(Servidor serv, List<Pedido> pedidos)
        {

            throw new NotImplementedException();
        }

        //si de libre pasa a ocupado devuelve true
        public override bool ocupar(Servidor serv, double tiempo)
        {
            serv.estado = new Ocupado();
            serv.hora_ocupacion = tiempo;
            //inicio la cola
            //cola =0
            return true;
        }
    }
}
