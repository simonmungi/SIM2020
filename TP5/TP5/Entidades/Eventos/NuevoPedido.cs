using Medallion.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TP5.Entidades.Pedidos;

namespace TP5.Entidades.Eventos
{
    class NuevoPedido : Evento
    {
        public NuevoPedido(Gestor g, double t)
        {
            gestor = g;
            nombre = "Nuevo pedido";
            tiempo = t;
        }

        public override void ocurrir(ref dynamic[] vector, PriorityQueue<Evento> eventos, Servidor emp1, Servidor emp2, Servidor emp3, Servidor del, List<Pedido> pedidos)
        {
            Pedido pedido = new Pedido();

            vector[gestor.col_evento] = nombre;
            vector[gestor.col_reloj] = tiempo;
            vector[gestor.col_tiempo_entre_pedidos] = pedido.calcularTiempoEntrePedidos();
            vector[gestor.col_tiempo_proximo_pedido] = vector[gestor.col_reloj] + vector[gestor.col_tiempo_entre_pedidos];
            //creo el proximo pedido y lo pongo en la cola
            Evento proximoPedido = new NuevoPedido(gestor, vector[gestor.col_tiempo_proximo_pedido]);
            eventos.Enqueue(proximoPedido);

            vector[gestor.col_tipo_pedido] = pedido.nombre;
            vector[gestor.col_cantidad] = pedido.cantidad;
            vector[gestor.col_costo] = pedido.costo;
        }
    }
}
