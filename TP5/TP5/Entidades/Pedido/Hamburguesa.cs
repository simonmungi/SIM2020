using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5.Entidades.Pedido
{
    class Hamburguesa : Pedido
    {
        double costoHamburguesa = 400;

        public Hamburguesa()
        {
            nombre = "Hamburguesa";
            calcularCantidad();
            calcularDemora();
            costo = costoHamburguesa * cantidad;
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
