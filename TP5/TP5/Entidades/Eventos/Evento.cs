using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades;
using TP5.Entidades.Pedidos;

namespace TP5.Entidades.Eventos
{
    abstract class Evento
    {
        public string nombre { get; set; }
        public double tiempo { get; set; }
        public Servidor servidor { get; set; }
        public Pedido pedido { get; set; }

        protected Gestor gestor;

        public Evento()
        {

        }

        public Evento(Gestor gestor, string nombre, double tiempo, Servidor servidor = null, Pedido pedido = null)
        {
            this.gestor = gestor;
            this.nombre = nombre;
            this.tiempo = tiempo;
            this.servidor = servidor;
            this.pedido = pedido;
        }



        //public abstract void ocurrir(ref dynamic[] vector, PriorityQueue<Evento> eventos, Servidor emp1, Servidor emp2, Servidor emp3, List<Pedido> pedidos);
    }

    class EventoComp : IComparer<Evento>
    {
        public int Compare(Evento x, Evento y)
        {
            return x.tiempo.CompareTo(y.tiempo);
        }
    }
}
}
