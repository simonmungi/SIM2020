using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5.Entidades.Pedidos;
using TP5.Entidades.StateServidor;

namespace TP5.Entidades
{
    public abstract class Servidor
    {
        public string nombre { get; set; }
        public EstadoServidor estado { get; set; }
        public Pedido ocupado_con { get; set; }
        public double hora_ocupacion { get; set; }
        //public int cola { get; set; }


    }
}
