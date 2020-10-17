using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades.StateServidor
{
    public abstract class EstadoServidor
    {
        protected string nombre;
        public abstract bool liberar(Servidor serv, List<Cliente> clientes);

        public abstract bool ocupar(Servidor serv, double tiempo);

        public virtual bool esLibre() { return false; }

        public virtual bool esOcupado() { return false; }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
