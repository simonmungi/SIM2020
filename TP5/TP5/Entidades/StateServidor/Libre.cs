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
        public override bool liberar(Servidor serv, List<Pedido> pedidos)
        {
            //logica de paso de estado
            throw new NotImplementedException();
        }

        public override bool ocupar(Servidor serv, double tiempo)
        {
            throw new NotImplementedException();
        }
    }
}
