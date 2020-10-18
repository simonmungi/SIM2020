using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades.Pedidos;

namespace TP5.Entidades.StateServidor
{
    class Ocupado : EstadoServidor
    {

        public Ocupado()
        {
            nombre = "Ocupado";
        }

        public override bool esOcupado()
        {
            return true;
        }

        public override bool liberar(Servidor serv, List<Pedido> pedidos)
        {
            //logica de paso de estado

            //si la cola es >0 hay que atender mas clientes, devolver false
            //si la cola es 0 cambiar estado a libre devolver true

            throw new NotImplementedException();
        }

        public override bool ocupar(Servidor serv, double tiempo)
        {

            throw new NotImplementedException();
        }
    }
}
