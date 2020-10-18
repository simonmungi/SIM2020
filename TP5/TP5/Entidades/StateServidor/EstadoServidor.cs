using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades.Pedidos;

namespace TP5.Entidades.StateServidor
{
    public abstract class EstadoServidor
    {
        protected string nombre;
        public abstract bool liberar(Servidor serv, List<Pedido> pedidos);

        public abstract bool ocupar(Servidor serv, double tiempo);

        public virtual bool esLibre() { return false; }

        public virtual bool esOcupado() { return false; }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
