using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades.Pedido
{
    class Lomito : Pedido
    {
        double costoLomito = 450;

        public Lomito()
        {
            nombre = "Lomito";
            calcularCantidad();
            calcularDemora();
            costo = cantidad * costoLomito;
        }
        public override void calcularCantidad()
        {
            cantidad = 1;
        }

        public override void calcularDemora()
        {
            demora = 8;
        }
    }
}
